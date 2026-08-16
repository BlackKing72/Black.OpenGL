namespace Black.OpenGL;

using System.Runtime.InteropServices;
using Black.Unmanaged;

public delegate nint GetProcAddressHandler(string name);
public sealed class LoadProcedureException(string procedureName)
    : Exception($"Failed to get procedure adreess for '{procedureName}'.");

public class Loader(GetProcAddressHandler? customHandler = null)
{
    private readonly IGetProcAddress loader = GetProcLoader(customHandler);

    public T LoadFunction<T>(string name) where T : Delegate
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

        return address switch
        {
            0 or 1 or 2 or 3 or -1 => false,
            _ => true
        };
    }

    private static IGetProcAddress GetProcLoader(GetProcAddressHandler? customHandler)
    {
        if (customHandler is not null)
            return new UserGetProcAddress(customHandler);

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return new WindowsGetProcAddress();

        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            return new LinuxGetProcAddress();

        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            return new OSXGetProcAddress();

        throw new PlatformNotSupportedException("Only Windows, Linux and Osx are supported. You can provide a custom handler for your platform.");
    }
}

internal interface IGetProcAddress
{
    public nint GetProcAddress(string procName);
}

internal unsafe sealed partial class UserGetProcAddress(GetProcAddressHandler customHandler) : IGetProcAddress
{
    public nint GetProcAddress(string procName)
    {
        return customHandler(procName);
    }
}

internal unsafe sealed partial class WindowsGetProcAddress : IGetProcAddress
{
    [LibraryImport("opengl32", StringMarshalling = StringMarshalling.Utf8)]
    private static partial nint wglGetProcAddress(string lpszProc);

    public nint GetProcAddress(string procName)
    {
        return wglGetProcAddress(procName);
    }
}

internal unsafe sealed partial class LinuxGetProcAddress : IGetProcAddress
{
    [LibraryImport("libGL", StringMarshalling = StringMarshalling.Utf8)]
    private static partial nint glXGetProcAddress(string procName);

    public nint GetProcAddress(string procName)
    {
        return glXGetProcAddress(procName);
    }
}

internal unsafe sealed partial class OSXGetProcAddress : IGetProcAddress
{
    [return: MarshalAs(UnmanagedType.Bool)]
    [LibraryImport("OpenGL.framework", StringMarshalling = StringMarshalling.Utf8)]
    private static partial bool NSIsSymbolNameDefined(string s);

    [LibraryImport("OpenGL.framework", StringMarshalling = StringMarshalling.Utf8)]
    private static partial nint NSLookupAndBindSymbol(string s);

    [LibraryImport("OpenGL.framework")]
    private static partial nint NSAddressOfSymbol(nint symbol);

    public nint GetProcAddress(string procName)
    {
        if (!NSIsSymbolNameDefined(procName))
            return nint.Zero;

        nint symbol = NSLookupAndBindSymbol(procName);

        if (symbol != nint.Zero)
            symbol = NSAddressOfSymbol(symbol);

        return symbol;


    }
}
