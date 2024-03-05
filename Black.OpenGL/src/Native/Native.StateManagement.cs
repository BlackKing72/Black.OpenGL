#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value null

namespace Black.OpenGL;

internal unsafe partial class Native
{
    internal delegate void BlendColor (float red, float green, float blue, float alpha);
    [OpenGL<BlendColor>] internal static BlendColor glBlendColor;

    internal delegate void BlendEquation (BlendEquations mode);
    [OpenGL<BlendEquation>] internal static BlendEquation glBlendEquation;

    internal delegate void BlendEquationSeparate (BlendEquations modeRGB, BlendEquations modeAlpha);
    [OpenGL<BlendEquationSeparate>] internal static BlendEquationSeparate glBlendEquationSeparate;
    
    internal delegate void BlendFunc (BlendFactors sfactor, BlendFactors dfactor);
    [OpenGL<BlendFunc>] internal static BlendFunc glBlendFunc;

    internal delegate void BlendFuncSeparate (BlendFactors srcRGB, BlendFactors dstRGB, BlendFactors srcAlpha, BlendFactors dstAlpha);
    [OpenGL<BlendFuncSeparate>] internal static BlendFuncSeparate glBlendFuncSeparate;
    
    internal delegate void ClampColor (uint target, uint clamp);
    [OpenGL<ClampColor>] internal static ClampColor glClampColor;

    internal delegate void ColorMask (byte red, byte green, byte blue, byte alpha);
    [OpenGL<ColorMask>] internal static ColorMask glColorMask;

    internal delegate void ColorMaski (uint buf, byte red, byte green, byte blue, byte alpha);
    [OpenGL<ColorMaski>] internal static ColorMaski glColorMaski;
    
    internal delegate void CullFace (TriangleFaces mode);
    [OpenGL<CullFace>] internal static CullFace glCullFace;

    internal delegate void DepthFunc (CompareFunctions func);
    [OpenGL<DepthFunc>] internal static DepthFunc glDepthFunc;

    internal delegate void DepthMask (byte flag);
    [OpenGL<DepthMask>] internal static DepthMask glDepthMask;
    
    internal delegate void DepthRange (double nearVal, double farVal);
    [OpenGL<DepthRange>] internal static DepthRange glDepthRange;
    
    internal delegate void Disable (Capabilities cap);
    [OpenGL<Disable>] internal static Disable glDisable;
    
    internal delegate void Disablei (Capabilities cap, uint index);
    [OpenGL<Disablei>] internal static Disablei glDisablei;
    
    internal delegate void Enable (Capabilities cap);
    [OpenGL<Enable>] internal static Enable glEnable;
    
    internal delegate void Enablei (Capabilities cap, uint index);
    [OpenGL<Enablei>] internal static Enablei glEnablei;
    
    internal delegate void FrontFace (FrontFaceModes mode);
    [OpenGL<FrontFace>] internal static FrontFace glFrontFace;
    
    internal delegate void GetBooleanv (GetParameterNames pName, byte* @params);
    [OpenGL<GetBooleanv>] internal static GetBooleanv glGetBooleanv;
    
    internal delegate void GetDoublev (GetParameterNames pName, double* @params);
    [OpenGL<GetDoublev>] internal static GetDoublev glGetDoublev;
    
    internal delegate void GetFloatv (GetParameterNames pName, float* @params);
    [OpenGL<GetFloatv>] internal static GetFloatv glGetFloatv;
    
    internal delegate void GetIntegerv (GetParameterNames pName, int* @params);
    [OpenGL<GetIntegerv>] internal static GetIntegerv glGetIntegerv;

    internal delegate void GetInteger64v (GetParameterNames pName, long* @params);
    [OpenGL<GetInteger64v>] internal static GetInteger64v glGetInteger64v;

    internal delegate void GetBooleani_v (GetParameterNames pName, uint index, byte* data);
    [OpenGL<GetBooleani_v>] internal static GetBooleani_v glGetBooleani_v;

    internal delegate void GetIntegeri_v (GetParameterNames pName, uint index, int* data);
    [OpenGL<GetIntegeri_v>] internal static GetIntegeri_v glGetIntegeri_v;

