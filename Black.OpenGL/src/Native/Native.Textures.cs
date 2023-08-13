#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value null

namespace Draft.OpenGL;

internal unsafe partial class Native
{
    internal delegate void ActiveTexture (uint texture);
    [OpenGL<ActiveTexture>] internal static ActiveTexture glActiveTexture;

    internal delegate void BindTexture(TexTarget target, uint texture);
    [OpenGL<BindTexture>] internal static BindTexture glBindTexture;

    internal delegate void CompressedTexImage1D (Compressed1DTarget target, int level, CompressedInternalFormat internalformat, int width, int border, int imageSize, void* data);
    [OpenGL<CompressedTexImage1D>] internal static CompressedTexImage1D glCompressedTexImage1D;

    internal delegate void CompressedTexImage2D (Compressed2DTarget target, int level, CompressedInternalFormat internalformat, int width, int height, int border, int imageSize, void* data);
    [OpenGL<CompressedTexImage2D>] internal static CompressedTexImage2D glCompressedTexImage2D;

    internal delegate void CompressedTexImage3D (Compressed3DTarget target, int level, CompressedInternalFormat internalformat, int width, int height, int depth, int border, int imageSize, void* data);
    [OpenGL<CompressedTexImage3D>] internal static CompressedTexImage3D glCompressedTexImage3D;

    internal delegate void CompressedTexSubImage1D (Compressed1DTarget target, int level, int xoffset, int width, CompressedInternalFormat format, int imageSize, void* data);
    [OpenGL<CompressedTexSubImage1D>] internal static CompressedTexSubImage1D glCompressedTexSubImage1D;

    internal delegate void CompressedTexSubImage2D (Compressed2DTarget target, int level, int xoffset, int yoffset, int width, int height, CompressedInternalFormat format, int imageSize, void* data);
    [OpenGL<CompressedTexSubImage2D>] internal static CompressedTexSubImage2D glCompressedTexSubImage2D;

    internal delegate void CompressedTexSubImage3D (Compressed3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, CompressedInternalFormat format, int imageSize, void* data);
    [OpenGL<CompressedTexSubImage3D>] internal static CompressedTexSubImage3D glCompressedTexSubImage3D;
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value null