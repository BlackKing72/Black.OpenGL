namespace Black.OpenGL;

using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Black.Unmanaged;

using static Black.OpenGL.Native;

public static unsafe partial class GL
{
    public static void BindFramebuffer(FramebufferTargets target, uint framebuffer)
    {
        glBindFramebuffer(target, framebuffer);
    }

    public static void BindRenderbuffer(uint framebuffer)
    {
        glBindRenderbuffer(Constants.glRenderbuffer, framebuffer);
    }

    public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, BlitMasks mask, BlitFilters filter)
    {
        glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
    }

    public static void BlitFramebuffer(Point srcMin, Point srcMax, Point dstMin, Point dstMax, BlitMasks mask, BlitFilters filter)
    {
        glBlitFramebuffer(srcMin.X, srcMin.Y, srcMax.X, srcMax.Y, dstMin.X, dstMin.Y, dstMax.X, dstMax.Y, mask, filter);
    }

    public static FramebufferStatus CheckFramebufferStatus(FramebufferTargets target)
    {
        return glCheckFramebufferStatus(target);
    }

    public static void DeleteFramebuffer(uint framebuffer)
    {
        glDeleteFramebuffers(1, &framebuffer);
    }

    public static void DeleteFramebuffers(ReadOnlySpan<uint> framebuffers)
    {
        glDeleteFramebuffers((uint)framebuffers.Length, framebuffers.AsPointer());
    }

    public static void DeleteRenderbuffer(uint renderbuffer)
    {
        glDeleteRenderbuffers(1, &renderbuffer);
    }

    public static void DeleteRenderbuffers(ReadOnlySpan<uint> renderbuffers)
    {
        glDeleteRenderbuffers((uint)renderbuffers.Length, renderbuffers.AsPointer());
    }

    public static void DrawBuffers(ReadOnlySpan<DrawBufferModes> bufs)
    {
        glDrawBuffers((uint)bufs.Length, bufs.AsPointer());
    }

    public static void FramebufferRenderbuffer(FramebufferTargets target, FramebufferAttachments attachment, uint renderbuffer)
    {
        glFramebufferRenderbuffer(target, attachment, Constants.glRenderbuffer, renderbuffer);
    }

    public static void FramebufferTexture(FramebufferTargets target, FramebufferAttachments attachment, uint texture, int level)
    {
        glFramebufferTexture(target, attachment, texture, level);
    }

    public static void FramebufferTexture1D(FramebufferTargets target, FramebufferAttachments attachment, uint texture, int level)
    {
        glFramebufferTexture1D(target, attachment, Constants.glTexture1D, texture, level);
    }

    public static void FramebufferTexture2D(FramebufferTargets target, FramebufferAttachments attachment, FramebufferTexture2DTargets textarget, uint texture, int level)
    {
        glFramebufferTexture2D(target, attachment, textarget, texture, level);
    }

    public static void FramebufferTexture3D(FramebufferTargets target, FramebufferAttachments attachment,  uint texture, int level, int layer)
    {
        glFramebufferTexture3D(target, attachment, Constants.glTexture3D, texture, level, layer);
    }

    public static void FramebufferTextureLayer(FramebufferTargets target, FramebufferAttachments attachment, uint texture, int level, int layer)
    {
        glFramebufferTextureLayer(target, attachment, texture, level, layer);
    }

    public static uint GenFramebuffer()
    {
        uint framebuffer;
        glGenFramebuffers(1, &framebuffer);
        return framebuffer;
    }
    
    public static uint[] GenFramebuffers(uint count)
    {
        uint[] framebuffers = new uint[count];
        glGenFramebuffers(count, framebuffers.AsPointer());
        return framebuffers;
    }

    public static uint GenRenderbuffer()
    {
        uint renderbuffer;
        glGenRenderbuffers(1, &renderbuffer);
        return renderbuffer;
    }
    
    public static uint[] GenRenderbuffers(uint count)
    {
        uint[] renderbuffers = new uint[count];
        glGenRenderbuffers(count, renderbuffers.AsPointer());
        return renderbuffers;
    }

    public static void GenerateMipmap(MipMapTargets target)
    {
        glGenerateMipmap(target);
    }

    public static int GetFramebufferAttachmentParameter<T>(FramebufferTargets target, FramebufferAttachments attachment, AttachmentParameters parameter)
    {
        int value;
        glGetFramebufferAttachmentParameteriv(target, attachment, parameter, &value);
        return value;
    }
    
    public static int GetRenderbufferParameter(FramebufferTargets target, RenderbufferParameters parameter)
    {
        int value;
        glGetRenderbufferParameteriv(target, parameter, &value);
        return value;
    }

    public static bool IsFramebuffer(uint framebuffer)
    {
        return glIsFramebuffer(framebuffer) == Constants.glTrue;
    }

    public static bool IsRenderbuffer(uint renderbuffer)
    {
        return glIsRenderbuffer(renderbuffer) == Constants.glTrue;
    }

    public static void RenderbufferStorage(InternalFormats internalFormat, uint width, uint Height)
    {
        glRenderbufferStorage(Constants.glRenderbuffer, internalFormat, width, Height);
    }

    public static void RenderbufferStorageMultisample(uint samples, InternalFormats internalFormat, uint width, uint Height)
    {
        glRenderbufferStorageMultisample(Constants.glRenderbuffer, samples, internalFormat, width, Height);
    }

    public static void SampleMask(uint maskNumber, uint mask)
    {
        glSampleMaski(maskNumber, mask);
    }
}