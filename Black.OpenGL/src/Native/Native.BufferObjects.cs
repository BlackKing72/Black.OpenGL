#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value null

namespace Black.OpenGL;

internal unsafe partial class Native
{
    internal delegate void BindBuffer(BufferTargets target, uint buffer);
    [OpenGL<BindBuffer>] internal static BindBuffer glBindBuffer;
    
    internal delegate void BindBufferBase(BufferTargets target, uint index, uint buffer);
    [OpenGL<BindBufferBase>] internal static BindBufferBase glBindBufferBase;
    
    internal delegate void BindBufferRange(BufferTargets target, uint index, uint buffer, int offset, int size);
    [OpenGL<BindBufferRange>] internal static BindBufferRange glBindBufferRange;
    
    internal delegate void BufferData(BufferTargets target, int size, void* data, BufferUsageHints usage);
    [OpenGL<BufferData>] internal static BufferData glBufferData;
    
    internal delegate void BufferSubData(BufferTargets target, int offset, int size, void* data);
    [OpenGL<BufferSubData>] internal static BufferSubData glBufferSubData;
    
    internal delegate void CopyBufferSubData(BufferTargets readTarget, BufferTargets writeTarget, int readOffset, int writeOffset, int size);
    [OpenGL<CopyBufferSubData>] internal static CopyBufferSubData glCopyBufferSubData;

    internal delegate void DeleteBuffers(int n, uint* buffers);
    [OpenGL<DeleteBuffers>] internal static DeleteBuffers glDeleteBuffers;
    
    internal delegate void DisableVertexAttribArray(uint index);
    [OpenGL<DisableVertexAttribArray>] internal static DisableVertexAttribArray glDisableVertexAttribArray;
    
    internal delegate void DrawArrays(DrawModes mode, int first, int count);
    [OpenGL<DrawArrays>] internal static DrawArrays glDrawArrays;

    internal delegate void DrawElements(DrawModes mode, int count, ElementTypes type, void* indices);
    [OpenGL<DrawElements>] internal static DrawElements glDrawElements;
    
    internal delegate void DrawElementsBaseVertex (DrawModes mode, int count, ElementTypes type, void *indices, int basevertex);
    [OpenGL<DrawElementsBaseVertex>] internal static DrawElementsBaseVertex glDrawElementsBaseVertex;


    internal delegate void EnableVertexAttribArray(uint index);
    [OpenGL<EnableVertexAttribArray>] internal static EnableVertexAttribArray glEnableVertexAttribArray;
    
    internal delegate void GenBuffers(int n, uint* buffers);
    [OpenGL<GenBuffers>] internal static GenBuffers glGenBuffers;

    internal delegate void GetVertexAttribdv(uint index, GetAtribParameters pname, double* @params);
    [OpenGL<GetVertexAttribdv>] internal static GetVertexAttribdv glGetVertexAttribdv;

    internal delegate void GetVertexAttribfv(uint index, GetAtribParameters pname, float* @params);
    [OpenGL<GetVertexAttribfv>] internal static GetVertexAttribfv glGetVertexAttribfv;

    internal delegate void GetVertexAttribiv(uint index, GetAtribParameters pname, int* @params);
    [OpenGL<GetVertexAttribiv>] internal static GetVertexAttribiv glGetVertexAttribiv;

    internal delegate void GetVertexAttribIiv(uint index, GetAtribParameters pname, int* @params);
    [OpenGL<GetVertexAttribIiv>] internal static GetVertexAttribIiv glGetVertexAttribIiv;

    internal delegate void GetVertexAttribIuiv(uint index, GetAtribParameters pname, uint* @params);
    [OpenGL<GetVertexAttribIuiv>] internal static GetVertexAttribIuiv glGetVertexAttribIuiv;

    internal delegate void GetVertexAttribPointerv(uint index, uint pname, void** pointer);
    [OpenGL<GetVertexAttribPointerv>] internal static GetVertexAttribPointerv glGetVertexAttribPointerv;

    internal delegate void VertexAttribPointer(uint index, int size, AttributeTypes type, byte normalized, int stride, void* pointer);
    [OpenGL<VertexAttribPointer>] internal static VertexAttribPointer glVertexAttribPointer;

    internal delegate void VertexAttribIPointer(uint index, int size, AttributeTypesI type, int stride, void* pointer);
    [OpenGL<VertexAttribIPointer>] internal static VertexAttribIPointer glVertexAttribIPointer;
}

#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value null
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.