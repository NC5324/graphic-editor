using CourseProject.Bounds;
using System.Drawing;

namespace CourseProject.Gfx
{
    [System.Serializable]
    public class Rectangle : Shape
    {
        public Rectangle(Boundary bounds) : base(bounds)
        {
        }

        public Rectangle()
        {

        }

        public override void Draw(Graphics gfx)
        {

            Pen pen = new Pen(OutlineColor, OutlineWidth);
            using (pen)
                gfx.DrawRectangle(pen, Bounds.X, Bounds.Y, Bounds.Width, Bounds.Height);

            Brush brush = new SolidBrush(FillColor);
            using (brush)
                gfx.FillRectangle(brush, Bounds.X, Bounds.Y, Bounds.Width, Bounds.Height);

            base.Draw(gfx);
        }

        internal override Shape Clone(Boundary bounds)
        {
            return new Rectangle(bounds);
        }
    }
}
