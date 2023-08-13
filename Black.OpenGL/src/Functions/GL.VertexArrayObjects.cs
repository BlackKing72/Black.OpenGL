namespace Draft.OpenGL;

using Black.Unmanaged;
using static Draft.OpenGL.Native;

public static unsafe partial class GL
{
    public static void BindVertexArray(uint vertexArray)
    {
        glBindVertexArray(vertexArray);
    }

    public static void DeleteVertexArray(uint vertexArray)
    {
        glDeleteVertexArrays(1, &vertexArray);
    }

    public static void DeleteVertexArrays(ReadOnlySpan<uint> vertexArrays)
    {
        glDeleteVertexArrays(vertexArrays.Length, vertexArrays.AsPointer());
    }

    public static uint GenVertexArray()
    {
        uint vertexArray;
        glGenVertexArrays(1, &vertexArray);
        return vertexArray;
    }

    public static uint[] GenVertexArrays(int count)
    {
        uint[] vertexArrays = new uint[count];
        glGenVertexArrays(count, vertexArrays.AsPointer());
        return vertexArrays;
    }

    public static bool IsVertexArray(uint vertexArray)
    {
        return glIsVertexArray(vertexArray) == True;
    }
}