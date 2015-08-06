using CodeGen.Configuration;
using CodeGen.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGen
{
    public partial class FormOptions : Form
    {
        #region properties

        public GlobalSettings _settings { get; set; }

        #endregion

        #region initialization

        public FormOptions()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        public void LoadLocalVariables()
        {
            _settings = ProgramSettings.GetGlobalSettings();

            txtDefaultProjectDirectory.Text = _settings.DirectoriesSettings.DefaultProjectDirectory;
            txtPluginsDirectory.Text = _settings.DirectoriesSettings.PluginsDirectory;
            txtCacheDirectory.Text = _settings.DirectoriesSettings.CacheDirectory;
            txtTempDirectory.Text = _settings.DirectoriesSettings.TempDirectory;
        }

        private bool Validate()
        {
            return true;
        }

        #endregion

        #region events

        private void btnChangeDefaultProjectDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserChangeDirectory.SelectedPath = txtDefaultProjectDirectory.Text;
            if( folderBrowserChangeDirectory.ShowDialog() == DialogResult.OK)
            {
                txtDefaultProjectDirectory.Text = folderBrowserChangeDirectory.SelectedPath;
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
            _settings.DirectoriesSettings.DefaultProjectDirectory = txtDefaultProjectDirectory.Text;
            _settings.DirectoriesSettings.PluginsDirectory = txtPluginsDirectory.Text;
            _settings.DirectoriesSettings.CacheDirectory = txtCacheDirectory.Text;
            _settings.DirectoriesSettings.TempDirectory = txtTempDirectory.Text;

            ProgramSettings.SaveGlobalSettings();
        }

        #endregion
    }
}
