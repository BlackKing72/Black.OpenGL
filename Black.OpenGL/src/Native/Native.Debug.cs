#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value null

namespace Black.OpenGL;

// csharpier-ignore-start
internal unsafe partial class Native
{
    internal delegate void DebugMessageCallback(DebugProc callback, void* userParam);
    [OpenGL<DebugMessageCallback>] internal static DebugMessageCallback glDebugMessageCallback;

    internal delegate void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, uint count, uint*ids, byte enabled);
    [OpenGL<DebugMessageControl>] internal static DebugMessageControl glDebugMessageControl;
}
// csharpier-ignore-end

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value null
