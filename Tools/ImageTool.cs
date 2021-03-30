using CourseProject.Bounds;
using CourseProject.Gfx;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CourseProject.Tools
{
    class ImageTool : Tool
    {
        private PointF _position1, _position2;
        private Boundary _selection;
        public Image Image { get; private set; }
        protected override bool InUse
        {
            get
            {
                return base.InUse;
            }
            set
            {
                base.InUse = value;

                if (value)
                {
                    canvas.Cursor = Cursors.Cross;
                }
                else
                {
                    canvas.Cursor = Cursors.Default;
                }
            }
        }
        internal ImageTool()
        {
            Menu = new ContextMenu();
            Menu.MenuItems.Add("Set As Background");
        }
        private static ImageTool _instance;
        public static ImageTool GetInstance(Image image = null)
        {
            if (_instance == null)
                _instance = new ImageTool();

            if (image != null)
                _instance.Image = image;

            return _instance;
        }

        protected internal override void OnMouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(sender, e);
            if (canvas.Layers[canvas.SelectedLayer].Locked)
                return;

            canvas.DeselectAll();

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
                if (Image == null)
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = @"C:\";
                        openFileDialog.Filter = "JPG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif";
                        openFileDialog.Title = "Open File";
                        openFileDialog.ShowDialog();

                        if (openFileDialog.FileName != "")
                        {
                            using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                            {
                                Image = Image.FromFile(openFileDialog.FileName);
                                Picture target = new Picture(_position1, _position2);
                                target.Image = Image;
                                canvas.Add(target);
                                canvas.Refresh();

                                canvas.Tool = Pointer.GetInstance();
                            }
                        }
                    }
                }
                else
                {
                    Picture imageWrapper = new Picture(_position1, _position2);
                    imageWrapper.Image = Image;
                    canvas.Add(imageWrapper);
                    canvas.Refresh();

                    canvas.Tool = Pointer.GetInstance();
                }

                _selection = null;
                Image = null;
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
