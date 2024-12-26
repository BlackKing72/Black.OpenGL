#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value null

namespace Black.OpenGL;

internal unsafe partial class Native
{
    internal delegate void BindFramebuffer(FramebufferTargets target, uint framebuffer);
    [OpenGL<BindFramebuffer>] internal static BindFramebuffer glBindFramebuffer;
    
    internal delegate void BindRenderbuffer(uint target, uint framebuffer);
    [OpenGL<BindRenderbuffer>] internal static BindRenderbuffer glBindRenderbuffer;
    
    internal delegate void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, BlitMasks mask, BlitFilters filter);
    [OpenGL<BlitFramebuffer>] internal static BlitFramebuffer glBlitFramebuffer;
    
    internal delegate void DeleteFramebuffers(uint n, uint* framebuffers);
    [OpenGL<DeleteFramebuffers>] internal static DeleteFramebuffers glDeleteFramebuffers;
    
    internal delegate void DeleteRenderbuffers(uint n, uint* renderbuffers);
    [OpenGL<DeleteRenderbuffers>] internal static DeleteRenderbuffers glDeleteRenderbuffers;
    
    internal delegate void DrawBuffers(uint n, DrawBufferModes* bufs);
    [OpenGL<DrawBuffers>] internal static DrawBuffers glDrawBuffers;
    
    internal delegate void FramebufferRenderbuffer(FramebufferTargets target, FramebufferAttachments attachment, uint rendebufferTarget, uint renderbuffer);
    [OpenGL<FramebufferRenderbuffer>] internal static FramebufferRenderbuffer glFramebufferRenderbuffer;
    
    internal delegate void FramebufferTexture(FramebufferTargets target, FramebufferAttachments attachment, uint texture, int level);
    [OpenGL<FramebufferTexture>] internal static FramebufferTexture glFramebufferTexture;

    internal delegate void FramebufferTexture1D(FramebufferTargets target, FramebufferAttachments attachment, uint textarget, uint texture, int level);
    [OpenGL<FramebufferTexture1D>] internal static FramebufferTexture1D glFramebufferTexture1D;

    internal delegate void FramebufferTexture2D(FramebufferTargets target, FramebufferAttachments attachment, FramebufferTexture2DTargets textarget, uint texture, int level);
    [OpenGL<FramebufferTexture2D>] internal static FramebufferTexture2D glFramebufferTexture2D;

    internal delegate void FramebufferTexture3D(FramebufferTargets target, FramebufferAttachments attachment, uint textarget, uint texture, int level, int layer);
    [OpenGL<FramebufferTexture3D>] internal static FramebufferTexture3D glFramebufferTexture3D;

    internal delegate void FramebufferTextureLayer(FramebufferTargets target, FramebufferAttachments attachment, uint texture, int level, int layer);
    [OpenGL<FramebufferTextureLayer>] internal static FramebufferTextureLayer glFramebufferTextureLayer;

    internal delegate FramebufferStatus CheckFramebufferStatus(FramebufferTargets target);
    [OpenGL<CheckFramebufferStatus>] internal static CheckFramebufferStatus glCheckFramebufferStatus;

    internal delegate void GenFramebuffers(uint n, uint* ids);
    [OpenGL<GenFramebuffers>] internal static GenFramebuffers glGenFramebuffers;
    
    internal delegate void GenRenderbuffers(uint n, uint* renderbuffers);
    [OpenGL<GenRenderbuffers>] internal static GenRenderbuffers glGenRenderbuffers;
    
    internal delegate void GenerateMipmap(MipMapTargets target);
    [OpenGL<GenerateMipmap>] internal static GenerateMipmap glGenerateMipmap;
    
    internal delegate void GetFramebufferAttachmentParameteriv(FramebufferTargets target, FramebufferAttachments attachment, AttachmentParameters pname, int* @params);
    [OpenGL<GetFramebufferAttachmentParameteriv>] internal static GetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv;

    internal delegate void GetRenderbufferParameteriv(FramebufferTargets target, RenderbufferParameters pname, int* @params);
    [OpenGL<GetRenderbufferParameteriv>] internal static GetRenderbufferParameteriv glGetRenderbufferParameteriv;

    internal delegate int IsFramebuffer(uint framebuffer);
    [OpenGL<IsFramebuffer>] internal static IsFramebuffer glIsFramebuffer;

    internal delegate int IsRenderbuffer(uint renderbuffer);
    [OpenGL<IsRenderbuffer>] internal static IsRenderbuffer glIsRenderbuffer;

    internal delegate void RenderbufferStorage(uint target, InternalFormats internalFormat, uint width, uint Height);
    [OpenGL<RenderbufferStorage>] internal static RenderbufferStorage glRenderbufferStorage;

    internal delegate void RenderbufferStorageMultisample(uint target, uint samples, InternalFormats internalFormat, uint width, uint Height);
    [OpenGL<RenderbufferStorageMultisample>] internal static RenderbufferStorageMultisample glRenderbufferStorageMultisample;
    
    internal delegate void SampleMaski(uint maskNumber, uint mask);
    [OpenGL<SampleMaski>] internal static SampleMaski glSampleMaski;
}

#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value null
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.