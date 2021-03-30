using CourseProject.Gfx;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseProject.Tools
{
    static class ToolFactory
    {
        private static readonly Dictionary<Type, Tool> tools = new Dictionary<Type, Tool>()
        {
            //IGraphic Tools
            {typeof(Oval), new ShapeTool<Oval>()},
            {typeof(Rectangle), new ShapeTool<Rectangle>()},
            {typeof(Triangle), new ShapeTool<Triangle>()},
            {typeof(Parallelogram), new ShapeTool<Parallelogram>()},
            {typeof(Pentagon), new ShapeTool<Pentagon>()},
            {typeof(Hexagon), new ShapeTool<Hexagon>()},
            {typeof(Heptagon), new ShapeTool<Heptagon>()},
            {typeof(Octagon), new ShapeTool<Octagon>()},
            {typeof(Scribble), new Pencil()},
            {typeof(Picture), new ImageTool()}
            ,
            //Other Tools
            {typeof(Pointer), Pointer.GetInstance()},
            {typeof(Pencil), new Pencil()},
            {typeof(SelectionTool), new SelectionTool() },
            {typeof(MagnifierTool), new MagnifierTool() },
            {typeof(Eraser), new Eraser() }
        };

        public static Tool GetInstance<T>()
        {
            Type type = typeof(T);
            if (tools.ContainsKey(type))
            {
                return tools[type];
            }
            else
            {
                throw new NotSupportedException();
            }
        }
        public static ContextMenu GetMenu(IGraphic graphic)
        {
            Type type = graphic.GetType();
            if (tools.ContainsKey(type))
            {
                return tools[type].Menu;
            }
            else
            {
                return new ContextMenu();
            }
        }

    }
}
