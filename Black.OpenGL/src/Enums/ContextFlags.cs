namespace Black.OpenGL;

[Flags]
public enum ContextFlags : uint
{
    ForwardCompatible = Constants.glContextFlagForwardCompatibleBit,
    Debug = Constants.glContextFlagDebugBit,
    RobustAccess = Constants.glContextFlagRobustAccessBit,
    NoError = Constants.glContextFlagNoErrorBit,
}
