using CodeGen.Domain;
using CodeGen.Data;
using CodeGen.Properties;
using System;
using System.IO;
using System.Windows.Forms;
using CodeGen.Controls;
using CodeGen.Utils;

namespace CodeGen
{
    public partial class FormMain : Form
    {
        #region properties

        private Project _activeProject;

        private ProjectWorkspace _activeControl;

        public string ProjectLocation { get; set; }

        #endregion

        #region initialization

        public FormMain()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        private void LoadLocalVariables()
        {
            openFileDialogProject.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

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
            bool enable = _activeProject.IsValid;

            toolStripMenuItemProject.Enabled = enable;

            toolStripMenuItemCloseProject.Enabled = enable;
            toolStripMenuItemSaveProject.Enabled = enable;
            toolStripMenuItemSaveProjectAs.Enabled = enable;
        }

        private void UpdateWindowTitle()
        {
            Text = _activeProject.IsValid
                    ? string.Format(_activeProject.IsUnsaved ? "*{0} - {1} {2}" : "{0} - {1} {2}", _activeProject.Name, ProgramInfo.AssemblyProduct, ProgramInfo.AssemblyVersion)
                    : string.Format("{0} {1}", ProgramInfo.AssemblyProduct, ProgramInfo.AssemblyVersion);
        }

        private void BlockWindowControls(bool block)
        {
        }

        private void OpenProject(string projectLocation)
        {
            _activeProject = ProjectController.OpenProjectFromLocation(projectLocation);

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
            if(showSaveDialog)
            {
                saveFileDialogProject.InitialDirectory = _activeProject.SaveLocation;

                if(saveFileDialogProject.ShowDialog() == DialogResult.OK)
                {
                    _activeProject.SaveLocation = saveFileDialogProject.FileName;
                }
            }
            else if(_activeProject.IsNew)
            {
                string projectDirectory = _activeProject.SaveDirectory;

                if(!Directory.Exists(projectDirectory))
                {
                    Directory.CreateDirectory(projectDirectory);
                }
            }

            BlockWindowControls(true);

            using (Stream projectStream = File.Open(_activeProject.SaveLocation, FileMode.Create, FileAccess.Write))
            {
                ProjectController.SaveProjectToStream(_activeProject, projectStream);
            }

            UpdateWindowTitle();
            BlockWindowControls(false);
        }

        private void CloseProject()
        {
            if(_activeControl != null)
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
            bool close = true;

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
            UpdateWindowTitle();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadLocalVariables();
            UpdateWindowTitle();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.IsMaximized = WindowState.Equals(FormWindowState.Maximized);
            Settings.Default.WindowSizeWidth = Size.Width;
            Settings.Default.WindowSizeHeight = Size.Height;
            Settings.Default.WindowPositionX = Location.X;
            Settings.Default.WindowPositionY = Location.Y;

            Settings.Default.Save();

            ProgramSettings.SaveGlobalSettings();
        }

        #region file menu

        private void toolStripMenuItemNewProject_Click(object sender, System.EventArgs e)
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

        private void toolStripMenuItemOpenProject_Click(object sender, EventArgs e)
        {
            SaveAndCloseProject(false);

            if(openFileDialogProject.ShowDialog() == DialogResult.OK)
            {
                OpenProject(openFileDialogProject.FileName);
            }
        }

        private void toolStripMenuItemCloseProject_Click(object sender, EventArgs e)
        {
            SaveAndCloseProject(false);
        }

        private void toolStripMenuItemSaveProject_Click(object sender, EventArgs e)
        {
            SaveProject(false);
        }

        private void toolStripMenuItemSaveProjectAs_Click(object sender, EventArgs e)
        {
            SaveProject(true);
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            SaveAndCloseProject(true);
        }

        #endregion

        #region project menu

        private void toolStripMenuItemGenerateClass_Click(object sender, EventArgs e)
        {
            _activeControl.LoadGenerator<GenerateCodeFile>();
        }

        private void toolStripMenuItemGenerateStoredProcedure_Click(object sender, EventArgs e)
        {
            _activeControl.LoadGenerator<GenerateCodeDatabase>();
        }

        #endregion

        #region tools menu

        private void toolStripMenuItemPluginsManager_Click(object sender, EventArgs e)
        {
            FormPluginsManager form = new FormPluginsManager();
            form.LoadLocalVariables();

            form.ShowDialog();
        }

        private void toolStripMenuItemOptions_Click(object sender, EventArgs e)
        {
            FormOptions form = new FormOptions();
            form.LoadLocalVariables();

            form.ShowDialog();
        }

        #endregion

        #region help menu

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }

        #endregion

        #endregion
    }
}
