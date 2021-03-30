using CourseProject.Bounds;
using System.Drawing;

namespace CourseProject.Gfx
{
    [System.Serializable]
    class Octagon : Shape
    {
        private PointF A, B, C, D, E, F, G, H;
        public Octagon(Boundary bounds) : base(bounds)
        {
            InitSpecifics();
            PositionChanged += OnBoundaryChanged;
            SizeChanged += OnBoundaryChanged;
            BoundsChanged += OnBoundaryChanged;
        }
        private void OnBoundaryChanged(object sender, System.EventArgs e)
        {
            InitSpecifics();
        }

        public Octagon() { }

        protected void InitSpecifics()
        {
            var top = Bounds.Top;
            var bot = Bounds.Bottom;
            var left = Bounds.Left;
            var right = Bounds.Right;
            var width = Bounds.Width;
            var height = Bounds.Height;

            A = new PointF(left, bot - 25.PercentOf(height));
            B = new PointF(left + 25.PercentOf(width), bot);
            C = new PointF(right - 25.PercentOf(width), bot);
            D = new PointF(right, bot - 25.PercentOf(height));
            E = new PointF(right, top + 25.PercentOf(height));
            F = new PointF(right - 25.PercentOf(width), top);
            G = new PointF(left + 25.PercentOf(width), top);
            H = new PointF(left, top + 25.PercentOf(height));
        }
        public override void Draw(Graphics gfx)
        {
            Pen pen = new Pen(OutlineColor, OutlineWidth);
            using (pen)
            {
                gfx.DrawPolygon(pen, new[] { A, B, C, D, E, F, G, H });

            }
            Brush brush = new SolidBrush(FillColor);
            using (brush)
            {
                gfx.FillPolygon(brush, new[] { A, B, C, D, E, F, G, H });
            }

            base.Draw(gfx);
        }
        internal override Shape Clone(Boundary bounds)
        {
            return new Octagon(bounds);
        }
    }
}
