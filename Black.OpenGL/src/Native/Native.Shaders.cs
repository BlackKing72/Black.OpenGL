#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value null
using Black.Unmanaged;

namespace Black.OpenGL;

internal unsafe partial class Native
{
    internal delegate void AttachShader(uint program, uint shader);
    [OpenGL<AttachShader>] internal static AttachShader glAttachShader;

    internal delegate void BindAttribLocation(uint program, uint index, byte* name);
    [OpenGL<BindAttribLocation>] internal static BindAttribLocation glBindAttribLocation;

    internal delegate void CompileShader(uint shader);
    [OpenGL<CompileShader>] internal static CompileShader glCompileShader;

    internal delegate uint CreateProgram();
    [OpenGL<CreateProgram>] internal static CreateProgram glCreateProgram;

    internal delegate uint CreateShader(ShaderTypes shaderType);
    [OpenGL<CreateShader>] internal static CreateShader glCreateShader;

    internal delegate void DeleteProgram(uint program);
    [OpenGL<DeleteProgram>] internal static DeleteProgram glDeleteProgram;

    internal delegate void DeleteShader(uint shader);
    [OpenGL<DeleteShader>] internal static DeleteShader glDeleteShader;

    internal delegate void DetachShader(uint program, uint shader);
    [OpenGL<DetachShader>] internal static DetachShader glDetachShader;

    internal delegate void GetProgramiv(uint program, ProgramParameterNames pname, int* @params);
    [OpenGL<GetProgramiv>] internal static GetProgramiv glGetProgramiv;

    internal delegate void GetShaderiv(uint shader, ShaderParameterNames pname, int* @params);
    [OpenGL<GetShaderiv>] internal static GetShaderiv glGetShaderiv;

    internal delegate void GetProgramInfoLog(uint program, int maxLength, int* length, UnmanagedStr infoLog);
    [OpenGL<GetProgramInfoLog>] internal static GetProgramInfoLog glGetProgramInfoLog;

    internal delegate void GetShaderInfoLog(uint shader, int maxLength, int* length, UnmanagedStr infoLog);
    [OpenGL<GetShaderInfoLog>] internal static GetShaderInfoLog glGetShaderInfoLog;

    internal delegate int GetAttribLocation(uint program, UnmanagedStr name);
    [OpenGL<GetAttribLocation>] internal static GetAttribLocation glGetAttribLocation;

    internal delegate uint GetUniformBlockIndex(uint program, byte* name);
    [OpenGL<GetUniformBlockIndex>] internal static GetUniformBlockIndex glGetUniformBlockIndex;

    internal delegate int GetUniformLocation(uint program, UnmanagedStr name);
    [OpenGL<GetUniformLocation>] internal static GetUniformLocation glGetUniformLocation;

    internal delegate byte IsProgram(uint program);
    [OpenGL<IsProgram>] internal static IsProgram glIsProgram;

    internal delegate byte IsShader(uint shader);
    [OpenGL<IsShader>] internal static IsShader glIsShader;

    internal delegate void LinkProgram(uint program);
    [OpenGL<LinkProgram>] internal static LinkProgram glLinkProgram;

    internal delegate void ShaderSource(uint shader, int count, UnmanagedStr* @string, int* length);
    [OpenGL<ShaderSource>] internal static ShaderSource glShaderSource;

    internal delegate void UseProgram(uint program);
    [OpenGL<UseProgram>] internal static UseProgram glUseProgram;

    internal delegate void Uniform1f(int location, float v0);
    [OpenGL<Uniform1f>] internal static Uniform1f glUniform1f;

    internal delegate void Uniform2f(int location, float v0, float v1);
    [OpenGL<Uniform2f>] internal static Uniform2f glUniform2f;

    internal delegate void Uniform3f(int location, float v0, float v1, float v2);
    [OpenGL<Uniform3f>] internal static Uniform3f glUniform3f;

    internal delegate void Uniform4f(int location, float v0, float v1, float v2, float v3);
    [OpenGL<Uniform4f>] internal static Uniform4f glUniform4f;

    internal delegate void Uniform1i(int location, int v0);
    [OpenGL<Uniform1i>] internal static Uniform1i glUniform1i;

    internal delegate void Uniform2i(int location, int v0, int v1);
    [OpenGL<Uniform2i>] internal static Uniform2i glUniform2i;

    internal delegate void Uniform3i(int location, int v0, int v1, int v2);
    [OpenGL<Uniform3i>] internal static Uniform3i glUniform3i;

    internal delegate void Uniform4i(int location, int v0, int v1, int v2, int v3);
    [OpenGL<Uniform4i>] internal static Uniform4i glUniform4i;

    internal delegate void UniformMatrix4fv(int location, nint count, byte transpose, float* value);
    [OpenGL<UniformMatrix4fv>] internal static UniformMatrix4fv glUniformMatrix4fv;

    internal delegate void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
    [OpenGL<UniformBlockBinding>] internal static UniformBlockBinding glUniformBlockBinding;
}

#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value null
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.