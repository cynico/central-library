using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralLibrary
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Environment.SetEnvironmentVariable("AWS_PROFILE", "default");
            Environment.SetEnvironmentVariable("AWS_REGION", "eu-central-1");

            Controller controllerObj = new Controller();
            Application.Run(new SignIn(ref controllerObj));
        }
    }
}
