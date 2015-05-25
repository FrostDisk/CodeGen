using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGen.Configuration;

namespace CodeGen.Controls
{
    public partial class PluginDetails : UserControl
    {
        #region properties
        #endregion

        #region initialization

        public PluginDetails()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        public void LoadType(PluginType type)
        {
            label1.Text = type.Name;
        }

        #endregion

        #region events
        #endregion
    }
}
