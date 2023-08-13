#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value null

namespace Draft.OpenGL;

internal unsafe partial class Native
{
    internal delegate void BindBuffer(BufferTarget target, uint buffer);
    [OpenGL<BindBuffer>] internal static BindBuffer glBindBuffer;
    
    internal delegate void BindBufferBase(BufferTarget target, uint index, uint buffer);
    [OpenGL<BindBufferBase>] internal static BindBufferBase glBindBufferBase;
    
    internal delegate void BindBufferRange(BufferTarget target, uint index, uint buffer, int offset, int size);
    [OpenGL<BindBufferRange>] internal static BindBufferRange glBindBufferRange;
    
    internal delegate void BufferData(BufferTarget target, int size, void* data, BufferUsageHint usage);
    [OpenGL<BufferData>] internal static BufferData glBufferData;
    
    internal delegate void BufferSubData(BufferTarget target, int offset, int size, void* data);
    [OpenGL<BufferSubData>] internal static BufferSubData glBufferSubData;
    
    internal delegate void CopyBufferSubData(BufferTarget readTarget, BufferTarget writeTarget, int readOffset, int writeOffset, int size);
    [OpenGL<CopyBufferSubData>] internal static CopyBufferSubData glCopyBufferSubData;

    internal delegate void DeleteBuffers(int n, uint* buffers);
    [OpenGL<DeleteBuffers>] internal static DeleteBuffers glDeleteBuffers;
    
    internal delegate void DisableVertexAttribArray(uint index);
    [OpenGL<DisableVertexAttribArray>] internal static DisableVertexAttribArray glDisableVertexAttribArray;
    
    internal delegate void DrawArrays(DrawMode mode, int first, int count);
    [OpenGL<DrawArrays>] internal static DrawArrays glDrawArrays;
    
    internal delegate void EnableVertexAttribArray(uint index);
    [OpenGL<EnableVertexAttribArray>] internal static EnableVertexAttribArray glEnableVertexAttribArray;
    
    internal delegate void GenBuffers(int n, uint* buffers);
    [OpenGL<GenBuffers>] internal static GenBuffers glGenBuffers;
    
    internal delegate void VertexAttribPointer(uint index, int size, AttributeType type, byte normalized, int stride, void* pointer);
    [OpenGL<VertexAttribPointer>] internal static VertexAttribPointer glVertexAttribPointer;

    internal delegate void VertexAttribIPointer(uint index, int size, AttributeTypeI type, int stride, void* pointer);
    [OpenGL<VertexAttribIPointer>] internal static VertexAttribIPointer glVertexAttribIPointer;
}

#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value null
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.