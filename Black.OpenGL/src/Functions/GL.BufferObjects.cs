namespace Black.OpenGL;

using System.Runtime.CompilerServices;
using Black.Unmanaged;
using static Black.OpenGL.Native;

public static unsafe partial class GL
{
    public static void BindBuffer(BufferTargets target, uint buffer)
    {
        glBindBuffer(target, buffer);
    }

    public static void BindBufferBase(BufferTargets target, uint index, uint buffer)
    {
        if (target is not BufferTargets.TransformFeedback or BufferTargets.Uniform)
            throw new ArgumentOutOfRangeException(nameof(target), $"Target must be either Transform Feedback or a Uniform buffer");

        glBindBufferBase(target, index, buffer);
    }

    public static void BindBufferRange(BufferTargets target, uint index, uint buffer, int offset, int size)
    {
        if (target is not BufferTargets.TransformFeedback or BufferTargets.Uniform)
            throw new ArgumentOutOfRangeException(nameof(target), $"Target must be either Transform Feedback or a Uniform buffer");

        glBindBufferRange(target, index, buffer, offset, size);
    }

    public static void BufferData(BufferTargets target, int size, nint data, BufferUsageHints usage)
    {
        glBufferData(target, size, data.ToPointer(), usage);
    }

    public static void BufferData<T>(BufferTargets target, T data, BufferUsageHints usage) where T : unmanaged
    {
        using var unmanagedData = new UnmanagedData<T>(data);
        glBufferData(target, (int)unmanagedData.SizeInBytes, unmanagedData, usage);
    }

    public static void BufferData<T>(BufferTargets target, ReadOnlySpan<T> data, BufferUsageHints usage) where T : unmanaged
    {
        int size = sizeof(T) * data.Length;
        glBufferData(target, size, data.AsPointer(), usage);
    }

    public static void BufferSubData<T>(BufferTargets target, int offset, T data) where T : unmanaged
    {
        using var unmanagedData = new UnmanagedData<T>(data);
        glBufferSubData(target, offset, (int)unmanagedData.SizeInBytes, unmanagedData);
    }

    public static void BufferSubData<T>(BufferTargets target, int offset, ReadOnlySpan<T> data) where T : unmanaged
    {
        int size = sizeof(T) * data.Length;
        glBufferSubData(target, offset, size, data.AsPointer());
    }

    public static void CopyBufferSubData(BufferTargets readTarget, BufferTargets writeTarget, int readOffset, int writeOffset, int size)
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

    public static void DrawArrays(DrawModes mode, int first, int count)
    {
        glDrawArrays(mode, first, count);
    }

    public static void DrawElements(DrawModes mode, int count, ElementTypes type)
    {
        glDrawElements(mode, count, type, NullPtr);
    }
    
    public static void DrawElementsBaseVertex (DrawModes mode, int count, ElementTypes type, void *indices, int basevertex)
    {
        glDrawElementsBaseVertex(mode, count, type, indices, basevertex);
    }

    public static void DrawElementsBaseVertex (DrawModes mode, int count, ElementTypes type, nint indices, int basevertex)
    {
        glDrawElementsBaseVertex(mode, count, type, indices.ToPointer(), basevertex);
    }

    public static void DrawElementsBaseVertex<T> (DrawModes mode, int count, ElementTypes type, ReadOnlySpan<T> indices, int basevertex) where T : unmanaged
    {
        glDrawElementsBaseVertex(mode, count, type, (void*)indices.AsPointer(), basevertex);
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

    public static double GetVertexAttribdv(uint index, GetAtribParameters pname)
    {
        double value = 0.0;
        glGetVertexAttribdv(index, pname, &value);
        return value;
    }

    public static void GetVertexAttribdv(uint index, GetAtribParameters pname, double* values)
    {
        glGetVertexAttribdv(index, pname, values);
    }

    public static float GetVertexAttribfv(uint index, GetAtribParameters pname)
    {
        float value = 0.0f;
        glGetVertexAttribfv(index, pname, &value);
        return value;
    }

    public static void GetVertexAttribfv(uint index, GetAtribParameters pname, float* values)
    {
        glGetVertexAttribfv(index, pname, values);
    }

    public static int GetVertexAttribiv(uint index, GetAtribParameters pname)
    {
        int value = 0;
        glGetVertexAttribiv(index, pname, &value);
        return value;        
    }

    public static void GetVertexAttribiv(uint index, GetAtribParameters pname, int* values)
    {
        glGetVertexAttribiv(index, pname, values);
    }

    public static int GetVertexAttribIiv(uint index, GetAtribParameters pname)
    {
        int value = 0;
        glGetVertexAttribIiv(index, pname, &value);
        return value;   
    }

    public static void GetVertexAttribIiv(uint index, GetAtribParameters pname, int* values)
    {
        glGetVertexAttribIiv(index, pname, values);
    }

    public static uint GetVertexAttribIuiv(uint index, GetAtribParameters pname)
    {
        uint value = 0;
        glGetVertexAttribIuiv(index, pname, &value);
        return value;   
    }

    public static void GetVertexAttribIuiv(uint index, GetAtribParameters pname, uint* values)
    {
        glGetVertexAttribIuiv(index, pname, values);
    }

    public static void GetVertexAttribPointerv(uint index, ref nint pointer)
    {
        const uint VertexAttribArrayPointer = 0x8645;
        glGetVertexAttribPointerv(index, VertexAttribArrayPointer, (void**)Unsafe.AsPointer(ref pointer));
    }

    public static nint GetVertexAttribPointerv(uint index)
    {
        const uint VertexAttribArrayPointer = 0x8645;
        nint pointer = new nint(0);
        glGetVertexAttribPointerv(index, VertexAttribArrayPointer, (void**)&pointer);
        return pointer;
    }

    public static void GetVertexAttribPointerv(uint index, void** pointer)
    {
        const uint VertexAttribArrayPointer = 0x8645;
        glGetVertexAttribPointerv(index, VertexAttribArrayPointer, pointer);
    }

    public static void VertexAttribPointer(uint index, int size, AttributeTypes type, bool normalized, int stride, int offset)
    {
        if (size is < 1 or > 4)
            throw new ArgumentOutOfRangeException(nameof(size), "Size must be 1, 2, 3 or 4");

        glVertexAttribPointer(index, size, type, normalized ? True : False, stride, (void*)offset);
    }

    public static void VertexAttribIPointer(uint index, int size, AttributeTypesI type, int stride, int offset)
    {
        if (size is < 1 or > 4)
            throw new ArgumentOutOfRangeException(nameof(size), "Size must be 1, 2, 3 or 4");
            
        glVertexAttribIPointer(index, size, type, stride, (void*)offset);
    }
}