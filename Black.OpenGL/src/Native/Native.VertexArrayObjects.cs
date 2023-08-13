#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value null

namespace Draft.OpenGL;

internal unsafe partial class Native
{
    internal delegate void BindVertexArray(uint array);
    [OpenGL<BindVertexArray>] internal static BindVertexArray glBindVertexArray;
    
    internal delegate void DeleteVertexArrays(int n, uint* arrays);
    [OpenGL<DeleteVertexArrays>] internal static DeleteVertexArrays glDeleteVertexArrays;
    
    internal delegate void GenVertexArrays(int n, uint* arrays);
    [OpenGL<GenVertexArrays>] internal static GenVertexArrays glGenVertexArrays;
    
    internal delegate int IsVertexArray(uint array);
    [OpenGL<IsVertexArray>] internal static IsVertexArray glIsVertexArray;
}

#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value null
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.