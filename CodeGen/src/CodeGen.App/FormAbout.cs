using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGen.Utils;
using CodeGen.Properties;

namespace CodeGen
{
    partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", ProgramInfo.AssemblyTitle);
            this.labelProductName.Text = ProgramInfo.AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", ProgramInfo.AssemblyVersion);
            this.labelCopyright.Text = ProgramInfo.AssemblyCopyright;
            this.labelCompanyName.Text = ProgramInfo.AssemblyCompany;
            this.textBoxDescription.Text = Resources.license_about;
        }

        #region Assembly Attribute Accessors

        #endregion
    }
}
