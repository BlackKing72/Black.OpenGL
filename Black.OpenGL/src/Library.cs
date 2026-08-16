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
        if (libraryName == Library.Name)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return NativeLibrary.Load("opengl32.dll", assembly, searchPath);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return NativeLibrary.Load("GL", assembly, searchPath);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return NativeLibrary.Load("OpenGL.framework", assembly, searchPath);
        }

        return nint.Zero;
    }
}
