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

namespace CodeGen.App.Controls
{
    public partial class BasicProjectProperties : UserControl
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
        #endregion

        #region events

        private void btnSelectProjectLocation_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
