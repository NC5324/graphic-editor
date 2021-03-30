using CourseProject.Bounds;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject.Tools
{
    internal class SelectionTool : Tool
    {
        private PointF _position1, _position2;
        private Boundary _selection;
        protected override bool InUse
        {
            get
            {
                return base.InUse;
            }
            set
            {
                base.InUse = value;

                if (value)
                {
                    canvas.Cursor = Cursors.Cross;
                }
                else
                {
                    canvas.Cursor = Cursors.Default;
                }
            }
        }
        internal SelectionTool() { }

        protected internal override void OnMouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(sender, e);
            if (canvas.IsResizing || canvas.Layers[canvas.SelectedLayer].Locked)
                return;

            var query = canvas.SelectedLayer.Where(x => x.Selected);
            foreach (var target in query)
                target.Selected = false;

            if (e.Button == MouseButtons.Left && !InUse)
            {
                _position1 = new PointF(e.X / canvas.ZoomFactor, e.Y / canvas.ZoomFactor);
                InUse = true;
            }
        }
        protected internal override void OnMouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(sender, e);

            _position2 = new PointF(e.X / canvas.ZoomFactor, e.Y / canvas.ZoomFactor);

            _selection = new Boundary(_position1, _position2);
            _selection.HideHandles();
            canvas.Invalidate(true);

        }
        protected internal override void OnMouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(sender, e);

            if (InUse)
            {
                var selectionQuery = canvas.SelectedLayer.Where(x => _selection.Contains(x));
                foreach (var target in selectionQuery)
                    target.Selected = true;

                canvas.Invalidate();
                if (selectionQuery.Count() > 0)
                {
                    canvas.Tool = ToolFactory.GetInstance<Pointer>();
                }
                _selection = null;
                InUse = false;
            }
        }
        protected internal override void OnPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(sender, e);


            if (InUse && _selection != null)
            {
                _selection.Draw(e.Graphics);
            }
        }
    }
}
