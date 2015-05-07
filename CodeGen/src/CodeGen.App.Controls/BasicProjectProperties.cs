using CodeGen.App.Controls.Classes;
using CodeGen.App.Controls.Forms;
using CodeGen.Data;
using CodeGen.Domain;
using CodeGen.Library.System.IO;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
            txtProjectDirectory.Text = projectLocation;
        }

        private void LoadDatabaseTypes()
        {
            cmbDatabaseType.DataSource = SystemHelper.GetSupportedTypes().DatabaseTypes;
            cmbDatabaseType.DisplayMember = "Name";
            cmbDatabaseType.ValueMember = "Code";
        }

        private void LoadLanguages()
        {
            cmbLanguage.DataSource = SystemHelper.GetSupportedTypes().Languages;
            cmbLanguage.DisplayMember = "Name";
            cmbLanguage.ValueMember = "Code";
        }

        public Project GetProject()
        {
            Project project = ProjectController.CreateEmptyProject(txtProjectName.Text, txtProjectDirectory.Text);

            project.Type = EnumDatabaseTypes.SqlServer;
            project.Description = txtProjectDescription.Text;
            project.ConnectionString = txtConnectionString.Text;

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

            if (string.IsNullOrWhiteSpace(txtProjectDirectory.Text))
            {
                MessageBoxHelper.ValidationMessage("Project location isn't specified");
                txtProjectDirectory.Focus();
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

            if (!FolderHelper.IsDirectoryEmpty(txtProjectDirectory.Text) && !MessageBoxHelper.ValidationQuestion("Selected directory isn't empty. Are you sure you want the project in the selected location?"))
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
            if (!string.IsNullOrWhiteSpace(txtProjectDirectory.Text))
            {
                folderBrowserSelectProjectLocation.SelectedPath = txtProjectDirectory.Text;
            }

            if (folderBrowserSelectProjectLocation.ShowDialog() == DialogResult.OK)
            {
                txtProjectDirectory.Text = folderBrowserSelectProjectLocation.SelectedPath;
            }
        }

        private void btnGenerateConnectionString_Click(object sender, EventArgs e)
        {
            FormGenerateConnectionString form = new FormGenerateConnectionString();
            form.LoadLocalVariables();

            if (cmbDatabaseType.SelectedItem != null)
            {
                form.DatabaseType = (DatabaseType)cmbDatabaseType.SelectedItem;
            }

            if (form.ShowDialog() == DialogResult.OK)
            {
                txtConnectionString.Text = form.GetConnectionString();
                cmbDatabaseType.SelectedItem = form.DatabaseType;
            }
        }

        #endregion
    }
}
