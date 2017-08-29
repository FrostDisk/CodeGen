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
using NLog;

namespace CodeGen.Controls
{
    /// <summary>
    /// BasicProjectProperties
    /// </summary>
    /// <seealso cref="UserControl" />
    /// <seealso cref="IBaseUserControl" />
    public partial class BasicProjectProperties : UserControl, IBaseUserControl
    {
        #region properties

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Gets or sets the default project location.
        /// </summary>
        public string DefaultProjectLocation { get; set; }

        /// <summary>
        /// Gets or sets the default name of the project.
        /// </summary>
        public string DefaultProjectName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is loaded.
        /// </summary>
        public bool IsLoaded { get; set; }

        #endregion

        #region initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicProjectProperties"/> class.
        /// </summary>
        public BasicProjectProperties()
        {
            InitializeComponent();
        }

        private void BasicProjectProperties_Load(object sender, EventArgs e)
        {
        }

        #endregion

        #region methods

        /// <summary>
        /// Loads the local variables.
        /// </summary>
        /// <exception cref="System.NullReferenceException">
        /// DefaultProjectLocation isn't defined
        /// or
        /// DefaultProjectName isn't defined
        /// </exception>
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

        /// <summary>
        /// Enables the controls.
        /// </summary>
        /// <param name="enable">if set to <c>true</c> [enable].</param>
        public void EnableControls(bool enable)
        {
            txtProjectName.Enabled = enable;
            btnSelectProjectLocation.Enabled = enable;

            txtProjectDescription.Enabled = enable;
            cmbDatabaseType.Enabled = enable;

            txtConnectionString.Enabled = enable;
            btnGenerateConnectionString.Enabled = enable && cmbDatabaseType.SelectedItem != null;
        }

        private void GenerateProjectFolder(int number = 1)
        {
            string baseProjectName = string.IsNullOrWhiteSpace(txtProjectName.Text) ? DefaultProjectName : txtProjectName.Text;
            string projectName = number == 1 ? baseProjectName : string.Format("{0} ({1})", baseProjectName, number);

            string safeProjectName = StringHelper.ConvertToSafeFileName(projectName);

            if (!string.IsNullOrWhiteSpace(safeProjectName))
            {
                string projectLocation = Path.Combine(DefaultProjectLocation, safeProjectName);
                if (Directory.Exists(projectLocation) && !FolderHelper.IsDirectoryEmpty(projectLocation))
                {
                    GenerateProjectFolder(number + 1);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtProjectName.Text))
                {
                    txtProjectName.Text = projectName;
                }
                txtProjectDirectory.Text = projectLocation;
            }
        }

        private void LoadDatabaseTypes()
        {
            cmbDatabaseType.DataSource = PluginsManager.GetSupportedAccessModelControllers();
            cmbDatabaseType.DisplayMember = "Name";
            cmbDatabaseType.ValueMember = "Name";
            cmbDatabaseType.SelectedItem = null;
            btnGenerateConnectionString.Enabled = false;
        }

        /// <summary>
        /// Gets the project.
        /// </summary>
        /// <returns></returns>
        public Project GetProject()
        {
            Project project = ProjectController.CreateEmptyProject(txtProjectName.Text, txtProjectDirectory.Text);

            SupportedPluginComponent item = (SupportedPluginComponent) cmbDatabaseType.SelectedItem;

            project.Type = PluginsManager.GetDataBaseType(item);
            project.Controller = new ProjectAccessModelController
            {
                Guid = item.Guid,
                Plugin = item.Type,
                ConnectionString = txtConnectionString.Text,
                Encrypt = chkEncrypt.Checked
            };
            project.Description = txtProjectDescription.Text;

            return project;
        }

        /// <summary>
        /// Validates the form.
        /// </summary>
        /// <returns></returns>
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

            bool _dataBaseTypeSelected = false;
            Invoke((MethodInvoker)delegate
            {
                _dataBaseTypeSelected = cmbDatabaseType.SelectedItem == null;
            });

            if (_dataBaseTypeSelected)
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
            else
            {
                SupportedPluginComponent item = null;
                Invoke((MethodInvoker)delegate
                {
                    item = cmbDatabaseType.SelectedItem as SupportedPluginComponent;
                });

                if (item != null)
                {
                    var plugin = item.Item as IAccessModelController;
                    if (plugin != null)
                    {
                        if(!plugin.CheckConnection(txtConnectionString.Text))
                        {
                            return false;
                        }
                    }
                }
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
                btnGenerateConnectionString.Enabled = PluginsManager.CheckIfPluginHaveCustomConnectionStringsForm(cmbDatabaseType.SelectedItem as SupportedPluginComponent);
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
            var item = cmbDatabaseType.SelectedItem as SupportedPluginComponent;
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
