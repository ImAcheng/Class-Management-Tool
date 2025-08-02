using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Management_Tool {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
            ProgramCheck();
        }

        static void ProgramCheck() {
            if (!Directory.Exists("UserData"))
                Directory.CreateDirectory("UserData");

            if (!File.Exists("UerData\\Accounts.json"))
                File.Create("UserData\\Accounts.json").Close();
        }
    }
}
