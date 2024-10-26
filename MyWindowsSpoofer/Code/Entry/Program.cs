using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spoofer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            tty_protection ttysecurity = new tty_protection();
            tty_system ttysystem = new tty_system();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(!ttysecurity.isStartedAsAdmin())
            {
        
                ttysystem.Restart();
            }
            ttysystem.rpc.Initialize();
            ttysystem.SetRPC("Starting up...");
            Application.Run(new LoginForm());
        }
    }
}
