using System;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class UnsavedDialog : Form
    {
        public UnsavedDialog()
        {
            InitializeComponent();

            DialogResult = DialogResult.None;
        }

        private void UnsavedDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.None)
                e.Cancel = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
