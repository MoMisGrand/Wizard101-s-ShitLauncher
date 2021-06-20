using System;
using System.Windows.Forms;
using W101RLauncher.Forms;

namespace W101RLauncher
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new W101RLauncherForm());
        }
    }
}