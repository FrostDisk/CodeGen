using System;
using System.Windows.Forms;
using CodeGen.Domain;
using CodeGen.Properties;

namespace CodeGen
{
    public partial class FormMain : Form
    {
        #region properties

        private Project _activeProject;

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

        private void toolStripMenuItemNewProject_Click(object sender, System.EventArgs e)
        {
            FormNewProject form = new FormNewProject();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _activeProject = form.Project;
            }
        }

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
