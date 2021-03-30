using System.Drawing;
using System.Windows.Forms;

namespace CourseProject.Tools
{
    class PanningTool : Tool
    {
        private Point _scrollPosition;
        private Point _position1;
        private Panel _canvasViewReference;
        internal PanningTool() { }
        private static PanningTool _instance;
        public static PanningTool GetInstance()
        {
            if (_instance == null)
                _instance = new PanningTool();

            return _instance;
        }

        protected internal override void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (canvas.IsResizing)
                return;

            _canvasViewReference = (Panel)canvas.Parent;
            if (e.Button == MouseButtons.Left && !InUse)
            {

                _position1 = e.Location;
                _scrollPosition = _canvasViewReference.AutoScrollPosition;

                InUse = true;
                canvas.Cursor = Cursors.Hand;
            }
        }

        protected internal override void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (InUse)
            {
                var deltaX = 50.PercentOf((_position1.X - e.X));
                var deltaY = 50.PercentOf((_position1.Y - e.Y));
                int x;
                int y;
                Point position;
                x = -_scrollPosition.X + deltaX;
                y = -_scrollPosition.Y + deltaY;

                position = new Point(x, y);

                _canvasViewReference.AutoScrollPosition = new Point(x, y);
            }

        }

        protected internal override void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (InUse)
            {
                InUse = false;
                canvas.Cursor = Cursors.Default;
                canvas.Invalidate();
                _canvasViewReference.Invalidate();
            }
        }
    }

}
