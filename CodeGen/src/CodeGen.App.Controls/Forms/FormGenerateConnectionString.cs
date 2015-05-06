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

        private void LoadDatabaseTypes()
        {
            cmbServerType.DataSource = SystemHelper.GetSupportedTypes().DatabaseTypes;
            cmbServerType.DisplayMember = "Name";
            cmbServerType.ValueMember = "Code";
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
            return false;
        }

        #endregion

        #region events

        private void cmbDatabaseName_Enter(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
