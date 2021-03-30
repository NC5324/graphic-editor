using System;
using System.Windows.Forms;

namespace CourseProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LaunchForm());
            //Application.Run(new CanvasCreationForm());
            Application.Run(new MainForm());
        }
    }
}
