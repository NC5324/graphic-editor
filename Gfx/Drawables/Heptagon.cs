using CourseProject.Bounds;
using System.Drawing;

namespace CourseProject.Gfx
{
    [System.Serializable]
    class Heptagon : Shape
    {
        private PointF A, B, C, D, E, F, G;
        public Heptagon(Boundary bounds) : base(bounds)
        {
            InitSpecifics();
            PositionChanged += OnBoundaryChanged;
            SizeChanged += OnBoundaryChanged;
            BoundsChanged += OnBoundaryChanged;
        }
        private void InitSpecifics()
        {
            var top = Bounds.Top;
            var bot = Bounds.Bottom;
            var left = Bounds.Left;
            var right = Bounds.Right;
            var width = Bounds.Width;
            var height = Bounds.Height;

            A = new PointF(left, top + 60.PercentOf(height));
            B = new PointF(left + 25.PercentOf(width), bot);
            C = new PointF(right - 25.PercentOf(width), bot);
            D = new PointF(right, top + 60.PercentOf(height));
            E = new PointF(right - 10.PercentOf(width), top + 20.PercentOf(height));
            F = new PointF(left + 50.PercentOf(width), top);
            G = new PointF(left + 10.PercentOf(width), top + 20.PercentOf(height));
        }
        private void OnBoundaryChanged(object sender, System.EventArgs e)
        {
            InitSpecifics();
        }

        public Heptagon() { }

        public override void Draw(Graphics gfx)
        {
            Pen pen = new Pen(OutlineColor, OutlineWidth);
            using (pen)
            {
                gfx.DrawPolygon(pen, new[] { A, B, C, D, E, F, G });
            }
            Brush brush = new SolidBrush(FillColor);
            using (brush)
            {
                gfx.FillPolygon(brush, new[] { A, B, C, D, E, F, G });
            }

            base.Draw(gfx);

        }
        internal override Shape Clone(Boundary bounds)
        {
            return new Heptagon(bounds);
        }
    }
}
