namespace Black.OpenGL;

using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Black.Unmanaged;
using static Black.OpenGL.Native;

public static unsafe partial class GL
{
    public static void AttachShader (uint program, uint shader)
    {
        glAttachShader(program, shader);
    }

    public static void CompileShader(uint shader)
    {
        glCompileShader(shader);
    }

    public static uint CreateProgram()
    {
        return glCreateProgram();
    }

    public static uint CreateShader(ShaderType shaderType)
    {
        return glCreateShader(shaderType);
    }

    public static void DeleteProgram(uint program)
    {
        glDeleteProgram(program);
    }

    public static void DeleteShader(uint shader)
    {
        glDeleteShader(shader);
    }

    public static void DeleteShaders(ReadOnlySpan<uint> shaders)
    {
        foreach(var shader in shaders)
            glDeleteShader(shader);
    }

    public static void DetachShader(uint program, uint shader)
    {
        glDetachShader(program, shader);
    }

    public static void DetachShaders(uint program, ReadOnlySpan<uint> shaders)
    {
        foreach(var shader in shaders)
            glDetachShader(program, shader);
    }

    public static int GetProgram(uint program, ProgramParameterName parameterName)
    {
        int parameter;
        glGetProgramiv(program, parameterName, &parameter);
        return parameter;
    }

    public static bool GetProgramLinkStatus(uint program)
    {
        return GetProgram(program, ProgramParameterName.LinkStatus) == True;
    }

    public static int GetProgramInfoLogLength(uint program)
    {
        return GetProgram(program, ProgramParameterName.InfoLogLength);
    }

    public static int GetShader(uint shader, ShaderParameterName parameterName)
    {
        int parameter;
        glGetShaderiv(shader, parameterName, &parameter);
        return parameter;
    }

    public static bool GetShaderCompileStatus (uint shader)
    {
        return GetShader(shader, ShaderParameterName.CompileStatus) == True;
    }
    
    public static int GetShaderInfoLogLength (uint shader)
    {
        return GetShader(shader, ShaderParameterName.InfoLogLength);
    }

    public static string GetProgramInfoLog(uint program)
    {
        int length = GetProgramInfoLogLength(program);

        using var unmanagedInfoLog = new UnmanagedStr((uint)length);
        glGetProgramInfoLog(program, length, &length, unmanagedInfoLog);

        return unmanagedInfoLog;
    }

    public static string GetShaderInfoLog(uint shader)
    {
        int length = GetShaderInfoLogLength(shader);

        using var unmanagedInfoLog = new UnmanagedStr((uint)length);
        glGetShaderInfoLog(shader, length, &length, unmanagedInfoLog);

        return unmanagedInfoLog;
    }

    public static int GetAttribLocation (uint program, string name)
    {
        using var unmanagedName = new UnmanagedStr(name);
        return glGetAttribLocation(program, unmanagedName);
    }

    public static int GetUniformLocation(uint program, string name)
    {
        using var unmanagedName = new UnmanagedStr(name);
        return glGetUniformLocation(program, unmanagedName);
    }

    public static bool IsProgram(uint program)
    {
        return glIsProgram(program).FromGLBoolean();
    }

    public static bool IsShader(uint shader)
    {
        return glIsShader(shader).FromGLBoolean();
    }


    public static void LinkProgram(uint program)
    {
        glLinkProgram(program);
    }

    public static void ShaderSource(uint shader, string source)
    {
        using var unmanagedSource = new UnmanagedStr(source);
        int unmanagedLength = (int)unmanagedSource.Length;

        glShaderSource(shader, 1, &unmanagedSource, &unmanagedLength);
    }

    public static void ShaderSource(uint shader, ReadOnlySpan<string> sources)
    {
        UnmanagedStr* unmanagedSources = stackalloc UnmanagedStr[sources.Length];
        int* unmanagedLengths = stackalloc int[sources.Length];

        for (int i = 0; i < sources.Length; i++)
        {
            unmanagedSources[i] = new UnmanagedStr(sources[i]);
            unmanagedLengths[i] = (int)unmanagedSources[i].Length;
        }

        glShaderSource(shader, sources.Length, unmanagedSources, unmanagedLengths);
    }

    public static void UseProgram (uint program)
    {
        glUseProgram(program);
    }

    public static void Uniform (int location, float v0)
    {
        glUniform1f(location, v0);
    }

    public static void Uniform (int location, float v0, float v1)
    {
        glUniform2f(location, v0, v1);
    }

    public static void Uniform (int location, float v0, float v1, float v2)
    {
        glUniform3f(location, v0, v1, v2);
    }

    public static void Uniform (int location, float v0, float v1, float v2, float v3)
    {
        glUniform4f(location, v0, v1, v2, v3);
    }

    public static void Uniform (int location, int v0)
    {
        glUniform1i(location, v0);
    }

    public static void Uniform (int location, int v0, int v1)
    {
        glUniform2i(location, v0, v1);
    }

    public static void Uniform (int location, int v0, int v1, int v2)
    {
        glUniform3i(location, v0, v1, v2);
    }

    public static void Uniform (int location, int v0, int v1, int v2, int v3)
    {
        glUniform4i(location, v0, v1, v2, v3);
    }


    public static void UniformMatrix (int location, bool transpose, Matrix4x4 matrix)
    {
        glUniformMatrix4fv(location, 1, transpose.ToGLBoolean(), &matrix.M11);
    }

}