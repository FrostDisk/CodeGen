using System;
using System.Windows.Forms;
using CodeGen.Plugin.Base;
using CodeGen.Plugin.MySql.Utils;

namespace CodeGen.Plugin.MySql
{
    public partial class FormGenerateConnectionString : Form, IConnectionStringForm
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
            txtServer.Clear();
            txtUserID.Clear();
            txtPassword.Clear();
            cmbDatabase.Items.Clear();
        }

        private void UpdateDatabaseList()
        {
            if (!string.IsNullOrWhiteSpace(txtServer.Text)
                && !string.IsNullOrWhiteSpace(txtUserID.Text)
                && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                cmbDatabase.Items.Clear();
                cmbDatabase.Items.AddRange(DatabaseUtils.GetDatabaseList(txtServer.Text, txtUserID.Text, txtPassword.Text).ToArray());
            }
        }

        public string GetConnectionString()
        {
            return DatabaseUtils.CreateBasicConnectionString(txtServer.Text, txtUserID.Text, txtPassword.Text, (string)cmbDatabase.SelectedItem);
        }

        public bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtServer.Text))
            {
                MessageBoxHelper.ValidationMessage("Property Server was not set");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                MessageBoxHelper.ValidationMessage("Property User ID was not set");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBoxHelper.ValidationMessage("Property Password was not set");
                return false;
            }

            if (cmbDatabase.SelectedItem == null)
            {
                MessageBoxHelper.ValidationMessage("Property Database was not set");
                return false;
            }

            return true;
        }

        #endregion

        #region events

        private void cmbDatabase_Enter(object sender, EventArgs e)
        {
            try
            {
                UpdateDatabaseList();
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
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
