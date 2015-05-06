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
    public partial class FormGenerateConnectionString : Form
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

        public string GetConnectionString()
        {
            return string.Empty;
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
