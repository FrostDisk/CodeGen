using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGen.Domain;

namespace CodeGen.App.Controls
{
    public partial class ProjectWorkspace : UserControl
    {
        #region properties

        public Project Project { get; set; }

        public event EventHandler OnProjectChange;

        #endregion

        #region initialization

        public ProjectWorkspace()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        public void LoadLocalVariables()
        {

        }

        #endregion

        #region events
        #endregion
    }
}
