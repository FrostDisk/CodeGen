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
            this.lblPluginTitle = new System.Windows.Forms.Label();
            this.txtPluginDescription = new System.Windows.Forms.TextBox();
            this.lblPluginVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPluginTitle
            // 
            this.lblPluginTitle.AutoSize = true;
            this.lblPluginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPluginTitle.Location = new System.Drawing.Point(3, 0);
            this.lblPluginTitle.Name = "lblPluginTitle";
            this.lblPluginTitle.Size = new System.Drawing.Size(115, 24);
            this.lblPluginTitle.TabIndex = 1;
            this.lblPluginTitle.Text = "Plugin Title";
            // 
            // txtPluginDescription
            // 
            this.txtPluginDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPluginDescription.Location = new System.Drawing.Point(3, 64);
            this.txtPluginDescription.Multiline = true;
            this.txtPluginDescription.Name = "txtPluginDescription";
            this.txtPluginDescription.ReadOnly = true;
            this.txtPluginDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPluginDescription.Size = new System.Drawing.Size(269, 82);
            this.txtPluginDescription.TabIndex = 1;
            // 
            // lblPluginVersion
            // 
            this.lblPluginVersion.AutoSize = true;
            this.lblPluginVersion.Location = new System.Drawing.Point(3, 24);
            this.lblPluginVersion.Name = "lblPluginVersion";
            this.lblPluginVersion.Size = new System.Drawing.Size(74, 13);
            this.lblPluginVersion.TabIndex = 1;
            this.lblPluginVersion.Text = "Plugin Version";
            // 
            // PluginDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPluginTitle);
            this.Controls.Add(this.lblPluginVersion);
            this.Controls.Add(this.txtPluginDescription);
            this.Name = "PluginDetails";
            this.Size = new System.Drawing.Size(275, 149);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPluginTitle;
        private System.Windows.Forms.TextBox txtPluginDescription;
        private System.Windows.Forms.Label lblPluginVersion;
    }
}
