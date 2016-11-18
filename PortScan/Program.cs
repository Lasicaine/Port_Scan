using System;
using System.Windows.Forms;

namespace PortScan
{
    /// <summary>
    /// Class with program entry point.
    /// </summary>
    internal sealed class Program
    {
        [STAThread] // ???
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles(); // включает визуалньные стили формы;
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());  // запуск главной формы

        }
    }
    }
