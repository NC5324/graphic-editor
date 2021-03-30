using CourseProject.Bounds;
using System;
using System.Drawing;

namespace CourseProject.Gfx
{
    [Serializable]
    public abstract class Shape : IGraphic
    {
        private Boundary _bounds;
        public Boundary Bounds
        {
            get
            {
                return _bounds;
            }
            set
            {
                if (_bounds == null)
                {
                    _bounds = value;
                }
                else if (_bounds != value)
                {
                    _bounds = value;
                    OnBoundsChanged(EventArgs.Empty);
                }
            }
        }
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
                    OnPositionChanged(new PositionEventArgs(true, false));
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
                    OnPositionChanged(new PositionEventArgs(false, true));
                }
            }
        }
        public float Width
        {
            get
            {
                return Bounds.Width;
            }
            set
            {
                if (Bounds.Width != value)
                {
                    Bounds.Width = value;
                    OnSizeChanged(new SizeEventArgs(true, false));
                }
            }
        }
        public float Height
        {
            get
            {
                return Bounds.Height;
            }
            set
            {
                if (Bounds.Height != value)
                {
                    Bounds.Height = value;
                    OnSizeChanged(new SizeEventArgs(false, true));
                }
            }
        }
        public int Z { get; set; }
        public Color OutlineColor { get; set; }
        public Color FillColor { get; set; }
        public int OutlineWidth { get; set; }
        public int FillOpacity { get; set; }
        public bool Selected { get; set; }

        protected event EventHandler<EventArgs> BoundsChanged;

        public event EventHandler<SizeEventArgs> SizeChanged;
        public event EventHandler<PositionEventArgs> PositionChanged;

        protected void OnBoundsChanged(EventArgs e)
        {
            BoundsChanged?.Invoke(this, e);
        }

        public void OnPositionChanged(PositionEventArgs e)
        {
            PositionChanged?.Invoke(this, e);
        }

        public void OnSizeChanged(SizeEventArgs e)
        {
            SizeChanged?.Invoke(this, e);
        }

        public virtual void Draw(Graphics gfx)
        {
            if (Selected) Bounds.Draw(gfx);
        }

        public void Move(float dx, float dy, Size? bounds = null)
        {
            X += dx;
            Y += dy;
        }

        public virtual bool Contains(PointF p)
        {
            return Bounds.Contains(p);
        }

        public Shape() { }
        public Shape(Boundary bounds)
        {
            Bounds = bounds;
            Selected = true;
        }

        internal abstract Shape Clone(Boundary bounds);

        public IGraphic Copy()
        {
            Boundary bounds = new Boundary(new PointF(Bounds.X, Bounds.Y), new PointF(Bounds.Right, Bounds.Bottom));
            var copy = Clone(bounds);
            copy.FillColor = FillColor;
            copy.OutlineColor = OutlineColor;
            copy.OutlineWidth = OutlineWidth;
            copy.FillOpacity = FillOpacity;

            return copy;
        }
    }
}
