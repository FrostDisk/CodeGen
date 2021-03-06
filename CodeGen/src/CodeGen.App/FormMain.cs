﻿using CodeGen.Domain;
using CodeGen.Data;
using CodeGen.Properties;
using System;
using System.IO;
using System.Windows.Forms;
using CodeGen.Controls;
using CodeGen.Utils;
using System.ComponentModel;
using NLog;

namespace CodeGen
{
    /// <summary>
    /// FormMain
    /// </summary>
    /// <seealso cref="Form" />
    public partial class FormMain : Form
    {
        #region properties

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        private Project _activeProject;

        private ProjectWorkspace _activeControl;

        /// <summary>
        /// Full-path project location
        /// </summary>
        public string ProjectLocation { get; set; }

        #endregion

        #region initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="FormMain"/> class.
        /// </summary>
        public FormMain()
        {
            _logger.Trace("FormMain.FormMain()");

            InitializeComponent();
        }

        #endregion

        #region methods

        private void LoadLocalVariables()
        {
            _logger.Trace("FormMain.LoadLocalVariables()");

            // Recover saved project directory (or load default if isn't any)
            openFileDialogProject.InitialDirectory = ProgramSettings.GetGlobalSettings().DirectoriesSettings.DefaultProjectsDirectory;

            // Detect if the application was loaded with a project (double clic on a project file)
            if(string.IsNullOrWhiteSpace(ProjectLocation))
            {
                _activeProject = new Project();
            }
            else
            {
                OpenProject(ProjectLocation);
            }

        }

        private void UpdateMenuControls()
        {
            _logger.Trace("FormMain.UpdateMenuControls()");

            // Block controls if is there a active project loaded
            bool enable = _activeProject.IsValid;

            toolStripMenuItemProject.Enabled = enable;

            toolStripMenuItemCloseProject.Enabled = enable;
            toolStripMenuItemSaveProject.Enabled = enable;
            toolStripMenuItemSaveProjectAs.Enabled = enable;
        }

        private void UpdateWindowTitle()
        {
            _logger.Trace("FormMain.UpdateWindowTitle()");

            // Shows an * in the Window title to mark if the project has any unsaved changes
            Text = _activeProject.IsValid
                    ? string.Format(_activeProject.IsUnsaved ? "*{0} - {1} {2}" : "{0} - {1} {2}", _activeProject.Name, ProgramInfo.AssemblyProduct, ProgramInfo.AssemblyVersion)
                    : string.Format("{0} {1}", ProgramInfo.AssemblyProduct, ProgramInfo.AssemblyVersion);
        }

        private void BlockWindowControls(bool block)
        {
            _logger.Trace("FormMain.BlockWindowControls()");
        }

        private void OpenProject(string projectLocation)
        {
            _logger.Trace("FormMain.OpenProject()");

            _activeProject = ProjectsController.OpenProjectFromLocation(projectLocation, Resources.EncriptionKey);

            if(!_activeProject.IsValid)
            {
                return;
            }

            _activeControl = new ProjectWorkspace();
            _activeControl.Dock = DockStyle.Fill;
            _activeControl.Project = _activeProject;
            _activeControl.OnProjectChange += activeControl_OnProjectChange;
            _activeControl.LoadLocalVariables();

            UpdateWindowTitle();
            UpdateMenuControls();

            panelMain.Visible = true;
            panelMain.Controls.Add(_activeControl);
        }

        private void SaveProject(bool showSaveDialog)
        {
            _logger.Trace("FormMain.SaveProject()");

            // To differentiate from "Save" and "Save as"
            if (showSaveDialog)
            {
                saveFileDialogProject.InitialDirectory = _activeProject.SaveLocation;

                if(saveFileDialogProject.ShowDialog() == DialogResult.OK)
                {
                    _activeProject.SaveLocation = saveFileDialogProject.FileName;
                }
            }

            // In case the project is new, the "Save" always show the SaveDialog
            else if(_activeProject.IsNew)
            {
                string projectDirectory = _activeProject.SaveDirectory;

                if(!Directory.Exists(projectDirectory))
                {
                    Directory.CreateDirectory(projectDirectory);
                }
            }

            BlockWindowControls(true);

            // Serialize the instance of the project class in a Xml file and save it in a file
            using (Stream projectStream = File.Open(_activeProject.SaveLocation, FileMode.Create, FileAccess.Write))
            {
                ProjectsController.SaveProjectToStream(_activeProject, projectStream, Resources.EncriptionKey);
            }

            UpdateWindowTitle();
            BlockWindowControls(false);
        }

        private void CloseProject()
        {
            _logger.Trace("FormMain.CloseProject()");

            if (_activeControl != null)
            {
                _activeProject = new Project();
            }

            panelMain.Controls.Clear();
            panelMain.Visible = false;

            UpdateMenuControls();
            UpdateWindowTitle();
        }

        private void SaveAndCloseProject(bool exitApplication)
        {
            _logger.Trace("FormMain.SaveAndCloseProject()");

            bool close = true;

            // Check if there a open project and has unsaved changes
            if(_activeProject.IsValid && _activeProject.IsUnsaved)
            {
                DialogResult dialogResult = MessageBox.Show("There are unsaved changes. Do you want to save now?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        {
                            SaveProject(false);
                            break;
                        }

                    case DialogResult.No:
                        {
                            break;
                        }

                    case DialogResult.Cancel:
                        {
                            close = false;
                            break;
                        }
                }
            }

            if (close)
            {
                if (exitApplication)
                {
                    Application.Exit();
                }
                else
                {
                    CloseProject();
                }
            }
        }

