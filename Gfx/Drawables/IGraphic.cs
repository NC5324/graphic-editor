using CourseProject.Bounds;
using System.Drawing;

namespace CourseProject.Gfx
{
    public interface IGraphic
    {
        float X { get; set; }
        float Y { get; set; }
        int Z { get; set; }
        Color OutlineColor { get; set; }
        Color FillColor { get; set; }
        int OutlineWidth { get; set; }
        void Draw(Graphics gfx);
        bool Selected { get; set; }
        void Move(float dx, float dy, Size? bounds = null);
        bool Contains(PointF p);

        IGraphic Copy();
        Boundary Bounds { get; set; }
    }
}
