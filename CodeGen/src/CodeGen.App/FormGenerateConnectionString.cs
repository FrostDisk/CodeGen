using System;
using System.Windows.Forms;
using CodeGen.Library.AccessModel;
using CodeGen.Plugin.Base;
using CodeGen.Utils;
using NLog;

namespace CodeGen
{
    /// <summary>
    /// Generate ConnectionString Form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="CodeGen.Plugin.Base.IConnectionStringForm" />
    public partial class FormGenerateConnectionString : Form, IConnectionStringForm
    {
        #region properties

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="FormGenerateConnectionString"/> class.
        /// </summary>
        public FormGenerateConnectionString()
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
            
        }

        private void CleanControls()
        {
            txtServerName.Clear();
            txtLogin.Clear();
            txtPassword.Clear();
            cmbDatabase.Items.Clear();
        }

        private void UpdateAuthenticationControls()
        {
            txtLogin.Enabled = rbtnSqlServerAuthentication.Checked;
            txtPassword.Enabled = rbtnSqlServerAuthentication.Checked;
        }

        private void UpdateDatabaseList()
        {
            if (!string.IsNullOrWhiteSpace(txtServerName.Text)
                && ((!string.IsNullOrWhiteSpace(txtLogin.Text)
                     && !string.IsNullOrWhiteSpace(txtPassword.Text)
                     && rbtnSqlServerAuthentication.Checked)
                    || rbtnWindowsAuthentication.Checked))
            {
                Invoke((MethodInvoker)delegate
                {
                    cmbDatabase.Items.Clear();
                    cmbDatabase.Items.AddRange(DatabaseUtils.GetDatabaseList(txtServerName.Text, txtLogin.Text, txtPassword.Text, rbtnWindowsAuthentication.Checked).ToArray());
                });
            }
        }

        /// <summary>
        /// Gets the connection string.
        /// </summary>
        /// <returns></returns>
        public string GetConnectionString()
        {
            return DatabaseUtils.CreateBasicConnectionString(txtServerName.Text, txtLogin.Text, txtPassword.Text, rbtnWindowsAuthentication.Checked, (string) cmbDatabase.SelectedItem);
        }

        private void EnableControls(bool enable)
        {
            txtServerName.Enabled = enable;
            pnlAuthentication.Enabled = enable;

            txtLogin.Enabled = enable && rbtnSqlServerAuthentication.Checked;
            txtPassword.Enabled = enable && rbtnSqlServerAuthentication.Checked;

            btnAccept.Enabled = enable;
            btnCancel.Enabled = enable;
        }

        /// <summary>
        /// Validates the form.
        /// </summary>
        /// <returns></returns>
        public bool ValidateForm()
        {
            if(string.IsNullOrWhiteSpace(txtServerName.Text))
            {
                MessageBoxHelper.ValidationMessage("Property Server Name was not set");
                return false;
            }

            if (rbtnSqlServerAuthentication.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtLogin.Text))
                {
                    MessageBoxHelper.ValidationMessage("Property Login was not set");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBoxHelper.ValidationMessage("Property Password was not set");
                    return false;
                }
            }

            if(cmbDatabase.SelectedItem == null)
            {
                MessageBoxHelper.ValidationMessage("Property Database was not set");
                return false;
            }

            return true;
        }

        #endregion

        #region events

        private void rbtnWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAuthenticationControls();
        }

        private void rbtnSqlServerAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAuthenticationControls();
        }

        private void cmbDatabaseName_Enter(object sender, EventArgs e)
        {
            EnableControls(false);
            workerLoadDatabases.RunWorkerAsync();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidateForm())
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void workerLoadDatabases_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            UpdateDatabaseList();
        }

        private void workerLoadDatabases_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if( e.Error != null)
            {
                MessageBoxHelper.ProcessException(e.Error);
            }

            EnableControls(true);
        }

        #endregion
    }
}
