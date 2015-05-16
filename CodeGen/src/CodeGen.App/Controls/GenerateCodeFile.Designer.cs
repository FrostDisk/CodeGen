namespace CodeGen.Controls
{
    partial class GenerateCodeFile
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
            this.grpConfiguration = new System.Windows.Forms.GroupBox();
            this.lblDatabaseEntity = new System.Windows.Forms.Label();
            this.cmbDatabaseEntity = new System.Windows.Forms.ComboBox();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.cmbTemplate = new System.Windows.Forms.ComboBox();
            this.lnkTemplateOptions = new System.Windows.Forms.LinkLabel();
            this.lblComponent = new System.Windows.Forms.Label();
            this.cmbComponent = new System.Windows.Forms.ComboBox();
            this.grpGenerate = new System.Windows.Forms.GroupBox();
            this.btnGenerateCode = new System.Windows.Forms.Button();
            this.chkCopyToClipboard = new System.Windows.Forms.CheckBox();
            this.btnSaveFileAs = new System.Windows.Forms.Button();
            this.txtGeneratedCode = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.grpConfiguration.SuspendLayout();
            this.grpGenerate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConfiguration
            // 
            this.grpConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConfiguration.Controls.Add(this.lblDatabaseEntity);
            this.grpConfiguration.Controls.Add(this.cmbDatabaseEntity);
            this.grpConfiguration.Controls.Add(this.lblTemplate);
            this.grpConfiguration.Controls.Add(this.cmbTemplate);
            this.grpConfiguration.Controls.Add(this.lnkTemplateOptions);
            this.grpConfiguration.Controls.Add(this.lblComponent);
            this.grpConfiguration.Controls.Add(this.cmbComponent);
            this.grpConfiguration.Location = new System.Drawing.Point(3, 3);
            this.grpConfiguration.Name = "grpConfiguration";
            this.grpConfiguration.Size = new System.Drawing.Size(556, 113);
            this.grpConfiguration.TabIndex = 0;
            this.grpConfiguration.TabStop = false;
            this.grpConfiguration.Text = "Configuration";
            // 
            // lblDatabaseEntity
            // 
            this.lblDatabaseEntity.AutoSize = true;
            this.lblDatabaseEntity.Location = new System.Drawing.Point(12, 22);
            this.lblDatabaseEntity.Name = "lblDatabaseEntity";
            this.lblDatabaseEntity.Size = new System.Drawing.Size(82, 13);
            this.lblDatabaseEntity.TabIndex = 0;
            this.lblDatabaseEntity.Text = "Database Entity";
            // 
            // cmbDatabaseEntity
            // 
            this.cmbDatabaseEntity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDatabaseEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatabaseEntity.FormattingEnabled = true;
            this.cmbDatabaseEntity.Location = new System.Drawing.Point(100, 19);
            this.cmbDatabaseEntity.Name = "cmbDatabaseEntity";
            this.cmbDatabaseEntity.Size = new System.Drawing.Size(450, 21);
            this.cmbDatabaseEntity.TabIndex = 1;
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Location = new System.Drawing.Point(43, 49);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(51, 13);
            this.lblTemplate.TabIndex = 0;
            this.lblTemplate.Text = "Template";
            // 
            // cmbTemplate
            // 
            this.cmbTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemplate.FormattingEnabled = true;
            this.cmbTemplate.Location = new System.Drawing.Point(100, 46);
            this.cmbTemplate.Name = "cmbTemplate";
            this.cmbTemplate.Size = new System.Drawing.Size(450, 21);
            this.cmbTemplate.TabIndex = 1;
            this.cmbTemplate.SelectedIndexChanged += new System.EventHandler(this.cmbTemplate_SelectedIndexChanged);
            // 
            // lnkTemplateOptions
            // 
            this.lnkTemplateOptions.AutoSize = true;
            this.lnkTemplateOptions.Location = new System.Drawing.Point(97, 70);
            this.lnkTemplateOptions.Name = "lnkTemplateOptions";
            this.lnkTemplateOptions.Size = new System.Drawing.Size(90, 13);
            this.lnkTemplateOptions.TabIndex = 2;
            this.lnkTemplateOptions.TabStop = true;
            this.lnkTemplateOptions.Text = "Template Options";
            this.lnkTemplateOptions.Visible = false;
            this.lnkTemplateOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTemplateOptions_LinkClicked);
            // 
            // lblComponent
            // 
            this.lblComponent.AutoSize = true;
            this.lblComponent.Location = new System.Drawing.Point(33, 89);
            this.lblComponent.Name = "lblComponent";
            this.lblComponent.Size = new System.Drawing.Size(61, 13);
            this.lblComponent.TabIndex = 4;
            this.lblComponent.Text = "Component";
            // 
            // cmbComponent
            // 
            this.cmbComponent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbComponent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComponent.FormattingEnabled = true;
            this.cmbComponent.Location = new System.Drawing.Point(100, 86);
            this.cmbComponent.Name = "cmbComponent";
            this.cmbComponent.Size = new System.Drawing.Size(450, 21);
            this.cmbComponent.TabIndex = 3;
            this.cmbComponent.SelectedIndexChanged += new System.EventHandler(this.cmbComponent_SelectedIndexChanged);
            // 
            // grpGenerate
            // 
            this.grpGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGenerate.Controls.Add(this.btnGenerateCode);
            this.grpGenerate.Controls.Add(this.chkCopyToClipboard);
            this.grpGenerate.Controls.Add(this.txtFileName);
            this.grpGenerate.Controls.Add(this.btnSaveFileAs);
            this.grpGenerate.Controls.Add(this.txtGeneratedCode);
            this.grpGenerate.Location = new System.Drawing.Point(3, 122);
            this.grpGenerate.Name = "grpGenerate";
            this.grpGenerate.Size = new System.Drawing.Size(556, 357);
            this.grpGenerate.TabIndex = 1;
            this.grpGenerate.TabStop = false;
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.Location = new System.Drawing.Point(6, 19);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Size = new System.Drawing.Size(133, 20);
            this.btnGenerateCode.TabIndex = 0;
            this.btnGenerateCode.Text = "Generate Code";
            this.btnGenerateCode.UseVisualStyleBackColor = true;
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // chkCopyToClipboard
            // 
            this.chkCopyToClipboard.AutoSize = true;
            this.chkCopyToClipboard.Checked = true;
            this.chkCopyToClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCopyToClipboard.Location = new System.Drawing.Point(145, 21);
            this.chkCopyToClipboard.Name = "chkCopyToClipboard";
            this.chkCopyToClipboard.Size = new System.Drawing.Size(109, 17);
            this.chkCopyToClipboard.TabIndex = 1;
            this.chkCopyToClipboard.Text = "Copy to Clipboard";
            this.chkCopyToClipboard.UseVisualStyleBackColor = true;
            // 
            // btnSaveFileAs
            // 
            this.btnSaveFileAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFileAs.Location = new System.Drawing.Point(462, 19);
            this.btnSaveFileAs.Name = "btnSaveFileAs";
            this.btnSaveFileAs.Size = new System.Drawing.Size(88, 21);
            this.btnSaveFileAs.TabIndex = 3;
            this.btnSaveFileAs.Text = "Save File";
            this.btnSaveFileAs.UseVisualStyleBackColor = true;
            this.btnSaveFileAs.Click += new System.EventHandler(this.btnSaveFileAs_Click);
            // 
            // txtGeneratedCode
            // 
            this.txtGeneratedCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGeneratedCode.Enabled = false;
            this.txtGeneratedCode.Location = new System.Drawing.Point(6, 48);
            this.txtGeneratedCode.Multiline = true;
            this.txtGeneratedCode.Name = "txtGeneratedCode";
            this.txtGeneratedCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGeneratedCode.Size = new System.Drawing.Size(544, 303);
            this.txtGeneratedCode.TabIndex = 2;
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(331, 19);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(125, 20);
            this.txtFileName.TabIndex = 4;
            // 
            // GenerateCodeFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpConfiguration);
            this.Controls.Add(this.grpGenerate);
            this.Name = "GenerateCodeFile";
            this.Size = new System.Drawing.Size(562, 482);
            this.grpConfiguration.ResumeLayout(false);
            this.grpConfiguration.PerformLayout();
            this.grpGenerate.ResumeLayout(false);
            this.grpGenerate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConfiguration;
        private System.Windows.Forms.Label lblDatabaseEntity;
        private System.Windows.Forms.ComboBox cmbDatabaseEntity;
        private System.Windows.Forms.ComboBox cmbTemplate;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.LinkLabel lnkTemplateOptions;
        private System.Windows.Forms.GroupBox grpGenerate;
        private System.Windows.Forms.TextBox txtGeneratedCode;
        private System.Windows.Forms.CheckBox chkCopyToClipboard;
        private System.Windows.Forms.Button btnGenerateCode;
        private System.Windows.Forms.Button btnSaveFileAs;
        private System.Windows.Forms.Label lblComponent;
        private System.Windows.Forms.ComboBox cmbComponent;
        private System.Windows.Forms.TextBox txtFileName;
    }
}
