using System;
using System.Windows.Forms;
using CodeGen.Configuration;
using CodeGen.Controls;
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
            
            UpdateAssemblyList();
        }

        public void UpdateAssemblyList()
        {
            var globalSettings = ProgramSettings.GetGlobalSettings();

            listAssemblyList.Items.Clear();
            foreach (var assembly in globalSettings.PluginsSettings.Plugins)
            {
                var assemblyName = assembly.IsBase ? "(base)" : assembly.File;

                listAssemblyList.Items.Add(new ListViewItem
                {
                    Name = assemblyName,
                    Text = assemblyName,
                    ImageIndex = 0,
                    Tag = assembly
                });
            }
        }

        public void LoadAssembly(PluginAssembly assembly)
        {
            listPluginsList.Items.Clear();
            pnlAssemblyDetails.Controls.Clear();

            if (assembly != null)
            {
                foreach (var type in assembly.Types)
                {
                    var pluginName = type.Name.Substring(type.Name.LastIndexOf(".", StringComparison.Ordinal) + 1);

                    listPluginsList.Items.Add(new ListViewItem
                    {
                        Name = pluginName,
                        Text = pluginName,
                        ImageIndex = 0,
                        Checked = type.Enabled,
                        Tag = type,
                    });
                }

                var control = new AssemblyDetails
                {
                    Dock = DockStyle.Fill
                };
                control.LoadAssembly(assembly);
                pnlAssemblyDetails.Controls.Add(control);
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

        private void listAssemblyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listAssemblyList.SelectedItems.Count > 0)
                {
                    LoadAssembly((PluginAssembly) listAssemblyList.SelectedItems[0].Tag);
                }
                else
                {
                    LoadAssembly(null);
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }
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
                
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ProcessException(ex);
            }
        }

        #endregion
    }
}
