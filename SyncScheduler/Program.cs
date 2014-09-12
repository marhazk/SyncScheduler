using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SyncScheduler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Main Form;
        public static FormThread f;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form = new Main();
            f = new FormThread();
            Application.Run(Form);
        }
    }
}
