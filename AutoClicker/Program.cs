using System;
using System.Windows.Forms;

namespace AutoClicker
{
    static class Program
    {
        public static int counter = 0;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
