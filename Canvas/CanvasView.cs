using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class CanvasView : UserControl
    {
        public event MouseEventHandler MouseDown
        {
            add
            {
                Canvas.MouseDown += value;
            }
            remove
            {
                Canvas.MouseDown -= value;
            }
        }
        public event MouseEventHandler MouseMove
        {
            add
            {
                Canvas.MouseMove += value;
            }
            remove
            {
                Canvas.MouseMove -= value;
            }
        }
        public event MouseEventHandler MouseUp
        {
            add
            {
                Canvas.MouseUp += value;
            }
            remove
            {
                Canvas.MouseUp -= value;
            }
        }
        public event PaintEventHandler Paint
        {
            add
            {
                Canvas.Paint += value;
            }
            remove
            {
                Canvas.Paint -= value;
            }
        }
        public Canvas Canvas { get; private set; }
        public Canvas ZoomCanvas { get; private set; }

        public CanvasView()
        {
            InitializeComponent();

            Canvas = new Canvas();
            Canvas.Location = new Point(0, 0);
            Canvas.Size = new Size(0, 0);
            Canvas.TabIndex = 0;
            Canvas.TabStop = false;
            panel1.Controls.Add(Canvas);
        }

        public void SetCanvas(Canvas canvas)
        {
            Canvas = canvas;
        }

    }
}
