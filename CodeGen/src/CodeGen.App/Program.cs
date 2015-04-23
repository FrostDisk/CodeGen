using System;
using System.Drawing;
using System.Windows.Forms;
using CodeGen.Properties;

namespace CodeGen
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

            FormMain form = new FormMain();

            if (Settings.Default.IsMaximized)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            else
            {
                if (Settings.Default.WindowSizeWidth > 0 && Settings.Default.WindowSizeHeight > 0)
                {
                    form.Size = new Size(Settings.Default.WindowSizeWidth, Settings.Default.WindowSizeHeight);
                }

                if (Settings.Default.WindowPositionX > 0 && Settings.Default.WindowPositionY > 0)
                {
                    form.StartPosition = FormStartPosition.Manual;
                    form.Location = new Point(Settings.Default.WindowPositionX, Settings.Default.WindowPositionY);
                }
            }

            Application.Run(form);
        }
    }
}
