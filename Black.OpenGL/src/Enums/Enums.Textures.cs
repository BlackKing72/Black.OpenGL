namespace Black.OpenGL;

public enum TextureTargets : uint
{
    Texture1D                           = 0x0DE0,
    Texture1DArray                      = 0x8C18,
    Texture2D                           = 0x0DE1,
    
    Texture2DArray                      = 0x8C1A,
    Texture2DMultisample                = 0x9100,
    Texture2DMultisampleArray           = 0x9102,
    Texture3D                           = 0x806F,
    CubeMap                             = 0x8513,
    Rectangle                           = 0x84F5,

    ProxyTexture1D                      = 0x8063,
    ProxyTexture1DArray                 = 0x8C19,
    ProxyTexture2D                      = 0x8070,
    ProxyTexture2DArray                 = 0x8C1B,
    ProxyTexture2DMultisample           = 0x8070,
    ProxyTexture2DMultisampleArray      = 0x9103,
    ProxyTexture3D                      = 0x9101,
    ProxyCubeMap                        = 0x851B,
    ProxyRectangle                      = 0x84F7,

    Buffer                              = 0x8C2A,

    CubeMapPositiveX                    = 0x8515,
    CubeMapNegativeX                    = 0x8516,
    CubeMapPositiveY                    = 0x8517,
    CubeMapNegativeY                    = 0x8518,
    CubeMapPositiveZ                    = 0x8519,
    CubeMapNegativeZ                    = 0x851A,
}

public enum Compressed1DTargets : uint
{
    Texture1D                           = TextureTargets.Texture1D,
    Texture1DProxy                      = TextureTargets.ProxyTexture1D,
}

public enum Compressed2DTargets : uint
{
    Texture2D                           = TextureTargets.Texture2D,
    ProxyTexture2D                      = TextureTargets.ProxyTexture2D,
    Texture1DArray                      = TextureTargets.Texture1DArray,
    ProxyTexture1DArray                 = TextureTargets.ProxyTexture1DArray,
    ProxyCubeMap                        = TextureTargets.ProxyCubeMap,
    CubeMapPositiveX                    = TextureTargets.CubeMapPositiveX,
    CubeMapNegativeX                    = TextureTargets.CubeMapNegativeX,
    CubeMapPositiveY                    = TextureTargets.CubeMapPositiveY,
    CubeMapNegativeY                    = TextureTargets.CubeMapNegativeY,
    CubeMapPositiveZ                    = TextureTargets.CubeMapPositiveZ,
    CubeMapNegativeZ                    = TextureTargets.CubeMapNegativeZ,
}

public enum Compressed3DTargets : uint
{
    Texture3D                           = TextureTargets.Texture3D,
    Texture3DProxy                      = TextureTargets.ProxyTexture3D,
    Texture2DArray                      = TextureTargets.Texture2DArray,
    Texture2DProxyArray                 = TextureTargets.ProxyTexture2DArray,
}

public enum InternalFormats : uint
{
    CompressedRed                       = 0x8225,
    CompressedRg                        = 0x8226,
    CompressedRgb                       = 0x84ED,
    CompressedRgba                      = 0x84EE,
    CompressedSrgb                      = 0x8C48,
    CompressedSrgbAlpha                 = 0x8C49,
    DepthComponent                      = 0x1902, 
    DepthComponent16                    = 0x81A5, 
    DepthComponent24                    = 0x81A6, 
    DepthComponent32                    = 0x81A7, 
    Red                                 = 0x1903, 
    Rg                                  = 0x8227, 
    Rgb                                 = 0x1907, 
    Rgba                                = 0x1908, 
    R3G3B2                              = 0x2A10, 
    Rgb4                                = 0x804F, 
    Rgb5                                = 0x8050, 
    Rgb8                                = 0x8051, 
    Rgb10                               = 0x8052, 
    Rgb12                               = 0x8053, 
    Rgb16                               = 0x8054, 
    Rgba2                               = 0x8055, 
    Rgba4                               = 0x8056, 
    Rgb5A1                              = 0x8057, 
    Rgba8                               = 0x8058, 
    Rgb10A2                             = 0x8059, 
    Rgba12                              = 0x805A, 
    Rgba16                              = 0x805B, 
    Srgb                                = 0x8C40, 
    Srgb8                               = 0x8C41, 
    Srgb8Alpha8                         = 0x8C43,
    SrgbAlpha                           = 0x8C42, 
}

public enum CompressedInternalFormats : uint
{
    CompressedRed                       = InternalFormats.CompressedRed,
    CompressedRg                        = InternalFormats.CompressedRg,
    CompressedRgb                       = InternalFormats.CompressedRgb,
    CompressedRgba                      = InternalFormats.CompressedRgba,
    CompressedSrgb                      = InternalFormats.CompressedSrgb,
    CompressedSrgbAlpha                 = InternalFormats.CompressedSrgbAlpha,
}

