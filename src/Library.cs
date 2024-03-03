using System.Runtime.InteropServices;
using System.Reflection;

namespace Black.OpenGL;

internal class Library
{
    internal const string Name = "opengl";

    internal static void Initialize()
    {
        NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), LibraryImporterResolver);
    }

    private static IntPtr LibraryImporterResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        if (libraryName == Name)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return NativeLibrary.Load("opengl32.dll", assembly, searchPath);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return NativeLibrary.Load("libGL.so.1", assembly, searchPath);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return NativeLibrary.Load("libglfw.3", assembly, searchPath);
        }

        return 0;
    }
}