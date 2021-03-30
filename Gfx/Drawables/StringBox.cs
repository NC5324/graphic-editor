using CourseProject.Bounds;
using System;
using System.Drawing;

namespace CourseProject.Gfx
{
    [Serializable]
    class StringBox : IGraphic
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

        public Color TextColor { get; set; }

        public int OutlineWidth { get; set; }

        public string Text { get; set; }
        public Font Font { get; set; }

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
        public bool Selected { get => _selected; set => _selected = value; }

        public StringBox(PointF p1, PointF p2, string text, Font font, Color textColor)
        {
            Bounds = new Boundary(p1, p2);
            Selected = true;

            Text = text;
            Font = font;
            TextColor = textColor;
        }

        public bool Contains(PointF point)
        {
            return Bounds.Contains(point);
        }

        public void Draw(Graphics gfx)
        {
            Pen pen = new Pen(OutlineColor, OutlineWidth);
            Brush brush = new SolidBrush(FillColor);
            Brush textBrush = new SolidBrush(TextColor);
            using (pen)
            using (brush)
            using (textBrush)
            {
                var bounds = new System.Drawing.RectangleF(Bounds.X, Bounds.Y, Bounds.Width, Bounds.Height);
                gfx.DrawRectangleF(pen, bounds);
                gfx.FillRectangleF(brush, bounds);
                gfx.DrawString(Text, Font, textBrush, bounds);
            }
            if (Selected)
                Bounds.Draw(gfx);
        }

        public void Move(float deltaX, float deltaY, Size? boundingSize = null)
        {
            var offset = 80.PercentOf(DragHandle.Size); System.Drawing.Rectangle bounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            if (boundingSize != null)
                bounds = new System.Drawing.Rectangle(new Point(0, 0), (Size)boundingSize);

            var newX = deltaX + Bounds.X;
            
            /*var width = Bounds.Width + offset;
            if (newX + width > bounds.Right)
            {
                newX -= ((newX + width) - bounds.Right);
            }
            else if (newX < bounds.Left + offset)
            {
                newX += bounds.Left + offset - newX;
            }*/

            var newY = deltaY + Bounds.Y;
            /*
            var height = Bounds.Height + offset;
            if (newY + height > bounds.Bottom)
            {
                newY -= ((newY + height) - bounds.Bottom);
            }
            else if (newY < bounds.Top + offset)
            {
                newY += bounds.Top + offset - newY;
            }*/

            X = newX;
            Y = newY;
        }

        public IGraphic Copy()
        {
            return new StringBox(new PointF(X, Y), new PointF(Bounds.Right, Bounds.Bottom),
                Text, (Font)Font.Clone(), TextColor);
        }
    }
}
