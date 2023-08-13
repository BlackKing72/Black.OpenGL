using System.Reflection;

namespace Draft.OpenGL;

public static unsafe partial class GL
{
    static GL ()
    {
        Library.Initialize();
        TryLoadFunctions();
    }

    public static void TryLoadFunctions ()
    {
        Type openglDelegates = typeof(Native);

        foreach (FieldInfo field in openglDelegates.GetTypeInfo().DeclaredFields)
        {
            OpenGLAttribute? attribute = field.GetCustomAttribute<OpenGLAttribute>();
            if (attribute is null) 
                continue;

            Delegate? lastValue = field.GetValue(null) as Delegate;
            Delegate currentValue = attribute.GetProcedure(field.Name);

            if (lastValue != currentValue)
                field.SetValue(null, currentValue);
        }
    }
}

public abstract class OpenGLAttribute : Attribute
{
    public abstract Delegate GetProcedure (string name);
}

public class OpenGLAttribute<T> : OpenGLAttribute where T : Delegate
{
    public override Delegate GetProcedure (string name)
    {
        return Loader.LoadFunction<T>(name);
    }
}
