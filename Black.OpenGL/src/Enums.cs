namespace Draft.OpenGL;

public enum ClearMask : uint
{
    Color                               = 0x00004000,
    Depth                               = 0x00000100,
    Stencil                             = 0x00000400,
}

public enum ShaderType : uint
{
    Vertex                              = 0x8B31,
    Fragment                            = 0x8B30,
    Geometry                            = 0x8DD9,
}

public enum ShaderParameterName : uint
{
    ShaderType                          = 0x8B4F,
    DeleteStatus                        = 0x8B80,
    CompileStatus                       = 0x8B81,
    InfoLogLength                       = 0x8B84,
    ShaderSourceLength                  = 0x8B88,
}

public enum ProgramParameterName : uint
{
    DeleteStatus                        = 0x8B80,
    LinkStatus                          = 0x8B82,
    ValidateStatus                      = 0x8B83,
    InfoLogLength                       = 0x8B84,
    AttachedShaders                     = 0x8B85, 
    ActiveAttributes                    = 0x8B89, 
    ActiveAttributeMaxLength            = 0x8B8A, 
    ActiveUniforms                      = 0x8B86, 
    ActiveUniformBlocks                 = 0x8A36, 
    ActiveUniformBlockMaxNameLength     = 0x8A35, 
    ActiveUniformMaxLength              = 0x8B87, 
    TransformFeedbackBufferMode         = 0x8C7F, 
    TransformFeedbackVaryings           = 0x8C83, 
    TransformFeedbackVaryingMaxLength   = 0x8C76, 
    GeometryVerticesOut                 = 0x8916, 
    GeometryInputType                   = 0x8917, 
    GeometryOutputType                  = 0x8918,
}

public enum BufferTarget
{
    Array                               = 0x8892,
    CopyRead                            = 0x8F36,
    CopyWrite                           = 0x8F37,
    ElementArray                        = 0x8893,
    PixelPack                           = 0x88EB,
    PixelUnpack                         = 0x88EC,
    Texture                             = 0x8C2A,
    TransformFeedback                   = 0x8C7F,
    Uniform                             = 0x8A11,

    Vertex                              = Array,
    Index                               = ElementArray
}

public enum BufferUsageHint
{
    StreamDraw                          = 0x88E0,
    StreamRead                          = 0x88E1,
    StreamCopy                          = 0x88E2,
    StaticDraw                          = 0x88E4,
    StaticRead                          = 0x88E5,
    StaticCopy                          = 0x88E6,
    DynamicDraw                         = 0x88E8,
    DynamicRead                         = 0x88E9,
    DynamicCopy                         = 0x88EA,
}

public enum AttributeType : uint 
{
    Byte                                = 0x1400,
    UByte                               = 0x1401,
    Short                               = 0x1402,
    UShort                              = 0x1403,
    Int                                 = 0x1404,
    UInt                                = 0x1405,
    Half                                = 0x140B,
    Float                               = 0x1406,
    Double                              = 0x140A,
    Int_2_10_10_10_Rev                  = 0x8D9F,
    UInt_2_10_10_10_Rev                 = 0x8368,

    I8                                  = Byte,
    U8                                  = UByte,
    I16                                 = Short,
    U16                                 = UShort,
    I32                                 = Int,
    U32                                 = UInt,
    F16                                 = Half,
    F32                                 = Float,
    F64                                 = Double
}

public enum AttributeTypeI : uint 
{
    Byte                                = 0x1400,
    UByte                               = 0x1401,
    Short                               = 0x1402,
    UShort                              = 0x1403,
    Int                                 = 0x1404,
    UInt                                = 0x1405,

    I8                                  = Byte,
    U8                                  = UByte,
    I16                                 = Short,
    U16                                 = UShort,
    I32                                 = Int,
    U32                                 = UInt,
}

public enum DrawMode : uint 
{
    Points                              = 0x0000,
    Lines                               = 0x0001,
    LineLoop                            = 0x0002,
    LineStrip                           = 0x0003,
    Triangles                           = 0x0004, 
    TriangleStrip                       = 0x0005, 
    TriangleFan                         = 0x0006, 
    LinesAdjacency                      = 0x000A, 
    LineStripAdjacency                  = 0x000B, 
    TrianglesAdjacency                  = 0x000C,
    TriangleStripAdjacency              = 0x000D,
}

public enum ClearBufferTarget : uint
{
    Color                               = 0x1800,
    Depth                               = 0x1801,
    Stencil                             = 0x1802,
    DepthStencil                        = 0x84F9,

    Front                               = 0x0404, 
    Back                                = 0x0405,
    Left                                = 0x0406,
    Right                               = 0x0407,
    FrontAndBack                        = 0x0408,
}

public enum BufferMode : uint
{
    None                                = 0x0000,
    FrontLeft                           = 0x0400,
    FrontRight                          = 0x0401,
    BackLeft                            = 0x0402,
    BackRight                           = 0x0403,
    Front                               = 0x0404,
    Back                                = 0x0405,
    Left                                = 0x0406,
    Right                               = 0x0407,
    FrontAndBack                        = 0x0408
}

