using System;
using System.Windows.Forms;

namespace CourseProject.Tools
{
    [Serializable]
    public abstract class Tool
    {
        private bool _inUse;
        protected Canvas canvas;
        protected internal ContextMenu Menu { get; protected set; }
        protected virtual bool InUse
        {
            get
            {
                return _inUse;
            }
            set
            {
                _inUse = value;
            }
        }
        protected internal virtual void OnMouseDown(object sender, MouseEventArgs e)
        {
            canvas = sender as Canvas;
            if (canvas == null)
                return;
        }
        protected internal virtual void OnMouseMove(object sender, MouseEventArgs e)
        {
            canvas = sender as Canvas;
            if (canvas == null)
                return;
        }
        protected internal virtual void OnMouseUp(object sender, MouseEventArgs e)
        {
            canvas = sender as Canvas;
            if (canvas == null)
                return;
        }
        protected internal virtual void OnPaint(object sender, PaintEventArgs e)
        {
            canvas = sender as Canvas;
            if (canvas == null)
                return;
        }
    }
}
