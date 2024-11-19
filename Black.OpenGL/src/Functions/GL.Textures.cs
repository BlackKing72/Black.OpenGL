namespace Black.OpenGL;

using Black.Unmanaged;

using static Black.OpenGL.Native;

public static unsafe partial class GL
{
    public static void ActiveTexture(uint texture)
    {
        const uint Texture0 = 0x84C0;
        glActiveTexture(Texture0 + texture);
    }

    public static void BindTexture(TextureTargets target, uint texture)
    {
        glBindTexture(target, texture);
    }

    public static void CompressedTexImage1D(Compressed1DTargets target, int level, CompressedInternalFormats internalformat, int width, int imageSize, void* dataPtr)
    {
        glCompressedTexImage1D(target, level, internalformat, width, 0, imageSize, dataPtr);
    }

    public static void CompressedTexImage1D(Compressed1DTargets target, int level, CompressedInternalFormats internalformat, int width, ReadOnlySpan<byte> data)
    {
        CompressedTexImage1D(target, level, internalformat, width, data.Length, data.AsPointer());
    }

    public static void CompressedTexImage2D(Compressed2DTargets target, int level, CompressedInternalFormats internalformat, int width, int height, int imageSize, void* data)
    {
        glCompressedTexImage2D(target, level, internalformat, width, height, 0, imageSize, data);
    }

    public static void CompressedTexImage2D(Compressed2DTargets target, int level, CompressedInternalFormats internalformat, int width, int height, ReadOnlySpan<byte> data)
    {
        CompressedTexImage2D(target, level, internalformat, width, height, data.Length, data.AsPointer());
    }

    public static void CompressedTexImage3D(Compressed3DTargets target, int level, CompressedInternalFormats internalformat, int width, int height, int depth, int imageSize, void* data)
    {
        glCompressedTexImage3D(target, level, internalformat, width, height, depth, 0, imageSize, data);
    }

    public static void CompressedTexImage3D(Compressed3DTargets target, int level, CompressedInternalFormats internalformat, int width, int height, int depth, ReadOnlySpan<byte> data)
    {
        CompressedTexImage3D(target, level, internalformat, width, height, depth, data.Length, data.AsPointer());
    }

    public static void CompressedTexSubImage1D(Compressed1DTargets target, int level, int xoffset, int width, CompressedInternalFormats format, int imageSize, void* data)
    {
        glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
    }

    public static void CompressedTexSubImage1D(Compressed1DTargets target, int level, int xoffset, int width, CompressedInternalFormats format, ReadOnlySpan<byte> data)
    {
        CompressedTexSubImage1D(target, level, xoffset, width, format, data.Length, data.AsPointer());
    }

    public static void CompressedTexSubImage2D(Compressed2DTargets target, int level, int xoffset, int yoffset, int width, int height, CompressedInternalFormats format, int imageSize, void* data)
    {
        glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
    }

