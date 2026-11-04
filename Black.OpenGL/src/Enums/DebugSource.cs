namespace Black.OpenGL;

public enum DebugSource : uint
{
    Api = Constants.glDebugSourceApi,
    WindowSystem = Constants.glDebugSourceWindowSystem,
    ShaderCompiler = Constants.glDebugSourceShaderCompiler,
    ThirdParty = Constants.glDebugSourceThirdParty,
    Application = Constants.glDebugSourceApplication,
    Other = Constants.glDebugSourceOther,
}
