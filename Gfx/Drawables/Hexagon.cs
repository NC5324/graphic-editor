using CourseProject.Bounds;
using System.Drawing;

namespace CourseProject.Gfx
{
    [System.Serializable]
    class Hexagon : Shape
    {
        private PointF A, B, C, D, E, F;
        public Hexagon(Boundary bounds) : base(bounds)
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

        public Hexagon() { }

        protected void InitSpecifics()
        {
            var top = Bounds.Top;
            var bot = Bounds.Bottom;
            var left = Bounds.Left;
            var right = Bounds.Right;
            var width = Bounds.Width;
            var height = Bounds.Height;

            A = new PointF(left, bot - 25.PercentOf(height));
            B = new PointF(left + 50.PercentOf(width), bot);
            C = new PointF(right, bot - 25.PercentOf(height));
            D = new PointF(right, top + 25.PercentOf(height));
            E = new PointF(left + 50.PercentOf(width), top);
            F = new PointF(left, top + 25.PercentOf(height));
        }
        public override void Draw(Graphics gfx)
        {
            Pen pen = new Pen(OutlineColor, OutlineWidth);
            using (pen)
            {
                gfx.DrawPolygon(pen, new[] { A, B, C, D, E, F });

            }
            Brush brush = new SolidBrush(FillColor);
            using (brush)
            {
                gfx.FillPolygon(brush, new[] { A, B, C, D, E, F });
            }

            base.Draw(gfx);

        }
        internal override Shape Clone(Boundary bounds)
        {
            return new Hexagon(bounds);
        }
    }
}