public enum ReadPixelFormat : uint
{
    StencilIndex                        = 0x1901,
    DepthComponent                      = 0x1902,
    DepthStencil                        = 0x84F9,
    Red                                 = 0x1903,
    Green                               = 0x1904,
    Blue                                = 0x1905,
    Rgb                                 = 0x1907,
    Rgba                                = 0x1908,
    Bgr                                 = 0x80E0,
    Bgra                                = 0x80E1,
}

public enum ReadPixelType : uint
{
    SByte                               = 0x1400,
    UByte                               = 0x1401,
    Short                               = 0x1402,
    UShort                              = 0x1403,
    Int                                 = 0x1404,
    UInt                                = 0x1405,
    Float                               = 0x1406,
    Half                                = 0x140B,
    UByte_332                           = 0x8032,
    UByte_233_Rev                       = 0x8362,
    UShort_565                          = 0x8363,
    UShort_565_Rev                      = 0x8364,
    UShort_4444                         = 0x8033,
    UShort_4444_Rev                     = 0x8365,
    UShort_5551                         = 0x8034,
    UShort_1555_Rev                     = 0x8366,
    UInt_8888                           = 0x8035,
    UInt_8888_Rev                       = 0x8367,
    Uint_1010102                        = 0x8036,
    Uint_2101010_Rev                    = 0x8368,
    UInt_248                            = 0x84FA,
    UInt_10F11F11F_Rev                  = 0x8C3B,
    Uint_5999_Rev                       = 0x8C3E,
    Float_32_UInt_248_Rev               = 0x8DAD,
}





#region Old

public enum TexTarget : uint
{
    Texture1D                           = 0x0DE0,
    Texture1DProxy                      = 0x8063,
    Texture1DArray                      = 0x8C18,
    Texture1DProxyArray                 = 0x8C19,

    Texture2D                           = 0x0DE1,
    Texture2DProxy                      = 0x8070,
    Texture2DArray                      = 0x8C1A,
    Texture2DProxyArray                 = 0x0,
    Texture2DMultisample                = 0x9100,
    Texture2DMultisampleArray           = 0x9102,

    Texture3D                           = 0x806F,
    Texture3DProxy                      = 0x0,

    Rectangle                           = 0x84F5,
    Buffer                              = 0x8C2A,

    CubeMap                             = 0x8513,
    CubeMapProxy                        = 0x851B,
    CubeMapPositiveX                    = 0x8515,
    CubeMapNegativeX                    = 0x8516,
    CubeMapPositiveY                    = 0x8517,
    CubeMapNegativeY                    = 0x8518,
    CubeMapPositiveZ                    = 0x8519,
    CubeMapNegativeZ                    = 0x851A,
}

public enum Compressed1DTarget : uint
{
    Texture1D                           = TexTarget.Texture1D,
    Texture1DProxy                      = TexTarget.Texture1DProxy,
}

public enum Compressed2DTarget : uint
{
    Texture2D                           = TexTarget.Texture2D,
    Texture2DProxy                      = TexTarget.Texture2DProxy,
    Texture1DArray                      = TexTarget.Texture1DArray,
    Texture1DProxyArray                 = TexTarget.Texture1DProxyArray,
    CubeMapProxy                        = TexTarget.CubeMapProxy,
    CubeMapPositiveX                    = TexTarget.CubeMapPositiveX,
    CubeMapNegativeX                    = TexTarget.CubeMapNegativeX,
    CubeMapPositiveY                    = TexTarget.CubeMapPositiveY,
    CubeMapNegativeY                    = TexTarget.CubeMapNegativeY,
    CubeMapPositiveZ                    = TexTarget.CubeMapPositiveZ,
    CubeMapNegativeZ                    = TexTarget.CubeMapNegativeZ,
}

public enum Compressed3DTarget : uint
{
    Texture3D                           = TexTarget.Texture3D,
    Texture3DProxy                      = TexTarget.Texture3DProxy,
    Texture2DArray                      = TexTarget.Texture2DArray,
    Texture2DProxyArray                 = TexTarget.Texture2DProxyArray,
}

public enum InternalFormat : uint
{
    CompressedRed                       = 0x8225,
    CompressedRg                        = 0x8226,
    CompressedRgb                       = 0x84ED,
    CompressedRgba                      = 0x84EE,
    CompressedSrgb                      = 0x8C48,
    CompressedSrgba                     = 0x8C49,
}

public enum CompressedInternalFormat : uint
{
    CompressedRed                       = InternalFormat.CompressedRed,
    CompressedRg                        = InternalFormat.CompressedRg,
    CompressedRgb                       = InternalFormat.CompressedRgb,
    CompressedRgba                      = InternalFormat.CompressedRgba,
    CompressedSrgb                      = InternalFormat.CompressedSrgb,
    CompressedSrgba                     = InternalFormat.CompressedSrgba,
}

#endregion