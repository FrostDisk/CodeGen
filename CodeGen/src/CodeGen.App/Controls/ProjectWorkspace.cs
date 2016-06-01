using System;
using System.Windows.Forms;
using CodeGen.Data;
using CodeGen.Domain;

namespace CodeGen.Controls
{
    /// <summary>
    /// ProjectWorkspace
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class ProjectWorkspace : UserControl
    {
        #region properties

        /// <summary>
        /// Project
        /// </summary>
        public Project Project { get; set; }

        /// <summary>
        /// OnProjectChange
        /// </summary>
        public event EventHandler OnProjectChange;

        private IGeneratorUserControl _activeControl;

        #endregion

        #region initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectWorkspace"/> class.
        /// </summary>
        public ProjectWorkspace()
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
        /// Loads the generator.
        /// </summary>
        /// <typeparam name="T"></typeparam>
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
