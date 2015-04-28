using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGen.Utils;

namespace CodeGen
{
    public partial class FormNewProject : Form
    {
        #region properties
        #endregion

        #region initialization

        public FormNewProject()
        {
            InitializeComponent();
            LoadLocalVariables();
            
        }

        #endregion

        #region methods

        public void LoadLocalVariables()
        {
            ucBasicProjectProperties.DefaultProjectLocation = ProgramSettings.GetGlobalSettings().ProjectSettings.DefaultProjectLocation;
            ucBasicProjectProperties.DefaultProjectName = ProgramSettings.GetGlobalSettings().ProjectSettings.DefaultProjectName;
            ucBasicProjectProperties.LoadLocalVariables();
        }

        #endregion

        #region events

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (ucBasicProjectProperties.ValidateForm())
            {
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
