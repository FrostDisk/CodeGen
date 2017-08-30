using CodeGen.Data;
using CodeGen.Domain;
using NLog;
using System;
using System.IO;
using System.Windows.Forms;

namespace CodeGen.Controls
{
    /// <summary>
    /// ProjectWorkspace
    /// </summary>
    /// <seealso cref="UserControl" />
    public partial class ProjectWorkspace : UserControl
    {
        #region properties

        private static Logger _logger = LogManager.GetCurrentClassLogger();

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
            _logger.Trace("ProjectWorkspace.LoadLocalVariables()");

            UpdateTreeView();
        }

        /// <summary>
        /// Loads the generator.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void LoadGenerator<T>() where T : UserControl, IGeneratorUserControl, new()
        {
            _logger.Trace("ProjectWorkspace.LoadGenerator()");

            if (_activeControl != null)
            {
                // Unload
            }

            T control = new T();
            control.Project = Project;
            control.LoadLocalVariables();
            control.Dock = DockStyle.Fill;
            control.OnControlUpdate += control_OnControlUpdate;
            control.OnSettingsUpdate += control_OnSettingsUpdate;
            _activeControl = control;

            UpdateTreeView();

            panelWorkspace.Controls.Clear();            
            panelWorkspace.Controls.Add(control);
        }

        private void UpdateTreeView()
        {
            _logger.Trace("ProjectWorkspace.UpdateTreeView()");

            var node = treeViewProject.Nodes[0];
            node.Text = Project.Name;

            foreach (var entity in Project.Entities)
            {
                var entityNodes = node.Nodes.Find(entity.Name, false);

                TreeNode entityNode;

                if (entityNodes.Length == 0)
                {
                    entityNode = node.Nodes.Add(entity.Name, entity.Name, "entity", "entity");
                }
                else
                {
                    entityNode = entityNodes[0];
                }

                foreach (var file in entity.Files)
                {
                    var fileNodes = entityNode.Nodes.Find(file.File, false);

                    if (fileNodes.Length == 0)
                    {
                        var extension = Path.GetExtension(file.File);

                        if (!imageListTreeViewProject.Images.ContainsKey(extension))
                        {
                            var icon = ProjectsController.GetImageFromFile(Project, entity, file);

                            imageListTreeViewProject.Images.Add(extension, icon);
                        }

                        entityNode.Nodes.Add(file.File, file.File, extension, extension);
                    }
                }
            }

            treeViewProject.ExpandAll();
            treeViewProject.Sort();
        }

        #endregion

        #region events

        private void control_OnControlUpdate(object sender, EventArgs e)
        {
            _logger.Trace("ProjectWorkspace.control_OnControlUpdate()");

            Project.IsUnsaved = true;

            UpdateTreeView();

            OnProjectChange?.Invoke(this, new EventArgs());
        }

        private void control_OnSettingsUpdate(object sender, EventArgs e)
        {
            _logger.Trace("ProjectWorkspace.control_OnSettingsUpdate()");

            ProjectsController.UpdatePluginSettings(Project, _activeControl.ActiveTemplate);

            Project.IsUnsaved = true;

            OnProjectChange?.Invoke(this, new EventArgs());
        }

        #endregion
    }
}
