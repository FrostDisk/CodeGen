namespace CodeGen
{
    partial class FormOptions
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupDirectories = new System.Windows.Forms.GroupBox();
            this.lblDefaultProjectsDirectory = new System.Windows.Forms.Label();
            this.txtDefaultProjectsDirectory = new System.Windows.Forms.TextBox();
            this.btnChangeDefaultProjectsDirectory = new System.Windows.Forms.Button();
            this.lblPluginsDirectory = new System.Windows.Forms.Label();
            this.txtPluginsDirectory = new System.Windows.Forms.TextBox();
            this.btnChangePluginsDirectory = new System.Windows.Forms.Button();
            this.lblCacheDirectory = new System.Windows.Forms.Label();
            this.txtCacheDirectory = new System.Windows.Forms.TextBox();
            this.btnChangeCacheDirectory = new System.Windows.Forms.Button();
            this.lblTempDirectory = new System.Windows.Forms.Label();
            this.txtTempDirectory = new System.Windows.Forms.TextBox();
            this.btnChangeTempDirectory = new System.Windows.Forms.Button();
            this.folderBrowserChangeDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.groupDirectories.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(410, 247);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(491, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupDirectories
            // 
            this.groupDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDirectories.Controls.Add(this.lblDefaultProjectsDirectory);
            this.groupDirectories.Controls.Add(this.txtDefaultProjectsDirectory);
            this.groupDirectories.Controls.Add(this.btnChangeDefaultProjectsDirectory);
            this.groupDirectories.Controls.Add(this.lblPluginsDirectory);
            this.groupDirectories.Controls.Add(this.txtPluginsDirectory);
            this.groupDirectories.Controls.Add(this.btnChangePluginsDirectory);
            this.groupDirectories.Controls.Add(this.lblCacheDirectory);
            this.groupDirectories.Controls.Add(this.txtCacheDirectory);
            this.groupDirectories.Controls.Add(this.btnChangeCacheDirectory);
            this.groupDirectories.Controls.Add(this.lblTempDirectory);
            this.groupDirectories.Controls.Add(this.txtTempDirectory);
            this.groupDirectories.Controls.Add(this.btnChangeTempDirectory);
            this.groupDirectories.Location = new System.Drawing.Point(12, 12);
            this.groupDirectories.Name = "groupDirectories";
            this.groupDirectories.Size = new System.Drawing.Size(554, 229);
            this.groupDirectories.TabIndex = 5;
            this.groupDirectories.TabStop = false;
            this.groupDirectories.Text = "Directories";
            // 
            // lblDefaultProjectsDirectory
            // 
            this.lblDefaultProjectsDirectory.AutoSize = true;
            this.lblDefaultProjectsDirectory.Location = new System.Drawing.Point(6, 24);
            this.lblDefaultProjectsDirectory.Name = "lblDefaultProjectsDirectory";
            this.lblDefaultProjectsDirectory.Size = new System.Drawing.Size(127, 13);
            this.lblDefaultProjectsDirectory.TabIndex = 0;
            this.lblDefaultProjectsDirectory.Text = "Default Projects Directory";
            // 
            // txtDefaultProjectsDirectory
            // 
            this.txtDefaultProjectsDirectory.Location = new System.Drawing.Point(6, 40);
            this.txtDefaultProjectsDirectory.Name = "txtDefaultProjectsDirectory";
            this.txtDefaultProjectsDirectory.ReadOnly = true;
            this.txtDefaultProjectsDirectory.Size = new System.Drawing.Size(461, 20);
            this.txtDefaultProjectsDirectory.TabIndex = 1;
            // 
            // btnChangeDefaultProjectsDirectory
            // 
            this.btnChangeDefaultProjectsDirectory.Location = new System.Drawing.Point(473, 40);
            this.btnChangeDefaultProjectsDirectory.Name = "btnChangeDefaultProjectsDirectory";
            this.btnChangeDefaultProjectsDirectory.Size = new System.Drawing.Size(75, 20);
            this.btnChangeDefaultProjectsDirectory.TabIndex = 2;
            this.btnChangeDefaultProjectsDirectory.Text = "Change";
            this.btnChangeDefaultProjectsDirectory.UseVisualStyleBackColor = true;
            this.btnChangeDefaultProjectsDirectory.Click += new System.EventHandler(this.btnChangeDefaultProjectsDirectory_Click);
            // 
            // lblPluginsDirectory
            // 
            this.lblPluginsDirectory.AutoSize = true;
            this.lblPluginsDirectory.Location = new System.Drawing.Point(6, 69);
            this.lblPluginsDirectory.Name = "lblPluginsDirectory";
            this.lblPluginsDirectory.Size = new System.Drawing.Size(86, 13);
            this.lblPluginsDirectory.TabIndex = 3;
            this.lblPluginsDirectory.Text = "Plugins Directory";
            // 
            // txtPluginsDirectory
            // 
            this.txtPluginsDirectory.Location = new System.Drawing.Point(6, 85);
            this.txtPluginsDirectory.Name = "txtPluginsDirectory";
            this.txtPluginsDirectory.ReadOnly = true;
            this.txtPluginsDirectory.Size = new System.Drawing.Size(461, 20);
            this.txtPluginsDirectory.TabIndex = 4;
            // 
            // btnChangePluginsDirectory
            // 
            this.btnChangePluginsDirectory.Location = new System.Drawing.Point(473, 85);
            this.btnChangePluginsDirectory.Name = "btnChangePluginsDirectory";
            this.btnChangePluginsDirectory.Size = new System.Drawing.Size(75, 20);
            this.btnChangePluginsDirectory.TabIndex = 5;
            this.btnChangePluginsDirectory.Text = "Change";
            this.btnChangePluginsDirectory.UseVisualStyleBackColor = true;
            this.btnChangePluginsDirectory.Click += new System.EventHandler(this.btnChangePluginsDirectory_Click);
            // 
            // lblCacheDirectory
            // 
            this.lblCacheDirectory.AutoSize = true;
            this.lblCacheDirectory.Location = new System.Drawing.Point(6, 117);
            this.lblCacheDirectory.Name = "lblCacheDirectory";
            this.lblCacheDirectory.Size = new System.Drawing.Size(83, 13);
            this.lblCacheDirectory.TabIndex = 6;
            this.lblCacheDirectory.Text = "Cache Directory";
            // 
            // txtCacheDirectory
            // 
            this.txtCacheDirectory.Location = new System.Drawing.Point(6, 133);
            this.txtCacheDirectory.Name = "txtCacheDirectory";
            this.txtCacheDirectory.ReadOnly = true;
            this.txtCacheDirectory.Size = new System.Drawing.Size(461, 20);
            this.txtCacheDirectory.TabIndex = 7;
            // 
            // btnChangeCacheDirectory
            // 
            this.btnChangeCacheDirectory.Location = new System.Drawing.Point(473, 133);
            this.btnChangeCacheDirectory.Name = "btnChangeCacheDirectory";
            this.btnChangeCacheDirectory.Size = new System.Drawing.Size(75, 20);
            this.btnChangeCacheDirectory.TabIndex = 8;
            this.btnChangeCacheDirectory.Text = "Change";
            this.btnChangeCacheDirectory.UseVisualStyleBackColor = true;
            this.btnChangeCacheDirectory.Click += new System.EventHandler(this.btnChangeCacheDirectory_Click);
            // 
            // lblTempDirectory
            // 
            this.lblTempDirectory.AutoSize = true;
            this.lblTempDirectory.Location = new System.Drawing.Point(6, 162);
            this.lblTempDirectory.Name = "lblTempDirectory";
            this.lblTempDirectory.Size = new System.Drawing.Size(79, 13);
            this.lblTempDirectory.TabIndex = 9;
            this.lblTempDirectory.Text = "Temp Directory";
            // 
            // txtTempDirectory
            // 
            this.txtTempDirectory.Location = new System.Drawing.Point(6, 178);
            this.txtTempDirectory.Name = "txtTempDirectory";
            this.txtTempDirectory.ReadOnly = true;
            this.txtTempDirectory.Size = new System.Drawing.Size(461, 20);
            this.txtTempDirectory.TabIndex = 10;
            // 
            // btnChangeTempDirectory
            // 
            this.btnChangeTempDirectory.Location = new System.Drawing.Point(473, 178);
            this.btnChangeTempDirectory.Name = "btnChangeTempDirectory";
            this.btnChangeTempDirectory.Size = new System.Drawing.Size(75, 20);
            this.btnChangeTempDirectory.TabIndex = 11;
            this.btnChangeTempDirectory.Text = "Change";
            this.btnChangeTempDirectory.UseVisualStyleBackColor = true;
            this.btnChangeTempDirectory.Click += new System.EventHandler(this.btnChangeTempDirectory_Click);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 282);
            this.Controls.Add(this.groupDirectories);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "General Options";
            this.groupDirectories.ResumeLayout(false);
            this.groupDirectories.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupDirectories;
        private System.Windows.Forms.Label lblDefaultProjectsDirectory;
        private System.Windows.Forms.TextBox txtDefaultProjectsDirectory;
        private System.Windows.Forms.Button btnChangeDefaultProjectsDirectory;
        private System.Windows.Forms.Label lblPluginsDirectory;
        private System.Windows.Forms.TextBox txtPluginsDirectory;
        private System.Windows.Forms.Button btnChangePluginsDirectory;
        private System.Windows.Forms.Label lblCacheDirectory;
        private System.Windows.Forms.TextBox txtCacheDirectory;
        private System.Windows.Forms.Button btnChangeCacheDirectory;
        private System.Windows.Forms.Label lblTempDirectory;
        private System.Windows.Forms.TextBox txtTempDirectory;
        private System.Windows.Forms.Button btnChangeTempDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserChangeDirectory;
    }
}