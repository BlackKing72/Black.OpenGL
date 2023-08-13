namespace Draft.OpenGL;

using System;
using System.Drawing;
using System.Numerics;
using Black.Unmanaged;

using static Draft.OpenGL.Native;

public static unsafe partial class GL
{
    public static void Clear (Color? color = null, double? depth = null, int? stencil = null)
    {
        ClearMask mask = 0;

        if (color.HasValue)
        {
            ClearColor(color.Value);
            mask |= ClearMask.Color;
        }

        if (depth.HasValue)
        {
            ClearDepth(depth.Value);
            mask |= ClearMask.Depth;
        }

        if (stencil.HasValue)
        {
            ClearStencil(stencil.Value);
            mask |= ClearMask.Stencil;
        }

        Clear(mask);
    }
    public static void Clear (ClearMask mask)
    {
        glClear(mask);
    }

    private static void ClearBuffer (ClearBufferTarget buffer, int drawBuffer, ReadOnlySpan<int> data)
    {
        glClearBufferiv(buffer, drawBuffer, data.AsPointer());
    }
    private static void ClearBuffer (ClearBufferTarget buffer, int drawBuffer, ReadOnlySpan<uint> data)
    {
        unsafe { glClearBufferuiv(buffer, drawBuffer, data.AsPointer()); }
    }
    private static void ClearBuffer (ClearBufferTarget buffer, int drawBuffer, ReadOnlySpan<float> data)
    {
        unsafe { glClearBufferfv(buffer, drawBuffer, data.AsPointer()); }
    }

    public static void ClearBufferColor (int drawBuffer, float r, float g, float b, float a)
    {
        unsafe
        {
            float* data = stackalloc float[] { r, g, b, a };
            glClearBufferfv(ClearBufferTarget.Color, drawBuffer, data);
        }
    }
    public static void ClearBufferColor (int drawBuffer, Vector4 color)
    {
        unsafe
        {
            float* data = stackalloc float[] { color.X, color.Y, color.Z, color.W };
            glClearBufferfv(ClearBufferTarget.Color, drawBuffer, data);
        }
    }
    public static void ClearBufferColor (int drawBuffer, Color color)
    {
        unsafe
        {
            float* data = stackalloc float[] {
                Math.Clamp(color.R / 255f, 0f, 1f),
                Math.Clamp(color.G / 255f, 0f, 1f),
                Math.Clamp(color.B / 255f, 0f, 1f),
                Math.Clamp(color.A / 255f, 0f, 1f)
            };

            glClearBufferfv(ClearBufferTarget.Color, drawBuffer, data);
        }
    }
    public static void ClearBufferDepth (float depth = 0f)
    {
        unsafe { glClearBufferfv(ClearBufferTarget.Depth, 0, &depth); }
    }
    public static void ClearBufferStencil (int stencil)
    {
        unsafe { glClearBufferiv(ClearBufferTarget.Stencil, 0, &stencil); }
    }
    public static void ClearBufferDepthStencil (float depth, int stencil)
    {
        unsafe { glClearBufferfi(ClearBufferTarget.DepthStencil, 0, depth, stencil); }
    }

    public static void ClearColor (float red, float green, float blue, float alpha)
    {
        glClearColor(red, green, blue, alpha);
    }
    public static void ClearColor (Vector4 color)
    {
        glClearColor(color.X, color.Y, color.Z, color.W);
    }
    public static void ClearColor (Color color)
    {
        glClearColor(
            Math.Clamp(color.R / 255f, 0f, 1f), 
            Math.Clamp(color.G / 255f, 0f, 1f), 
            Math.Clamp(color.B / 255f, 0f, 1f), 
            Math.Clamp(color.A / 255f, 0f, 1f));
    }

    public static void ClearDepth (double depth)
    {
        glClearDepth(depth);
    }

    public static void ClearStencil (int stencil)
    {
        glClearStencil(stencil);
    }

    public static void DrawBuffer (BufferMode mode)
    {
        glDrawBuffer((uint)mode);
    }

    public static void Finish ()
    {
        glFinish();
    }

    public static void Flush ()
    {
        glFlush();
    }

    public static void ReadBuffer (BufferMode mode)
    {
        glReadBuffer((uint)mode);
    }

    public static void ReadBuffer (uint colorAttachment)
    {
        glReadBuffer(colorAttachment);
    }

    public static unsafe void ReadPixels (int x, int y, int width, int height, ReadPixelFormat format, ReadPixelType type, void* data)
    {
        glReadPixels(x, y, width, height, format, type, data);
    }

    public static unsafe void ReadPixels (int x, int y, int width, int height, ReadPixelFormat format, ReadPixelType type, nint data)
    {
        glReadPixels(x, y, width, height, format, type, data.ToPointer());
    }

    public static Span<T> ReadPixels<T> (int x, int y, int width, int height, ReadPixelFormat format, ReadPixelType type) where T : unmanaged
    {
        int elementCount = format switch
        {
            ReadPixelFormat.Bgr or ReadPixelFormat.Rgb => 3,
            ReadPixelFormat.Bgra or ReadPixelFormat.Rgba => 4,
            _ => 1
        };

        Span<T> pixels = new T[width * height * elementCount];
        unsafe { glReadPixels(x, y, width, height, format, type, pixels.AsPointer()); }

        return pixels;
    }
}
