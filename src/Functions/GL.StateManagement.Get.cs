namespace Black.OpenGL;

using Black.Unmanaged;
using static Black.OpenGL.Native;
public static unsafe partial class GL
{
    public static uint ActiveTextureUnit
    {
        get
        {
            int textureUnit = 0;
            glGetIntegerv(GetParameterNames.ActiveTexture, &textureUnit);

            const uint Texture0 = 0x84C0;
            return (uint)(Texture0 - textureUnit);
        }
    }

    public static uint CurrentProgram
    {
        get
        {
            int currentProgram = 0;
            glGetIntegerv(GetParameterNames.CurrentProgram, &currentProgram);

            return (uint)currentProgram;
        }
    }

    public static uint DrawFramebufferBinding
    {
        get
        {
            int drawFramebufferBinding = 0;
            glGetIntegerv(GetParameterNames.DrawFramebufferBinding, &drawFramebufferBinding);

            return (uint)drawFramebufferBinding;
        }
    }

    public static uint ReadFramebufferBinding
    {
        get
        {
            int readFramebufferBinding = 0;
            glGetIntegerv(GetParameterNames.ReadFramebufferBinding, &readFramebufferBinding);

            return (uint)readFramebufferBinding;
        }
    }

    public static bool IsBlendEnabled
    {
        get
        {
            bool isBlendEnabled = false;
            glGetBooleanv(GetParameterNames.Blend, (byte*)&isBlendEnabled);

            return isBlendEnabled;
        }
    }

    public static bool IsBlendDisabled => !IsBlendEnabled;

    public static bool IsDepthTestEnabled
    {
        get
        {
            bool isDepthTestEnabled = false;
            glGetBooleanv(GetParameterNames.DepthTest, (byte*)&isDepthTestEnabled);

            return isDepthTestEnabled;
        }
    }

    public static bool IsDepthTestDisabled => !IsDepthTestEnabled;
}