public enum CopyTex2DTargets : uint
{
    Texture2D                           = TextureTargets.Texture2D, 
    CubeMapPositiveX                    = TextureTargets.CubeMapPositiveX, 
    CubeMapNegativeX                    = TextureTargets.CubeMapNegativeX, 
    CubeMapPositiveY                    = TextureTargets.CubeMapPositiveY, 
    CubeMapNegativeY                    = TextureTargets.CubeMapNegativeY, 
    CubeMapPositiveZ                    = TextureTargets.CubeMapPositiveZ, 
    CubeMapNegativeZ                    = TextureTargets.CubeMapNegativeZ,
}

public enum CopyTex3DTargets : uint 
{
    Texture3D                           = TextureTargets.Texture3D,
    Texture2DArray                      = TextureTargets.Texture2DArray,
}

public enum GetCompressedTexTargets : uint
{
    Texture1D                           = TextureTargets.Texture1D,
    Texture2D                           = TextureTargets.Texture2D, 
    Texture3D                           = TextureTargets.Texture3D, 
    CubeMapPositiveX                    = TextureTargets.CubeMapPositiveX,
    CubeMapNegativeX                    = TextureTargets.CubeMapNegativeX, 
    CubeMapPositiveY                    = TextureTargets.CubeMapPositiveY, 
    CubeMapNegativeY                    = TextureTargets.CubeMapNegativeY, 
    CubeMapPositiveZ                    = TextureTargets.CubeMapPositiveZ, 
    CubeMapNegativeZ                    = TextureTargets.CubeMapNegativeZ,
}

public enum GetTexLevelTargets : uint
{
    Texture1D                           = TextureTargets.Texture1D,
    Texture2D                           = TextureTargets.Texture2D, 
    Texture3D                           = TextureTargets.Texture3D, 
    Texture1DArray                      = TextureTargets.Texture1DArray,
    Texture2DArray                      = TextureTargets.Texture2DArray,
    TextureRectangle                    = TextureTargets.Rectangle,
    CubeMapPositiveX                    = TextureTargets.CubeMapPositiveX,
    CubeMapNegativeX                    = TextureTargets.CubeMapNegativeX, 
    CubeMapPositiveY                    = TextureTargets.CubeMapPositiveY, 
    CubeMapNegativeY                    = TextureTargets.CubeMapNegativeY, 
    CubeMapPositiveZ                    = TextureTargets.CubeMapPositiveZ, 
    CubeMapNegativeZ                    = TextureTargets.CubeMapNegativeZ,
}

public enum GetTexLevelParameterNames : uint
{
    TextureWidth                        = 0x1000, 
    TextureHeight                       = 0x1001, 
    TextureDepth                        = 0x8071, 
    TextureInternalFormat               = 0x1003,
    TextureRedSize                      = 0x805C, 
    TextureGreenSize                    = 0x805D, 
    TextureBlueSize                     = 0x805E, 
    TextureAlphaSize                    = 0x805F, 
    TextureDepthSize                    = 0x884A, 
    TextureCompressed                   = 0x86A1, 
    TextureCompressedImageSize          = 0x86A0,
    TextureRedType                      = 0x8C10,
    TextureGreenType                    = 0x8C11,
    TextureBlueType                     = 0x8C12,
    TextureAlphaType                    = 0x8C13,
    TextureDepthType                    = 0x8C16,
}

public enum TextureParameterTargets : uint
{
    Texture1D                           = TextureTargets.Texture1D, 
    Texture2D                           = TextureTargets.Texture2D, 
    Texture1DArray                      = TextureTargets.Texture1DArray, 
    Texture2DArray                      = TextureTargets.Texture2DArray, 
    Texture3D                           = TextureTargets.Texture3D, 
    TextureRectangle                    = TextureTargets.Rectangle, 
    TextureCubeMap                      = TextureTargets.CubeMap,
}

public enum TextureParameters : uint
{
    TextureBaseLevel                    = 0x813C, 
    TextureBorderColor                  = 0x1004, 
    TextureCompareFunc                  = 0x884D, 
    TextureCompareMode                  = 0x884C, 
    TextureLodBias                      = 0x8501, 
    TextureMagFilter                    = 0x2800, 
    TextureMaxLevel                     = 0x813D, 
    TextureMaxLod                       = 0x813B, 
    TextureMinFilter                    = 0x2801, 
    TextureMinLod                       = 0x813A, 
    TextureSwizzleA                     = 0x8E46, 
    TextureSwizzleB                     = 0x8E42, 
    TextureSwizzleG                     = 0x8E43, 
    TextureSwizzleR                     = 0x8E44, 
    TextureSwizzleRgba                  = 0x8E45, 
    TextureWrapR                        = 0x8072,
    TextureWrapS                        = 0x2802, 
    TextureWrapT                        = 0x2803,
}

public enum Texture1DTargets : uint
{
    Texture1D                           = TextureTargets.Texture1D,
    ProxyTexture1D                      = TextureTargets.ProxyTexture1D
}

