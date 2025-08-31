#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value null

namespace Black.OpenGL;

internal unsafe partial class Native
{
    internal delegate void GetMultisamplefv(uint pname, uint index, float* val);
    [OpenGL<GetMultisamplefv>] internal static GetMultisamplefv glGetMultisamplefv;

    internal delegate byte* GetString(GetStringName texture);
    [OpenGL<GetString>] internal static GetString glGetString;
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value null