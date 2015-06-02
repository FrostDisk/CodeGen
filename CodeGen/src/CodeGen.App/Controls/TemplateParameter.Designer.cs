namespace CodeGen.Controls
{
    partial class TemplateParameter
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.toolTipParameter = new System.Windows.Forms.ToolTip(this.components);
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
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.Location = new System.Drawing.Point(3, 23);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(304, 20);
            this.txtValue.TabIndex = 1;
            this.txtValue.Enter += new System.EventHandler(this.txtValue_Enter);
            this.txtValue.Leave += new System.EventHandler(this.txtValue_Leave);
            // 
            // lblCode
            // 
            this.lblCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCode.Location = new System.Drawing.Point(107, 7);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(200, 13);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "label2";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TemplateParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtValue);
            this.Name = "TemplateParameter";
            this.Size = new System.Drawing.Size(310, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ToolTip toolTipParameter;
    }
}
