using System;
using System.IO;
using System.Windows.Forms;
using CodeGen.Core;
using CodeGen.Data;
using CodeGen.Domain;
using CodeGen.Library.Formats;
using CodeGen.Library.System.IO;
using CodeGen.Plugin.Base;
using CodeGen.Utils;

namespace CodeGen.Controls
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

            IsLoaded = true;
        }

        private void GenerateProjectFolder(int number = 1)
        {
            string projectName = StringHelper.ConvertToSafeCodeName(string.IsNullOrWhiteSpace(txtProjectName.Text) ? number == 1 ? DefaultProjectName : string.Format("{0} ({1})", DefaultProjectName, number) : txtProjectName.Text, false);

            string projectLocation = Path.Combine(DefaultProjectLocation, projectName);
            if (Directory.Exists(projectLocation) && !FolderHelper.IsDirectoryEmpty(projectLocation))
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProjectName.Text))
            {
                txtProjectName.Text = projectName;
            }
            txtProjectDirectory.Text = projectLocation;
        }

        private void LoadDatabaseTypes()
        {
            cmbDatabaseType.DataSource = PluginsManager.GetSupportedDatabaseControllers();
            cmbDatabaseType.DisplayMember = "Name";
            cmbDatabaseType.ValueMember = "Name";
            cmbDatabaseType.SelectedItem = null;
            btnGenerateConnectionString.Enabled = false;
        }

        public Project GetProject()
        {
            Project project = ProjectController.CreateEmptyProject(txtProjectName.Text, txtProjectDirectory.Text);

            SupportedType item = (SupportedType) cmbDatabaseType.SelectedItem;

            project.Type = PluginsManager.GetDataBaseType(item);
            project.Plugin = new ProjectPlugin
            {
                Assembly = item.Assembly,
                Type = item.Type
            };
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

            if (Directory.Exists(txtProjectDirectory.Text))
            {
                if (!FolderHelper.IsDirectoryEmpty(txtProjectDirectory.Text) && !MessageBoxHelper.ValidationQuestion("Selected directory isn't empty. Are you sure you want the project in the selected location?"))
                {
                    return false;
                }
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
            else
            {
                folderBrowserSelectProjectLocation.SelectedPath = DefaultProjectLocation;
            }

            if (folderBrowserSelectProjectLocation.ShowDialog() == DialogResult.OK)
            {
                txtProjectDirectory.Text = folderBrowserSelectProjectLocation.SelectedPath;
            }
        }

        private void cmbDatabaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDatabaseType.SelectedItem != null)
            {
                btnGenerateConnectionString.Enabled = PluginsManager.CheckIfPluginHaveCustomConnectionStringsForm(cmbDatabaseType.SelectedItem as SupportedType);
                txtConnectionString.ReadOnly = false;
            }
            else
            {
                btnGenerateConnectionString.Enabled = false;
                txtConnectionString.ReadOnly = true;
            }
        }

        private void btnGenerateConnectionString_Click(object sender, EventArgs e)
        {
            var item = cmbDatabaseType.SelectedItem as SupportedType;
            if (item != null)
            {
                var plugin = item.Item as IAccessModelController;
                if (plugin != null)
                {
                    string connectionString;
                    if (plugin.ShowGenerateConnectionStringForm(out connectionString))
                    {
                        txtConnectionString.Text = connectionString;
                    }
                }
            }
        }

        #endregion
    }
}
