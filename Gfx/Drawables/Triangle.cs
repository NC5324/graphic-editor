using CourseProject.Bounds;
using System.Drawing;

namespace CourseProject.Gfx
{
    [System.Serializable]
    public class Triangle : Shape
    {
        private PointF A, B, C;
        public Triangle(Boundary bounds) : base(bounds)
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

        public Triangle()
        {

        }

        public override void Draw(Graphics gfx)
        {
            Pen pen = new Pen(OutlineColor, OutlineWidth);
            using (pen)
            {
                gfx.DrawPolygon(pen, new[] { A, B, C });
            }
            Brush brush = new SolidBrush(FillColor);
            using (brush)
            {
                gfx.FillPolygon(brush, new[] { A, B, C });
            }

            base.Draw(gfx);
        }

        protected void InitSpecifics()
        {
            A = new PointF(Bounds.X, Bounds.Bottom);
            B = new PointF(Bounds.Right, Bounds.Bottom);
            C = new PointF(Bounds.Left + 50.PercentOf(Bounds.Width), Bounds.Top);
        }
        internal override Shape Clone(Boundary bounds)
        {
            return new Triangle(bounds);
        }

    }
}
