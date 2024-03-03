namespace Black.OpenGL;

using System.Drawing;
using System.Runtime.CompilerServices;
using Black.Unmanaged;
using static Black.OpenGL.Native;

public static unsafe partial class GL
{
    public static void BlendColor (float red, float green, float blue, float alpha)
    {
        glBlendColor(red, green, blue, alpha);
    }

    public static void BlendEquation (BlendEquations mode)
    {
        glBlendEquation(mode);
    }

    public static void BlendEquationSeparate (BlendEquations modeRGB, BlendEquations modeAlpha)
    {
        glBlendEquationSeparate(modeRGB, modeAlpha);
    }
        
    public static void BlendFunc (BlendFactors sfactor, BlendFactors dfactor)
    {
        glBlendFunc(sfactor, dfactor);
    }

    public static void BlendFuncSeparate (BlendFactors srcRGB, BlendFactors dstRGB, BlendFactors srcAlpha, BlendFactors dstAlpha)
    {
        glBlendFuncSeparate(srcRGB, dstRGB, srcAlpha, dstAlpha);
    } 

    public static void ClampColor (bool clamp)
    {
        const uint ClampRedColor = 0x891C;
        glClampColor(ClampRedColor, (uint)(clamp ? Native.True : Native.False));
    }

    public static void ColorMask (bool red, bool green, bool blue, bool alpha)
    {
        glColorMask(red.ToGLBoolean(), green.ToGLBoolean(), blue.ToGLBoolean(), alpha.ToGLBoolean());
    }

    public static void ColorMask (uint bufferIndex, bool red, bool green, bool blue, bool alpha)
    {
        glColorMaski(bufferIndex, red.ToGLBoolean(), green.ToGLBoolean(), blue.ToGLBoolean(), alpha.ToGLBoolean());
    }

    public static void CullFace (TriangleFaces cullMode)
    {
        glCullFace(cullMode);
    }

    public static void DepthFunc (CompareFunctions comparisonFunction)
    {
        glDepthFunc(comparisonFunction);
    }

    public static void DepthMask (bool enableWriting)
    {
        glDepthMask(enableWriting.ToGLBoolean());
    }

    public static void DepthRange (double nearClipping, double farClipping)
    {
        glDepthRange(nearClipping, farClipping);
    }

    public static void Disable (Capabilities cap)
    {
        glDisable(cap);
    }

    public static void Disable (Capabilities cap, uint index)
    {
        glDisablei(cap, index);
    }

    public static void Enable (Capabilities cap)
    {
        glEnable(cap);
    }

    public static void Enable (Capabilities cap, uint index)
    {
        glEnablei(cap, index);
    }
    
    public static void FrontFace (FrontFaceModes mode)
    {
        glFrontFace(mode);
    }

    public static bool GetBoolean (GetParameterNames parameterName)
    {
        byte unmanagedResult = Native.False;
        glGetBooleanv(parameterName, &unmanagedResult);
        return unmanagedResult.FromGLBoolean();
    }

    public static double GetDouble (GetParameterNames parameterName)
    {
        double unmanagedResult = 0.0;
        glGetDoublev(parameterName, &unmanagedResult);
        return unmanagedResult;
    }

    public static float GetFloat (GetParameterNames parameterName)
    {
        float unmanagedResult = 0.0f;
        glGetFloatv(parameterName, &unmanagedResult);
        return unmanagedResult;
    }

    public static int GetInteger (GetParameterNames parameterName)
    {
        int unmanagedResult = 0;
        glGetIntegerv(parameterName, &unmanagedResult);
        return unmanagedResult;
    }

    public static void GetInteger (GetParameterNames parameterName, Span<int> data)
    {
        glGetIntegerv(parameterName, data.AsPointer());
    }

    public static long GetInteger64 (GetParameterNames parameterName)
    {
        long unmanagedResult = 0;
        glGetInteger64v(parameterName, &unmanagedResult);
        return unmanagedResult;
    }

    public static void GetBoolean (GetParameterNames parameterName, uint index, Span<bool> data)
    {
        glGetBooleani_v(parameterName, index, (byte*)data.AsPointer());
    }

    public static void GetInteger (GetParameterNames parameterName, uint index, Span<int> data)
    {
        glGetIntegeri_v(parameterName, index, data.AsPointer());
    }

    public static void GetInteger64 (GetParameterNames parameterName, uint index, Span<long> data)
    {
        glGetInteger64i_v(parameterName, index, data.AsPointer());
    }

