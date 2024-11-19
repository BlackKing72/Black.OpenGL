#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value null

namespace Black.OpenGL;

internal unsafe partial class Native
{
    internal delegate void ActiveTexture (uint texture);
    [OpenGL<ActiveTexture>] internal static ActiveTexture glActiveTexture;

    internal delegate void BindTexture(TextureTargets target, uint texture);
    [OpenGL<BindTexture>] internal static BindTexture glBindTexture;

    internal delegate void CompressedTexImage1D (Compressed1DTargets target, int level, CompressedInternalFormats internalformat, int width, int border, int imageSize, void* data);
    [OpenGL<CompressedTexImage1D>] internal static CompressedTexImage1D glCompressedTexImage1D;

    internal delegate void CompressedTexImage2D (Compressed2DTargets target, int level, CompressedInternalFormats internalformat, int width, int height, int border, int imageSize, void* data);
    [OpenGL<CompressedTexImage2D>] internal static CompressedTexImage2D glCompressedTexImage2D;

    internal delegate void CompressedTexImage3D (Compressed3DTargets target, int level, CompressedInternalFormats internalformat, int width, int height, int depth, int border, int imageSize, void* data);
    [OpenGL<CompressedTexImage3D>] internal static CompressedTexImage3D glCompressedTexImage3D;

    internal delegate void CompressedTexSubImage1D (Compressed1DTargets target, int level, int xoffset, int width, CompressedInternalFormats format, int imageSize, void* data);
    [OpenGL<CompressedTexSubImage1D>] internal static CompressedTexSubImage1D glCompressedTexSubImage1D;

    internal delegate void CompressedTexSubImage2D (Compressed2DTargets target, int level, int xoffset, int yoffset, int width, int height, CompressedInternalFormats format, int imageSize, void* data);
    [OpenGL<CompressedTexSubImage2D>] internal static CompressedTexSubImage2D glCompressedTexSubImage2D;

    internal delegate void CompressedTexSubImage3D (Compressed3DTargets target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, CompressedInternalFormats format, int imageSize, void* data);
    [OpenGL<CompressedTexSubImage3D>] internal static CompressedTexSubImage3D glCompressedTexSubImage3D;

    internal delegate void CopyTexImage1D (uint target, int level, InternalFormats internalformat, int x, int y, int width, int border);
    [OpenGL<CopyTexImage1D>] internal static CopyTexImage1D glCopyTexImage1D;

    internal delegate void CopyTexImage2D (CopyTex2DTargets target, int level, InternalFormats internalformat, int x, int y, int width, int height, int border);
    [OpenGL<CopyTexImage2D>] internal static CopyTexImage2D glCopyTexImage2D;

    internal delegate void CopyTexSubImage1D (uint target, int level, int xoffset, int x, int y, int width);
    [OpenGL<CopyTexSubImage1D>] internal static CopyTexSubImage1D glCopyTexSubImage1D;

