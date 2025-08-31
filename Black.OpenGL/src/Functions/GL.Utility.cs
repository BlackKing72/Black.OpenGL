namespace Black.OpenGL;

using Black.Unmanaged;
using static Black.OpenGL.Native;

public static unsafe partial class GL
{
    public static void GetMultisample(uint index, out float value)
    {
        value = GetMultisample(index);
    }

    public static float GetMultisample(uint index)
    {
        float value = 0f;
        glGetMultisamplefv(Constants.glSamplePosition, index, &value);
        return value;
    }

    public static string GetString(GetStringName name)
    {
        using var unmanaged = new UnmanagedStr(glGetString(name));
        return unmanaged.ToString();
    }
}