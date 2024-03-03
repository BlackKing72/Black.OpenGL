namespace Black.OpenGL;

public enum SizedInternalFormats : uint
{
    R8                                  = 0x8229,
    R8Int                               = 0x8231,
    R8UInt                              = 0x8232,
    R8Snorm                             = 0x8F94,

    R16                                 = 0x822A,
    R16Float                            = 0x822D,
    R16Int                              = 0x8233,
    R16UInt                             = 0x8234,
    R16Snorm                            = 0x8F98,
    
    R32Float                            = 0x822E,
    R32Int                              = 0x8235,
    R32UInt                             = 0x8236,
    
    Rg8                                 = 0x822B,
    Rg8Int                              = 0x8237,
    Rg8UInt                             = 0x8238,
    Rg8Snorm                            = 0x8F95,

    Rg16                                = 0x822C,
    Rg16Float                           = 0x822F,
    Rg16Int                             = 0x8239,
    Rg16UInt                            = 0x823A,
    Rg16Snorm                           = 0x8F99,
    
    Rg32Float                           = 0x8230,
    Rg32Int                             = 0x823B,
    Rg32UInt                            = 0x823C,

    Rgb8                                = 0x8051,
    Rgb8Int                             = 0x8D8F,
    Rgb8UInt                            = 0x8D7D,
    Rgb8Snorm                           = 0x8F96,

    Rgb16                               = 0x8054,   
    Rgb16Float                          = 0x881B,
    Rgb16Int                            = 0x8D89,
    Rgb16UInt                           = 0x8D77,
    Rgb16Snorm                          = 0x8F9A,

    Rgb32Float                          = 0x8815,
    Rgb32Int                            = 0x8D83,
    Rgb32UInt                           = 0x8D71,

    Rgba8                               = 0x8058,
    Rgba8Int                            = 0x8D8E,
    Rgba8UInt                           = 0x8D7C,
    Rgba8Snorm                          = 0x8F97,

    Rgba16                              = 0x805B,
    Rgba16Float                         = 0x881A,
    Rgba16Int                           = 0x8D88,
    Rgba16UInt                          = 0x8D76,
    Rgba16Snorm                         = 0x8F9B,
    
    Rgba32Float                         = 0x8814,
    Rgba32Int                           = 0x8D82,
    Rgba32UInt                          = 0x8D70,

    Srgb8                               = 0x8C41,
    Srgb8Alpha8                         = 0x8C43,

    Rgb10A2                             = 0x8059,
    Rgb10A2UInt                         = 0x906F,
    R11FG11FB10F                        = 0x8C3A,
       
    Rgb9E5                              = 0x8C3D,   
    
    CompressedRgRgtc2                   = 0x8DBD,
    CompressedSignedRedRgtc1            = 0x8DBC,
    CompressedSignedRgRgtc2             = 0x8DBE,    
    CompressedRedRgtc1                  = 0x8DBB,

    DepthComponent16                    = 0x81A5,
    DepthComponent24                    = 0x81A6,
    DepthComponent32                    = 0x81A7,
    DepthComponent32Float               = 0x8CAC,
    Depth24Stencil8                     = 0x88F0,
    Depth32FStencil8                    = 0x8CAD,
}
