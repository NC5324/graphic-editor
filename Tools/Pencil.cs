using CourseProject.Gfx;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject.Tools
{
    internal class Pencil : Tool
    {
        private Scribble _scribble;
        private PointF _position1, _position2;
        private List<PointF> _trail;
        internal Pencil() { }

        protected internal override void OnMouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(sender, e);
            if (canvas.IsResizing || canvas.Layers[canvas.SelectedLayer].Locked)
                return;

            var query = canvas.SelectedLayer.Where(x => x.Selected);
            foreach (var target in query)
                target.Selected = false;

            if (e.Button == MouseButtons.Left)
            {
                _position1 = new PointF(e.X / canvas.ZoomFactor, e.Y / canvas.ZoomFactor);
                InUse = true;
                _trail = new List<PointF>() { _position1 };
            }
        }

        protected internal override void OnMouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(sender, e);
            if (canvas.IsResizing || canvas.Layers[canvas.SelectedLayer].Locked)
                return;

            if (InUse)
            {
                _position2 = new PointF(e.X / canvas.ZoomFactor, e.Y / canvas.ZoomFactor);

                _trail.Add(_position2);
                _scribble = new Scribble(_trail);
                canvas.Invalidate();
            }
        }

        protected internal override void OnMouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(sender, e);

            if (InUse)
            {
                canvas.Add(_scribble);
                canvas.Refresh();

                InUse = false;
            }
        }

        protected internal override void OnPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(sender, e);

            if (InUse && canvas.Layers[canvas.SelectedLayer].Visible && _scribble != null)
            {
                _scribble.OutlineColor = canvas.OutlineColor;
                _scribble.FillColor = canvas.FillColor;
                _scribble.OutlineWidth = canvas.OutlineWidth;
                _scribble.Draw(e.Graphics);
            }
        }
    }
}

