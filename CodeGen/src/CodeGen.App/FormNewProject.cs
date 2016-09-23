using System;
using System.ComponentModel;
using System.Windows.Forms;
using CodeGen.Domain;
using CodeGen.Utils;

namespace CodeGen
{
    /// <summary>
    /// Form Dialog with 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormNewProject : Form
    {
        #region properties

        /// <summary>
        /// Project object Instance
        /// </summary>
        public Project Project { get; private set; }

        private bool _validationResult;

        #endregion

        #region initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="FormNewProject"/> class.
        /// </summary>
        public FormNewProject()
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