    internal delegate void CopyTexSubImage2D (CopyTex2DTargets target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
    [OpenGL<CopyTexSubImage2D>] internal static CopyTexSubImage2D glCopyTexSubImage2D;

    internal delegate void CopyTexSubImage3D (CopyTex3DTargets target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
    [OpenGL<CopyTexSubImage3D>] internal static CopyTexSubImage3D glCopyTexSubImage3D;

    internal delegate void DeleteTextures(int n, uint* textures);
    [OpenGL<DeleteTextures>] internal static DeleteTextures glDeleteTextures;

    internal delegate void GenTextures(int n, uint* textures);
    [OpenGL<GenTextures>] internal static GenTextures glGenTextures;

    internal delegate void GetCompressedTexImage(GetCompressedTexTargets target, int lod, void* img);
    [OpenGL<GetCompressedTexImage>] internal static GetCompressedTexImage glGetCompressedTexImage;

    internal delegate void GetTexImage(TextureParameterTargets target, int level, PixelFormats format, PixelTypes type, void* img);
    [OpenGL<GetTexImage>] internal static GetTexImage glGetTexImage;

    internal delegate void GetTexLevelParameterfv(TextureTargets target, int level, GetTexLevelParameterNames pname, float* @params);
    [OpenGL<GetTexLevelParameterfv>] internal static GetTexLevelParameterfv glGetTexLevelParameterfv;

    internal delegate void GetTexLevelParameteriv(TextureTargets target, int level, GetTexLevelParameterNames pname, int* @params);
    [OpenGL<GetTexLevelParameteriv>] internal static GetTexLevelParameteriv glGetTexLevelParameteriv;

    internal delegate void GetTexParameterfv(TextureParameterTargets target, TextureParameters pname, float* @params);
    [OpenGL<GetTexParameterfv>] internal static GetTexParameterfv glGetTexParameterfv;
    internal delegate void GetTexParameteriv(TextureParameterTargets target, TextureParameters pname, int* @params);
    [OpenGL<GetTexParameteriv>] internal static GetTexParameteriv glGetTexParameteriv;
    internal delegate void GetTexParameterIiv(TextureParameterTargets target, TextureParameters pname, int* @params);
    [OpenGL<GetTexParameterIiv>] internal static GetTexParameterIiv glGetTexParameterIiv;
    internal delegate void GetTexParameterIuiv(TextureParameterTargets target, TextureParameters pname, uint* @params);
    [OpenGL<GetTexParameterIuiv>] internal static GetTexParameterIuiv glGetTexParameterIuiv;

    internal delegate byte IsTexture(uint texture);
    [OpenGL<IsTexture>] internal static IsTexture glIsTexture;
    internal delegate void TexBuffer(uint target, SizedInternalFormats internalformat, uint buffer);
    [OpenGL<TexBuffer>] internal static TexBuffer glTexBuffer;
    internal delegate void TexImage1D(Texture1DTargets target, int level, Internal1DFormats internalformat, int width, int border, TexturePixelFormats format, PixelTypes type, void* data);
    [OpenGL<TexImage1D>] internal static TexImage1D glTexImage1D;
    internal delegate void TexImage2D(Texture2DTargets target, int level, SizedInternalFormats internalformat, int width, int height, int border, TexturePixelFormats format, PixelTypes type, void* data);
    [OpenGL<TexImage2D>] internal static TexImage2D glTexImage2D;
    internal delegate void TexImage2DMultisample(Texture2DMultisampleTargets target, int samples, SizedInternalFormats internalformat, int width, int height, byte fixedsamplelocations);
    [OpenGL<TexImage2DMultisample>] internal static TexImage2DMultisample glTexImage2DMultisample;
    internal delegate void TexImage3D(Texture3DTargets target, int level, SizedInternalFormats internalFormat, int width, int height, int depth, int border, TexturePixelFormats format, PixelTypes type, void* data);
    [OpenGL<TexImage3D>] internal static TexImage3D glTexImage3D;
    internal delegate void TexImage3DMultisample(Texture3DMultisampleTargets target, int samples, SizedInternalFormats internalformat, int width, int height, int depth, byte fixedsamplelocations);
    [OpenGL<TexImage3DMultisample>] internal static TexImage3DMultisample glTexImage3DMultisample;
    internal delegate void TexParameterf(TextureParameterTargets target, TextureParameters pname, float param);
    [OpenGL<TexParameterf>] internal static TexParameterf glTexParameterf;
    internal delegate void TexParameteri(TextureParameterTargets target, TextureParameters pname, int param);
    [OpenGL<TexParameteri>] internal static TexParameteri glTexParameteri;
    internal delegate void TexSubImage1D(Texture1DTargets target, int level, int xoffset, int width, TexturePixelFormats format, PixelTypes type, void* data);
    [OpenGL<TexSubImage1D>] internal static TexSubImage1D glTexSubImage1D;
    internal delegate void TexSubImage2D(Texture2DTargets target, int level, int xoffset, int yoffset, int width, int height, TexturePixelFormats format, PixelTypes type, void* data);
    [OpenGL<TexSubImage2D>] internal static TexSubImage2D glTexSubImage2D;
    internal delegate void TexSubImage3D(Texture3DTargets target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, TexturePixelFormats format, PixelTypes type, void* data);
    [OpenGL<TexSubImage3D>] internal static TexSubImage3D glTexSubImage3D;
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value null