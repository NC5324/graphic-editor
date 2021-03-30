using CourseProject.Bounds;
using System.Drawing;

namespace CourseProject.Gfx
{
    class Decagon : Shape
    {
        private Point A, B, C, D, E, F, G, H, I, J;
        public Decagon(Boundary bounds) : base(bounds)
        {
            //   InitSpecifics();
        }

        public Decagon() { }

        /*
        protected void InitSpecifics()
        {
            A = new Point(Bounds.Left + Bounds.Part(10,0), Bounds.Bottom - Bounds.Part(20,0));
            B = new Point(Bounds.Left + Bounds.Part(20,0), Bounds.Bottom);
            C = new Point(Bounds.Right - Bounds.Part(20,0), Bounds.Bottom);
            D = new Point(Bounds.Right-Bounds.Part(10,0), Bounds.Bottom - Bounds.Part(20,1));
            E = Bounds.DragHandles[DragHandleAnchor.MiddleRight].Location;
            F = new Point(Bounds.Right - Bounds.Part(10,0), Bounds.Top + Bounds.Part(20,1));
            G = new Point(Bounds.Right - Bounds.Part(20,0), Bounds.Top);
            H = new Point(Bounds.Left+Bounds.Part(20,0), Bounds.Top);
            I = new Point(Bounds.Top + Bounds.Part(20, 1), Bounds.Left);
            J = Bounds.DragHandles[DragHandleAnchor.MiddleLeft].Location;
        }
        */
        public override void Draw(Graphics gfx)
        {
            base.Draw(gfx);
            Pen pen = new Pen(OutlineColor, OutlineWidth);
            using (pen)
            {
                gfx.DrawLine(pen, A, B);
                gfx.DrawLine(pen, B, C);
                gfx.DrawLine(pen, C, D);
                gfx.DrawLine(pen, D, E);
                gfx.DrawLine(pen, E, F);
                gfx.DrawLine(pen, F, G);
                gfx.DrawLine(pen, G, H);
                gfx.DrawLine(pen, H, I);
                gfx.DrawLine(pen, I, J);
                gfx.DrawLine(pen, J, A);

            }
            Brush brush = new SolidBrush(FillColor);
            using (brush)
            {
                gfx.FillPolygon(brush, new[] { A, B, C, D, E, F, G, H, I, J });
            }
        }
        internal override Shape Clone(Boundary bounds)
        {
            return new Decagon(bounds);
        }
    }
}
