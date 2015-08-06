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
            this.lblDefaultProjectDirectory = new System.Windows.Forms.Label();
            this.txtDefaultProjectDirectory = new System.Windows.Forms.TextBox();
            this.btnChangeDefaultProjectDirectory = new System.Windows.Forms.Button();
            this.btnChangePluginsDirectory = new System.Windows.Forms.Button();
            this.txtPluginsDirectory = new System.Windows.Forms.TextBox();
            this.lblPluginsDirectory = new System.Windows.Forms.Label();
            this.btnChangeCacheDirectory = new System.Windows.Forms.Button();
            this.txtCacheDirectory = new System.Windows.Forms.TextBox();
            this.lblCacheDirectory = new System.Windows.Forms.Label();
            this.btnChangeTempDirectory = new System.Windows.Forms.Button();
            this.txtTempDirectory = new System.Windows.Forms.TextBox();
            this.lblTempDirectory = new System.Windows.Forms.Label();
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
            this.groupDirectories.Controls.Add(this.lblDefaultProjectDirectory);
            this.groupDirectories.Controls.Add(this.txtDefaultProjectDirectory);
            this.groupDirectories.Controls.Add(this.btnChangeDefaultProjectDirectory);
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
            // lblDefaultProjectDirectory
            // 
            this.lblDefaultProjectDirectory.AutoSize = true;
            this.lblDefaultProjectDirectory.Location = new System.Drawing.Point(6, 24);
            this.lblDefaultProjectDirectory.Name = "lblDefaultProjectDirectory";
            this.lblDefaultProjectDirectory.Size = new System.Drawing.Size(122, 13);
            this.lblDefaultProjectDirectory.TabIndex = 0;
            this.lblDefaultProjectDirectory.Text = "Default Project Directory";
            // 
            // txtDefaultProjectDirectory
            // 
            this.txtDefaultProjectDirectory.Location = new System.Drawing.Point(6, 40);
            this.txtDefaultProjectDirectory.Name = "txtDefaultProjectDirectory";
            this.txtDefaultProjectDirectory.ReadOnly = true;
            this.txtDefaultProjectDirectory.Size = new System.Drawing.Size(461, 20);
            this.txtDefaultProjectDirectory.TabIndex = 1;
            // 
            // btnChangeDefaultProjectDirectory
            // 
            this.btnChangeDefaultProjectDirectory.Location = new System.Drawing.Point(473, 40);
            this.btnChangeDefaultProjectDirectory.Name = "btnChangeDefaultProjectDirectory";
            this.btnChangeDefaultProjectDirectory.Size = new System.Drawing.Size(75, 20);
            this.btnChangeDefaultProjectDirectory.TabIndex = 2;
            this.btnChangeDefaultProjectDirectory.Text = "Change";
            this.btnChangeDefaultProjectDirectory.UseVisualStyleBackColor = true;
            this.btnChangeDefaultProjectDirectory.Click += new System.EventHandler(this.btnChangeDefaultProjectDirectory_Click);
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
            // txtPluginsDirectory
            // 
            this.txtPluginsDirectory.Location = new System.Drawing.Point(6, 85);
            this.txtPluginsDirectory.Name = "txtPluginsDirectory";
            this.txtPluginsDirectory.ReadOnly = true;
            this.txtPluginsDirectory.Size = new System.Drawing.Size(461, 20);
            this.txtPluginsDirectory.TabIndex = 4;
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
            // txtCacheDirectory
            // 
            this.txtCacheDirectory.Location = new System.Drawing.Point(6, 133);
            this.txtCacheDirectory.Name = "txtCacheDirectory";
            this.txtCacheDirectory.ReadOnly = true;
            this.txtCacheDirectory.Size = new System.Drawing.Size(461, 20);
            this.txtCacheDirectory.TabIndex = 7;
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
            // txtTempDirectory
            // 
            this.txtTempDirectory.Location = new System.Drawing.Point(6, 178);
            this.txtTempDirectory.Name = "txtTempDirectory";
            this.txtTempDirectory.ReadOnly = true;
            this.txtTempDirectory.Size = new System.Drawing.Size(461, 20);
            this.txtTempDirectory.TabIndex = 10;
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
        private System.Windows.Forms.Label lblDefaultProjectDirectory;
        private System.Windows.Forms.TextBox txtDefaultProjectDirectory;
        private System.Windows.Forms.Button btnChangeDefaultProjectDirectory;
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