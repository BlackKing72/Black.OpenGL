﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Black.OpenGL;

internal static unsafe partial class Native
{
    public static readonly void* NullPtr = ((void*)0);

    public const byte True = 1;
    public const byte False = 0;

    public static byte ToGLBoolean (this bool value) => value ? True : False;
    public static bool FromGLBoolean (this byte value) => value == True;
}