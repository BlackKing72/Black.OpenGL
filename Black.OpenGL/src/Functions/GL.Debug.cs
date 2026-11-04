namespace Black.OpenGL;

using System.Runtime.CompilerServices;
using Black.Unmanaged;
using static Black.OpenGL.Native;

public static unsafe partial class GL
{
    public static void DebugMessageCallback(DebugProc callback)
    {
        glDebugMessageCallback(callback, NullPtr);
    }

    public static void DebugMessageCallback<T>(DebugProc callback, ref T userParam)
        where T : unmanaged
    {
        var pointer = Unsafe.AsPointer(ref userParam);
        glDebugMessageCallback(callback, pointer);
    }

    public static void DebugMessageControl(
        DebugSource source = (DebugSource)Constants.glDontCare,
        DebugType type = (DebugType)Constants.glDontCare,
        DebugSeverity severity = (DebugSeverity)Constants.glDontCare,
        uint[]? ids = null,
        bool enabled = false
    )
    {
        uint[] debugIds = ids ?? [];
        glDebugMessageControl(
            source,
            type,
            severity,
            (uint)debugIds.Length,
            debugIds.UnsafeAsPointer(),
            enabled.ToGLBoolean()
        );
    }
}
