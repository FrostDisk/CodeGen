using System;
using System.Windows.Forms;
using CodeGen.Core;
using CodeGen.Domain;
using CodeGen.Plugin.Base;
using CodeGen.Utils;

namespace CodeGen.Controls
{
    public partial class GenerateCodeFile : UserControl, IGeneratorUserControl
    {
        #region properties

        public Project Project { get; set; }

        public bool IsLoaded { get; set; }

        #endregion

        #region initialization

        public GenerateCodeFile()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        public void LoadLocalVariables()
        {
            cmbDatabaseEntity.Items.Clear();
            cmbDatabaseEntity.Items.AddRange(PluginsManager.GetTableListFromPlugin(Project.ConnectionString, Project.Plugin).ToArray());

            cmbTemplate.Items.Clear();
            cmbTemplate.DataSource = PluginsManager.GetCodeTemplates();
            cmbTemplate.DisplayMember = "Name";
            cmbTemplate.ValueMember = "Name";
            cmbTemplate.SelectedItem = null;
        }

        public bool ValidateForm()
        {
            return true;
        }

        #endregion

        #region events

        private void cmbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTemplate.SelectedItem != null)
            {
                var item = (SupportedType) cmbTemplate.SelectedItem;

                rlstOptions.DataSource = PluginsManager.GetComponents(item);
                rlstOptions.DisplayMember = "Name";
                rlstOptions.ValueMember = "Id";
            }
        }

        private void lnkTemplateOptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveFileAs_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
