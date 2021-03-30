using System;

namespace CourseProject
{
    [Serializable]
    public class LayerProperties
    {
        public bool Visible { get; set; }
        public bool Locked { get; set; }
        public string Name { get; set; } = "New Layer";
        public int Order { get; set; }

        public LayerProperties(string name, bool visible, bool locked, int order)
        {
            Name = name;
            Visible = visible;
            Locked = locked;
            Order = order;
        }
    }
}
