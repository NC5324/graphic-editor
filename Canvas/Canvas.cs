using CourseProject.Bounds;
using CourseProject.Gfx;
using CourseProject.Tools;

using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject
{
    [Designer(typeof(CanvasControlDesigner))]
    public partial class Canvas : PictureBox
    {
        #region Properties
        private Color _fillColor;
        [Category("Drawing Properties")]
        public Color FillColor
        {
            get
            {
                return _fillColor;
            }
            set
            {
                _fillColor = Color.FromArgb(
                    FillOpacity.PercentOf(byte.MaxValue), value.R, value.G, value.B);
            }
        }
        [DefaultValue(typeof(Color), "Black"), Category("Drawing Properties")]
        public Color OutlineColor { get; set; } = Color.Black;

        [DefaultValue(5), DisplayName("Outline Width"), Category("Drawing Properties")]
        public int OutlineWidth { get; set; } = 5;

        private int _fillOpacity = 100;
        [DisplayName("Fill Opacity"), Category("Drawing Properties")]
        public int FillOpacity { get => _fillOpacity; set { if (_fillOpacity != value) { _fillOpacity = value; FillColor = FillColor; } } }

        [DefaultValue(false)]
        public bool SnapToGrid { get; set; }

        [Browsable(false)]
        public override AnchorStyles Anchor { get => base.Anchor; set => base.Anchor = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LayerCollection Layers { get; set; }

        private Layer _selectedLayer;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Layer SelectedLayer
        {
            get
            {
                return _selectedLayer;
            }
            set
            {
                if (_selectedLayer != value)
                {
                    DeselectAll();

                    _selectedLayer = value;
                    SelectedLayerProperties = Layers[value];
                    Invalidate();
                }
            }
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LayerProperties SelectedLayerProperties { get; set; }

        private Tool _tool;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Tool Tool
        {
            get
            {
                return _tool;
            }
            set
            {
                if (_tool != value)
                {
                    var prev = _tool;
                    if (_tool != null)
                    {
                        MouseDown -= _tool.OnMouseDown;
                        MouseMove -= _tool.OnMouseMove;
                        MouseUp -= _tool.OnMouseUp;
                        Paint -= _tool.OnPaint;
                    }

                    _tool = value;
                    MouseDown += _tool.OnMouseDown;
                    MouseMove += _tool.OnMouseMove;
                    MouseUp += _tool.OnMouseUp;
                    Paint += _tool.OnPaint;

                    if (_tool != Pointer.GetInstance())
                        DeselectAll();

                    Cursor = Cursors.Default;
                }
            }
        }
        public PropertyGrid PropertyGridReference { get; private set; }

        [DisplayName("Grid Cell Size")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int GridCellSize
        {
            get
            {
                return Grid.CellSize;
            }
            set
            {
                Grid.CellSize = value;
                Grid.Initialize(this);
                Invalidate();
            }
        }

        [DisplayName("Show Grid")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowGrid { get; set; } = true;
        internal Grid Grid { get; private set; }

        private int w, h;
        internal float ZoomFactor { get; private set; } = 1;

        private Scaling _scaling;
        public Scaling Scaling
        {
            get
            {
                return _scaling;
            }
            set
            {
                if (_scaling != value)
                {
                    _scaling = value;
                    OnScalingChanged(EventArgs.Empty);
                }
            }
        }
        #endregion

        #region Event Stuff
        private event EventHandler<EventArgs> ScalingChanged;
        protected virtual void OnScalingChanged(EventArgs e)
        {
            switch (Scaling)
            {
                case Scaling.Normal:
                    ZoomFactor = 1f;
                    Width = w;
                    Height = h;
                    break;
                case Scaling.Small:
                    ZoomFactor = 0.5f;
                    Width = (int)(w * 0.3f);
                    Height = (int)(h * 0.3f);
                    break;
                case Scaling.Big:
                    ZoomFactor = 1.5f;
                    Width = (int)(w * ZoomFactor);
                    Height = (int)(h * ZoomFactor);
                    break;
            }

            Invalidate();
            ScalingChanged?.Invoke(this, e);
        }
        protected virtual void Canvas_OnSizeChanged(object sender, EventArgs e)
        {
            Grid.Initialize(this);
            PositionDragHandles();

            if (w == 0)
                w = Width;
            if (h == 0)
                h = Height;
        }

        #endregion

        #region Resizing Handles
        public DragHandleCollection DragHandles { get; private set; }
        internal void PositionDragHandles()
        {
            DragHandles[DragHandleAnchor.MiddleRight].Visible = true;
            DragHandles[DragHandleAnchor.BottomRight].Visible = true;
            DragHandles[DragHandleAnchor.BottomCenter].Visible = true;

            DragHandles[DragHandleAnchor.MiddleRight].Bounds = new System.Drawing.RectangleF(Right - DragHandle.Size - 3, Top + DragHandle.Size + 3, DragHandle.Size, DragHandle.Size);
            DragHandles[DragHandleAnchor.BottomRight].Bounds = new System.Drawing.RectangleF(Right - DragHandle.Size - 3, Bottom - DragHandle.Size - 3, DragHandle.Size, DragHandle.Size);
            DragHandles[DragHandleAnchor.BottomCenter].Bounds = new System.Drawing.RectangleF(Left + DragHandle.Size + 3, Bottom - DragHandle.Size - 3, DragHandle.Size, DragHandle.Size);
        }
        #endregion
        public Canvas()
        {
            InitializeComponent();

            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            SizeMode = PictureBoxSizeMode.AutoSize;
            //AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            BorderStyle = BorderStyle.FixedSingle;

            Layers = new LayerCollection();
            SelectedLayer = Layers.Internal.FirstOrDefault(x => x.Key.Order == 0).Value;
            DragHandles = new DragHandleCollection();
            Grid = new Grid(50);

            SizeChanged += Canvas_OnSizeChanged;
        }

        #region Methods
        internal void SetPropertyGrid(PropertyGrid grid)
        {
            PropertyGridReference = grid;
        }
        public void Add(IGraphic visual)
        {
            SelectedLayer.Add(visual);
        }
        public void Remove(IGraphic visual)
        {
            if (!SelectedLayer.Contains(visual))
                return;

            SelectedLayer.Remove(visual);
        }
        public void DeselectAll()
        {
            if (SelectedLayer == null)
                return;

            foreach (var v in SelectedLayer)
                v.Selected = false;

            Invalidate();
        }

        #endregion

        #region Canvas Specific Actions
        public bool IsResizing { get; private set; }
        private Point _position1;
        private DragHandle target;
        private int? fixedX, fixedY;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            target = DragHandles.Where(x => x.Contains(e.Location)).LastOrDefault();
            if (target != null)
            {

                IsResizing = true;
            }

            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {

            if (IsResizing)
            {
                var nextPosition = Point.Empty;
                switch (target.Anchor)
                {
                    case DragHandleAnchor.BottomCenter:
                        fixedX = fixedX == null ? Right : fixedX;
                        nextPosition = new Point((int)fixedX, e.Y);
                        break;
                    case DragHandleAnchor.MiddleRight:
                        fixedY = fixedY == null ? Bottom : fixedY;
                        nextPosition = new Point(e.X, (int)fixedY);
                        break;
                    default:
                        nextPosition = e.Location;
                        break;
                }
                var width = nextPosition.X - _position1.X;
                var height = nextPosition.Y - _position1.Y;

                this.Width = width;
                this.Height = height;

                w = width;
                h = height;

                this.Invalidate();
            }
            else
            {
                if (Layers[SelectedLayer].Locked)
                {
                    Cursor = Cursors.No;
                }
                else if (Cursor == Cursors.No)
                {
                    Cursor = Cursors.Default;
                }
            }

            base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (IsResizing)
            {
                IsResizing = false;
            }

            base.OnMouseUp(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;

            if (!savingToImage)
            {
                if (ShowGrid)
                    Grid.Draw(gfx);

                foreach (var handle in DragHandles)
                {
                    handle.Draw(gfx);
                }
            }

            gfx.ScaleTransform(ZoomFactor, ZoomFactor);

            foreach (var layer in Layers.Where(x => Layers[x].Visible).OrderBy(x => Layers[x].Order))
            {
                foreach (var visual in layer.OrderBy(x => x.Z))
                {
                    visual.Draw(gfx);
                }
            }
            base.OnPaint(e);
        }
        #endregion

        private bool savingToImage;
        public Bitmap CurrentStateToImage()
        {
            savingToImage = true;
            Bitmap bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            this.DrawToBitmap(bmp, ClientRectangle);
            savingToImage = false;
            return bmp;
        }
    }
}