#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value null

namespace Black.OpenGL;

internal unsafe partial class Native
{
    internal delegate void Clear (ClearMasks mask);
    [OpenGL<Clear>] internal static Clear glClear;

    internal delegate void ClearBufferiv (ClearBufferTargets buffer, int drawBuffer, int* value);
    [OpenGL<ClearBufferiv>] internal static ClearBufferiv glClearBufferiv;

    internal delegate void ClearBufferuiv (ClearBufferTargets buffer, int drawBuffer, uint* value);
    [OpenGL<ClearBufferuiv>] internal static ClearBufferuiv glClearBufferuiv;

    internal delegate void ClearBufferfv (ClearBufferTargets buffer, int drawBuffer, float* value);
    [OpenGL<ClearBufferfv>] internal static ClearBufferfv glClearBufferfv;
    
    internal delegate void ClearBufferfi (ClearBufferTargets buffer, int drawBuffer, float depth, int stencil);
    [OpenGL<ClearBufferfi>] internal static ClearBufferfi glClearBufferfi;
    
    internal delegate void ClearColor (float red, float green, float blue, float alpha);
    [OpenGL<ClearColor>] internal static ClearColor glClearColor;
    
    internal delegate void ClearDepth (double depth);
    [OpenGL<ClearDepth>] internal static ClearDepth glClearDepth;
    
    internal delegate void ClearStencil(int stencil);
    [OpenGL<ClearStencil>] internal static ClearStencil glClearStencil;
    
    internal delegate void Finish ();
    [OpenGL<Finish>] internal static Finish glFinish;

    internal delegate void DrawBuffer (uint mode);
    [OpenGL<DrawBuffer>] internal static DrawBuffer glDrawBuffer;
    
    internal delegate void Flush ();
    [OpenGL<Flush>] internal static Flush glFlush;
    
    internal delegate void ReadBuffer (uint mode);
    [OpenGL<ReadBuffer>] internal static ReadBuffer glReadBuffer;
    
    internal delegate void ReadPixels (int x, int y, int width, int height, ReadPixelFormats format, ReadPixelTypes type, void* data);
    [OpenGL<ReadPixels>] internal static ReadPixels glReadPixels;
}

#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value null
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.