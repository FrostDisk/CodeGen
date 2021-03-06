﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CodeGen.Core;
using CodeGen.Domain;
using CodeGen.Plugin.Base;
using CodeGen.Utils;
using System.IO;
using NLog;
using static CodeGen.Controls.ProjectWorkspace;
using CodeGen.Data;

namespace CodeGen.Controls
{
    /// <summary>
    /// GenerateCodeFile
    /// </summary>
    /// <seealso cref="UserControl" />
    /// <seealso cref="IGeneratorUserControl" />
    public partial class GenerateCodeFile : UserControl, IGeneratorUserControl
    {
        #region properties

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Project
        /// </summary>
        public Project Project { get; set; }

        /// <summary>
        /// IsLoaded
        /// </summary>
        public bool IsLoaded { get; set; }

        /// <summary>
        /// Occurs when [on control update].
        /// </summary>
        public event EventHandler OnControlUpdate;

        /// <summary>
        /// Occurs when [on settings update].
        /// </summary>
        public event EventHandler OnSettingsUpdate;

        /// <summary>
        /// Gets the settings.
        /// </summary>
        public PluginSettings Settings
        {
            get
            {
                if (cmbTemplate.SelectedItem != null)
                {
                    return PluginsManager.GetSettingsFromPlugin((SupportedPluginComponent)cmbTemplate.SelectedItem);
                }
                return null;
            }
        }

        /// <summary>
        /// Gets the active template.
        /// </summary>
        /// <value>
        /// The active template.
        /// </value>
        public IGeneratorTemplate ActiveTemplate { get; private set; }

        private Dictionary<string, DatabaseEntity> _entities;

        #endregion

        #region initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateCodeFile"/> class.
        /// </summary>
        public GenerateCodeFile()
        {
            InitializeComponent();

            _entities = new Dictionary<string, DatabaseEntity>();
        }

        #endregion

        #region methods

        /// <summary>
        /// Updates the settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public void UpdateSettings(PluginSettings settings)
        {
            if (cmbTemplate.SelectedItem == null)
            {
                PluginsManager.UpdateSettingsForPlugin((SupportedPluginComponent)cmbTemplate.SelectedItem, settings);
            }
        }

        /// <summary>
        /// Loads the local variables.
        /// </summary>
        public void LoadLocalVariables()
        {
            cmbDatabaseEntity.Items.Clear();
            cmbDatabaseEntity.Items.AddRange(PluginsManager.GetTableListFromPlugin(Project.Controller).ToArray());

            cmbTemplate.Items.Clear();
            cmbTemplate.DataSource = PluginsManager.GetSupportedTemplates<ICodeGeneratorTemplate>(Project.Controller);
            cmbTemplate.DisplayMember = "Name";
            cmbTemplate.ValueMember = "Name";
        }

        /// <summary>
        /// Validates the form.
        /// </summary>
        /// <returns></returns>
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
            if (ActiveTemplate != null && cmbDatabaseEntity.SelectedItem != null)
            {
                string entityItem = (string)cmbDatabaseEntity.SelectedItem;

                DatabaseEntity entity;
                if (!_entities.TryGetValue(entityItem, out entity))
                {
                    entity = PluginsManager.GetEntityInfoFromPlugin(Project.Controller, entityItem);
                    _entities[entityItem] = entity;
                }

                txtFileName.Text = ActiveTemplate.GenerateFileName(entity, (GeneratorComponent)cmbComponent.SelectedItem);
            }
            else
            {
                txtFileName.Text = string.Empty;
            }
        }

        private void EnableButtons()
        {
            bool enable = cmbDatabaseEntity.SelectedItem != null && cmbTemplate.SelectedItem != null && cmbComponent.SelectedItem != null;

            btnGenerateCode.Enabled = enable;
            btnSaveFileAs.Enabled = enable && !string.IsNullOrWhiteSpace(txtGeneratedCode.Text);
            chkCopyToClipboard.Enabled = enable;
        }

        #endregion

        #region events

        private void cmbDatabaseEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateFileName();

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
                    var item = (SupportedPluginComponent) cmbTemplate.SelectedItem;

                    ActiveTemplate = (IGeneratorTemplate) item.Item;

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
                    var templateItem = (SupportedPluginComponent) cmbTemplate.SelectedItem;

                    if (PluginsManager.ShowTemplateOptions(templateItem))
                    {
                        OnSettingsUpdate?.Invoke(this, new EventArgs());

                        OnControlUpdate?.Invoke(this, new EventArgs());

                        UpdateFileName();
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
                UpdateFileName();

                EnableButtons();
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    string tableName = (string) cmbDatabaseEntity.SelectedItem;

                    DatabaseEntity entity;
                    if (!_entities.TryGetValue(tableName, out entity))
                    {
                        entity = PluginsManager.GetEntityInfoFromPlugin(Project.Controller, tableName);
                        _entities[tableName] = entity;
                    }

                    var component = (GeneratorComponent)cmbComponent.SelectedItem;

                    var code = ActiveTemplate.Generate(entity, component);

                    if (!string.IsNullOrWhiteSpace(code))
                    {
                        txtGeneratedCode.Text = code;

                        ProjectsController.SaveCodeToProject(ActiveTemplate, component, Project, tableName, code, txtFileName.Text);

                        OnControlUpdate?.Invoke(this, new EventArgs());

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
                var component = (GeneratorComponent)cmbComponent.SelectedItem;

                saveDialogGeneratedCode.Filter = DefaultFilters.Filters[component.Extension];
                saveDialogGeneratedCode.FileName = txtFileName.Text;

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
