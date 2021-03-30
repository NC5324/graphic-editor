using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class TextToolForm : Form
    {
        public new string Text { get; private set; }
        public new Font Font { get; private set; }
        public Color TextColor { get; private set; }

        public int OutlineWidth { get; private set; }
        public TextToolForm()
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = richTextBox1;
            AcceptButton = btnOK;
            CancelButton = btnCancel;
        }

        public TextToolForm(Point location) : this()
        {
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            richTextBox1.Invalidate();
            propertyGrid1.Invalidate();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Text = richTextBox1.Text;
            Font = richTextBox1.Font;
            OutlineWidth = (int)richTextBox1.Font.SizeInPoints;
            TextColor = richTextBox1.ForeColor;

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TextToolForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