    public static void CompressedTexSubImage2D(Compressed2DTargets target, int level, int xoffset, int yoffset, int width, int height, CompressedInternalFormats format, ReadOnlySpan<byte> data)
    {
        CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, data.Length, data.AsPointer());
    }

    public static void CompressedTexSubImage3D(Compressed3DTargets target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, CompressedInternalFormats format, int imageSize, void* data)
    {
        glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
    }

    public static void CompressedTexSubImage3D(Compressed3DTargets target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, CompressedInternalFormats format, ReadOnlySpan<byte> data)
    {
        CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, data.Length, data.AsPointer());
    }

    public static void CopyTexImage1D(int level, InternalFormats internalformat, int x, int y, int width)
    {
        glCopyTexImage1D((uint)TextureTargets.Texture1D, level, internalformat, x, y, width, 0);
    }

    public static void CopyTexImage2D(CopyTex2DTargets target, int level, InternalFormats internalformat, int x, int y, int width, int height, int border)
    {
        glCopyTexImage2D(target, level, internalformat, x, y, width, height, 0);
    }

    public static void CopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width)
    {
        glCopyTexSubImage1D((uint)TextureTargets.Texture1D, level, xoffset, x, y, width);
    }

    public static void CopyTexSubImage2D(CopyTex2DTargets target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
    {
        glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
    }

    public static void CopyTexSubImage3D(CopyTex3DTargets target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
    {
        glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
    }

    public static void DeleteTexture(uint texture)
    {
        glDeleteTextures(1, &texture);
    }

    public static void DeleteTextures(ReadOnlySpan<uint> textures)
    {
        glDeleteTextures(textures.Length, textures.AsPointer());
    }

    public static uint GenTexture()
    {
        uint texture = 0;
        glGenTextures(1, &texture);
        return texture;
    }

    public static ReadOnlySpan<uint> GenTextures(int count)
    {
        Span<uint> result = new uint[count];
        glGenTextures(count, result.AsPointer());
        return result;
    }

    public static void GetCompressedTexImage(GetCompressedTexTargets target, int lod, void* img)
    {
        glGetCompressedTexImage(target, lod, img);
    }

    public static void GetCompressedTexImage(GetCompressedTexTargets target, int level, Span<byte> data)
    {
        glGetCompressedTexImage(target, level, data.AsPointer());
    }

    public static ReadOnlySpan<byte> GetCompressedTexImage(GetCompressedTexTargets target, int level)
    {
        GetTexLevelParameter(
            (TextureTargets)(uint)target,
            level,
            GetTexLevelParameterNames.TextureCompressedImageSize,
            out int textureSize);

        ReadOnlySpan<byte> compressedTexture = new byte[textureSize];
        glGetCompressedTexImage(target, level, compressedTexture.AsPointer());
        return compressedTexture;
    }

    public static void GetTexImage(TextureParameterTargets target, int level, PixelFormats format, PixelTypes type, void* img)
    {
        glGetTexImage(target, level, format, type, img);
    }

    public static void GetTexImage(TextureParameterTargets target, int level, PixelFormats format, PixelTypes type, Span<byte> img)
    {
        glGetTexImage(target, level, format, type, img.AsPointer());
    }

    public static ReadOnlySpan<byte> GetTexImage(TextureParameterTargets target, int level, PixelFormats format, PixelTypes type)
    {
        GetTexLevelParameter((TextureTargets)(uint)target, level, GetTexLevelParameterNames.TextureWidth, out int width);
        GetTexLevelParameter((TextureTargets)(uint)target, level, GetTexLevelParameterNames.TextureHeight, out int height);
        GetTexLevelParameter((TextureTargets)(uint)target, level, GetTexLevelParameterNames.TextureDepth, out int depth);

        var packAlignment = GetInteger(GetParameterNames.PackAlignment);
        var pixelSize = type switch
        {
            PixelTypes.SByte or PixelTypes.UByte or PixelTypes.UByte_332 or PixelTypes.UByte_233_Rev => 1,

            PixelTypes.Short or PixelTypes.UShort or PixelTypes.Half or
            PixelTypes.UShort_565 or PixelTypes.UShort_565_Rev or
            PixelTypes.UShort_4444 or PixelTypes.UShort_4444_Rev or
            PixelTypes.UShort_5551 or PixelTypes.UShort_1555_Rev => 2,

            PixelTypes.Int or PixelTypes.UInt or PixelTypes.Float or
            PixelTypes.UInt_8888 or PixelTypes.UInt_8888_Rev or
            PixelTypes.Uint_1010102 or PixelTypes.Uint_2101010_Rev or
            PixelTypes.UInt_248 or PixelTypes.UInt_10F11F11F_Rev or
            PixelTypes.Uint_5999_Rev => 4,

            PixelTypes.Float_32_UInt_248_Rev => 8,

            _ => 1
        };
        var formatSize = format switch
        {
            PixelFormats.Rgba or PixelFormats.RgbaInteger or PixelFormats.Bgra or PixelFormats.BgraInteger => 4,
            PixelFormats.Rgb or PixelFormats.RgbInteger or PixelFormats.Bgr or PixelFormats.BgrInteger => 3,
            PixelFormats.Rg or PixelFormats.RgInteger => 2,

            PixelFormats.StencilIndex or PixelFormats.DepthComponent or PixelFormats.DepthStencil or
            PixelFormats.Red or PixelFormats.Green or PixelFormats.Blue or PixelFormats.RedInteger or
            PixelFormats.GreenInteger or PixelFormats.BlueInteger => 1,

            _ => 1,
        };

        var rowSize = width * formatSize * pixelSize;
        var paddedRowSize = (rowSize + (packAlignment - 1)) & ~(packAlignment - 1);

        var textureSize = paddedRowSize * height * depth;
        ReadOnlySpan<byte> texture = new byte[textureSize];

        glGetTexImage(target, level, format, type, texture.AsPointer());
        return texture;
    }

    public static void GetTexLevelParameter(TextureTargets target, int level, GetTexLevelParameterNames parameterName, out float value)
    {
        float unmanagedValue = 0f;
        glGetTexLevelParameterfv(target, level, parameterName, &unmanagedValue);
        value = unmanagedValue;
    }

    public static void GetTexLevelParameter(TextureTargets target, int level, GetTexLevelParameterNames parameterName, out int value)
    {
        int unmanagedValue = 0;
        glGetTexLevelParameteriv(target, level, parameterName, &unmanagedValue);
        value = unmanagedValue;
    }

    public static void GetTexParameter(TextureParameterTargets target, TextureParameters pname, Span<float> values)
    {
        glGetTexParameterfv(target, pname, values.AsPointer());
    }

    public static void GetTexParameter(TextureParameterTargets target, TextureParameters pname, Span<int> values)
    {
        glGetTexParameteriv(target, pname, values.AsPointer());
    }

    public static void GetTexParameterI(TextureParameterTargets target, TextureParameters pname, Span<int> values)
    {
        glGetTexParameterIiv(target, pname, values.AsPointer());
    }

    public static void GetTexParameterI(TextureParameterTargets target, TextureParameters pname, Span<uint> values)
    {
        glGetTexParameterIuiv(target, pname, values.AsPointer());
    }

    public static bool IsTexture(uint texture)
    {
        return glIsTexture(texture).FromGLBoolean();
    }

    public static void TexBuffer(uint target, SizedInternalFormats internalFormat, uint buffer)
    {
        glTexBuffer(target, internalFormat, buffer);
    }

    public static void TexImage1D(Texture1DTargets target, int level, Internal1DFormats internalFormat, int width, int border, TexturePixelFormats format, PixelTypes type, void* data)
    {
        glTexImage1D(target, level, internalFormat, width, border, format, type, data);
    }

    public static void TexImage1D<T>(Texture1DTargets target, int level, Internal1DFormats internalFormat, int width, int border, TexturePixelFormats format, PixelTypes type, ReadOnlySpan<T> data) where T : unmanaged
    {
        glTexImage1D(target, level, internalFormat, width, border, format, type, (void*)data.AsPointer());
    }

    public static void TexImage2D(Texture2DTargets target, int level, SizedInternalFormats internalFormat, int width, int height, int border, TexturePixelFormats format, PixelTypes type, void* data)
    {
        glTexImage2D(target, level, internalFormat, width, height, border, format, type, data);
    }

    public static void TexImage2D(Texture2DTargets target, int level, SizedInternalFormats internalFormat, int width, int height, int border, TexturePixelFormats format, PixelTypes type, nint data)
    {
        glTexImage2D(target, level, internalFormat, width, height, border, format, type, (void*)data);
    }


    public static void TexImage2D<T>(Texture2DTargets target, int level, SizedInternalFormats internalFormat, int width, int height, int border, TexturePixelFormats format, PixelTypes type, ReadOnlySpan<T> data) where T : unmanaged
    {
        glTexImage2D(target, level, internalFormat, width, height, border, format, type, (void*)data.AsPointer());
    }

    public static void TexImage2DMultisample(Texture2DMultisampleTargets target, int samples, SizedInternalFormats internalFormat, int width, int height, bool fixedSampleLocations)
    {
        glTexImage2DMultisample(target, samples, internalFormat, width, height, fixedSampleLocations.ToGLBoolean());
    }

    public static void TexImage3D(Texture3DTargets target, int level, SizedInternalFormats internalFormat, int width, int height, int depth, int border, TexturePixelFormats format, PixelTypes type, void* data)
    {
        glTexImage3D(target, level, internalFormat, width, height, depth, border, format, type, data);
    }

    public static void TexImage3D<T>(Texture3DTargets target, int level, SizedInternalFormats internalFormat, int width, int height, int depth, int border, TexturePixelFormats format, PixelTypes type, ReadOnlySpan<T> data) where T : unmanaged
    {
        glTexImage3D(target, level, internalFormat, width, height, depth, border, format, type, (void*)data.AsPointer());
    }

    public static void TexImage3DMultisample(Texture3DMultisampleTargets target, int samples, SizedInternalFormats internalFormat, int width, int height, int depth, bool fixedSamplelocations)
    {
        glTexImage3DMultisample(target, samples, internalFormat, width, height, depth, fixedSamplelocations.ToGLBoolean());
    }

    public static void TexParameter(TextureParameterTargets target, TextureParameters parameterName, float parameter)
    {
        glTexParameterf(target, parameterName, parameter);
    }

    public static void TexParameter(TextureParameterTargets target, TextureParameters parameterName, int parameter)
    {
        glTexParameteri(target, parameterName, parameter);
    }

    public static void TexParameter(TextureParameterTargets target, TextureParameters parameterName, TextureMinFilters parameter)
    {
        if (parameterName is not TextureParameters.TextureMinFilter)
            throw new ArgumentException("Expected a value for {parameterName}, received a value for Texture Min Filter", nameof(parameter));

        glTexParameteri(target, parameterName, (int)parameter);
    }

    public static void TexParameter(TextureParameterTargets target, TextureParameters parameterName, TextureMagFilters parameter)
    {
        if (parameterName is not TextureParameters.TextureMagFilter)
            throw new ArgumentException("Expected a value for {parameterName}, received a value for Texture Mag Filter", nameof(parameter));
            
        glTexParameteri(target, parameterName, (int)parameter);
    }

    public static void TexParameter(TextureParameterTargets target, TextureParameters parameterName, TextureWrapModes parameter)
    {
        if (parameterName is not TextureParameters.TextureWrapS or TextureParameters.TextureWrapT or TextureParameters.TextureWrapR)
            throw new ArgumentException("Expected a value for {parameterName}, received a value for Texture Wrap", nameof(parameter));
            
        glTexParameteri(target, parameterName, (int)parameter);
    }

    public static void TexMinFilter(TextureParameterTargets target, TextureMinFilters parameter)
    {
        glTexParameteri(target, TextureParameters.TextureMinFilter, (int)parameter);
    }

    public static void TexMagFilter(TextureParameterTargets target, TextureMagFilters parameter)
    {
        glTexParameteri(target, TextureParameters.TextureMagFilter, (int)parameter);
    }

    public static void TexWrapS(TextureParameterTargets target, TextureWrapModes parameter)
    {
        glTexParameteri(target, TextureParameters.TextureWrapS, (int)parameter);
    }

    public static void TexWrapT(TextureParameterTargets target, TextureWrapModes parameter)
    {
        glTexParameteri(target, TextureParameters.TextureWrapT, (int)parameter);
    }

    public static void TexWrapR(TextureParameterTargets target, TextureWrapModes parameter)
    {
        glTexParameteri(target, TextureParameters.TextureWrapR, (int)parameter);
    }

    public static void TexSubImage1D(Texture1DTargets target, int level, int xoffset, int width, TexturePixelFormats format, PixelTypes type, void* data)
    {
        glTexSubImage1D(target, level, xoffset, width, format, type, data);
    }

    public static void TexSubImage1D<T>(Texture1DTargets target, int level, int xoffset, int width, TexturePixelFormats format, PixelTypes type, ReadOnlySpan<T> data) where T : unmanaged
    {
        glTexSubImage1D(target, level, xoffset, width, format, type, (void*)data.AsPointer());
    }

    public static void TexSubImage2D(Texture2DTargets target, int level, int xoffset, int yoffset, int width, int height, TexturePixelFormats format, PixelTypes type, void* data)
    {
        glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, data);
    }

    public static void TexSubImage2D<T>(Texture2DTargets target, int level, int xoffset, int yoffset, int width, int height, TexturePixelFormats format, PixelTypes type, ReadOnlySpan<T> data) where T : unmanaged
    {
        glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, (void*)data.AsPointer());
    }

    public static void TexSubImage3D(Texture3DTargets target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, TexturePixelFormats format, PixelTypes type, void* data)
    {
        glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
    }

    public static void TexSubImage3D<T>(Texture3DTargets target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, TexturePixelFormats format, PixelTypes type, ReadOnlySpan<T> data) where T : unmanaged
    {
        glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, (void*)data.AsPointer());
    }
}

