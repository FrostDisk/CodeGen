using System.Windows.Forms;
using CodeGen.Properties;

namespace CodeGen
{
    public partial class FormMain : Form
    {
        #region properties
        #endregion

        #region init

        public FormMain()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        private void EnableProjectControl(bool enable)
        {
            toolStripMenuItemProject.Enabled = enable;
            toolStripMenuItemCloseProject.Enabled = enable;
        }

        #endregion

        #region events

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.IsMaximized = WindowState.Equals(FormWindowState.Maximized);
            Settings.Default.WindowSizeWidth = Size.Width;
            Settings.Default.WindowSizeHeight = Size.Height;
            Settings.Default.WindowPositionX = Location.X;
            Settings.Default.WindowPositionY = Location.Y;

            Settings.Default.Save();
        }

        #endregion
    }
}
