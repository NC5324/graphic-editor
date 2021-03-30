using CourseProject.Bounds;
using CourseProject.Gfx;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject.Tools
{
    internal class ShapeTool<T> : Tool
    {
        private PointF _position1, _position2;
        private Shape _shape;
        private double _delta;
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
        internal ShapeTool() { }

        protected internal override void OnMouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(sender, e);
            if (canvas.IsResizing || canvas.Layers[canvas.SelectedLayer].Locked)
                return;

            var query = canvas.Layers.SelectMany(x => x).Where(x => x.Selected);
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

            _delta = Math.Sqrt((_position1.X - e.X) * (_position1.X - e.X) + (_position1.Y - e.Y) * (_position1.Y - e.Y));

            if (_delta >= 10 && InUse)
            {
                _position2 = new PointF(e.X / canvas.ZoomFactor, e.Y / canvas.ZoomFactor);

                if (base.canvas.SnapToGrid)
                {
                    var cellsize = (int)(canvas.GridCellSize / canvas.ZoomFactor);
                    int newX = (int)Math.Round((double)(_position2.X / cellsize)) * cellsize;
                    int newY = (int)Math.Round((double)(_position2.Y / cellsize)) * cellsize;

                    _position2 = new PointF(newX, newY);
                }

                Boundary bounds = new Boundary(_position1, _position2);
                _shape = Shapes.Clone<T>(bounds);

                canvas.Invalidate();
            }
        }

        protected internal override void OnMouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(sender, e);

            if (InUse)
            {
                if (_shape != null)
                {
                    _shape.OutlineColor = canvas.OutlineColor;
                    _shape.FillColor = canvas.FillColor;
                    _shape.OutlineWidth = canvas.OutlineWidth;

                    canvas.Add(_shape);
                    canvas.Refresh();
                    InUse = true;

                    if (canvas.PropertyGridReference != null)
                        canvas.PropertyGridReference.SelectedObject = _shape;

                    InUse = false;
                    canvas.Tool = Pointer.GetInstance();
                    Pointer.GetInstance().Target = _shape;
                }
            }
        }

        protected internal override void OnPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(sender, e);

            if (InUse && canvas.Layers[canvas.SelectedLayer].Visible)
            {
                _shape.OutlineColor = canvas.OutlineColor;
                _shape.FillColor = canvas.FillColor;
                _shape.OutlineWidth = canvas.OutlineWidth;
                _shape.Draw(e.Graphics);
            }
        }
    }
}
