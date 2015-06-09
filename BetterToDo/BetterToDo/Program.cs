using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace BetterToDo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isOnlyInstance;
            using (new Mutex(true, "BetterToDo", out isOnlyInstance))
            {
                if (isOnlyInstance)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    try { Application.Run(new MainForm()); }
                    catch (ObjectDisposedException) { }
                }
                else
                {
                    var current = Process.GetCurrentProcess();

                    foreach (var process in Process.GetProcessesByName(current.ProcessName))
                    {
                        if (process.Id == current.Id) continue;
                        PInvokes.SetForegroundWindow(process.MainWindowHandle);
                        break;
                    }
                }
               
            }
        }
    }
}