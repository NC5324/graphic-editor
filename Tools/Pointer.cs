using CourseProject.Bounds;
using CourseProject.Gfx;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject.Tools
{
    [Serializable]
    class Pointer : Tool
    {
        Dictionary<DragHandleAnchor, Cursor> resizeCursorMap = new Dictionary<DragHandleAnchor, Cursor>()
        {
                            {DragHandleAnchor.TopLeft,  Cursors.SizeNWSE},
                            {DragHandleAnchor.TopCenter,  Cursors.SizeNS},
                            {DragHandleAnchor.TopRight,  Cursors.SizeNESW},
                            {DragHandleAnchor.MiddleLeft,  Cursors.SizeWE},
                            {DragHandleAnchor.MiddleRight,  Cursors.SizeWE},
                            {DragHandleAnchor.BottomLeft,  Cursors.SizeNESW},
                            {DragHandleAnchor.BottomCenter,  Cursors.SizeNS},
                            {DragHandleAnchor.BottomRight,  Cursors.SizeNWSE}
        };

        private bool _moving, _resizing;
        private float? _fixedX, _fixedY;
        private PointF _pos1;
        private PointF Position1
        {
            get
            {
                return _pos1;
            }
            set
            {
                _pos1 = new PointF(value.X / canvas.ZoomFactor, value.Y / canvas.ZoomFactor);
            }
        }

        internal IGraphic Target;
        private DragHandle _resizeHandle;

        private Pointer()
        {
            Menu = new ContextMenu();
            EventHandler menuHandler = new EventHandler(MenuOnClick);
            Menu.MenuItems.Add("Bring To Front Once", menuHandler);
            Menu.MenuItems.Add("Send To Back Once", menuHandler);
            Menu.MenuItems.Add("Send To Back", menuHandler);
            Menu.MenuItems.Add("Bring To Front", menuHandler);
        }
        private static Pointer _instance;
        public static Pointer GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Pointer();
            }

            return _instance;
        }

        private void MenuOnClick(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            switch (menuItem.Index)
            {
                case 0:
                    Target.Z += 2;
                    break;
                case 1:
                    Target.Z -= 2;
                    break;
                case 2:
                    var minZ = canvas.SelectedLayer.Min(x => x.Z);
                    if (Target.Z != minZ - 1)
                        Target.Z = minZ - 1;
                    break;
                case 3:
                    var maxZ = canvas.SelectedLayer.Max(x => x.Z);
                    if (Target.Z != maxZ + 1)
                        Target.Z = maxZ + 1;
                    break;
            }
            canvas.Invalidate();
        }

        protected internal override void OnMouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(sender, e);
            if (canvas.IsResizing || canvas.Layers[canvas.SelectedLayer].Locked)
                return;

            var query = canvas.SelectedLayer
                .Where(x =>
                            x.Contains(new PointF(e.X / canvas.ZoomFactor, e.Y / canvas.ZoomFactor)))
                .OrderBy(x => x.Z)
                .LastOrDefault();

            if (e.Button == MouseButtons.Left)
            {

                if (canvas.Cursor == Cursors.Hand && query != null)
                {
                    _moving = true;
                    canvas.Cursor = Cursors.SizeAll;
                    Position1 = e.Location;

                    canvas.DeselectAll();

                    Target = query;
                    Target.Selected = true;

                    canvas.PropertyGridReference.SelectedObject = Target;
                    canvas.PropertyGridReference.Invalidate();

                    canvas.Invalidate();
                }
                else if (resizeCursorMap.ContainsValue(canvas.Cursor))
                {
                    _resizing = true;

                    switch (_resizeHandle.Anchor)
                    {
                        case DragHandleAnchor.MiddleRight:
                        case DragHandleAnchor.BottomCenter:
                        case DragHandleAnchor.BottomRight:
                            Position1 = new PointF(Target.Bounds.Left, Target.Bounds.Top);
                            break;
                        case DragHandleAnchor.MiddleLeft:
                        case DragHandleAnchor.BottomLeft:
                            Position1 = new PointF(Target.Bounds.Right, Target.Bounds.Top);
                            break;
                        case DragHandleAnchor.TopLeft:
                            Position1 = new PointF(Target.Bounds.Right, Target.Bounds.Bottom);
                            break;
                        case DragHandleAnchor.TopCenter:
                        case DragHandleAnchor.TopRight:
                            Position1 = new PointF(Target.Bounds.Left, Target.Bounds.Bottom);
                            break;
                    }
                }
                else
                {
                    canvas.DeselectAll();
                    canvas.PropertyGridReference.SelectedObject = canvas;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                if (query != null && query.Selected)
                {
                    Menu.Show(canvas, e.Location);
                }
            }
        }

        protected internal override void OnMouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(sender, e);
            if (canvas.IsResizing || canvas.Layers[canvas.SelectedLayer].Locked)
                return;

            var query = canvas.SelectedLayer
                .Where(x =>
                            x.Contains(new PointF(e.X / canvas.ZoomFactor, e.Y / canvas.ZoomFactor)))
                .OrderBy(x => x.Z)
                .LastOrDefault();

            DragHandle handleQuery = null;

            if (query != null)
            {
                if (!_moving)
                    canvas.Cursor = Cursors.Hand;
            }
            else
            {
                if (handleQuery == null)
                    canvas.Cursor = Cursors.Default;
            }

            if (Target != null && Target.Selected && !_resizing)
            {
                handleQuery = Target.Bounds.DragHandles
                    .Where(x => x.Contains(new PointF(e.X / canvas.ZoomFactor, e.Y / canvas.ZoomFactor)))
                    .LastOrDefault();

                if (handleQuery != null)
                {
                    _resizeHandle = handleQuery;

                    canvas.Cursor = resizeCursorMap[handleQuery.Anchor];
                }
            }

            if (_moving)
            {
                var deltaX = e.X / canvas.ZoomFactor - Position1.X;
                var deltaY = e.Y / canvas.ZoomFactor - Position1.Y;

                Target.Move(deltaX, deltaY, canvas.Size);
                Position1 = e.Location;
                canvas.Invalidate();
            }
            else if (_resizing)
            {
                var nextPosition = PointF.Empty;
                switch (_resizeHandle.Anchor)
                {
                    case DragHandleAnchor.BottomCenter:
                    case DragHandleAnchor.TopCenter:
                        if (_fixedX == null)
                        {
                            _fixedX = Target.Bounds.Right;
                        }
                        nextPosition = new PointF((float)_fixedX, e.Y / canvas.ZoomFactor);
                        break;
                    case DragHandleAnchor.MiddleLeft:
                    case DragHandleAnchor.MiddleRight:
                        if (_fixedY == null)
                        {
                            _fixedY = Target.Bounds.Right;
                        }
                        nextPosition = new PointF(e.X / canvas.ZoomFactor, (float)_fixedY);
                        break;
                    default:
                        nextPosition = new PointF(e.X / canvas.ZoomFactor, e.Y / canvas.ZoomFactor);
                        break;
                }

                Target.Bounds = new Boundary(Position1, nextPosition);
                canvas.Invalidate();
            }
        }

        protected internal override void OnMouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(sender, e);
            if (canvas.IsResizing || canvas.Layers[canvas.SelectedLayer].Locked)
                return;

            if (e.Button == MouseButtons.Left)
            {
                _moving = false;
                _resizing = false;
                _fixedX = null;
                _fixedY = null;
            }
        }
    }
}
