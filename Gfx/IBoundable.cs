using CourseProject.Bounds;

namespace CourseProject.Gfx
{
    public interface IBoundable
    {
        Boundary Bounds { get; set; }
        DragHandleCollection DragHandles { get; }
    }
}
