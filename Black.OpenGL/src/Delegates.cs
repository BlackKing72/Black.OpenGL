using System.Runtime.InteropServices;

namespace Black.OpenGL;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void DebugProc(
    DebugSource source,
    DebugType type,
    DebugSeverity severity,
    uint length,
    [MarshalAs(UnmanagedType.LPUTF8Str)] string message,
    nint userParam
);
