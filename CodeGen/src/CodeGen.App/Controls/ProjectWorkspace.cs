using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CodeGen.Core;
using CodeGen.Data;
using CodeGen.Domain;
using CodeGen.Utils;

namespace CodeGen.Controls
{
    public partial class ProjectWorkspace : UserControl
    {
        #region properties

        public Project Project { get; set; }

        public event EventHandler OnProjectChange;

        private IGeneratorUserControl _activeControl;

        #endregion

        #region initialization

        public ProjectWorkspace()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        public void LoadLocalVariables()
        {

        }

        public void LoadGenerator<T>() where T : UserControl, IGeneratorUserControl, new()
        {
            if (_activeControl != null)
            {
                // Unload
            }

            T control = new T();
            control.Project = Project;
            control.LoadLocalVariables();
            control.Dock = DockStyle.Fill;
            control.OnSettingsUpdate += control_OnSettingsUpdate;
            _activeControl = control;

            panelWorkspace.Controls.Clear();            
            panelWorkspace.Controls.Add(control);
        }

        #endregion

        #region events

        private void control_OnSettingsUpdate(object sender, EventArgs e)
        {
            ProjectController.UpdatePluginSettings(Project, _activeControl.ActiveTemplate);
        }

        #endregion
    }
}
