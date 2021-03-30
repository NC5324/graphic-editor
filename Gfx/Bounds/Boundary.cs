using CourseProject.Gfx;
using System;
using System.Drawing;
using System.Linq;

namespace CourseProject.Bounds
{
    [Serializable]
    public class Boundary
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Right { get { return X + Width; } }
        public float Left { get { return X; } }
        public float Top { get { return Y; } }
        public float Bottom { get { return Y + Height; } }

        public Boundary(PointF p1, PointF p2)
        {

            DragHandles = new DragHandleCollection();
            X = Math.Min(p1.X, p2.X);
            Y = Math.Min(p1.Y, p2.Y);
            Width = Math.Abs(p1.X - p2.X);
            Height = Math.Abs(p1.Y - p2.Y);

            foreach (var v in DragHandles)
                v.Visible = true;

            PositionDragHandles();
        }

        public DragHandleCollection DragHandles { get; }

        internal void PositionDragHandles()
        {
            if (this.DragHandles != null && DragHandle.Size > 0)
            {
                var halfDragHandleSize = DragHandle.Size / 2;

                DragHandles[DragHandleAnchor.TopLeft].Bounds = new System.Drawing.RectangleF(Left - DragHandle.Size, Top - DragHandle.Size, DragHandle.Size, DragHandle.Size);
                DragHandles[DragHandleAnchor.TopCenter].Bounds = new System.Drawing.RectangleF(Left + 50.PercentOf(Width) - halfDragHandleSize, Top - DragHandle.Size, DragHandle.Size, DragHandle.Size);
                DragHandles[DragHandleAnchor.TopRight].Bounds = new System.Drawing.RectangleF(Right, Top - DragHandle.Size, DragHandle.Size, DragHandle.Size);
                DragHandles[DragHandleAnchor.MiddleLeft].Bounds = new System.Drawing.RectangleF(Left - DragHandle.Size, Top + 50.PercentOf(Height) - halfDragHandleSize, DragHandle.Size, DragHandle.Size);
                DragHandles[DragHandleAnchor.MiddleRight].Bounds = new System.Drawing.RectangleF(Right, Top + 50.PercentOf(Height) - halfDragHandleSize, DragHandle.Size, DragHandle.Size);
                DragHandles[DragHandleAnchor.BottomLeft].Bounds = new System.Drawing.RectangleF(Left - DragHandle.Size, Bottom, DragHandle.Size, DragHandle.Size);
                DragHandles[DragHandleAnchor.BottomCenter].Bounds = new System.Drawing.RectangleF(Left + 50.PercentOf(Width) - halfDragHandleSize, Bottom, DragHandle.Size, DragHandle.Size);
                DragHandles[DragHandleAnchor.BottomRight].Bounds = new System.Drawing.RectangleF(Right, Bottom, DragHandle.Size, DragHandle.Size);

            }
        }
        public void Draw(Graphics gfx)
        {
            PositionDragHandles();

            Pen pen = new Pen(SystemColors.ActiveCaption, 5);
            using (pen)
            using (var brush = new SolidBrush(Color.FromArgb(50, pen.Color.R, pen.Color.G, pen.Color.B)))
            {
                gfx.DrawRectangle(pen, X, Y, Width, Height);
                gfx.FillRectangle(brush, X, Y, Width, Height);

                foreach (var v in DragHandles.Where(x => x.Visible))
                    v.Draw(gfx);
            }
        }

        public void HideHandles()
        {
            foreach (var handle in DragHandles)
                handle.Visible = false;
        }

        public void ShowHandles()
        {
            foreach (var handle in DragHandles)
                handle.Visible = true;
        }

        public bool Contains(IGraphic shape)
        {
            return Left <= shape.Bounds.Left && Right >= shape.Bounds.Right
                && Top <= shape.Bounds.Top && Bottom >= shape.Bounds.Bottom;
        }
        public virtual bool Contains(PointF point)
        {
            return point.X > Left && point.X < Right
                && point.Y > Top && point.Y < Bottom;
        }

    }
}