        #endregion

        #region events

        private void activeControl_OnProjectChange(object sender, EventArgs e)
        {
            _logger.Trace("FormMain.activeControl_OnProjectChange()");

            UpdateWindowTitle();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _logger.Trace("FormMain.FormMain_Load()");

            try
            {
                LoadLocalVariables();
                UpdateWindowTitle();

                if (!PluginsManager.CheckIfPluginsAreLoaded())
                {
                    menuMain.Enabled = false;
                    toolStripStatusLabelMain.Text = "Checking plugins";
                    statusStripMain.Refresh();
                    workerCheckPlugins.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logger.Trace("FormMain.FormMain_FormClosed()");

            try
            {
                // Store some global configuration to save
                Settings.Default.IsMaximized = WindowState.Equals(FormWindowState.Maximized);
                Settings.Default.WindowSizeWidth = Size.Width;
                Settings.Default.WindowSizeHeight = Size.Height;
                Settings.Default.WindowPositionX = Location.X;
                Settings.Default.WindowPositionY = Location.Y;

                Settings.Default.Save();

                ProgramSettings.SaveGlobalSettings();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
                MessageBoxHelper.ProcessException(ex);
            }
        }

        #region file menu

        private void toolStripMenuItemNewProject_Click(object sender, EventArgs e)
        {
            _logger.Trace("FormMain.toolStripMenuItemNewProject_Click()");

            try
            {
                SaveAndCloseProject(false);

                FormNewProject form = new FormNewProject();
                form.LoadLocalVariables();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    _activeProject = form.Project;

                    _activeControl = new ProjectWorkspace();
                    _activeControl.Dock = DockStyle.Fill;
                    _activeControl.Project = _activeProject;
                    _activeControl.OnProjectChange += activeControl_OnProjectChange;
                    _activeControl.LoadLocalVariables();

                    UpdateWindowTitle();
                    UpdateMenuControls();

                    panelMain.Visible = true;
                    panelMain.Controls.Add(_activeControl);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void toolStripMenuItemOpenProject_Click(object sender, EventArgs e)
        {
            _logger.Trace("FormMain.toolStripMenuItemOpenProject_Click()");

            try
            {
                // Before opening a new project, save the active project (if there's any)
                SaveAndCloseProject(false);

                if (openFileDialogProject.ShowDialog() == DialogResult.OK)
                {
                    OpenProject(openFileDialogProject.FileName);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void toolStripMenuItemCloseProject_Click(object sender, EventArgs e)
        {
            _logger.Trace("FormMain.toolStripMenuItemCloseProject_Click()");

            try
            {
                SaveAndCloseProject(false);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void toolStripMenuItemSaveProject_Click(object sender, EventArgs e)
        {
            _logger.Trace("FormMain.toolStripMenuItemSaveProject_Click()");

            try
            {
                SaveProject(false);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void toolStripMenuItemSaveProjectAs_Click(object sender, EventArgs e)
        {
            _logger.Trace("FormMain.toolStripMenuItemSaveProjectAs_Click()");

            try
            {
                SaveProject(true);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            _logger.Trace("FormMain.toolStripMenuItemExit_Click()");

            try
            {
                SaveAndCloseProject(true);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
                MessageBoxHelper.ProcessException(ex);
            }
        }

        #endregion

        #region project menu

        private void toolStripMenuItemGenerateCodeFile_Click(object sender, EventArgs e)
        {
            _logger.Trace("FormMain.toolStripMenuItemGenerateCodeFile_Click()");

            try
            {
                _activeControl.LoadGenerator<GenerateCodeFile>();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void toolStripMenuItemGenerateDatabaseScript_Click(object sender, EventArgs e)
        {
            _logger.Trace("FormMain.toolStripMenuItemGenerateDatabaseScript_Click()");

            try
            {
                _activeControl.LoadGenerator<GenerateCodeDatabase>();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
                MessageBoxHelper.ProcessException(ex);
            }
        }

        #endregion

        #region tools menu

        private void toolStripMenuItemPluginsManager_Click(object sender, EventArgs e)
        {
            _logger.Trace("FormMain.toolStripMenuItemPluginsManager_Click()");

            try
            {
                FormPluginsManager form = new FormPluginsManager();
                form.LoadLocalVariables();

                form.ShowDialog();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
                MessageBoxHelper.ProcessException(ex);
            }
        }

        private void toolStripMenuItemOptions_Click(object sender, EventArgs e)
        {
            _logger.Trace("FormMain.toolStripMenuItemOptions_Click()");

            try
            {
                FormOptions form = new FormOptions();
                form.LoadLocalVariables();

                form.ShowDialog();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
                MessageBoxHelper.ProcessException(ex);
            }
        }

        #endregion

        #region help menu

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            _logger.Trace("FormMain.toolStripMenuItemAbout_Click()");

            new FormAbout().ShowDialog();
        }

        #endregion

        private void workerCheckPlugins_DoWork(object sender, DoWorkEventArgs e)
        {
            _logger.Trace("FormMain.workerCheckPlugins_DoWork()");

            PluginsManager.UpdatePluginList();
            PluginsManager.CheckExistingPlugins();
        }

        private void workerCheckPlugins_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _logger.Trace("FormMain.workerCheckPlugins_RunWorkerCompleted()");

            if ( e.Error != null)
            {
                _logger.Error(e.Error, e.Error.Message);
                MessageBoxHelper.ProcessException(e.Error);
            }

            menuMain.Enabled = true;
            toolStripStatusLabelMain.Text = string.Empty;
            statusStripMain.Refresh();
        }

        #endregion
    }
}
