using System;
using System.Windows.Forms;

namespace Organizador_2._0
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAbertura());
        }
    }
}
