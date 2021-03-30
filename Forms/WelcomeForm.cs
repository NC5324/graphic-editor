using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    public enum MyDialogResult
    {
        OK, Cancel, Resume, Load
    }

    public partial class WelcomeForm : Form
    {
        private ColorDialog cd = new ColorDialog();
        public int CanvasWidth { get; private set; }
        public int CanvasHeight { get; private set; }
        public Color CanvasColor { get; private set; }
        public string File { get; private set; }
        public MyDialogResult myDialogResult { get; private set; }

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myDialogResult = MyDialogResult.Cancel;
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlLogo.Visible = true;

            numericUpDown1.Value = numericUpDown1.Minimum;
            numericUpDown2.Value = numericUpDown2.Minimum;

            pnlNew.Visible = false;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            CanvasWidth = (int)numericUpDown1.Value;
            CanvasHeight = (int)numericUpDown2.Value;
            CanvasColor = btnColor.BackColor;
            myDialogResult = MyDialogResult.Resume;
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlLogo.Visible = false;
            pnlNew.Visible = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            myDialogResult = MyDialogResult.Load;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CanvasWidth = (int)numericUpDown1.Value;
            CanvasHeight = (int)numericUpDown2.Value;
            CanvasColor = btnColor.BackColor;

            myDialogResult = MyDialogResult.OK;
            Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            btnColor.BackColor = cd.Color;
        }
    }
}
