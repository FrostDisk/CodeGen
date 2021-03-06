﻿using CodeGen.Controls;

namespace CodeGen
{
    partial class FormNewProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewProject));
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ucBasicProjectProperties = new CodeGen.Controls.BasicProjectProperties();
            this.workerValidateForm = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ucBasicProjectProperties
            // 
            resources.ApplyResources(this.ucBasicProjectProperties, "ucBasicProjectProperties");
            this.ucBasicProjectProperties.DefaultProjectLocation = null;
            this.ucBasicProjectProperties.DefaultProjectName = null;
            this.ucBasicProjectProperties.IsLoaded = false;
            this.ucBasicProjectProperties.Name = "ucBasicProjectProperties";
            // 
            // workerValidateForm
            // 
            this.workerValidateForm.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerValidateForm_DoWork);
            this.workerValidateForm.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerValidateForm_RunWorkerCompleted);
            // 
            // FormNewProject
            // 
            this.AcceptButton = this.btnAccept;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.ucBasicProjectProperties);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewProject";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private BasicProjectProperties ucBasicProjectProperties;
        private System.ComponentModel.BackgroundWorker workerValidateForm;
    }
}