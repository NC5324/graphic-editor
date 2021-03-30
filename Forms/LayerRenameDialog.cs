using System;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class LayerRenameDialog : Form
    {
        public string LayerName { get; private set; }
        public LayerRenameDialog()
        {
            InitializeComponent();

            AcceptButton = btnOK;
            CancelButton = btnCancel;

            DialogResult = DialogResult.None;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LayerName = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LayerRenameDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.None)
                e.Cancel = true;
        }
    }
}
