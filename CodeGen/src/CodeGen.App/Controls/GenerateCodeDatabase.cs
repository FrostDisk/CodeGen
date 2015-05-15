using System.Windows.Forms;
using CodeGen.Core;
using CodeGen.Domain;
using System;
using CodeGen.Plugin.Base;

namespace CodeGen.Controls
{
    public partial class GenerateCodeDatabase : UserControl, IGeneratorUserControl
    {
        #region properties

        public Project Project { get; set; }

        public bool IsLoaded { get; set; }

        public event EventHandler OnControlUpdate;

        public event EventHandler OnSettingsUpdate;

        public PluginSettings Settings
        {
            get { throw new NotImplementedException(); }
        }

        public IGeneratorTemplate ActiveTemplate { get; private set; }

        #endregion

        #region initialization

        public GenerateCodeDatabase()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        public void UpdateSettings(PluginSettings settings)
        {
            throw new NotImplementedException();
        }

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
