using System.Reflection;

namespace Black.OpenGL;

public static unsafe partial class GL
{
    public static event Action<LoadProcedureException>? OnLoadFailed = null;

    public static void Initialize()
    {
        Library.Initialize();
        LoadFunctions();
    }

    public static void LoadFunctions()
    {
        Type openglDelegates = typeof(Native);

        foreach (FieldInfo field in openglDelegates.GetTypeInfo().DeclaredFields)
        {
            OpenGLAttribute? attribute = field.GetCustomAttribute<OpenGLAttribute>();
            if (attribute is null)
                continue;

            try 
            {
                Delegate? lastValue = field.GetValue(null) as Delegate;
                Delegate currentValue = attribute.GetProcedure(field.Name);

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
    public abstract Delegate GetProcedure(string name);
}

public class OpenGLAttribute<T> : OpenGLAttribute where T : Delegate
{
    public override Delegate GetProcedure(string name)
    {
        return Loader.LoadFunction<T>(name);
    }
}
