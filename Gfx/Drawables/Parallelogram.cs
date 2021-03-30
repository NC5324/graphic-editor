using CourseProject.Bounds;
using System.Drawing;

namespace CourseProject.Gfx
{
    [System.Serializable]
    public class Parallelogram : Shape
    {
        private PointF A, B, C, D;
        public Parallelogram(Boundary bounds) : base(bounds)
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

        public Parallelogram()
        {

        }
        public override void Draw(Graphics gfx)
        {
            using (Pen pen = new Pen(OutlineColor, OutlineWidth))
            {
                gfx.DrawPolygon(pen, new[] { A, B, C, D });
            }
            using (Brush brush = new SolidBrush(FillColor))
            {
                gfx.FillPolygon(brush, new[] { A, B, C, D });
            }

            base.Draw(gfx);
        }

        protected void InitSpecifics()
        {
            A = new PointF(Bounds.Left, Bounds.Bottom);
            B = new PointF(Bounds.Right - 25.PercentOf(Bounds.Width), Bounds.Bottom);
            C = new PointF(Bounds.Right, Bounds.Top);
            D = new PointF(Bounds.Left + 25.PercentOf(Bounds.Width), Bounds.Top);
        }

        internal override Shape Clone(Boundary bounds)
        {
            return new Parallelogram(bounds);
        }
    }
}
