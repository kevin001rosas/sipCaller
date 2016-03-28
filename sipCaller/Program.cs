using System;
using System.Windows.Forms;

namespace sipCaller
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
            //Application.Run(new formSipRegister());
            Application.Run(new FormCallAssistant());
        }
    }
}