    public static ErrorFlags GetError ()
    {
        return glGetError();
    }

    public static void ClearErrors ()
    {
        while (GetError() != ErrorFlags.NoError);
    }

    public static void CheckErrors (Action function, 
        [CallerFilePath]string file = "",
        [CallerMemberName]string member = "",
        [CallerArgumentExpression(nameof(function))]string expr = "",
        [CallerLineNumber]int line = 0)
    {
        function();

        var error = GetError();
        if (error != ErrorFlags.NoError)
        {
            Console.WriteLine($"OpenGL Error {error} - {file}:{line} at {member} called with {expr}");
        }
    }

    public static void Hint (HintTargets target, HintModes mode)
    {
        glHint(target, mode);
    }

    public static bool IsEnabled (Capabilities cap)
    {
        return glIsEnabled(cap);
    }
    
    public static bool IsEnabled (Capabilities cap, uint index)
    {
        return glIsEnabledi(cap, index);
    }
    
    public static void LineWidth (float width)
    {
        glLineWidth(width);
    }
    
    public static void LogicOp (LogicOperations opcode)
    {
        glLogicOp(opcode);
    }

    public static void PixelStore (PixelStoreParameters parameterName, float value)
    {
        glPixelStoref(parameterName, value);
    }

    public static void PixelStore (PixelStoreParameters parameterName, int value)
    {
        glPixelStorei(parameterName, value);
    }

    public static void PointFadeThresholdSize (float thresholdSize)
    {
        glPointParameterf(PointParameterNames.PointFadeThresholdSize, thresholdSize);
    }

    public static void PointSpriteCoordOrigin (SpriteCoordOrigin origin)
    {
        glPointParameteri(PointParameterNames.PointSpriteCoordOrigin, (int)origin);
    }

    public static void PointParameters (PointParameterNames parameterName, float value)
    {
        glPointParameterf(parameterName, value);
    }

    public static void PointParameters (PointParameterNames parameterName, int value)
    {
        glPointParameteri(parameterName, value);
    }

    public static void PointParameters (PointParameterNames parameterName, ReadOnlySpan<float> values)
    {
        glPointParameterfv(parameterName, values.AsPointer());
    }

    public static void PointParameters (PointParameterNames parameterName, ReadOnlySpan<int> values)
    {
        glPointParameteriv(parameterName, values.AsPointer());
    }

    public static void PointSize (float size)
    {
        glPointSize(size);
    }

    public static void PolygonMode (PolygonModes mode)
    {
        glPolygonMode(TriangleFaces.FrontAndBack, mode);
    }

    public static void PolygonMode (TriangleFaces face, PolygonModes mode)
    {
        glPolygonMode(face, mode);
    }

    public static void PolygonOffset (float factor, float units)
    {
        glPolygonOffset(factor, units);
    }

    public static void SampleCoverage (float value, bool invert)
    {
        glSampleCoverage(value, invert.ToGLBoolean());
    }

    public static void Scissor (int x, int y, int width, int height)
    {
        glScissor(x, y, width, height);
    }

    public static void Scissor (Rectangle rect)
    {
        glScissor(rect.X, rect.Y, rect.Width, rect.Height);
    }

    public static void StencilFunction (CompareFunctions function, int reference, uint mask)
    {
        glStencilFunc(function, reference, mask);
    }

    public static void StencilFunction (TriangleFaces face, CompareFunctions function, int reference, uint mask)
    {
        glStencilFuncSeparate(face, function, reference, mask);
    }

    public static void StencilMask (uint mask)
    {
        glStencilMask(mask);
    }

    public static void StencilMask (TriangleFaces face, uint mask)
    {
        glStencilMaskSeparate(face, mask);
    }

    public static void StencilOp (StencilOperations sfail, StencilOperations dpfail, StencilOperations dppass)
    {
        glStencilOp(sfail, dpfail, dppass);
    }

    public static void StencilOp (TriangleFaces face, StencilOperations sfail, StencilOperations dpfail, StencilOperations dppass)
    {
        glStencilOpSeparate(face, sfail, dpfail, dppass);
    }

    public static void Viewport(int x, int y, int width, int height)
    {
        glViewport(x, y, width, height);
    }
    public static void Viewport(Rectangle rect)
    {
        glViewport(rect.X, rect.Y, rect.Width, rect.Height);
    }  
}