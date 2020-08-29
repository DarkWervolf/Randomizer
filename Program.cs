using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Randomizer
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

            string currentPath = Directory.GetCurrentDirectory();
            string yourfilesfoldername = Path.Combine(currentPath, "Your Files");
            if (!Directory.Exists(Path.Combine(currentPath, "Your Files")))
            {
                Directory.CreateDirectory(yourfilesfoldername);
            }
            //at this point your folder should exist

            Application.Run(new Form1());

            
        }
    }
}
