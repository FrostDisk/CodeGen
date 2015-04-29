using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGen.Domain;
using CodeGen.Library.System.IO;

namespace CodeGen.App.Controls
{
    public partial class BasicProjectProperties : UserControl, IBaseUserControl
    {
        #region properties

        public string DefaultProjectLocation { get; set; }

        public string DefaultProjectName { get; set; }

        public bool IsLoaded { get; set; }

        #endregion

        #region initialization

        public BasicProjectProperties()
        {
            InitializeComponent();
        }

        private void BasicProjectProperties_Load(object sender, EventArgs e)
        {
        }

        #endregion

        #region methods

        public void LoadLocalVariables()
        {
            if (string.IsNullOrWhiteSpace(DefaultProjectLocation))
            {
                throw new NullReferenceException("DefaultProjectLocation isn't defined");
            }

            if (string.IsNullOrWhiteSpace(DefaultProjectName))
            {
                throw new NullReferenceException("DefaultProjectName isn't defined");
            }

            GenerateProjectFolder();
            LoadDatabaseTypes();
            LoadLanguages();

            IsLoaded = true;
        }

        private void GenerateProjectFolder(int number = 1)
        {
            string projectName = string.IsNullOrWhiteSpace(txtProjectName.Text) ? number == 1 ? DefaultProjectName : string.Format("{0} ({1})", DefaultProjectName, number) : txtProjectName.Text;

            string projectLocation = Path.Combine(DefaultProjectLocation, projectName);
            if (Directory.Exists(projectLocation) && !FolderHelper.IsDirectoryEmpty(projectLocation))
            {
                GenerateProjectFolder(number + 1);
            }

            Directory.CreateDirectory(projectLocation);

            if (string.IsNullOrWhiteSpace(txtProjectName.Text))
            {
                txtProjectName.Text = projectName;
            }
            txtProjectLocation.Text = projectLocation;
        }

        private void LoadDatabaseTypes()
        {
            
        }

        private void LoadLanguages()
        {
            
        }

        public Project GetProject()
        {
            Project project = new Project();

            project.Name = txtProjectName.Text;
            project.Version = Project.ActiveVersion;
            project.Type = DatabaseType.SqlServer;
            project.Description = txtProjectDescription.Text;


            return project;
        }

        public bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtProjectName.Text))
            {
                MessageBoxHelper.ValidationMessage("Project name isn't specified");
                txtProjectName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProjectLocation.Text))
            {
                MessageBoxHelper.ValidationMessage("Project location isn't specified");
                txtProjectLocation.Focus();
                return false;
            }

            if (cmbDatabaseType.SelectedItem == null)
            {
                MessageBoxHelper.ValidationMessage("Database Type isn't specified");
                cmbDatabaseType.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtConnectionString.Text))
            {
                MessageBoxHelper.ValidationMessage("Connection string isn't specified");
                txtConnectionString.Focus();
                return false;
            }

            if (cmbLanguage.SelectedItem == null)
            {
                MessageBoxHelper.ValidationMessage("Language isn't specified");
                cmbLanguage.Focus();
                return false;
            }

            if (!FolderHelper.IsDirectoryEmpty(txtProjectLocation.Text) && !MessageBoxHelper.ValidationQuestion("Selected directory isn't empty. Are you sure you want the project in the selected location?"))
            {
                return false;
            }

            return true;
        }

        #endregion

        #region events

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {
            GenerateProjectFolder();
        }

        private void btnSelectProjectLocation_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtProjectLocation.Text))
            {
                folderBrowserSelectProjectLocation.SelectedPath = txtProjectLocation.Text;
            }

            if (folderBrowserSelectProjectLocation.ShowDialog() == DialogResult.OK)
            {
                txtProjectLocation.Text = folderBrowserSelectProjectLocation.SelectedPath;
            }
        }

        private void btnGenerateConnectionString_Click(object sender, EventArgs e)
        {
            FormGenerateConnectionString form = new FormGenerateConnectionString();

            if (cmbDatabaseType.SelectedItem != null && form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        #endregion
    }
}
