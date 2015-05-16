﻿using System;
using System.Windows.Forms;
using CodeGen.Core;
using CodeGen.Data;
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

        public event EventHandler OnControlUpdate;

        public event EventHandler OnSettingsUpdate;

        public PluginSettings Settings
        {
            get
            {
                if (cmbTemplate.SelectedItem != null)
                {
                    return PluginsManager.GetSettingsFromPlugin(cmbTemplate.SelectedItem as SupportedType);
                }
                return null;
            }
        }

        public IGeneratorTemplate ActiveTemplate { get; private set; }

        #endregion

        #region initialization

        public GenerateCodeFile()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        public void UpdateSettings(PluginSettings settings)
        {
            if (cmbTemplate.SelectedItem == null)
            {
                PluginsManager.UpdateSettingsForPlugin(cmbTemplate.SelectedItem as SupportedType, settings);
            }
        }

        public void LoadLocalVariables()
        {
            cmbDatabaseEntity.Items.Clear();
            cmbDatabaseEntity.Items.AddRange(PluginsManager.GetTableListFromPlugin(Project.ConnectionString, Project.Plugin).ToArray());

            cmbTemplate.Items.Clear();
            cmbTemplate.DataSource = PluginsManager.GetSupportedTemplates<ICodeGeneratorTemplate>();
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

                ActiveTemplate = item.Item as IGeneratorTemplate;

                cmbComponent.DataSource = PluginsManager.GetComponents(item);
                cmbComponent.DisplayMember = "Name";
                cmbComponent.ValueMember = "Id";

                lnkTemplateOptions.Visible = PluginsManager.CheckIfPluginHaveOptions(item);

                PluginsManager.UpdateProjectSettingsForPlugin(item, Project);
            }
            else
            {
                ActiveTemplate = null;
                cmbComponent.DataSource = null;
                lnkTemplateOptions.Visible = false;
            }
        }

        private void lnkTemplateOptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cmbTemplate.SelectedItem != null)
            {
                var item = (SupportedType)cmbTemplate.SelectedItem;

                if (PluginsManager.ShowTemplateOptions(item))
                {
                    if (OnSettingsUpdate != null)
                    {
                        OnSettingsUpdate(this, new EventArgs());
                    }

                    if (OnControlUpdate != null)
                    {
                        OnControlUpdate(this, new EventArgs());
                    }
                }
            }
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                txtGeneratedCode.Text = ActiveTemplate.Generate((DatabaseEntity) cmbDatabaseEntity.SelectedItem, (int) cmbComponent.SelectedValue);

                if (OnControlUpdate != null)
                {
                    OnControlUpdate(this, new EventArgs());
                }
            }
        }

        private void cmbComponent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveFileAs_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
