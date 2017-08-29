namespace CodeGen.AccessModel.SqlServer
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
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlAuthentication = new System.Windows.Forms.Panel();
            this.rbtnWindowsAuthentication = new System.Windows.Forms.RadioButton();
            this.rbtnSqlServerAuthentication = new System.Windows.Forms.RadioButton();
            this.lblAuthentication = new System.Windows.Forms.Label();
            this.workerLoadDatabases = new System.ComponentModel.BackgroundWorker();
            this.pnlAuthentication.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            resources.ApplyResources(this.lblServerName, "lblServerName");
            this.lblServerName.Name = "lblServerName";
            // 
            // lblLogin
            // 
            resources.ApplyResources(this.lblLogin, "lblLogin");
            this.lblLogin.Name = "lblLogin";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // lblDatabase
            // 
            resources.ApplyResources(this.lblDatabase, "lblDatabase");
            this.lblDatabase.Name = "lblDatabase";
            // 
            // txtServerName
            // 
            resources.ApplyResources(this.txtServerName, "txtServerName");
            this.txtServerName.Name = "txtServerName";
            // 
            // txtLogin
            // 
            resources.ApplyResources(this.txtLogin, "txtLogin");
            this.txtLogin.Name = "txtLogin";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cmbDatabase
            // 
            resources.ApplyResources(this.cmbDatabase, "cmbDatabase");
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Enter += new System.EventHandler(this.cmbDatabaseName_Enter);
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
            // pnlAuthentication
            // 
            resources.ApplyResources(this.pnlAuthentication, "pnlAuthentication");
            this.pnlAuthentication.Controls.Add(this.rbtnWindowsAuthentication);
            this.pnlAuthentication.Controls.Add(this.rbtnSqlServerAuthentication);
            this.pnlAuthentication.Name = "pnlAuthentication";
            // 
            // rbtnWindowsAuthentication
            // 
            resources.ApplyResources(this.rbtnWindowsAuthentication, "rbtnWindowsAuthentication");
            this.rbtnWindowsAuthentication.Checked = true;
            this.rbtnWindowsAuthentication.Name = "rbtnWindowsAuthentication";
            this.rbtnWindowsAuthentication.TabStop = true;
            this.rbtnWindowsAuthentication.UseVisualStyleBackColor = true;
            this.rbtnWindowsAuthentication.CheckedChanged += new System.EventHandler(this.rbtnWindowsAuthentication_CheckedChanged);
            // 
            // rbtnSqlServerAuthentication
            // 
            resources.ApplyResources(this.rbtnSqlServerAuthentication, "rbtnSqlServerAuthentication");
            this.rbtnSqlServerAuthentication.Name = "rbtnSqlServerAuthentication";
            this.rbtnSqlServerAuthentication.UseVisualStyleBackColor = true;
            this.rbtnSqlServerAuthentication.CheckedChanged += new System.EventHandler(this.rbtnSqlServerAuthentication_CheckedChanged);
            // 
            // lblAuthentication
            // 
            resources.ApplyResources(this.lblAuthentication, "lblAuthentication");
            this.lblAuthentication.Name = "lblAuthentication";
            // 
            // workerLoadDatabases
            // 
            this.workerLoadDatabases.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerLoadDatabases_DoWork);
            this.workerLoadDatabases.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerLoadDatabases_RunWorkerCompleted);
            // 
            // FormGenerateConnectionString
            // 
            this.AcceptButton = this.btnAccept;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblAuthentication);
            this.Controls.Add(this.pnlAuthentication);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGenerateConnectionString";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.pnlAuthentication.ResumeLayout(false);
            this.pnlAuthentication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlAuthentication;
        private System.Windows.Forms.RadioButton rbtnSqlServerAuthentication;
        private System.Windows.Forms.RadioButton rbtnWindowsAuthentication;
        private System.Windows.Forms.Label lblAuthentication;
        private System.ComponentModel.BackgroundWorker workerLoadDatabases;
    }
}