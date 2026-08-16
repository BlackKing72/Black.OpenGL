using System.Reflection;

namespace Black.OpenGL;

public static unsafe partial class GL
{
    private static GetProcAddressHandler? customHandler = null;
    private static Loader? loader = null;

    /// <summary> Occurs when an OpenGL function cannot be loaded.</summary>
    /// <remarks> If no handler is registered, an <see cref="LoadProcedureException"/> is throw instead of being passed to a handler. </remarks>
    public static event Action<LoadProcedureException>? OnLoadFailed = null;

    /// <summary> Initializes the library and load all OpenGL functions supported by the library </summary>
    /// <param name="customHandler"> An optional handler used to load OpenGL functions. If <see cref="null"/>, the defalt handler for the current platform is used. </param>
    public static void Initialize(GetProcAddressHandler? customHandler = null)
    {
        GL.customHandler = customHandler;

        Library.Initialize();
        LoadFunctions();
    }

    private static void LoadFunctions()
    {
        loader ??= new Loader(customHandler);

        Type openglDelegates = typeof(Native);

        foreach (FieldInfo field in openglDelegates.GetTypeInfo().DeclaredFields)
        {
            OpenGLAttribute? attribute = field.GetCustomAttribute<OpenGLAttribute>();
            if (attribute is null)
                continue;

            try
            {
                Delegate? lastValue = field.GetValue(null) as Delegate;
                Delegate currentValue = attribute.GetProcedure(loader, field.Name);

                if (lastValue != currentValue)
                    field.SetValue(null, currentValue);
            }
            catch(LoadProcedureException e)
            {
                if (OnLoadFailed is null)
                    throw;

                OnLoadFailed.Invoke(e);
            }
        }
    }
}



public abstract class OpenGLAttribute : Attribute
{
    public abstract Delegate GetProcedure(Loader loader, string name);
}

public class OpenGLAttribute<T> : OpenGLAttribute where T : Delegate
{
    public override Delegate GetProcedure(Loader loader, string name)
    {
        return loader.LoadFunction<T>(name);
    }
}
