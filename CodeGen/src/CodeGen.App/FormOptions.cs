using CodeGen.Configuration;
using CodeGen.Utils;
using System;
using System.Windows.Forms;

namespace CodeGen
{
    /// <summary>
    /// FormOptions
    /// </summary>
    /// <seealso cref="Form" />
    public partial class FormOptions : Form
    {
        #region properties

        /// <summary>
        /// Gets or sets the _settings.
        /// </summary>
        private GlobalSettings _settings { get; set; }

        #endregion

        #region initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="FormOptions"/> class.
        /// </summary>
        public FormOptions()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        /// <summary>
        /// Loads the local variables.
        /// </summary>
        public void LoadLocalVariables()
        {
            _settings = ProgramSettings.GetGlobalSettings();

            txtDefaultProjectsDirectory.Text = _settings.DirectoriesSettings.DefaultProjectsDirectory;
            txtPluginsDirectory.Text = _settings.DirectoriesSettings.PluginsDirectory;
            txtCacheDirectory.Text = _settings.DirectoriesSettings.CacheDirectory;
            txtTempDirectory.Text = _settings.DirectoriesSettings.TempDirectory;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtDefaultProjectsDirectory.Text))
            {

            }

            return true;
        }

        #endregion

        #region events

        private void btnChangeDefaultProjectsDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserChangeDirectory.SelectedPath = txtDefaultProjectsDirectory.Text;
            if( folderBrowserChangeDirectory.ShowDialog() == DialogResult.OK)
            {
                txtDefaultProjectsDirectory.Text = folderBrowserChangeDirectory.SelectedPath;
            }
        }

        private void btnChangePluginsDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserChangeDirectory.SelectedPath = txtPluginsDirectory.Text;
            if (folderBrowserChangeDirectory.ShowDialog() == DialogResult.OK)
            {
                txtPluginsDirectory.Text = folderBrowserChangeDirectory.SelectedPath;
            }
        }

        private void btnChangeCacheDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserChangeDirectory.SelectedPath = txtCacheDirectory.Text;
            if (folderBrowserChangeDirectory.ShowDialog() == DialogResult.OK)
            {
                txtCacheDirectory.Text = folderBrowserChangeDirectory.SelectedPath;
            }
        }

        private void btnChangeTempDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserChangeDirectory.SelectedPath = txtTempDirectory.Text;
            if (folderBrowserChangeDirectory.ShowDialog() == DialogResult.OK)
            {
                txtTempDirectory.Text = folderBrowserChangeDirectory.SelectedPath;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            _settings.DirectoriesSettings.DefaultProjectsDirectory = txtDefaultProjectsDirectory.Text;
            _settings.DirectoriesSettings.PluginsDirectory = txtPluginsDirectory.Text;
            _settings.DirectoriesSettings.CacheDirectory = txtCacheDirectory.Text;
            _settings.DirectoriesSettings.TempDirectory = txtTempDirectory.Text;

            ProgramSettings.SaveGlobalSettings();
        }

        #endregion
    }
}
