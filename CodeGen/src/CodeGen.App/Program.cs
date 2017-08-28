using CodeGen.Properties;
using CodeGen.Utils;
using NLog;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CodeGen
{
    static class Program
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ProgramSettings.UpdateLoggerTargets();

            FormMain form = new FormMain();

            if (Settings.Default.IsMaximized)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            else
            {
                Screen screen = Screen.FromControl(form);

                int locationX = form.Location.X;
                int locationY = form.Location.Y;

                if (Settings.Default.WindowPositionX > 0 && Settings.Default.WindowPositionX < screen.WorkingArea.Width
                    && Settings.Default.WindowPositionY > 0 && Settings.Default.WindowPositionY < screen.WorkingArea.Height)
                {
                    locationX = Settings.Default.WindowPositionX;
                    locationY = Settings.Default.WindowPositionY;

                    form.StartPosition = FormStartPosition.Manual;
                    form.Location = new Point(locationX, locationY);
                }

                if (Settings.Default.WindowSizeWidth > 0 && Settings.Default.WindowSizeHeight > 0)
                {
                    form.Size = new Size(Settings.Default.WindowSizeWidth, Settings.Default.WindowSizeHeight);
                }
            }

            Application.Run(form);
        }
    }
}
