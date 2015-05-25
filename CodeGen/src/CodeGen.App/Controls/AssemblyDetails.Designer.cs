namespace CodeGen.Controls
{
    partial class AssemblyDetails
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
            this.lblAssemblyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAssemblyName
            // 
            this.lblAssemblyName.AutoSize = true;
            this.lblAssemblyName.Location = new System.Drawing.Point(25, 41);
            this.lblAssemblyName.Name = "lblAssemblyName";
            this.lblAssemblyName.Size = new System.Drawing.Size(35, 13);
            this.lblAssemblyName.TabIndex = 0;
            this.lblAssemblyName.Text = "label1";
            // 
            // AseemblyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAssemblyName);
            this.Name = "AseemblyDetails";
            this.Size = new System.Drawing.Size(201, 394);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAssemblyName;
    }
}
