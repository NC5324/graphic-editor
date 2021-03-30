using System;

namespace CourseProject.Gfx
{
    public class PositionEventArgs : EventArgs
    {
        public bool xIsChanged { get; }
        public bool yIsChanged { get; }

        public PositionEventArgs(bool x, bool y)
        {
            xIsChanged = x;
            yIsChanged = y;
        }
    }
    interface IPositionable
    {
        event EventHandler<PositionEventArgs> PositionChanged;
        float X { get; set; }
        float Y { get; set; }
        int Z { get; set; }
        void OnPositionChanged(PositionEventArgs e);
    }
}
