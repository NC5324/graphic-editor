using CourseProject.Bounds;
using System;
using System.Collections.Generic;

namespace CourseProject.Gfx
{
    public enum BasicShapes
    {
        Oval, Rectangle, Triangle, Parallelogram, Pentagon, Hexagon, Heptagon, Octagon, Decagon, Polygon
    }
    public class Shapes
    {
        private static readonly Dictionary<Type, Shape> _availableShapes = new Dictionary<Type, Shape>()
        {
            {typeof(Oval), new Oval() },
            {typeof(Triangle), new Triangle() },
            {typeof(Parallelogram), new Parallelogram() },
            {typeof(Rectangle), new Rectangle() },
            {typeof(Pentagon), new Pentagon() },
            {typeof(Hexagon), new Hexagon() },
            {typeof(Heptagon), new Heptagon() },
            {typeof(Octagon), new Octagon() },
            {typeof(Decagon), new Decagon() },
        };
        public static Shape Clone<T>(Boundary bounds)
        {
            var graphicType = typeof(T);
            if (_availableShapes.ContainsKey(graphicType))
            {
                Shape shape = _availableShapes[graphicType].Clone(bounds);
                return shape;
            }
            else
                throw new NotSupportedException();
        }
    }
}
