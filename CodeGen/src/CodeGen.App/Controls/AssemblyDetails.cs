using System.Windows.Forms;
using CodeGen.Configuration;

namespace CodeGen.Controls
{
    public partial class AssemblyDetails : UserControl
    {
        #region properties

        public PluginAssembly ActiveAssembly { get; set; }

        #endregion

        #region initialization

        public AssemblyDetails()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        public void LoadAssembly(PluginAssembly assembly)
        {
            ActiveAssembly = assembly;

            lblAssemblyName.Text = assembly.File;
        }

        #endregion

        #region events
        #endregion
    }
}
