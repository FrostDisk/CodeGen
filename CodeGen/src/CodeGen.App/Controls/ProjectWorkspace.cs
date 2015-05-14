using System;
using System.Windows.Forms;
using CodeGen.Core;
using CodeGen.Domain;

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
            _activeControl = control;

            panelGenerator.Controls.Clear();            
            panelGenerator.Controls.Add(control);
        }

        #endregion

        #region events
        #endregion
    }
}
