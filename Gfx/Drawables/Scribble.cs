using CourseProject.Bounds;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace CourseProject.Gfx
{
    [Serializable]
    public class Scribble : IGraphic
    {
        protected delegate void BoundsChangedEventHandler();
        protected event BoundsChangedEventHandler BoundsChanged;
        protected void OnBoundsChanged()
        {
            BoundsChanged?.Invoke();
        }

        #region Properties
        public float X
        {
            get
            {
                return Bounds.X;
            }
            set
            {
                if (Bounds.X != value)
                {
                    Bounds.X = value;
                    OnBoundsChanged();
                }
            }
        }
        public float Y
        {
            get
            {
                return Bounds.Y;
            }
            set
            {
                if (Bounds.Y != value)
                {
                    Bounds.Y = value;
                    OnBoundsChanged();
                }
            }
        }

        public int Z { get; set; }
        public Color OutlineColor { get; set; }
        public Color FillColor { get; set; }
        public int OutlineWidth { get; set; }
        public DashStyle DashStyle { get; set; }

        private Boundary _bounds;
        public Boundary Bounds
        {
            get
            {
                return _bounds;
            }
            set
            {
                if (_bounds != value)
                {
                    _bounds = value;
                    OnBoundsChanged();
                }
            }
        }

        [NonSerialized]
        private bool _selected;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Selected { get => _selected; set => _selected = value; }

        #endregion

        private List<PointF> Trail { get; set; }
        public Scribble(List<PointF> trail)
        {
            Trail = trail;
            UpdateBounds();
        }

        private void UpdateBounds()
        {
            var xmin = Trail.Min(p => p.X);
            var ymin = Trail.Min(p => p.Y);
            var xmax = Trail.Max(p => p.X);
            var ymax = Trail.Max(p => p.Y);

            Bounds = new Boundary(new PointF(xmin, ymax), new PointF(xmax, ymin));
            foreach (var v in Bounds.DragHandles)
            {
                v.Visible = true;
            }
        }

        public void Draw(Graphics gfx)
        {
            Pen pen = new Pen(OutlineColor, OutlineWidth);
            pen.DashStyle = DashStyle;
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            using (pen)
            {
                gfx.DrawLines(pen, Trail.ToArray());
            }

            if (Selected)
            {
                Bounds.Draw(gfx);
            }
        }

        public bool Contains(PointF p)
        {
            var query = Trail
                .Select(x => new System.Drawing.RectangleF(x.X - 10, x.Y - 10, OutlineWidth + 10, OutlineWidth + 10))
                .Where(x => x.Contains(p));
            return query.Count() > 0;
        }

        public void Move(float dx, float dy, Size? boundingSize = null)
        {
            for (int i = 0; i < Trail.Count; i++)
            {
                Trail[i] = new PointF(Trail[i].X + dx, Trail[i].Y + dy);
            }
            UpdateBounds();
        }

        public IGraphic Copy()
        {
            return new Scribble(new List<PointF>(Trail));
        }
    }
}
