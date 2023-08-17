namespace Black.OpenGL;

using System.Drawing;
using static Black.OpenGL.Native;

public static unsafe partial class GL
{
    public static void Viewport(int x, int y, int width, int height)
    {
        glViewport(x, y, width, height);
    }
    public static void Viewport(Rectangle rect)
    {
        glViewport(rect.X, rect.Y, rect.Width, rect.Height);
    }
}