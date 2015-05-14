using System;
using System.Windows.Forms;
using CodeGen.Controls;
using CodeGen.Core;
using CodeGen.Library.AccessModel;
using CodeGen.Utils;

namespace CodeGen
{
    public partial class FormGenerateConnectionString : Form, IBaseForm
    {
        #region properties

        #endregion

        #region initialization

        public FormGenerateConnectionString()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

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
                cmbDatabase.Items.Clear();
                cmbDatabase.Items.AddRange(DatabaseUtils.GetDatabaseList(txtServerName.Text, txtLogin.Text, txtPassword.Text, rbtnWindowsAuthentication.Checked).ToArray());
            }
        }

        public string GetConnectionString()
        {
            return DatabaseUtils.CreateBasicConnectionString(txtServerName.Text, txtLogin.Text, txtPassword.Text, rbtnWindowsAuthentication.Checked, (string) cmbDatabase.SelectedItem);
        }

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
            try
            {
                UpdateDatabaseList();
            }
            catch(Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }
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

        #endregion
    }
}
