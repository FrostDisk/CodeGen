using CodeGen.Properties;
using CodeGen.Utils;
using NLog;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
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
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #if DEBUG
            InstallBasePlugins();
            #else
            if (ProgramSettings.CheckIfFirstRun())
            {
                InstallBasePlugins();
            }
            #endif

            ProgramSettings.UpdateLoggerTargets();

            if (args.Length > 0)
            {
                if (args.Any(a => a.Equals("/install", StringComparison.InvariantCultureIgnoreCase)))
                {
                    InstallBasePlugins();

                    Application.Exit();
                    return;
                }
            }

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

        private static void InstallBasePlugins()
        {
            var directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");

            foreach (string extractedPluginLocation in Directory.GetFiles(directory, "*.dll", SearchOption.AllDirectories))
            {
                PluginsManager.ImportPlugin(extractedPluginLocation, true);
            }
        }
    }
}
