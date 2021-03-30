using System.Drawing;

namespace CourseProject.Gfx
{
    public static class GraphicsExtension
    {
        public static void DrawRectangleF(this Graphics gfx, Pen pen, RectangleF rectangle)
        {
            gfx.DrawRectangle(pen, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }
        public static void FillRectangleF(this Graphics gfx, Brush brush, RectangleF rectangle)
        {
            gfx.FillRectangle(brush, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }
    }
}
