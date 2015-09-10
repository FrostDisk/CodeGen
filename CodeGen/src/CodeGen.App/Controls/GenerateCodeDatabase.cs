using System.Windows.Forms;
using CodeGen.Core;
using CodeGen.Domain;
using System;
using System.Collections.Generic;
using CodeGen.Plugin.Base;
using CodeGen.Utils;
using System.IO;

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

        private Dictionary<string, DatabaseEntity> _entities;

        #endregion

        #region initialization

        public GenerateCodeDatabase()
        {
            InitializeComponent();

            _entities = new Dictionary<string, DatabaseEntity>();
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
            cmbTemplate.DataSource = PluginsManager.GetSupportedTemplates<IQueryGeneratorTemplate>();
            cmbTemplate.DisplayMember = "Name";
            cmbTemplate.ValueMember = "Name";
        }

        public bool ValidateForm()
        {
            if (cmbDatabaseEntity.SelectedItem == null)
            {
                MessageBoxHelper.ValidationMessage("Select Database Entity");
                return false;
            }

            if (cmbTemplate.SelectedItem == null)
            {
                MessageBoxHelper.ValidationMessage("Select Template Plugin");
                return false;
            }

            if (cmbComponent.SelectedItem == null)
            {
                MessageBoxHelper.ValidationMessage("Select Template Component");
                return false;
            }

            return true;
        }

        private void UpdateFileName()
        {
            string entityItem = (string)cmbDatabaseEntity.SelectedItem;

            DatabaseEntity entity;
            if (!_entities.TryGetValue(entityItem, out entity))
            {
                entity = PluginsManager.GetEntityInfoFromPlugin(Project.ConnectionString, Project.Plugin, entityItem);
                _entities[entityItem] = entity;
            }

            txtFileName.Text = ActiveTemplate.GenerateFileName(entity, (int)cmbComponent.SelectedValue);
        }

        private void EnableButtons()
        {
            bool enable = cmbDatabaseEntity.SelectedItem != null && cmbTemplate.SelectedItem != null && cmbComponent.SelectedItem != null;

            btnGenerateScript.Enabled = enable;
            btnSaveFileAs.Enabled = enable && !string.IsNullOrWhiteSpace(txtGeneratedCode.Text);
            chkCopyToClipboard.Enabled = enable;
        }

        #endregion

        #region events

        private void cmbDatabaseEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                EnableButtons();
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void cmbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTemplate.SelectedItem != null)
                {
                    var item = (SupportedType)cmbTemplate.SelectedItem;

                    ActiveTemplate = (IGeneratorTemplate)item.Item;

                    if (!ActiveTemplate.IsLoaded)
                    {
                        ActiveTemplate.Load(Project.Name);
                    }

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

                EnableButtons();
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void lnkTemplateOptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (cmbTemplate.SelectedItem != null)
                {
                    var templateItem = (SupportedType)cmbTemplate.SelectedItem;

                    if (PluginsManager.ShowTemplateOptions(templateItem))
                    {
                        if (OnSettingsUpdate != null)
                        {
                            OnSettingsUpdate(this, new EventArgs());
                        }

                        if (OnControlUpdate != null)
                        {
                            OnControlUpdate(this, new EventArgs());
                        }

                        if (cmbDatabaseEntity.SelectedItem != null)
                        {
                            UpdateFileName();
                        }
                    }
                }

                EnableButtons();
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void cmbComponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ActiveTemplate != null && cmbDatabaseEntity.SelectedItem != null)
                {
                    UpdateFileName();
                }

                EnableButtons();
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void btnGenerateScript_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    string tableName = (string)cmbDatabaseEntity.SelectedItem;

                    DatabaseEntity entity;
                    if (!_entities.TryGetValue(tableName, out entity))
                    {
                        entity = PluginsManager.GetEntityInfoFromPlugin(Project.ConnectionString, Project.Plugin, tableName);
                        _entities[tableName] = entity;
                    }

                    var code = ActiveTemplate.Generate(entity, (int)cmbComponent.SelectedValue);

                    if (!string.IsNullOrWhiteSpace(code))
                    {
                        txtGeneratedCode.Text = code;

                        if (OnControlUpdate != null)
                        {
                            OnControlUpdate(this, new EventArgs());
                        }

                        if (chkCopyToClipboard.Checked)
                        {
                            txtGeneratedCode.SelectAll();
                            txtGeneratedCode.Copy();

                            MessageBox.Show("Copied to Clipboard", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                EnableButtons();
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void btnSaveFileAs_Click(object sender, EventArgs e)
        {
            try
            {
                saveDialogGeneratedCode.Filter = ActiveTemplate.FileNameFilter;
                saveDialogGeneratedCode.FileName = txtFileName.Text;

                saveDialogGeneratedCode.ShowDialog();

                if (saveDialogGeneratedCode.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveDialogGeneratedCode.FileName, txtGeneratedCode.Text);

                    MessageBoxHelper.ShowGeneratedFileMessage(saveDialogGeneratedCode.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }
        }

        #endregion
    }
}
