#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value null
using Black.Unmanaged;

namespace Black.OpenGL;

internal unsafe partial class Native
{
    internal delegate void AttachShader(uint program, uint shader);
    [OpenGL<AttachShader>] internal static AttachShader glAttachShader;
    
    internal delegate void CompileShader(uint shader);
    [OpenGL<CompileShader>] internal static CompileShader glCompileShader;
    
    internal delegate uint CreateProgram();
    [OpenGL<CreateProgram>] internal static CreateProgram glCreateProgram;

    internal delegate uint CreateShader(ShaderType shaderType);
    [OpenGL<CreateShader>] internal static CreateShader glCreateShader;
    
    internal delegate void DeleteProgram(uint program);
    [OpenGL<DeleteProgram>] internal static DeleteProgram glDeleteProgram;
    
    internal delegate void DeleteShader(uint shader);
    [OpenGL<DeleteShader>] internal static DeleteShader glDeleteShader;
    
    internal delegate void GetProgramiv(uint program, ProgramParameterName pname, int* @params);
    [OpenGL<GetProgramiv>] internal static GetProgramiv glGetProgramiv;
    
    internal delegate void GetShaderiv(uint shader, ShaderParameterName pname, int* @params);
    [OpenGL<GetShaderiv>] internal static GetShaderiv glGetShaderiv;
    
    internal delegate void GetProgramInfoLog(uint program, int maxLength, int* length, UnmanagedStr infoLog);
    [OpenGL<GetProgramInfoLog>] internal static GetProgramInfoLog glGetProgramInfoLog;
    
    internal delegate void GetShaderInfoLog(uint shader, int maxLength, int* length, UnmanagedStr infoLog);
    [OpenGL<GetShaderInfoLog>] internal static GetShaderInfoLog glGetShaderInfoLog;
    
    internal delegate void LinkProgram(uint program);
    [OpenGL<LinkProgram>] internal static LinkProgram glLinkProgram;
    
    internal delegate void ShaderSource(uint shader, int count, UnmanagedStr* @string, int* length);
    [OpenGL<ShaderSource>] internal static ShaderSource glShaderSource;
    
    internal delegate void UseProgram(uint program);
    [OpenGL<UseProgram>] internal static UseProgram glUseProgram;
}

#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value null
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.