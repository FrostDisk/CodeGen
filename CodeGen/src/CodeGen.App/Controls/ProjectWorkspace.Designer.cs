namespace CodeGen.Controls
{
    partial class ProjectWorkspace
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelWorkspace = new System.Windows.Forms.Panel();
            this.splitWorkspace = new System.Windows.Forms.SplitContainer();
            this.panelProject = new System.Windows.Forms.Panel();
            this.treeViewProject = new System.Windows.Forms.TreeView();
            this.imageListTreeViewProject = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitWorkspace)).BeginInit();
            this.splitWorkspace.Panel1.SuspendLayout();
            this.splitWorkspace.Panel2.SuspendLayout();
            this.splitWorkspace.SuspendLayout();
            this.panelProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWorkspace
            // 
            this.panelWorkspace.BackColor = System.Drawing.SystemColors.Control;
            this.panelWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkspace.Location = new System.Drawing.Point(0, 0);
            this.panelWorkspace.Name = "panelWorkspace";
            this.panelWorkspace.Size = new System.Drawing.Size(396, 419);
            this.panelWorkspace.TabIndex = 1;
            // 
            // splitWorkspace
            // 
            this.splitWorkspace.BackColor = System.Drawing.SystemColors.Control;
            this.splitWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitWorkspace.Location = new System.Drawing.Point(0, 0);
            this.splitWorkspace.Name = "splitWorkspace";
            // 
            // splitWorkspace.Panel1
            // 
            this.splitWorkspace.Panel1.Controls.Add(this.panelProject);
            this.splitWorkspace.Panel1MinSize = 100;
            // 
            // splitWorkspace.Panel2
            // 
            this.splitWorkspace.Panel2.Controls.Add(this.panelWorkspace);
            this.splitWorkspace.Size = new System.Drawing.Size(500, 419);
            this.splitWorkspace.SplitterDistance = 100;
            this.splitWorkspace.TabIndex = 2;
            // 
            // panelProject
            // 
            this.panelProject.Controls.Add(this.treeViewProject);
            this.panelProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProject.Location = new System.Drawing.Point(0, 0);
            this.panelProject.Name = "panelProject";
            this.panelProject.Size = new System.Drawing.Size(100, 419);
            this.panelProject.TabIndex = 0;
            // 
            // treeViewProject
            // 
            this.treeViewProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewProject.ImageIndex = 0;
            this.treeViewProject.ImageList = this.imageListTreeViewProject;
            this.treeViewProject.Location = new System.Drawing.Point(0, 0);
            this.treeViewProject.Name = "treeViewProject";
            this.treeViewProject.SelectedImageIndex = 0;
            this.treeViewProject.Size = new System.Drawing.Size(100, 419);
            this.treeViewProject.TabIndex = 0;
            // 
            // imageListTreeViewProject
            // 
            this.imageListTreeViewProject.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListTreeViewProject.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListTreeViewProject.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ProjectWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.splitWorkspace);
            this.Name = "ProjectWorkspace";
            this.Size = new System.Drawing.Size(500, 419);
            this.splitWorkspace.Panel1.ResumeLayout(false);
            this.splitWorkspace.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitWorkspace)).EndInit();
            this.splitWorkspace.ResumeLayout(false);
            this.panelProject.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWorkspace;
        private System.Windows.Forms.SplitContainer splitWorkspace;
        private System.Windows.Forms.Panel panelProject;
        private System.Windows.Forms.TreeView treeViewProject;
        private System.Windows.Forms.ImageList imageListTreeViewProject;
    }
}
