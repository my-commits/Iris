using System;
using System.Windows.Forms;

namespace WF_Iris
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //MLClass mLClass = new MLClass();
            //mLClass.Predict(new float[] { 0.5f, 0.5f, 0.5f, 0.5f });
            Application.Run(new Form1());
        }
    }
}
