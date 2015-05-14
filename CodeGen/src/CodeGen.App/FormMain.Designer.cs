﻿namespace CodeGen
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCloseProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSaveProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveProjectAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGenerateClass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGenerateStoredProcedure = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripProjectSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemProjectProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.saveFileDialogProject = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogProject = new System.Windows.Forms.OpenFileDialog();
            this.workerPluginsCheck = new System.ComponentModel.BackgroundWorker();
            this.menuMain.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemProject,
            this.toolStripMenuItemHelp});
            resources.ApplyResources(this.menuMain, "menuMain");
            this.menuMain.Name = "menuMain";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNewProject,
            this.toolStripMenuItemOpenProject,
            this.toolStripMenuItemCloseProject,
            this.toolStripFileSeparator1,
            this.toolStripMenuItemSaveProject,
            this.toolStripMenuItemSaveProjectAs,
            this.toolStripFileSeparator2,
            this.toolStripMenuItemExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            resources.ApplyResources(this.toolStripMenuItemFile, "toolStripMenuItemFile");
            // 
            // toolStripMenuItemNewProject
            // 
            this.toolStripMenuItemNewProject.Name = "toolStripMenuItemNewProject";
            resources.ApplyResources(this.toolStripMenuItemNewProject, "toolStripMenuItemNewProject");
            this.toolStripMenuItemNewProject.Click += new System.EventHandler(this.toolStripMenuItemNewProject_Click);
            // 
            // toolStripMenuItemOpenProject
            // 
            this.toolStripMenuItemOpenProject.Name = "toolStripMenuItemOpenProject";
            resources.ApplyResources(this.toolStripMenuItemOpenProject, "toolStripMenuItemOpenProject");
            this.toolStripMenuItemOpenProject.Click += new System.EventHandler(this.toolStripMenuItemOpenProject_Click);
            // 
            // toolStripMenuItemCloseProject
            // 
            resources.ApplyResources(this.toolStripMenuItemCloseProject, "toolStripMenuItemCloseProject");
            this.toolStripMenuItemCloseProject.Name = "toolStripMenuItemCloseProject";
            this.toolStripMenuItemCloseProject.Click += new System.EventHandler(this.toolStripMenuItemCloseProject_Click);
            // 
            // toolStripFileSeparator1
            // 
            this.toolStripFileSeparator1.Name = "toolStripFileSeparator1";
            resources.ApplyResources(this.toolStripFileSeparator1, "toolStripFileSeparator1");
            // 
            // toolStripMenuItemSaveProject
            // 
            resources.ApplyResources(this.toolStripMenuItemSaveProject, "toolStripMenuItemSaveProject");
            this.toolStripMenuItemSaveProject.Name = "toolStripMenuItemSaveProject";
            this.toolStripMenuItemSaveProject.Click += new System.EventHandler(this.toolStripMenuItemSaveProject_Click);
            // 
            // toolStripMenuItemSaveProjectAs
            // 
            resources.ApplyResources(this.toolStripMenuItemSaveProjectAs, "toolStripMenuItemSaveProjectAs");
            this.toolStripMenuItemSaveProjectAs.Name = "toolStripMenuItemSaveProjectAs";
            this.toolStripMenuItemSaveProjectAs.Click += new System.EventHandler(this.toolStripMenuItemSaveProjectAs_Click);
            // 
            // toolStripFileSeparator2
            // 
            this.toolStripFileSeparator2.Name = "toolStripFileSeparator2";
            resources.ApplyResources(this.toolStripFileSeparator2, "toolStripFileSeparator2");
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            resources.ApplyResources(this.toolStripMenuItemExit, "toolStripMenuItemExit");
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemProject
            // 
            this.toolStripMenuItemProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemGenerateClass,
            this.toolStripMenuItemGenerateStoredProcedure,
            this.toolStripProjectSeparator1,
            this.toolStripMenuItemProjectProperties});
            resources.ApplyResources(this.toolStripMenuItemProject, "toolStripMenuItemProject");
            this.toolStripMenuItemProject.Name = "toolStripMenuItemProject";
            // 
            // toolStripMenuItemGenerateClass
            // 
            this.toolStripMenuItemGenerateClass.Name = "toolStripMenuItemGenerateClass";
            resources.ApplyResources(this.toolStripMenuItemGenerateClass, "toolStripMenuItemGenerateClass");
            this.toolStripMenuItemGenerateClass.Click += new System.EventHandler(this.toolStripMenuItemGenerateClass_Click);
            // 
            // toolStripMenuItemGenerateStoredProcedure
            // 
            this.toolStripMenuItemGenerateStoredProcedure.Name = "toolStripMenuItemGenerateStoredProcedure";
            resources.ApplyResources(this.toolStripMenuItemGenerateStoredProcedure, "toolStripMenuItemGenerateStoredProcedure");
            this.toolStripMenuItemGenerateStoredProcedure.Click += new System.EventHandler(this.toolStripMenuItemGenerateStoredProcedure_Click);
            // 
            // toolStripProjectSeparator1
            // 
            this.toolStripProjectSeparator1.Name = "toolStripProjectSeparator1";
            resources.ApplyResources(this.toolStripProjectSeparator1, "toolStripProjectSeparator1");
            // 
            // toolStripMenuItemProjectProperties
            // 
            this.toolStripMenuItemProjectProperties.Name = "toolStripMenuItemProjectProperties";
            resources.ApplyResources(this.toolStripMenuItemProjectProperties, "toolStripMenuItemProjectProperties");
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAbout});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            resources.ApplyResources(this.toolStripMenuItemHelp, "toolStripMenuItemHelp");
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            resources.ApplyResources(this.toolStripMenuItemAbout, "toolStripMenuItemAbout");
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Controls.Add(this.statusStripMain);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // statusStripMain
            // 
            resources.ApplyResources(this.statusStripMain, "statusStripMain");
            this.statusStripMain.Name = "statusStripMain";
            // 
            // saveFileDialogProject
            // 
            resources.ApplyResources(this.saveFileDialogProject, "saveFileDialogProject");
            // 
            // openFileDialogProject
            // 
            resources.ApplyResources(this.openFileDialogProject, "openFileDialogProject");
            // 
            // workerPluginsCheck
            // 
            this.workerPluginsCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerPluginsCheck_DoWork);
            this.workerPluginsCheck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerPluginsCheck_RunWorkerCompleted);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuMain);
            this.Name = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProject;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewProject;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenProject;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCloseProject;
        private System.Windows.Forms.ToolStripSeparator toolStripFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGenerateClass;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGenerateStoredProcedure;
        private System.Windows.Forms.ToolStripSeparator toolStripProjectSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProjectProperties;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.SaveFileDialog saveFileDialogProject;
        private System.Windows.Forms.OpenFileDialog openFileDialogProject;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveProject;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveProjectAs;
        private System.Windows.Forms.ToolStripSeparator toolStripFileSeparator2;
        private System.ComponentModel.BackgroundWorker workerPluginsCheck;

    }
}

