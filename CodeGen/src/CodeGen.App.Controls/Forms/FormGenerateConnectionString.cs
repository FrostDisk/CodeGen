using CodeGen.App.Controls.Classes;
using CodeGen.Domain;
using CodeGen.Library.AccessModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGen.App.Controls.Forms
{
    public partial class FormGenerateConnectionString : Form, IBaseForm
    {
        #region properties

        public DatabaseType DatabaseType
        {
            get { return (DatabaseType)cmbDatabaseType.SelectedItem; }
            set { cmbDatabaseType.SelectedItem = value; }
        }

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
            LoadDatabaseTypes();
        }

        private void CleanControls()
        {
            txtDataSource.Clear();
            txtUserID.Clear();
            txtPassword.Clear();
            cmbDatabaseName.Items.Clear();
        }

        private void LoadDatabaseTypes()
        {
            cmbDatabaseType.DataSource = SystemHelper.GetSupportedTypes().DatabaseTypes;
            cmbDatabaseType.DisplayMember = "Name";
            cmbDatabaseType.ValueMember = "Code";
        }

        private void UpdateDatabaseList()
        {
            if(!string.IsNullOrWhiteSpace(txtDataSource.Text)
                && !string.IsNullOrWhiteSpace(txtUserID.Text)
                && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                cmbDatabaseName.Items.Clear();
                cmbDatabaseName.Items.AddRange(DatabaseUtils.GetDatabaseList(txtDataSource.Text, txtUserID.Text, txtPassword.Text).ToArray());
            }
        }

        public string GetConnectionString()
        {
            return DatabaseUtils.CreateBasicConnectionString(txtDataSource.Text, txtUserID.Text, txtPassword.Text, (string)cmbDatabaseName.SelectedItem);
        }

        public bool ValidateForm()
        {
            if(cmbDatabaseType.SelectedItem == null)
            {
                MessageBoxHelper.ValidationMessage("Database type isn't specified");
                return false;
            }

            if(string.IsNullOrWhiteSpace(txtDataSource.Text))
            {
                MessageBoxHelper.ValidationMessage("Data source isn't specified");
                return false;
            }

            if(string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                MessageBoxHelper.ValidationMessage("User ID isn't specified");
                return false;
            }

            if(string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBoxHelper.ValidationMessage("Password isn't specified");
                return false;
            }

            if(cmbDatabaseName.SelectedItem == null)
            {
                MessageBoxHelper.ValidationMessage("Database name isn't specified");
                return false;
            }

            return true;
        }

        #endregion

        #region events

        private void cmbDatabaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CleanControls();
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }
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
