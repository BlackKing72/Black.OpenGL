namespace Black.OpenGL;

public enum FramebufferTargets : uint
{
    DrawFramebuffer             = Constants.glDrawFramebuffer,
    ReadFramebuffer             = Constants.glReadFramebuffer,
    Framebuffer                 = Constants.glFramebuffer,
}

public enum FramebufferStatus : uint
{
    Complete                    = Constants.glFramebufferComplete,
    Undefined                   = Constants.glFramebufferUndefined,
    IncompleteAttachment        = Constants.glFramebufferIncompleteAttachment,
    IncompleteMissingAttachment = Constants.glFramebufferIncompleteMissingAttachment,
    IncompleteDrawBuffer        = Constants.glFramebufferIncompleteDrawBuffer,
    IncompleteReadBuffer        = Constants.glFramebufferIncompleteReadBuffer,
    Unsupported                 = Constants.glFramebufferUnsupported,
    IncompleteMultisample       = Constants.glFramebufferIncompleteMultisample,
    IncompleteLayerTargets      = Constants.glFramebufferIncompleteLayerTargets,
    Error                       = 0x0000,
}

[Flags]
public enum BlitMasks : uint
{
    Color                       = Constants.glColorBufferBit,
    Depth                       = Constants.glDepthBufferBit,
    Stencil                     = Constants.glStencilBufferBit,

    Everything = Color | Depth | Stencil,
}

public enum BlitFilters : uint
{
    Nearest                     = Constants.glNearest,
    Linear                      = Constants.glLinear,
}

public enum DrawBufferModes : uint
{
    None                        = Constants.glNone,      
    FrontLeft                   = Constants.glFrontLeft,
    FrontRight                  = Constants.glFrontRight,
    BackLeft                    = Constants.glBackLeft,
    BackRight                   = Constants.glBackRight,
    Color0                      = Constants.glColorAttachment0,
    Color1                      = Constants.glColorAttachment1,
    Color2                      = Constants.glColorAttachment2,
    Color3                      = Constants.glColorAttachment3,
    Color4                      = Constants.glColorAttachment4,
    Color5                      = Constants.glColorAttachment5,
    Color6                      = Constants.glColorAttachment6,
    Color7                      = Constants.glColorAttachment7,
    Color8                      = Constants.glColorAttachment8,
    Color9                      = Constants.glColorAttachment9,
    Color10                     = Constants.glColorAttachment10,
    Color11                     = Constants.glColorAttachment11,
    Color12                     = Constants.glColorAttachment12,
    Color13                     = Constants.glColorAttachment13,
    Color14                     = Constants.glColorAttachment14,
    Color15                     = Constants.glColorAttachment15,
    Color16                     = Constants.glColorAttachment16,
    Color17                     = Constants.glColorAttachment17,
    Color18                     = Constants.glColorAttachment18,
    Color19                     = Constants.glColorAttachment19,
    Color20                     = Constants.glColorAttachment20,
    Color21                     = Constants.glColorAttachment21,
    Color22                     = Constants.glColorAttachment22,
    Color23                     = Constants.glColorAttachment23,
    Color24                     = Constants.glColorAttachment24,
    Color25                     = Constants.glColorAttachment25,
    Color26                     = Constants.glColorAttachment26,
    Color27                     = Constants.glColorAttachment27,
    Color28                     = Constants.glColorAttachment28,
    Color29                     = Constants.glColorAttachment29,
    Color30                     = Constants.glColorAttachment30,
    Color31                     = Constants.glColorAttachment31,
}

