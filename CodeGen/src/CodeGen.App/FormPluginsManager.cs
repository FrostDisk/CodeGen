using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CodeGen.Configuration;
using CodeGen.Controls;
using CodeGen.Utils;
using NLog;
using System.Linq;

namespace CodeGen
{
    /// <summary>
    /// Plugin Manager Form Dialog
    /// </summary>
    /// <seealso cref="Form" />
    public partial class FormPluginsManager : Form
    {
        #region properties

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="FormPluginsManager"/> class.
        /// </summary>
        public FormPluginsManager()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        /// <summary>
        /// Loads the local variables.
        /// </summary>
        public void LoadLocalVariables()
        {
        }

        /// <summary>
        /// Enables the controls.
        /// </summary>
        /// <param name="enable">if set to <c>true</c> [enable].</param>
        public void EnableControls(bool enable)
        {
            listPluginsList.Enabled = enable;

            btnImportPlugins.Enabled = enable;
            btnClose.Enabled = enable;
        }

        /// <summary>
        /// Updates the assembly list.
        /// </summary>
        public void UpdateAssemblyList()
        {
            var globalSettings = ProgramSettings.GetGlobalSettings();

            listPluginsList.Items.Clear();
            listPluginsList.Groups.Clear();
            foreach (var assembly in globalSettings.Assemblies)
            {
                ListViewGroup lstViewGroup = new ListViewGroup();

                lstViewGroup = new ListViewGroup(assembly.Title, HorizontalAlignment.Left);

                listPluginsList.Groups.Add(lstViewGroup);

                foreach (var type in assembly.Plugins)
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

                    item.Group = lstViewGroup;

                    listPluginsList.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Loads the plugin.
        /// </summary>
        /// <param name="type">The type.</param>
        public void LoadPlugin(Configuration.GlobalPlugin type)
        {
            pnlPluginDetails.Controls.Clear();

            if (type != null)
            {
                var control = new PluginDetails
                {
                    Dock = DockStyle.Fill
                };
                control.LoadComponent(type);

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
                    LoadPlugin((Configuration.GlobalPlugin)listPluginsList.SelectedItems[0].Tag);
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
                var type = (Configuration.GlobalPlugin) e.Item.Tag;
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

        private void workerCheckPlugins_DoWork(object sender, DoWorkEventArgs e)
        {
            PluginsManager.UpdatePluginList();
            PluginsManager.CheckExistingPlugins();
        }

        private void workerCheckPlugins_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBoxHelper.ProcessException(e.Error);
            }

            EnableControls(true);
            progressBarCheckPlugins.Visible = false;

            UpdateAssemblyList();
        }

        private void workerImportPlugins_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string fileName in openDialogImportPlugins.FileNames)
            {
                PluginsManager.ImportPlugin(fileName);
            }

            PluginsManager.UpdatePluginList();
            PluginsManager.CheckExistingPlugins();
        }

        private void workerImportPlugins_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBoxHelper.ProcessException(e.Error);
            }

            EnableControls(true);
            progressBarCheckPlugins.Visible = false;

            UpdateAssemblyList();

            ProgramSettings.SaveGlobalSettings();
        }

        #endregion
    }
}
