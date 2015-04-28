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

        public string ProjectName
        {
            get { return txtProjectName.Text; }
            set { txtProjectName.Text = value; }
        }

        public string ProjectLocation
        {
            get { return txtProjectLocation.Text; }
            set { txtProjectLocation.Text = value; }
        }

        public string ProjectDescription
        {
            get { return txtProjectDescription.Text; }
            set { txtProjectDescription.Text = value; }
        }

        public DatabaseType ProjectDatabaseType { get; set; }

        public Language ProjectLanguage { get; set; }

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

        public bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtProjectName.Text))
            {
                MessageBoxHelper.ValidationMessage("You must write a project name");
                txtProjectName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProjectLocation.Text))
            {
                MessageBoxHelper.ValidationMessage("You must define a project location");
                txtProjectLocation.Focus();
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

        #endregion
    }
}
