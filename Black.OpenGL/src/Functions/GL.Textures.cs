namespace Draft.OpenGL;

using Black.Unmanaged;

using static Draft.OpenGL.Native;

public static unsafe partial class GL
{
    public static void ActiveTexture (uint texture)
    {
        glActiveTexture(texture);
    }

    public static void BindTexture (TexTarget target, uint texture)
    {
        glBindTexture(target, texture);
    }

    public static void CompressedTexImage1D (Compressed1DTarget target, int level, CompressedInternalFormat internalformat, int width, int imageSize, void* dataPtr)
    {
        glCompressedTexImage1D(target, level, internalformat, width, 0, imageSize, dataPtr);
    }
    
    public static void CompressedTexImage1D (Compressed1DTarget target, int level, CompressedInternalFormat internalformat, int width, ReadOnlySpan<byte> data)
    {
        CompressedTexImage1D(target, level, internalformat, width, data.Length, data.AsPointer());
    }

    public static void CompressedTexImage2D (Compressed2DTarget target, int level, CompressedInternalFormat internalformat, int width, int height, int imageSize, void* data)
    {
        glCompressedTexImage2D(target, level, internalformat, width, height, 0, imageSize, data);
    }

    public static void CompressedTexImage2D (Compressed2DTarget target, int level, CompressedInternalFormat internalformat, int width, int height, ReadOnlySpan<byte> data)
    {
        CompressedTexImage2D(target, level, internalformat, width, height, data.Length, data.AsPointer());
    }

    public static void CompressedTexImage3D (Compressed3DTarget target, int level, CompressedInternalFormat internalformat, int width, int height, int depth, int imageSize, void* data)
    {
        glCompressedTexImage3D(target, level, internalformat, width, height, depth, 0, imageSize, data);
    }

    public static void CompressedTexImage3D (Compressed3DTarget target, int level, CompressedInternalFormat internalformat, int width, int height, int depth, ReadOnlySpan<byte> data)
    {
        CompressedTexImage3D(target, level, internalformat, width, height, depth, data.Length, data.AsPointer());
    }

    public static void CompressedTexSubImage1D (Compressed1DTarget target, int level, int xoffset, int width, CompressedInternalFormat format, int imageSize, void* data)
    {
        glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
    }

    public static void CompressedTexSubImage1D (Compressed1DTarget target, int level, int xoffset, int width, CompressedInternalFormat format, ReadOnlySpan<byte> data)
    {
        CompressedTexSubImage1D(target, level, xoffset, width, format, data.Length, data.AsPointer());
    }

    public static void CompressedTexSubImage2D (Compressed2DTarget target, int level, int xoffset, int yoffset, int width, int height, CompressedInternalFormat format, int imageSize, void* data)
    {
        glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
    }

    public static void CompressedTexSubImage2D (Compressed2DTarget target, int level, int xoffset, int yoffset, int width, int height, CompressedInternalFormat format, ReadOnlySpan<byte> data)
    {
        CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, data.Length, data.AsPointer());
    }

    public static void CompressedTexSubImage3D (Compressed3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, CompressedInternalFormat format, int imageSize, void* data)
    {
        glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
    }

    public static void CompressedTexSubImage3D (Compressed3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, CompressedInternalFormat format, ReadOnlySpan<byte> data)
    {
        CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, data.Length, data.AsPointer());
    }

}

