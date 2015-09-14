using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGen.Domain;
using CodeGen.Utils;

namespace CodeGen
{
    public partial class FormNewProject : Form
    {
        #region properties

        public Project Project { get; private set; }

        private bool _validationResult;

        #endregion

        #region initialization

        public FormNewProject()
        {
            InitializeComponent();           
        }

        #endregion

        #region methods

        public void LoadLocalVariables()
        {
            ucBasicProjectProperties.DefaultProjectLocation = ProgramSettings.GetGlobalSettings().DirectoriesSettings.DefaultProjectsDirectory;
            ucBasicProjectProperties.DefaultProjectName = ProgramSettings.GetGlobalSettings().ProjectSettings.DefaultProjectName;
            ucBasicProjectProperties.LoadLocalVariables();
        }

        private void EnableControls(bool enable)
        {
            ucBasicProjectProperties.EnableControls(enable);
            btnAccept.Enabled = enable;
            btnCancel.Enabled = enable;
        }

        #endregion

        #region events

        private void btnAccept_Click(object sender, EventArgs e)
        {
            EnableControls(false);

            _validationResult = false;
            workerValidateForm.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void workerValidateForm_DoWork(object sender, DoWorkEventArgs e)
        {
            _validationResult = ucBasicProjectProperties.ValidateForm();
        }

        private void workerValidateForm_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableControls(true);

            if (_validationResult)
            {
                Project = ucBasicProjectProperties.GetProject();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        #endregion
    }
}