public enum Texture2DTargets : uint
{
    Texture2D                           = TextureTargets.Texture2D, 
    ProxyTexture2D                      = TextureTargets.ProxyTexture2D, 
    Texture1DArray                      = TextureTargets.Texture1DArray, 
    ProxyTexture1DArray                 = TextureTargets.ProxyTexture1DArray, 
    Rectangle                           = TextureTargets.Rectangle, 
    ProxyRectangle                      = TextureTargets.ProxyRectangle, 
    CubeMapPositiveX                    = TextureTargets.CubeMapPositiveX, 
    CubeMapNegativeX                    = TextureTargets.CubeMapNegativeX, 
    CubeMapPositiveY                    = TextureTargets.CubeMapPositiveY, 
    CubeMapNegativeY                    = TextureTargets.CubeMapNegativeY, 
    CubeMapPositiveZ                    = TextureTargets.CubeMapPositiveZ, 
    CubeMapNegativeZ                    = TextureTargets.CubeMapNegativeZ, 
    ProxyCubeMap                        = TextureTargets.ProxyCubeMap,
}

public enum Texture2DMultisampleTargets : uint
{
    Texture2DMultisample                = TextureTargets.Texture2DMultisample,
    ProxyTexture2DMultisample           = TextureTargets.ProxyTexture2DMultisample,
}

public enum Texture3DTargets : uint
{
    Texture3D                           = TextureTargets.Texture3D,
    ProxyTexture3D                      = TextureTargets.ProxyTexture3D,
    Texture2DArray                      = TextureTargets.Texture2DArray,
    ProxyTexture2DArray                 = TextureTargets.ProxyTexture2DArray,
}

public enum Texture3DMultisampleTargets : uint
{
    Texture2DMultisampleArray           = TextureTargets.Texture2DMultisampleArray,
    ProxyTexture2DMultisampleArray      = TextureTargets.ProxyTexture2DMultisampleArray,
}

public enum Internal1DFormats : uint
{
    CompressedRed                       = InternalFormats.CompressedRed,
    CompressedRg                        = InternalFormats.CompressedRg,
    CompressedRgb                       = InternalFormats.CompressedRgb,
    CompressedRgba                      = InternalFormats.CompressedRgba,
    CompressedSrgb                      = InternalFormats.CompressedSrgb,
    CompressedSrgbAlpha                 = InternalFormats.CompressedSrgbAlpha,
    DepthComponent                      = InternalFormats.DepthComponent,
    DepthComponent16                    = InternalFormats.DepthComponent16,
    DepthComponent24                    = InternalFormats.DepthComponent24,
    DepthComponent32                    = InternalFormats.DepthComponent32,
    R3G3B2                              = InternalFormats.R3G3B2,
    Red                                 = InternalFormats.Red,
    Rg                                  = InternalFormats.Rg,
    Rgb                                 = InternalFormats.Rgb,
    Rgb4                                = InternalFormats.Rgb4,
    Rgb5                                = InternalFormats.Rgb5,
    Rgb8                                = InternalFormats.Rgb8,
    Rgb10                               = InternalFormats.Rgb10,
    Rgb12                               = InternalFormats.Rgb12,
    Rgb16                               = InternalFormats.Rgb16,
    Rgba                                = InternalFormats.Rgba,
    Rgba2                               = InternalFormats.Rgba2,
    Rgba4                               = InternalFormats.Rgba4,
    Rgb5A1                              = InternalFormats.Rgb5A1,
    Rgba8                               = InternalFormats.Rgba8,
    Rgb10A2                             = InternalFormats.Rgb10A2,
    Rgba12                              = InternalFormats.Rgba12,
    Rgba16                              = InternalFormats.Rgba16,
    Srgb                                = InternalFormats.Srgb,
    Srgb8                               = InternalFormats.Srgb8,
    SrgbAlpha                           = InternalFormats.SrgbAlpha,
    Srgb8Alpha8                         = InternalFormats.Srgb8Alpha8,
}

public enum TexturePixelFormats : uint
{
    Red                                 = PixelFormats.Red,
    Rg                                  = PixelFormats.Rg,
    Rgb                                 = PixelFormats.Rgb,
    Rgba                                = PixelFormats.Rgba,
    Bgr                                 = PixelFormats.Bgr,
    Bgra                                = PixelFormats.Bgra,
    DepthComponent                      = PixelFormats.DepthComponent,
    DepthStencil                        = PixelFormats.DepthStencil,
}

public enum TextureMinFilters : uint
{
    Nearest                             = 0x2600,
    Linear                              = 0x2601,
    NearestMipmapNearest                = 0x2700,
    LinearMipmapNearest                 = 0x2701,
    NearestMipmapLinear                 = 0x2702,
    LinearMipMapLinear                  = 0x2703,
}

public enum TextureMagFilters : uint
{
    Nearest                             = TextureMinFilters.Nearest,
    Linear                              = TextureMinFilters.Linear
}

public enum TextureWrapModes : uint
{
    ClampToBorder                       = 0x812D,
    ClampToEdge                         = 0x812F,
    MirroredRepeat                      = 0x8370,
    Repeat                              = 0x2901, 
}