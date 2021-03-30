using System;

namespace CourseProject.Gfx
{
    public class SizeEventArgs : EventArgs
    {
        public bool WidthIsChanged { get; }
        public bool HeightIsChanged { get; }

        public SizeEventArgs(bool w, bool h)
        {
            WidthIsChanged = w;
            HeightIsChanged = h;
        }
    }
    interface ISizable
    {
        event EventHandler<SizeEventArgs> SizeChanged;
        float Width { get; set; }
        float Height { get; set; }
        void OnSizeChanged(SizeEventArgs e);
    }
}
