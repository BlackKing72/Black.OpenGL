# Black.OpenGL
OpenGL 3 bindings that support native AOT.

### Status
This library is not complete yet, and functions are added as needed. So expect some OpenGL functions to be missing, especially the newer APIs.

### Loading a specific version of OpenGL
The current implementation ignore the OpengGL version and just try to load all the functions available on the API.

If during initialization a function is missing, the API will raise an event and you can decide how you want to handled it.

This is someting that i want to redone at some point.

### FAQ
> **Why am I building this?**
> Mainly for learning purposes and for personal use in other projects.

> **Why create a new library instead of using the ones currently available?**
> Some of them don't support AOT, or don't support my older hardware. 

> **Is production ready?**
> Maybe one day, but for now **NO**. This is made mainly for learning purposes, and for me to use in my prototypes, so, some of the API still untested and some of the code is not great. if you're fine with that, be free to test it in your project.