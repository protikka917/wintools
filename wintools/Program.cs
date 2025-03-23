// See https://aka.ms/new-console-template for more information
using System;
using System.Windows.Forms;

namespace wintools
{
    internal static class NewBaseType
    {
        [STAThread]
        static void Main()
        {
            if (OperatingSystem.IsWindowsVersionAtLeast(6, 1))
            {
                Application.SetCompatibleTextRenderingDefault(false);
            }

            // Run the MainForm
            if (OperatingSystem.IsWindowsVersionAtLeast(6, 1))
            {
                Application.Run(new MainForm());
            }
        }
    }



}





