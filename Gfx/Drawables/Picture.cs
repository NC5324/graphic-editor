using CourseProject.Bounds;
using System;
using System.ComponentModel;
using System.Drawing;

namespace CourseProject.Gfx
{
    [System.Serializable]
    class Picture : IGraphic
    {
        protected delegate void BoundsChangedEventHandler();
        protected event BoundsChangedEventHandler BoundsChanged;
        protected void OnBoundsChanged()
        {
            BoundsChanged?.Invoke();
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

        public Image Image { get; set; }

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

        public Picture(PointF p1, PointF p2)
        {
            Bounds = new Boundary(p1, p2);
        }

        public Picture(Image image)
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(image.Width, image.Height);
            Bounds = new Boundary(p1, p2);
            Image = image;
        }

        public bool Contains(PointF point)
        {
            return point.X > Bounds.Left && point.X < Bounds.Right
                && point.Y > Bounds.Top && point.Y < Bounds.Bottom;

        }

        public void Draw(Graphics gfx)
        {
            gfx.DrawImage(Image, Bounds.X, Bounds.Y, Bounds.Width, Bounds.Height);
            if (Selected)
                Bounds.Draw(gfx);
        }

        public void Move(float deltaX, float deltaY, Size? boundingSize = null)
        {
            var offset = DragHandle.Size;
            System.Drawing.Rectangle bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            if (boundingSize != null)
                bounds = new System.Drawing.Rectangle(new Point(0, 0), (Size)boundingSize);

            X = deltaX + Bounds.X;
            Y = deltaY + Bounds.Y;
        }

        public IGraphic Copy()
        {
            return new Picture((Image)this.Image.Clone());
        }
    }
}
