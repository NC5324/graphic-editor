using System.Linq;
using System.Windows.Forms;

namespace CourseProject.Tools
{
    public class Eraser : Tool
    {
        internal Eraser() { }

        protected internal override void OnMouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(sender, e);
            if (canvas.Layers[canvas.SelectedLayer].Locked)
                return;

            var query = canvas.SelectedLayer.Where(x => x.Selected);
            foreach (var target in query)
                target.Selected = false;

            if (e.Button == MouseButtons.Left)
            {
                var ePos = new System.Drawing.PointF(e.X / canvas.ZoomFactor, e.Y / canvas.ZoomFactor);
                var target = canvas.SelectedLayer.Where(x => x.Contains(ePos)).LastOrDefault();

                if (target != null)
                {
                    canvas.SelectedLayer.Remove(target);
                    canvas.Invalidate();
                }
            }
        }
    }
}

