using System.Windows.Forms;
using CodeGen.Core;
using CodeGen.Domain;

namespace CodeGen.Controls
{
    public partial class GenerateCodeDatabase : UserControl, IGeneratorUserControl
    {
        #region properties

        public Project Project { get; set; }

        public bool IsLoaded { get; set; }

        #endregion

        #region initialization

        public GenerateCodeDatabase()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        public void LoadLocalVariables()
        {
            throw new System.NotImplementedException();
        }

        public bool ValidateForm()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region events
        #endregion
    }
}
