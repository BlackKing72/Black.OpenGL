# Black.OpenGL

OpenGL 3 bindings that support native AOT compilation.

### Status

This library is a working in progress. Functions are added as needed, so expect some OpenGL functions to be missing, especially from newer APIs. Expect incomplete  functionality for now.


### Loading a specific version of OpenGL

The current implementation ignore the OpengGL versioning and attempts to load all available functions from the API.

If a function fails to load during initialization, the library raises an event (`OnLoadFailed`). You can subscribe to this event and handle the failure as needed. If no handler is registered, an Exception will be throw instead.

```cs
GL.OnLoadFailed += (LoadProcedureException e) => {
  Console.WriteLine($"Failed to load a function: {e.Message}");
};
```

> Note: This is someting that i want to change at some point.

### Usage
To use the library follow these steps:

1. Create a valid OpenGL context using a library such as [GLFW](https://www.glfw.org/) or [SDL](https://www.libsdl.org/index.php).   
2. (Optional) Subscribe to the `OnLoadFailed` event to handle missing OpenGL functions.
3. Initialize the library using `GL.Initialize()`.

Example:
```cs
using Black.OpenGL;

// 1: Create an OpenGL context (using GLFW, SDL, etc.)
// (Code for setting up the context will depend on your chosen library)

// 2: (Optional) Handle missing function errors
GL.OnLoadFailed += (LoadProcedureException e) =>
{
    Console.WriteLine($"Failed to load a function: {e.Message}");
};

// 3: Initialize the library
GL.Initialize();
```

### FAQ

> **Why am I building this?**
> Mainly for learning purposes and for personal use in other projects.

> **Why create a new library instead of using the ones currently available?**
> Some existing libraries don't support AOT compilation, and/or don't have compatibility with my older hardware. 

> **Is production ready?**
> Not yet, and may never be. This project is mainly for learning purposes and experimentation. While it works for my projects, parts of the API will remain untested and some of the code will require refinement. if you're okay with these limitation, feel free to try it out in your projects.
