namespace Black.OpenGL;

using System.Drawing;
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
}