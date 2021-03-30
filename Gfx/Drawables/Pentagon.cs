using CourseProject.Bounds;
using System.Drawing;

namespace CourseProject.Gfx
{
    [System.Serializable]
    class Pentagon : Shape
    {
        private PointF A, B, C, D, E;
        public Pentagon(Boundary bounds) : base(bounds)
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

        public Pentagon() { }

        protected void InitSpecifics()
        {
            A = new PointF(Bounds.Left + 25.PercentOf(Bounds.Width), Bounds.Bottom);
            B = new PointF(Bounds.Right - 25.PercentOf(Bounds.Width), Bounds.Bottom);
            C = new PointF(Bounds.Right, Bounds.Top + 50.PercentOf(Bounds.Height));
            D = new PointF(Bounds.Right - 50.PercentOf(Bounds.Width), Bounds.Top);
            E = new PointF(Bounds.Left, Bounds.Top + 50.PercentOf(Bounds.Height));
        }
        public override void Draw(Graphics gfx)
        {
            Pen pen = new Pen(OutlineColor, OutlineWidth);
            using (pen)
            {
                gfx.DrawPolygon(pen, new[] { A, B, C, D, E });
            }
            Brush brush = new SolidBrush(FillColor);
            using (brush)
            {
                gfx.FillPolygon(brush, new[] { A, B, C, D, E });
            }
            base.Draw(gfx);

        }
        internal override Shape Clone(Boundary bounds)
        {
            return new Pentagon(bounds);
        }
    }
}
