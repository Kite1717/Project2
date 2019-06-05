using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Project2
{
    class Program
    {

        [DllImport("kernel32.dll")]
       static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        static void Main(string[] args)
        {
           /* var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
             */
            //new App();
            LoginScreen lg = new LoginScreen();
            Application.Run(lg);



        }

     
    }
}