public enum FramebufferAttachments : uint
{
    Color0                      = Constants.glColorAttachment0,
    Color1                      = Constants.glColorAttachment1,
    Color2                      = Constants.glColorAttachment2,
    Color3                      = Constants.glColorAttachment3,
    Color4                      = Constants.glColorAttachment4,
    Color5                      = Constants.glColorAttachment5,
    Color6                      = Constants.glColorAttachment6,
    Color7                      = Constants.glColorAttachment7,
    Color8                      = Constants.glColorAttachment8,
    Color9                      = Constants.glColorAttachment9,
    Color10                     = Constants.glColorAttachment10,
    Color11                     = Constants.glColorAttachment11,
    Color12                     = Constants.glColorAttachment12,
    Color13                     = Constants.glColorAttachment13,
    Color14                     = Constants.glColorAttachment14,
    Color15                     = Constants.glColorAttachment15,
    Color16                     = Constants.glColorAttachment16,
    Color17                     = Constants.glColorAttachment17,
    Color18                     = Constants.glColorAttachment18,
    Color19                     = Constants.glColorAttachment19,
    Color20                     = Constants.glColorAttachment20,
    Color21                     = Constants.glColorAttachment21,
    Color22                     = Constants.glColorAttachment22,
    Color23                     = Constants.glColorAttachment23,
    Color24                     = Constants.glColorAttachment24,
    Color25                     = Constants.glColorAttachment25,
    Color26                     = Constants.glColorAttachment26,
    Color27                     = Constants.glColorAttachment27,
    Color28                     = Constants.glColorAttachment28,
    Color29                     = Constants.glColorAttachment29,
    Color30                     = Constants.glColorAttachment30,
    Color31                     = Constants.glColorAttachment31,
    Depth                       = Constants.glDepthAttachment,
    Stencil                     = Constants.glStencilAttachment,
    DepthStencil                = Constants.glDepthStencilAttachment,
}

public enum FramebufferTexture2DTargets : uint
{
    Texture2D                   = Constants.glTexture2D,
    Rectangle                   = Constants.glTextureRectangle,
    CubeMapPositiveX            = Constants.glTextureCubeMapPositiveX,
    CubeMapPositiveY            = Constants.glTextureCubeMapPositiveY,
    CubeMapPositiveZ            = Constants.glTextureCubeMapPositiveZ,
    CubeMapNegativeX            = Constants.glTextureCubeMapNegativeX,
    CubeMapNegativeY            = Constants.glTextureCubeMapNegativeY,
    CubeMapNegativeZ            = Constants.glTextureCubeMapNegativeZ,
    Texture2DMultisample        = Constants.glTexture2DMultisample,
}

public enum MipMapTargets : uint
{
    Texture1D                   = Constants.glTexture1D,
    Texture2D                   = Constants.glTexture2D,
    Texture3D                   = Constants.glTexture3D,
    Texture1DArray              = Constants.glTexture1DArray,
    Texture2DArray              = Constants.glTexture2DArray,
    CubeMap                     = Constants.glTextureCubeMap,
}

public enum AttachmentParameters : uint
{
    ColorEncoding               = Constants.glFramebufferAttachmentColorEncoding,
    ComponentType               = Constants.glFramebufferAttachmentComponentType,
    RedSize                     = Constants.glFramebufferAttachmentRedSize,
    GreenSize                   = Constants.glFramebufferAttachmentGreenSize,
    BlueSize                    = Constants.glFramebufferAttachmentBlueSize,
    AlphaSize                   = Constants.glFramebufferAttachmentAlphaSize,
    DepthSize                   = Constants.glFramebufferAttachmentDepthSize,
    StencilSize                 = Constants.glFramebufferAttachmentStencilSize,
    ObjectType                  = Constants.glFramebufferAttachmentObjectType,
    ObjectName                  = Constants.glFramebufferAttachmentObjectName,
    TextureLevel                = Constants.glFramebufferAttachmentTextureLevel,
    CubeMapFace                 = Constants.glFramebufferAttachmentTextureCubeMapFace,
    TextureLayer                = Constants.glFramebufferAttachmentTextureLayer,
    Layered                     = Constants.glFramebufferAttachmentLayered,    
}

public enum RenderbufferParameters : uint
{
    Width                       = Constants.glRenderbufferWidth,
    Height                      = Constants.glRenderbufferHeight,
    InternalFormat              = Constants.glRenderbufferInternalFormat,
    RedSize                     = Constants.glRenderbufferRedSize,
    GreenSize                   = Constants.glRenderbufferGreenSize,
    BlueSize                    = Constants.glRenderbufferBlueSize,
    AlphaSize                   = Constants.glRenderbufferAlphaSize,
    DepthSize                   = Constants.glRenderbufferDepthSize,
    StencilSize                 = Constants.glRenderbufferStencilSize,
    Samples                     = Constants.glRenderbufferSamples
}