using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject.Tools
{
    class BucketTool : Tool
    {
        public Color FillColor { get; set; }
        public Color OutlineColor { get; set; }
        public bool FillEnabled { get; set; }
        public bool OutlineEnabled { get; set; }

        private static BucketTool _instance;
        private BucketTool(Color outline, Color fill, bool outlineEnabled, bool fillEnabled)
        {
            FillColor = fill;
            OutlineColor = outline;
            FillEnabled = fillEnabled;
            OutlineEnabled = outlineEnabled;
        }

        private BucketTool() { }

        public static BucketTool GetInstance(Color outline, Color fill, bool outlineEnabled, bool fillEnabled)
        {
            if (_instance == null)
            {
                _instance = new BucketTool(outline, fill, outlineEnabled, fillEnabled);
            }

            _instance.OutlineColor = outline;
            _instance.FillColor = fill;
            _instance.OutlineEnabled = outlineEnabled;
            _instance.FillEnabled = fillEnabled;

            return _instance;
        }
        public static BucketTool GetInstance()
        {
            if (_instance == null)
            {
                _instance = new BucketTool();
            }

            return _instance;
        }

        protected override bool InUse
        {
            get => base.InUse; set
            {
                base.InUse = value;

                if (value)
                    canvas.Cursor = Cursors.Cross;
                else
                    canvas.Cursor = Cursors.Default;
            }
        }

        protected internal override void OnMouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(sender, e);
            if (canvas.IsResizing || canvas.Layers[canvas.SelectedLayer].Locked)
                return;

            var ePos = new System.Drawing.PointF(e.X / canvas.ZoomFactor, e.Y / canvas.ZoomFactor);
            var target = canvas.SelectedLayer.Where(x => x.Contains(ePos)).LastOrDefault();

            if (e.Button == MouseButtons.Left)
            {
                if (target != null)
                {
                    target.FillColor = FillEnabled ? FillColor : target.FillColor;
                }
                canvas.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (target != null)
                    target.OutlineColor = OutlineEnabled ? OutlineColor : target.OutlineColor;
                canvas.Invalidate();
            }
        }

        protected internal override void OnMouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(sender, e);

            InUse = true;
        }

        protected internal override void OnPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(sender, e);
        }

    }
}
