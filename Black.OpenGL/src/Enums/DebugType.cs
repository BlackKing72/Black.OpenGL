namespace Black.OpenGL;

public enum DebugType : uint
{
    Error = Constants.glDebugTypeError,
    DeprecatedBehavior = Constants.glDebugTypeDeprecatedBehavior,
    UndefinedBehavior = Constants.glDebugTypeUndefinedBehavior,
    Portability = Constants.glDebugTypePortability,
    Performance = Constants.glDebugTypePerformance,
    Other = Constants.glDebugTypeOther,
    Marker = Constants.glDebugTypeMarker,
    PushGroup = Constants.glDebugTypePushGroup,
    PopGroup = Constants.glDebugTypePopGroup,
}
