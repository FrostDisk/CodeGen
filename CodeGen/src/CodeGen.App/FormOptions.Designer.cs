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
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tabDirectories = new System.Windows.Forms.TabPage();
            this.tabOtherOptions = new System.Windows.Forms.TabPage();
            this.cmbLogLevel = new System.Windows.Forms.ComboBox();
            this.lblLogLevel = new System.Windows.Forms.Label();
            this.lblLogDirectory = new System.Windows.Forms.Label();
            this.txtLogDirectory = new System.Windows.Forms.TextBox();
            this.btnChangeLogDirectory = new System.Windows.Forms.Button();
            this.tabOptions.SuspendLayout();
            this.tabDirectories.SuspendLayout();
            this.tabOtherOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(410, 270);
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
            this.btnCancel.Location = new System.Drawing.Point(491, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            this.txtDefaultProjectsDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefaultProjectsDirectory.Location = new System.Drawing.Point(6, 40);
            this.txtDefaultProjectsDirectory.Name = "txtDefaultProjectsDirectory";
            this.txtDefaultProjectsDirectory.ReadOnly = true;
            this.txtDefaultProjectsDirectory.Size = new System.Drawing.Size(447, 20);
            this.txtDefaultProjectsDirectory.TabIndex = 1;
            // 
            // btnChangeDefaultProjectsDirectory
            // 
            this.btnChangeDefaultProjectsDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeDefaultProjectsDirectory.Location = new System.Drawing.Point(459, 40);
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
            this.txtPluginsDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPluginsDirectory.Location = new System.Drawing.Point(6, 85);
            this.txtPluginsDirectory.Name = "txtPluginsDirectory";
            this.txtPluginsDirectory.ReadOnly = true;
            this.txtPluginsDirectory.Size = new System.Drawing.Size(447, 20);
            this.txtPluginsDirectory.TabIndex = 4;
            // 
            // btnChangePluginsDirectory
            // 
            this.btnChangePluginsDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePluginsDirectory.Location = new System.Drawing.Point(459, 85);
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
            this.txtCacheDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCacheDirectory.Location = new System.Drawing.Point(6, 133);
            this.txtCacheDirectory.Name = "txtCacheDirectory";
            this.txtCacheDirectory.ReadOnly = true;
            this.txtCacheDirectory.Size = new System.Drawing.Size(447, 20);
            this.txtCacheDirectory.TabIndex = 7;
            // 
            // btnChangeCacheDirectory
            // 
            this.btnChangeCacheDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeCacheDirectory.Location = new System.Drawing.Point(459, 133);
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
            this.txtTempDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTempDirectory.Location = new System.Drawing.Point(6, 178);
            this.txtTempDirectory.Name = "txtTempDirectory";
            this.txtTempDirectory.ReadOnly = true;
            this.txtTempDirectory.Size = new System.Drawing.Size(447, 20);
            this.txtTempDirectory.TabIndex = 10;
            // 
            // btnChangeTempDirectory
            // 
            this.btnChangeTempDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeTempDirectory.Location = new System.Drawing.Point(459, 178);
            this.btnChangeTempDirectory.Name = "btnChangeTempDirectory";
            this.btnChangeTempDirectory.Size = new System.Drawing.Size(75, 20);
            this.btnChangeTempDirectory.TabIndex = 11;
            this.btnChangeTempDirectory.Text = "Change";
            this.btnChangeTempDirectory.UseVisualStyleBackColor = true;
            this.btnChangeTempDirectory.Click += new System.EventHandler(this.btnChangeTempDirectory_Click);
            // 
            // tabOptions
            // 
            this.tabOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOptions.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabOptions.Controls.Add(this.tabDirectories);
            this.tabOptions.Controls.Add(this.tabOtherOptions);
            this.tabOptions.Location = new System.Drawing.Point(12, 12);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(554, 249);
            this.tabOptions.TabIndex = 6;
            // 
            // tabDirectories
            // 
            this.tabDirectories.Controls.Add(this.lblDefaultProjectsDirectory);
            this.tabDirectories.Controls.Add(this.txtDefaultProjectsDirectory);
            this.tabDirectories.Controls.Add(this.btnChangeDefaultProjectsDirectory);
            this.tabDirectories.Controls.Add(this.lblPluginsDirectory);
            this.tabDirectories.Controls.Add(this.txtPluginsDirectory);
            this.tabDirectories.Controls.Add(this.btnChangePluginsDirectory);
            this.tabDirectories.Controls.Add(this.lblCacheDirectory);
            this.tabDirectories.Controls.Add(this.txtCacheDirectory);
            this.tabDirectories.Controls.Add(this.btnChangeCacheDirectory);
            this.tabDirectories.Controls.Add(this.lblTempDirectory);
            this.tabDirectories.Controls.Add(this.txtTempDirectory);
            this.tabDirectories.Controls.Add(this.btnChangeTempDirectory);
            this.tabDirectories.Location = new System.Drawing.Point(4, 25);
            this.tabDirectories.Name = "tabDirectories";
            this.tabDirectories.Padding = new System.Windows.Forms.Padding(3);
            this.tabDirectories.Size = new System.Drawing.Size(546, 220);
            this.tabDirectories.TabIndex = 0;
            this.tabDirectories.Text = "Directories";
            this.tabDirectories.UseVisualStyleBackColor = true;
            // 
            // tabOtherOptions
            // 
            this.tabOtherOptions.Controls.Add(this.lblLogDirectory);
            this.tabOtherOptions.Controls.Add(this.txtLogDirectory);
            this.tabOtherOptions.Controls.Add(this.btnChangeLogDirectory);
            this.tabOtherOptions.Controls.Add(this.lblLogLevel);
            this.tabOtherOptions.Controls.Add(this.cmbLogLevel);
            this.tabOtherOptions.Location = new System.Drawing.Point(4, 25);
            this.tabOtherOptions.Name = "tabOtherOptions";
            this.tabOtherOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOtherOptions.Size = new System.Drawing.Size(546, 220);
            this.tabOtherOptions.TabIndex = 1;
            this.tabOtherOptions.Text = "Other options";
            this.tabOtherOptions.UseVisualStyleBackColor = true;
            // 
            // cmbLogLevel
            // 
            this.cmbLogLevel.DisplayMember = "Name";
            this.cmbLogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogLevel.FormattingEnabled = true;
            this.cmbLogLevel.Location = new System.Drawing.Point(66, 62);
            this.cmbLogLevel.Name = "cmbLogLevel";
            this.cmbLogLevel.Size = new System.Drawing.Size(132, 21);
            this.cmbLogLevel.TabIndex = 0;
            this.cmbLogLevel.ValueMember = "Name";
            // 
            // lblLogLevel
            // 
            this.lblLogLevel.AutoSize = true;
            this.lblLogLevel.Location = new System.Drawing.Point(6, 65);
            this.lblLogLevel.Name = "lblLogLevel";
            this.lblLogLevel.Size = new System.Drawing.Size(54, 13);
            this.lblLogLevel.TabIndex = 1;
            this.lblLogLevel.Text = "Log Level";
            // 
            // lblLogDirectory
            // 
            this.lblLogDirectory.AutoSize = true;
            this.lblLogDirectory.Location = new System.Drawing.Point(6, 12);
            this.lblLogDirectory.Name = "lblLogDirectory";
            this.lblLogDirectory.Size = new System.Drawing.Size(70, 13);
            this.lblLogDirectory.TabIndex = 12;
            this.lblLogDirectory.Text = "Log Directory";
            // 
            // txtLogDirectory
            // 
            this.txtLogDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogDirectory.Location = new System.Drawing.Point(6, 28);
            this.txtLogDirectory.Name = "txtLogDirectory";
            this.txtLogDirectory.ReadOnly = true;
            this.txtLogDirectory.Size = new System.Drawing.Size(447, 20);
            this.txtLogDirectory.TabIndex = 13;
            // 
            // btnChangeLogDirectory
            // 
            this.btnChangeLogDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeLogDirectory.Location = new System.Drawing.Point(459, 28);
            this.btnChangeLogDirectory.Name = "btnChangeLogDirectory";
            this.btnChangeLogDirectory.Size = new System.Drawing.Size(75, 20);
            this.btnChangeLogDirectory.TabIndex = 14;
            this.btnChangeLogDirectory.Text = "Change";
            this.btnChangeLogDirectory.UseVisualStyleBackColor = true;
            this.btnChangeLogDirectory.Click += new System.EventHandler(this.btnChangeLogDirectory_Click);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 305);
            this.Controls.Add(this.tabOptions);
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
            this.tabOptions.ResumeLayout(false);
            this.tabDirectories.ResumeLayout(false);
            this.tabDirectories.PerformLayout();
            this.tabOtherOptions.ResumeLayout(false);
            this.tabOtherOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
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
        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage tabDirectories;
        private System.Windows.Forms.TabPage tabOtherOptions;
        private System.Windows.Forms.Label lblLogDirectory;
        private System.Windows.Forms.TextBox txtLogDirectory;
        private System.Windows.Forms.Button btnChangeLogDirectory;
        private System.Windows.Forms.Label lblLogLevel;
        private System.Windows.Forms.ComboBox cmbLogLevel;
    }
}