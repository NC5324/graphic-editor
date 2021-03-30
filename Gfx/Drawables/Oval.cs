using CourseProject.Bounds;
using System.Drawing;

namespace CourseProject.Gfx
{
    [System.Serializable]
    public class Oval : Shape
    {
        public int HRadius { get; private set; }
        public int VRadius { get; private set; }
        public PointF Center { get; private set; }

        public Oval(Boundary bounds) : base(bounds)
        {
            InitSpecifics();
        }

        public Oval()
        {

        }

        public override void Draw(Graphics gfx)
        {

            var ellipseBounds = new System.Drawing.RectangleF(Bounds.X, Bounds.Y, Bounds.Width, Bounds.Height);
            Pen pen = new Pen(OutlineColor, OutlineWidth);
            using (pen)
                gfx.DrawEllipse(pen, ellipseBounds);

            Brush brush = new SolidBrush(FillColor);
            using (brush)
                gfx.FillEllipse(brush, ellipseBounds);

            base.Draw(gfx);

        }

        internal override Shape Clone(Boundary bounds)
        {
            return new Oval(bounds);
        }

        protected void InitSpecifics()
        {
            //HRadius = this.Bounds.HalfWidth;
            //VRadius = this.Bounds.HalfHeight;
            //Center = new PointF(Bounds.Left + HRadius, Bounds.Top + VRadius);
        }
    }
}
