using System;
using System.Drawing;
using System.Windows.Forms;
using CodeGen.Configuration;
using CodeGen.Controls;
using CodeGen.Plugin.Base;
using CodeGen.Utils;

namespace CodeGen
{
    public partial class FormPluginsManager : Form
    {
        #region properties

        #endregion

        #region initialization

        public FormPluginsManager()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        public void LoadLocalVariables()
        {
        }

        public void EnableControls(bool enable)
        {
            listPluginsList.Enabled = enable;

            btnImportPlugins.Enabled = enable;
            btnClose.Enabled = enable;
        }

        public void UpdateAssemblyList()
        {
            var globalSettings = ProgramSettings.GetGlobalSettings();

            listPluginsList.Items.Clear();
            listPluginsList.Groups.Clear();
            foreach (var assembly in globalSettings.PluginsSettings.Plugins)
            {
                var lstViewGroup = new ListViewGroup(assembly.Title, HorizontalAlignment.Left);
                if (!assembly.IsBase)
                {
                    listPluginsList.Groups.Add(lstViewGroup);
                }

                foreach (var type in assembly.Types)
                {
                    var item = new ListViewItem();
                    item.Name = type.Title;
                    item.Text = type.Title;
                    item.ImageKey = type.Base;
                    item.Checked = type.Enabled;
                    item.Tag = type;
                    if (!type.IsValid)
                    {
                        item.Font = new Font(item.Font, FontStyle.Strikeout);
                    }

                    if (!assembly.IsBase)
                    {
                        item.Group = lstViewGroup;
                    }

                    listPluginsList.Items.Add(item);
                }
            }
        }

        public void LoadPlugin(PluginType type)
        {
            pnlPluginDetails.Controls.Clear();

            if (type != null)
            {
                var control = new PluginDetails
                {
                    Dock = DockStyle.Fill
                };
                control.LoadType(type);

                pnlPluginDetails.Controls.Add(control);
            }
        }

        #endregion

        #region events

        private void FormPluginsManager_Load(object sender, EventArgs e)
        {
            EnableControls(false);
            progressBarCheckPlugins.Visible = true;
            workerCheckPlugins.RunWorkerAsync();
        }

        private void listPluginsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listPluginsList.SelectedItems.Count > 0)
                {
                    LoadPlugin((PluginType) listPluginsList.SelectedItems[0].Tag);
                }
                else
                {
                    LoadPlugin(null);
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void listPluginsList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                var type = (PluginType) e.Item.Tag;
                type.Enabled = e.Item.Checked;
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void btnImportPlugins_Click(object sender, EventArgs e)
        {
            try
            {
                if (openDialogImportPlugins.ShowDialog() == DialogResult.OK)
                {
                    EnableControls(false);
                    progressBarCheckPlugins.Visible = true;
                    workerImportPlugins.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void workerCheckPlugins_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            PluginsManager.UpdatePluginList();
            PluginsManager.CheckExistingPlugins();
        }

        private void workerCheckPlugins_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            EnableControls(true);
            progressBarCheckPlugins.Visible = false;

            UpdateAssemblyList();
        }

        private void workerImportPlugins_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            foreach (string fileName in openDialogImportPlugins.FileNames)
            {
                PluginsManager.ImportPlugin(fileName);
            }

            PluginsManager.UpdatePluginList();
            PluginsManager.CheckExistingPlugins();
        }

        private void workerImportPlugins_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            EnableControls(true);
            progressBarCheckPlugins.Visible = false;

            UpdateAssemblyList();
        }

        #endregion
    }
}
