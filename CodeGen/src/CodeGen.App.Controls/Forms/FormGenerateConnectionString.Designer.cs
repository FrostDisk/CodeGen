namespace CodeGen.App.Controls.Forms
{
    partial class FormGenerateConnectionString
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerateConnectionString));
            this.lblServerType = new System.Windows.Forms.Label();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.cmbServerType = new System.Windows.Forms.ComboBox();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbDatabaseName = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServerType
            // 
            resources.ApplyResources(this.lblServerType, "lblServerType");
            this.lblServerType.Name = "lblServerType";
            // 
            // lblDataSource
            // 
            resources.ApplyResources(this.lblDataSource, "lblDataSource");
            this.lblDataSource.Name = "lblDataSource";
            // 
            // lblUserID
            // 
            resources.ApplyResources(this.lblUserID, "lblUserID");
            this.lblUserID.Name = "lblUserID";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // lblDatabaseName
            // 
            resources.ApplyResources(this.lblDatabaseName, "lblDatabaseName");
            this.lblDatabaseName.Name = "lblDatabaseName";
            // 
            // cmbServerType
            // 
            resources.ApplyResources(this.cmbServerType, "cmbServerType");
            this.cmbServerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServerType.FormattingEnabled = true;
            this.cmbServerType.Name = "cmbServerType";
            // 
            // txtDataSource
            // 
            resources.ApplyResources(this.txtDataSource, "txtDataSource");
            this.txtDataSource.Name = "txtDataSource";
            // 
            // txtUserID
            // 
            resources.ApplyResources(this.txtUserID, "txtUserID");
            this.txtUserID.Name = "txtUserID";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // cmbDatabaseName
            // 
            resources.ApplyResources(this.cmbDatabaseName, "cmbDatabaseName");
            this.cmbDatabaseName.FormattingEnabled = true;
            this.cmbDatabaseName.Name = "cmbDatabaseName";
            this.cmbDatabaseName.Enter += new System.EventHandler(this.cmbDatabaseName_Enter);
            // 
            // btnAccept
            // 
            resources.ApplyResources(this.btnAccept, "btnAccept");
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.Controls.Add(this.lblServerType, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.cmbServerType, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblDataSource, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtDataSource, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblUserID, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.txtUserID, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblPassword, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.txtPassword, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lblDatabaseName, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.cmbDatabaseName, 1, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // FormGenerateConnectionString
            // 
            this.AcceptButton = this.btnAccept;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGenerateConnectionString";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServerType;
        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.ComboBox cmbServerType;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbDatabaseName;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}