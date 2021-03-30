using CourseProject.Gfx;
using System;
using System.Drawing;

namespace CourseProject.Bounds
{
    [Serializable]
    public class DragHandle
    {
        public DragHandle(DragHandleAnchor anchor)
        {
            Anchor = anchor;
        }

        internal static int Size { get; set; } = 10;
        public DragHandleAnchor Anchor { get; private set; }
        public Point Location { get; set; }
        public RectangleF Bounds { get; set; }
        public bool Visible { get; set; } = true;
        public void Draw(Graphics graphics)
        {
            graphics.FillRectangleF(Brushes.Black, Bounds);
            graphics.DrawRectangleF(Pens.Black, Bounds);
        }

        public bool Contains(PointF p)
        {
            return Visible && Bounds.Contains(p);
        }

        public bool Contains(Point p, float sx, float sy)
        {
            RectangleF scaledBounds = new RectangleF(Bounds.X * sx, Bounds.Y * sy, Bounds.Width * sx, Bounds.Height * sy);
            return scaledBounds.Contains(p);
        }
    }
}
