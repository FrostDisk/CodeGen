namespace CodeGen.App.Controls
{
    partial class BasicProjectProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicProjectProperties));
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.lblProjectDescription = new System.Windows.Forms.Label();
            this.lblDatabaseType = new System.Windows.Forms.Label();
            this.cmbDatabaseType = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblProjectLocation = new System.Windows.Forms.Label();
            this.txtProjectLocation = new System.Windows.Forms.TextBox();
            this.btnSelectProjectLocation = new System.Windows.Forms.Button();
            this.folderBrowserSelectProjectLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            resources.ApplyResources(this.lblProjectName, "lblProjectName");
            this.lblProjectName.Name = "lblProjectName";
            // 
            // txtProjectName
            // 
            resources.ApplyResources(this.txtProjectName, "txtProjectName");
            this.txtProjectName.Name = "txtProjectName";
            // 
            // txtProjectDescription
            // 
            resources.ApplyResources(this.txtProjectDescription, "txtProjectDescription");
            this.txtProjectDescription.Name = "txtProjectDescription";
            // 
            // lblProjectDescription
            // 
            resources.ApplyResources(this.lblProjectDescription, "lblProjectDescription");
            this.lblProjectDescription.Name = "lblProjectDescription";
            // 
            // lblDatabaseType
            // 
            resources.ApplyResources(this.lblDatabaseType, "lblDatabaseType");
            this.lblDatabaseType.Name = "lblDatabaseType";
            // 
            // cmbDatabaseType
            // 
            resources.ApplyResources(this.cmbDatabaseType, "cmbDatabaseType");
            this.cmbDatabaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatabaseType.FormattingEnabled = true;
            this.cmbDatabaseType.Name = "cmbDatabaseType";
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.Name = "lblLanguage";
            // 
            // lblProjectLocation
            // 
            resources.ApplyResources(this.lblProjectLocation, "lblProjectLocation");
            this.lblProjectLocation.Name = "lblProjectLocation";
            // 
            // txtProjectLocation
            // 
            resources.ApplyResources(this.txtProjectLocation, "txtProjectLocation");
            this.txtProjectLocation.Name = "txtProjectLocation";
            this.txtProjectLocation.ReadOnly = true;
            // 
            // btnSelectProjectLocation
            // 
            resources.ApplyResources(this.btnSelectProjectLocation, "btnSelectProjectLocation");
            this.btnSelectProjectLocation.Name = "btnSelectProjectLocation";
            this.btnSelectProjectLocation.UseVisualStyleBackColor = true;
            this.btnSelectProjectLocation.Click += new System.EventHandler(this.btnSelectProjectLocation_Click);
            // 
            // folderBrowserSelectProjectLocation
            // 
            this.folderBrowserSelectProjectLocation.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // cmbLanguage
            // 
            resources.ApplyResources(this.cmbLanguage, "cmbLanguage");
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Name = "cmbLanguage";
            // 
            // BasicProjectProperties
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.lblProjectLocation);
            this.Controls.Add(this.txtProjectLocation);
            this.Controls.Add(this.btnSelectProjectLocation);
            this.Controls.Add(this.lblProjectDescription);
            this.Controls.Add(this.txtProjectDescription);
            this.Controls.Add(this.lblDatabaseType);
            this.Controls.Add(this.cmbDatabaseType);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cmbLanguage);
            this.Name = "BasicProjectProperties";
            this.Load += new System.EventHandler(this.BasicProjectProperties_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.Label lblProjectDescription;
        private System.Windows.Forms.Label lblDatabaseType;
        private System.Windows.Forms.ComboBox cmbDatabaseType;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblProjectLocation;
        private System.Windows.Forms.TextBox txtProjectLocation;
        private System.Windows.Forms.Button btnSelectProjectLocation;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserSelectProjectLocation;
        private System.Windows.Forms.ComboBox cmbLanguage;
    }
}
