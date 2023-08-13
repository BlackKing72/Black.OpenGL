namespace Draft.OpenGL;

using System.Runtime.InteropServices;
using Black.Unmanaged;

using static Draft.OpenGL.Native;

public static unsafe partial class GL
{
    public static void BindBuffer(BufferTarget target, uint buffer)
    {
        glBindBuffer(target, buffer);
    }

    public static void BindBufferBase(BufferTarget target, uint index, uint buffer)
    {
        if (target is not BufferTarget.TransformFeedback or BufferTarget.Uniform)
            throw new ArgumentOutOfRangeException(nameof(target), $"Target must be either Transform Feedback or a Uniform buffer");

        glBindBufferBase(target, index, buffer);
    }

    public static void BindBufferRange(BufferTarget target, uint index, uint buffer, int offset, int size)
    {
        if (target is not BufferTarget.TransformFeedback or BufferTarget.Uniform)
            throw new ArgumentOutOfRangeException(nameof(target), $"Target must be either Transform Feedback or a Uniform buffer");

        glBindBufferRange(target, index, buffer, offset, size);
    }

    public static void BufferData<T>(BufferTarget target, T data, BufferUsageHint usage) where T : unmanaged
    {
        using var unmanagedData = new UnmanagedData<T>(data);
        glBufferData(target, (int)unmanagedData.SizeInBytes, unmanagedData, usage);
    }

    public static void BufferData<T>(BufferTarget target, ReadOnlySpan<T> data, BufferUsageHint usage) where T : unmanaged
    {
        int size = sizeof(T) * data.Length;
        glBufferData(target, size, data.AsPointer(), usage);
    }

    public static void BufferSubData<T>(BufferTarget target, int offset, T data) where T : unmanaged
    {
        using var unmanagedData = new UnmanagedData<T>(data);
        glBufferSubData(target, offset, (int)unmanagedData.SizeInBytes, unmanagedData);
    }

    public static void BufferSubData<T>(BufferTarget target, int offset, ReadOnlySpan<T> data) where T : unmanaged
    {
        int size = sizeof(T) * data.Length;
        glBufferSubData(target, offset, size, data.AsPointer());
    }

    public static void CopyBufferSubData(BufferTarget readTarget, BufferTarget writeTarget, int readOffset, int writeOffset, int size)
    {
        glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
    }

    public static void DeleteBuffer(uint buffer)
    {
        glDeleteBuffers(1, &buffer);
    }

    public static void DeleteBuffers(ReadOnlySpan<uint> buffers)
    {
        glDeleteBuffers(buffers.Length, buffers.AsPointer());    
    }

    public static void DisableVertexAttribArray(uint index)
    {
        glDisableVertexAttribArray(index);
    }

    public static void DrawArrays(DrawMode mode, int first, int count)
    {
        glDrawArrays(mode, first, count);
    }

    public static void EnableVertexAttribArray(uint index)
    {
        glEnableVertexAttribArray(index);
    }

    public static uint GenBuffer()
    {
        uint buffer;
        glGenBuffers(1, &buffer);
        return buffer;
    }

    public static uint[] GenBuffers(uint count)
    {
        uint[] buffers = new uint[count];
        glGenBuffers(buffers.Length, buffers.AsPointer());
        return buffers;
    }

    public static void VertexAttribPointer(uint index, int size, AttributeType type, bool normalized, int stride, int offset)
    {
        if (size is < 1 or > 4)
            throw new ArgumentOutOfRangeException("Size must be 1, 2, 3 or 4");

        glVertexAttribPointer(index, size, type, normalized ? True : False, stride, (void*)offset);
    }

    public static void VertexAttribIPointer(uint index, int size, AttributeTypeI type, int stride, int offset)
    {
        if (size is < 1 or > 4)
            throw new ArgumentOutOfRangeException("Size must be 1, 2, 3 or 4");
            
        glVertexAttribIPointer(index, size, type, stride, (void*)offset);
    }

}