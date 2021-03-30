using System.Windows.Forms;

namespace CourseProject.Tools
{
    class MagnifierTool : Tool
    {
        protected internal override void OnMouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(sender, e);
            if (canvas.IsResizing)
                return;

            if (e.Button == MouseButtons.Left)
            {
                switch (canvas.Scaling)
                {
                    case Gfx.Scaling.Small:
                        canvas.Scaling = Gfx.Scaling.Normal;
                        break;
                    case Gfx.Scaling.Normal:
                        canvas.Scaling = Gfx.Scaling.Big;
                        break;
                }

            }
            else if (e.Button == MouseButtons.Right)
            {
                switch (canvas.Scaling)
                {
                    case Gfx.Scaling.Big:
                        canvas.Scaling = Gfx.Scaling.Normal;
                        break;
                    case Gfx.Scaling.Normal:
                        canvas.Scaling = Gfx.Scaling.Small;
                        break;
                }
            }
        }
    }
}