    internal delegate void GetInteger64i_v (GetParameterNames pName, uint index, long* data);
    [OpenGL<GetInteger64i_v>] internal static GetInteger64i_v glGetInteger64i_v;
    
    internal delegate ErrorFlags GetError ();
    [OpenGL<GetError>] internal static GetError glGetError;
    
    internal delegate void Hint (HintTargets target, HintModes mode);
    [OpenGL<Hint>] internal static Hint glHint;

    internal delegate bool IsEnabled (Capabilities cap);
    [OpenGL<IsEnabled>] internal static IsEnabled glIsEnabled;
    
    internal delegate bool IsEnabledi (Capabilities cap, uint index);
    [OpenGL<IsEnabledi>] internal static IsEnabledi glIsEnabledi;
    
    internal delegate void LineWidth (float width);
    [OpenGL<LineWidth>] internal static LineWidth glLineWidth;

    internal delegate void LogicOp (LogicOperations opcode);
    [OpenGL<LogicOp>] internal static LogicOp glLogicOp;

    internal delegate void PixelStoref (PixelStoreParameters pname, float param);
    [OpenGL<PixelStoref>] internal static PixelStoref glPixelStoref;

    internal delegate void PixelStorei (PixelStoreParameters pname, int param);
    [OpenGL<PixelStorei>] internal static PixelStorei glPixelStorei;

    internal delegate void PointParameterf (PointParameterNames pname, float param);
    [OpenGL<PointParameterf>] internal static PointParameterf glPointParameterf;

    internal delegate void PointParameteri (PointParameterNames pname, int param);
    [OpenGL<PointParameteri>] internal static PointParameteri glPointParameteri;

    internal delegate void PointParameterfv (PointParameterNames pname, float* @params);
    [OpenGL<PointParameterfv>] internal static PointParameterfv glPointParameterfv;

    internal delegate void PointParameteriv (PointParameterNames pname, int* @params);
    [OpenGL<PointParameteriv>] internal static PointParameteriv glPointParameteriv;

    internal delegate void PointSize (float size);
    [OpenGL<PointSize>] internal static PointSize glPointSize;

    internal delegate void PolygonMode (TriangleFaces face, PolygonModes mode);
    [OpenGL<PolygonMode>] internal static PolygonMode glPolygonMode;

    internal delegate void PolygonOffset (float factor, float units);
    [OpenGL<PolygonOffset>] internal static PolygonOffset glPolygonOffset;

    internal delegate void SampleCoverage (float value, byte invert);
    [OpenGL<SampleCoverage>] internal static SampleCoverage glSampleCoverage;

    internal delegate void Scissor (int x, int y, int width, int height);
    [OpenGL<Scissor>] internal static Scissor glScissor;

    internal delegate void StencilFunc (CompareFunctions func, int @ref, uint mask);
    [OpenGL<StencilFunc>] internal static StencilFunc glStencilFunc;

    internal delegate void StencilFuncSeparate (TriangleFaces face, CompareFunctions func, int @ref, uint mask);
    [OpenGL<StencilFuncSeparate>] internal static StencilFuncSeparate glStencilFuncSeparate;

    internal delegate void StencilMask (uint mask);
    [OpenGL<StencilMask>] internal static StencilMask glStencilMask;
    
    internal delegate void StencilMaskSeparate (TriangleFaces face, uint mask);
    [OpenGL<StencilMaskSeparate>] internal static StencilMaskSeparate glStencilMaskSeparate;

    internal delegate void StencilOp (StencilOperations sfail, StencilOperations dpfail, StencilOperations dppass);
    [OpenGL<StencilOp>] internal static StencilOp glStencilOp;

    internal delegate void StencilOpSeparate (TriangleFaces face, StencilOperations sfail, StencilOperations dpfail, StencilOperations dppass);
    [OpenGL<StencilOpSeparate>] internal static StencilOpSeparate glStencilOpSeparate;

    internal delegate void Viewport (int x, int y, int width, int height);
    [OpenGL<Viewport>] internal static Viewport glViewport;
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value null