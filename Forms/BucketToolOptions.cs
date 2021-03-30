using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class BucketToolOptions : Form
    {
        public Color FillColor { get; private set; }
        public Color OutlineColor { get; private set; }
        public bool OutlineEnabled { get; private set; } = true;
        public bool FillEnabled { get; private set; } = true;
        public BucketToolOptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = Color.Black;
            cd.ShowDialog();

            button1.BackColor = cd.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = Color.White;
            cd.ShowDialog();

            button2.BackColor = cd.Color;
        }

        private void myCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            OutlineEnabled = myCheckBox1.Checked;

        }

        private void myCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            FillEnabled = myCheckBox2.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OutlineColor = button1.BackColor;
            FillColor = button2.BackColor;
            Close();
        }
    }
}
