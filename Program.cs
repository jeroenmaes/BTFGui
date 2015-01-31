using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTF.GUI
{
    static class Program
    {
        #region Private Constants
        //***************************
        // Formats
        //***************************
        //private const string ExceptionFormat = "Exception: {0}";
        //private const string InnerExceptionFormat = "InnerException: {0}";
        #endregion
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
