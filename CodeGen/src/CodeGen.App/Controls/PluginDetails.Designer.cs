namespace CodeGen.Controls
{
    partial class PluginDetails
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
            this.txtPluginDescription = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pictureTypeIcon = new System.Windows.Forms.PictureBox();
            this.lblInfoCreatedBy = new System.Windows.Forms.Label();
            this.lblInfoDateInstalled = new System.Windows.Forms.Label();
            this.lblInfoVersion = new System.Windows.Forms.Label();
            this.lnkReleasaeInfo = new System.Windows.Forms.LinkLabel();
            this.lnkAuthorWebsite = new System.Windows.Forms.LinkLabel();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblDateInstalled = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTypeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPluginDescription
            // 
            this.txtPluginDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPluginDescription.Location = new System.Drawing.Point(3, 73);
            this.txtPluginDescription.Multiline = true;
            this.txtPluginDescription.Name = "txtPluginDescription";
            this.txtPluginDescription.ReadOnly = true;
            this.txtPluginDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPluginDescription.Size = new System.Drawing.Size(363, 212);
            this.txtPluginDescription.TabIndex = 1;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(132, 29);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(74, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Plugin Version";
            // 
            // pictureTypeIcon
            // 
            this.pictureTypeIcon.Location = new System.Drawing.Point(3, 3);
            this.pictureTypeIcon.Name = "pictureTypeIcon";
            this.pictureTypeIcon.Size = new System.Drawing.Size(64, 64);
            this.pictureTypeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTypeIcon.TabIndex = 2;
            this.pictureTypeIcon.TabStop = false;
            // 
            // lblInfoCreatedBy
            // 
            this.lblInfoCreatedBy.AutoSize = true;
            this.lblInfoCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCreatedBy.Location = new System.Drawing.Point(73, 3);
            this.lblInfoCreatedBy.Name = "lblInfoCreatedBy";
            this.lblInfoCreatedBy.Size = new System.Drawing.Size(72, 13);
            this.lblInfoCreatedBy.TabIndex = 3;
            this.lblInfoCreatedBy.Text = "Created by:";
            // 
            // lblInfoDateInstalled
            // 
            this.lblInfoDateInstalled.AutoSize = true;
            this.lblInfoDateInstalled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDateInstalled.Location = new System.Drawing.Point(73, 16);
            this.lblInfoDateInstalled.Name = "lblInfoDateInstalled";
            this.lblInfoDateInstalled.Size = new System.Drawing.Size(89, 13);
            this.lblInfoDateInstalled.TabIndex = 4;
            this.lblInfoDateInstalled.Text = "Date installed:";
            // 
            // lblInfoVersion
            // 
            this.lblInfoVersion.AutoSize = true;
            this.lblInfoVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoVersion.Location = new System.Drawing.Point(73, 29);
            this.lblInfoVersion.Name = "lblInfoVersion";
            this.lblInfoVersion.Size = new System.Drawing.Size(53, 13);
            this.lblInfoVersion.TabIndex = 5;
            this.lblInfoVersion.Text = "Version:";
            // 
            // lnkReleasaeInfo
            // 
            this.lnkReleasaeInfo.AutoSize = true;
            this.lnkReleasaeInfo.Location = new System.Drawing.Point(73, 54);
            this.lnkReleasaeInfo.Name = "lnkReleasaeInfo";
            this.lnkReleasaeInfo.Size = new System.Drawing.Size(67, 13);
            this.lnkReleasaeInfo.TabIndex = 6;
            this.lnkReleasaeInfo.TabStop = true;
            this.lnkReleasaeInfo.Text = "Release Info";
            this.lnkReleasaeInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReleasaeInfo_LinkClicked);
            // 
            // lnkAuthorWebsite
            // 
            this.lnkAuthorWebsite.AutoSize = true;
            this.lnkAuthorWebsite.Location = new System.Drawing.Point(146, 54);
            this.lnkAuthorWebsite.Name = "lnkAuthorWebsite";
            this.lnkAuthorWebsite.Size = new System.Drawing.Size(80, 13);
            this.lnkAuthorWebsite.TabIndex = 7;
            this.lnkAuthorWebsite.TabStop = true;
            this.lnkAuthorWebsite.Text = "Author Website";
            this.lnkAuthorWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAuthorWebsite_LinkClicked);
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(151, 3);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(56, 13);
            this.lblCreatedBy.TabIndex = 8;
            this.lblCreatedBy.Text = "CreatedBy";
            // 
            // lblDateInstalled
            // 
            this.lblDateInstalled.AutoSize = true;
            this.lblDateInstalled.Location = new System.Drawing.Point(168, 16);
            this.lblDateInstalled.Name = "lblDateInstalled";
            this.lblDateInstalled.Size = new System.Drawing.Size(69, 13);
            this.lblDateInstalled.TabIndex = 9;
            this.lblDateInstalled.Text = "DateInstalled";
            // 
            // PluginDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureTypeIcon);
            this.Controls.Add(this.lblInfoCreatedBy);
            this.Controls.Add(this.lblCreatedBy);
            this.Controls.Add(this.lblInfoDateInstalled);
            this.Controls.Add(this.lblDateInstalled);
            this.Controls.Add(this.lblInfoVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lnkReleasaeInfo);
            this.Controls.Add(this.lnkAuthorWebsite);
            this.Controls.Add(this.txtPluginDescription);
            this.Name = "PluginDetails";
            this.Size = new System.Drawing.Size(369, 288);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTypeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPluginDescription;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox pictureTypeIcon;
        private System.Windows.Forms.Label lblInfoCreatedBy;
        private System.Windows.Forms.Label lblInfoDateInstalled;
        private System.Windows.Forms.Label lblInfoVersion;
        private System.Windows.Forms.LinkLabel lnkReleasaeInfo;
        private System.Windows.Forms.LinkLabel lnkAuthorWebsite;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblDateInstalled;
    }
}
