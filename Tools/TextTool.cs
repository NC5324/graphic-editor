using CourseProject.Bounds;
using CourseProject.Gfx;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject.Tools
{
    class TextTool : Tool
    {
        private TextToolForm _options;
        private static TextTool _instance;
        private Boundary _selection;
        private PointF _position1, _position2;
        public static TextTool GetInstance(TextToolForm options = null)
        {
            if (_instance == null)
                _instance = new TextTool();

            if (options != null)
                _instance._options = options;

            return _instance;
        }
        internal TextTool() { }

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

            if (InUse)
            {
                _position2 = new PointF(e.X / canvas.ZoomFactor, e.Y / canvas.ZoomFactor);

                if (base.canvas.SnapToGrid)
                {
                    int newX = (int)Math.Round((double)(_position2.X / canvas.GridCellSize)) * canvas.GridCellSize;
                    int newY = (int)Math.Round((double)(_position2.Y / canvas.GridCellSize)) * canvas.GridCellSize;

                    _position2 = new Point(newX, newY);
                }

                _selection = new Boundary(_position1, _position2);
                canvas.Invalidate();
            }

        }
        protected internal override void OnMouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(sender, e);

            if (InUse)
            {
                if (_options == null)
                {
                    _options = new TextToolForm();
                    _options.ShowDialog();

                    if (_options.DialogResult == DialogResult.OK && _options.Text.Length > 0)
                    {
                        var o = _options;
                        StringBox textBox = new StringBox(_position1, _position2, o.Text, o.Font, o.TextColor);
                        canvas.Add(textBox);
                        canvas.Refresh();

                        canvas.Tool = Pointer.GetInstance();
                    }
                }
                else
                {
                    var o = _options;
                    StringBox textBox = new StringBox(_position1, _position2, o.Text, o.Font, o.TextColor);
                    canvas.Add(textBox);
                    canvas.Refresh();

                    canvas.Tool = Pointer.GetInstance();
                }

                _selection = null;
                _options = null;
                InUse = false;
                canvas.Invalidate();
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
