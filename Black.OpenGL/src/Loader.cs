namespace Black.OpenGL;

using System.Runtime.InteropServices;
using Black.Unmanaged;

public sealed class LoadProcedureException : Exception
{
    public string ProcedureName { get; private set; }

    public LoadProcedureException (string procedureName) 
        : base($"Failed to get procedure adreess for '{procedureName}'.")
    {
        ProcedureName = procedureName;
    }
}

public static class Loader
{
    private static readonly IGetProcAddress loader;

    static Loader()
    {
        loader = GetProcLoader();
    }

    public static T LoadFunction<T>(string name) where T : Delegate
    {
        nint address = loader.GetProcAddress(name);

        if (AddressIsValid(address))
            return Marshal.GetDelegateForFunctionPointer<T>(address);

        throw new LoadProcedureException(name);
    }

    public static bool AddressIsValid(nint address)
    {
        // From: https://www.khronos.org/opengl/wiki/Load_OpenGL_Functions
        // The MSDN documentation says that wglGetProcAddress returns NULL (0) on failure, some 
        // implementations will return other values. 1, 2, and 3 are used, as well as -1.

        return address is not 0 or 1 or 2 or 3 or -1;
    }

    private static IGetProcAddress GetProcLoader()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return new WindowsGetProcAddress();

        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            return new LinuxGetProcAddress();

        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            return new OSXGetProcAddress();

        throw new PlatformNotSupportedException("Only Windows, Linux and Osx are supported");
    }
}

internal interface IGetProcAddress
{
    public nint GetProcAddress(string procName);
}

internal unsafe sealed class WindowsGetProcAddress : IGetProcAddress
{
    public nint GetProcAddress(string procName)
    {
        using var unmanagedProcName = new UnmanagedStr(procName);
        return wglGetProcAddress(unmanagedProcName);

        [DllImport(Library.Name)]
        static extern nint wglGetProcAddress(byte* lpszProc);
    }
}

internal unsafe sealed class LinuxGetProcAddress : IGetProcAddress
{
    public nint GetProcAddress(string procName)
    {
        using var unmanagedProcName = new UnmanagedStr(procName);
        return glxGetProcAddress(unmanagedProcName);

        [DllImport(Library.Name)]
        static extern unsafe nint glxGetProcAddress(UnmanagedStr procName);
    }
}

internal unsafe sealed class OSXGetProcAddress : IGetProcAddress
{
    private const int False = 0;

    public nint GetProcAddress(string procName)
    {
        using var unmanagedProcName = new UnmanagedStr(procName);

        if (NSIsSymbolNameDefined(unmanagedProcName) == False)
            return nint.Zero;

        nint symbol = NSLookupAndBindSymbol(unmanagedProcName);

        if (symbol != nint.Zero)
            symbol = NSAddressOfSymbol(symbol);

        return symbol;

        [DllImport(Library.Name)]
        static extern unsafe int NSIsSymbolNameDefined(UnmanagedStr s);

        [DllImport(Library.Name)]
        static extern unsafe nint NSLookupAndBindSymbol(UnmanagedStr s);

        [DllImport(Library.Name)]
        static extern unsafe nint NSAddressOfSymbol(nint symbol);
    }
}

