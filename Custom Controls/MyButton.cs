using System.Windows.Forms;

namespace CourseProject
{
    class MyButton : Button
    {
        public MyButton() : base()
        {
            this.SetStyle(ControlStyles.Selectable, false);
        }

        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }
    }
}
