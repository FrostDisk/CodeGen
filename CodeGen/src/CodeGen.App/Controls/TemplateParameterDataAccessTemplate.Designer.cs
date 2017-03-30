namespace CodeGen.Controls
{
    partial class TemplateParameterDataAccessTemplate
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.toolTipParameter = new System.Windows.Forms.ToolTip(this.components);
            this.radioDataAccessTemplateDefault = new System.Windows.Forms.RadioButton();
            this.radioDataAccessTemplateEnglish = new System.Windows.Forms.RadioButton();
            this.radioDataAccessTemplateSpanish = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // lblCode
            // 
            this.lblCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCode.Location = new System.Drawing.Point(240, 7);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(200, 13);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "label2";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // radioDataAccessTemplateDefault
            // 
            this.radioDataAccessTemplateDefault.AutoSize = true;
            this.radioDataAccessTemplateDefault.Checked = true;
            this.radioDataAccessTemplateDefault.Location = new System.Drawing.Point(6, 23);
            this.radioDataAccessTemplateDefault.Name = "radioDataAccessTemplateDefault";
            this.radioDataAccessTemplateDefault.Size = new System.Drawing.Size(59, 17);
            this.radioDataAccessTemplateDefault.TabIndex = 8;
            this.radioDataAccessTemplateDefault.TabStop = true;
            this.radioDataAccessTemplateDefault.Text = "Default";
            this.radioDataAccessTemplateDefault.UseVisualStyleBackColor = true;
            // 
            // radioDataAccessTemplateEnglish
            // 
            this.radioDataAccessTemplateEnglish.AutoSize = true;
            this.radioDataAccessTemplateEnglish.Location = new System.Drawing.Point(84, 23);
            this.radioDataAccessTemplateEnglish.Name = "radioDataAccessTemplateEnglish";
            this.radioDataAccessTemplateEnglish.Size = new System.Drawing.Size(165, 17);
            this.radioDataAccessTemplateEnglish.TabIndex = 9;
            this.radioDataAccessTemplateEnglish.Text = "AccessModel Library (english)";
            this.radioDataAccessTemplateEnglish.UseVisualStyleBackColor = true;
            // 
            // radioDataAccessTemplateSpanish
            // 
            this.radioDataAccessTemplateSpanish.AutoSize = true;
            this.radioDataAccessTemplateSpanish.Location = new System.Drawing.Point(267, 23);
            this.radioDataAccessTemplateSpanish.Name = "radioDataAccessTemplateSpanish";
            this.radioDataAccessTemplateSpanish.Size = new System.Drawing.Size(168, 17);
            this.radioDataAccessTemplateSpanish.TabIndex = 10;
            this.radioDataAccessTemplateSpanish.Text = "AccessModel Library (spanish)";
            this.radioDataAccessTemplateSpanish.UseVisualStyleBackColor = true;
            // 
            // TemplateParameterDataAccessTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioDataAccessTemplateDefault);
            this.Controls.Add(this.radioDataAccessTemplateEnglish);
            this.Controls.Add(this.radioDataAccessTemplateSpanish);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Name = "TemplateParameterDataAccessTemplate";
            this.Size = new System.Drawing.Size(443, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ToolTip toolTipParameter;
        private System.Windows.Forms.RadioButton radioDataAccessTemplateDefault;
        private System.Windows.Forms.RadioButton radioDataAccessTemplateEnglish;
        private System.Windows.Forms.RadioButton radioDataAccessTemplateSpanish;
    }
}
