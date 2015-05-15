﻿namespace CodeGen
{
    partial class FormCSharpCodeConfiguration
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
            this.tabConfiguration = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.paramBaseNamespace = new CodeGen.Controls.TemplateParameter();
            this.paramDataAccessNamespace = new CodeGen.Controls.TemplateParameter();
            this.paramDomainNamespace = new CodeGen.Controls.TemplateParameter();
            this.templateParameter10 = new CodeGen.Controls.TemplateParameter();
            this.templateParameter11 = new CodeGen.Controls.TemplateParameter();
            this.tabClasses = new System.Windows.Forms.TabPage();
            this.tableLayoutClasses = new System.Windows.Forms.TableLayoutPanel();
            this.paramDomainPrefix = new CodeGen.Controls.TemplateParameter();
            this.paramDomainSuffix = new CodeGen.Controls.TemplateParameter();
            this.paramDataAccessPrefix = new CodeGen.Controls.TemplateParameter();
            this.paramDataAccessSuffix = new CodeGen.Controls.TemplateParameter();
            this.tabProcedures = new System.Windows.Forms.TabPage();
            this.tableLayoutProcedures = new System.Windows.Forms.TableLayoutPanel();
            this.paramSavePrefix = new CodeGen.Controls.TemplateParameter();
            this.paramSaveSuffix = new CodeGen.Controls.TemplateParameter();
            this.paramGetByIdPrefix = new CodeGen.Controls.TemplateParameter();
            this.paramGetByIdSuffix = new CodeGen.Controls.TemplateParameter();
            this.paramListAllPrefix = new CodeGen.Controls.TemplateParameter();
            this.paramListAllSuffix = new CodeGen.Controls.TemplateParameter();
            this.paramDeletePrefix = new CodeGen.Controls.TemplateParameter();
            this.paramDeleteSuffix = new CodeGen.Controls.TemplateParameter();
            this.tabDataAccess = new System.Windows.Forms.TabPage();
            this.tableLayoutDataAccess = new System.Windows.Forms.TableLayoutPanel();
            this.paramSaveMethodName = new CodeGen.Controls.TemplateParameter();
            this.paramGetByIdMethodName = new CodeGen.Controls.TemplateParameter();
            this.paramListAllMethodName = new CodeGen.Controls.TemplateParameter();
            this.paramDeleteMethodName = new CodeGen.Controls.TemplateParameter();
            this.paramBuildFunctionMethodName = new CodeGen.Controls.TemplateParameter();
            this.tabAccessModel = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.paramGetScalarMethodName = new CodeGen.Controls.TemplateParameter();
            this.paramGetEntityMethodName = new CodeGen.Controls.TemplateParameter();
            this.paramGetDataTableMethodName = new CodeGen.Controls.TemplateParameter();
            this.paramExecuteStoredProcedureMethodName = new CodeGen.Controls.TemplateParameter();
            this.paramDBHelperInstanceObject = new CodeGen.Controls.TemplateParameter();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.tabConfiguration.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabClasses.SuspendLayout();
            this.tableLayoutClasses.SuspendLayout();
            this.tabProcedures.SuspendLayout();
            this.tableLayoutProcedures.SuspendLayout();
            this.tabDataAccess.SuspendLayout();
            this.tableLayoutDataAccess.SuspendLayout();
            this.tabAccessModel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabConfiguration.Controls.Add(this.tabGeneral);
            this.tabConfiguration.Controls.Add(this.tabClasses);
            this.tabConfiguration.Controls.Add(this.tabProcedures);
            this.tabConfiguration.Controls.Add(this.tabDataAccess);
            this.tabConfiguration.Controls.Add(this.tabAccessModel);
            this.tabConfiguration.Location = new System.Drawing.Point(12, 12);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.SelectedIndex = 0;
            this.tabConfiguration.Size = new System.Drawing.Size(482, 306);
            this.tabConfiguration.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tableLayoutPanel1);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(474, 280);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.paramBaseNamespace, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.paramDataAccessNamespace, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.paramDomainNamespace, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.templateParameter10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.templateParameter11, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(468, 274);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // paramBaseNamespace
            // 
            this.paramBaseNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramBaseNamespace.Location = new System.Drawing.Point(3, 3);
            this.paramBaseNamespace.Name = "paramBaseNamespace";
            this.paramBaseNamespace.ParameterCode = "NAMESPACE_BASE";
            this.paramBaseNamespace.ParameterName = "Base Namespace";
            this.paramBaseNamespace.ParameterValue = "MyProject";
            this.paramBaseNamespace.ReadOnly = false;
            this.paramBaseNamespace.Required = true;
            this.paramBaseNamespace.Size = new System.Drawing.Size(462, 46);
            this.paramBaseNamespace.TabIndex = 0;
            this.paramBaseNamespace.Tooltip = "";
            // 
            // paramDataAccessNamespace
            // 
            this.paramDataAccessNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramDataAccessNamespace.Location = new System.Drawing.Point(3, 107);
            this.paramDataAccessNamespace.Name = "paramDataAccessNamespace";
            this.paramDataAccessNamespace.ParameterCode = "NAMESPACE_DATAACCESS";
            this.paramDataAccessNamespace.ParameterName = "DataAccess Namespace";
            this.paramDataAccessNamespace.ParameterValue = "MyProject.Data";
            this.paramDataAccessNamespace.ReadOnly = false;
            this.paramDataAccessNamespace.Required = true;
            this.paramDataAccessNamespace.Size = new System.Drawing.Size(462, 46);
            this.paramDataAccessNamespace.TabIndex = 2;
            this.paramDataAccessNamespace.Tooltip = "";
            // 
            // paramDomainNamespace
            // 
            this.paramDomainNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramDomainNamespace.Location = new System.Drawing.Point(3, 55);
            this.paramDomainNamespace.Name = "paramDomainNamespace";
            this.paramDomainNamespace.ParameterCode = "NAMESPACE_DOMAIN";
            this.paramDomainNamespace.ParameterName = "Domain Namespace";
            this.paramDomainNamespace.ParameterValue = "MyProject.Domain";
            this.paramDomainNamespace.ReadOnly = false;
            this.paramDomainNamespace.Required = true;
            this.paramDomainNamespace.Size = new System.Drawing.Size(462, 46);
            this.paramDomainNamespace.TabIndex = 1;
            this.paramDomainNamespace.Tooltip = "";
            // 
            // templateParameter10
            // 
            this.templateParameter10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.templateParameter10.Location = new System.Drawing.Point(3, 159);
            this.templateParameter10.Name = "templateParameter10";
            this.templateParameter10.ParameterCode = "NAMESPACE_DBHELPER";
            this.templateParameter10.ParameterName = "DBHelper Namespace";
            this.templateParameter10.ParameterValue = "MyProject.AccessModel";
            this.templateParameter10.ReadOnly = false;
            this.templateParameter10.Required = true;
            this.templateParameter10.Size = new System.Drawing.Size(462, 46);
            this.templateParameter10.TabIndex = 3;
            this.templateParameter10.Tooltip = "";
            // 
            // templateParameter11
            // 
            this.templateParameter11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.templateParameter11.Location = new System.Drawing.Point(3, 211);
            this.templateParameter11.Name = "templateParameter11";
            this.templateParameter11.ParameterCode = "NAMESPACE_ACCESS_MODEL";
            this.templateParameter11.ParameterName = "Access Model Namespace";
            this.templateParameter11.ParameterValue = "MyProject.Library.AccessModel";
            this.templateParameter11.ReadOnly = false;
            this.templateParameter11.Required = true;
            this.templateParameter11.Size = new System.Drawing.Size(462, 46);
            this.templateParameter11.TabIndex = 4;
            this.templateParameter11.Tooltip = "";
            // 
            // tabClasses
            // 
            this.tabClasses.Controls.Add(this.tableLayoutClasses);
            this.tabClasses.Location = new System.Drawing.Point(4, 22);
            this.tabClasses.Name = "tabClasses";
            this.tabClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabClasses.Size = new System.Drawing.Size(474, 280);
            this.tabClasses.TabIndex = 1;
            this.tabClasses.Text = "Classes";
            this.tabClasses.UseVisualStyleBackColor = true;
            // 
            // tableLayoutClasses
            // 
            this.tableLayoutClasses.ColumnCount = 2;
            this.tableLayoutClasses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutClasses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutClasses.Controls.Add(this.paramDomainPrefix, 0, 0);
            this.tableLayoutClasses.Controls.Add(this.paramDomainSuffix, 1, 0);
            this.tableLayoutClasses.Controls.Add(this.paramDataAccessPrefix, 0, 1);
            this.tableLayoutClasses.Controls.Add(this.paramDataAccessSuffix, 1, 1);
            this.tableLayoutClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutClasses.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutClasses.Name = "tableLayoutClasses";
            this.tableLayoutClasses.RowCount = 3;
            this.tableLayoutClasses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutClasses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutClasses.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutClasses.Size = new System.Drawing.Size(468, 274);
            this.tableLayoutClasses.TabIndex = 4;
            // 
            // paramDomainPrefix
            // 
            this.paramDomainPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramDomainPrefix.Location = new System.Drawing.Point(3, 3);
            this.paramDomainPrefix.Name = "paramDomainPrefix";
            this.paramDomainPrefix.ParameterCode = "DOMAIN_PREFIX";
            this.paramDomainPrefix.ParameterName = "Domain Prefix";
            this.paramDomainPrefix.ParameterValue = "";
            this.paramDomainPrefix.ReadOnly = false;
            this.paramDomainPrefix.Required = false;
            this.paramDomainPrefix.Size = new System.Drawing.Size(228, 46);
            this.paramDomainPrefix.TabIndex = 0;
            this.paramDomainPrefix.Tooltip = "";
            // 
            // paramDomainSuffix
            // 
            this.paramDomainSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramDomainSuffix.Location = new System.Drawing.Point(237, 3);
            this.paramDomainSuffix.Name = "paramDomainSuffix";
            this.paramDomainSuffix.ParameterCode = "DOMAIN_SUFFIX";
            this.paramDomainSuffix.ParameterName = "Domain Suffix";
            this.paramDomainSuffix.ParameterValue = "";
            this.paramDomainSuffix.ReadOnly = false;
            this.paramDomainSuffix.Required = false;
            this.paramDomainSuffix.Size = new System.Drawing.Size(228, 46);
            this.paramDomainSuffix.TabIndex = 1;
            this.paramDomainSuffix.Tooltip = "";
            // 
            // paramDataAccessPrefix
            // 
            this.paramDataAccessPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramDataAccessPrefix.Location = new System.Drawing.Point(3, 55);
            this.paramDataAccessPrefix.Name = "paramDataAccessPrefix";
            this.paramDataAccessPrefix.ParameterCode = "DATAACCESS_PREFIX";
            this.paramDataAccessPrefix.ParameterName = "DataAccess Prefix";
            this.paramDataAccessPrefix.ParameterValue = "";
            this.paramDataAccessPrefix.ReadOnly = false;
            this.paramDataAccessPrefix.Required = false;
            this.paramDataAccessPrefix.Size = new System.Drawing.Size(228, 46);
            this.paramDataAccessPrefix.TabIndex = 2;
            this.paramDataAccessPrefix.Tooltip = "";
            // 
            // paramDataAccessSuffix
            // 
            this.paramDataAccessSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramDataAccessSuffix.Location = new System.Drawing.Point(237, 55);
            this.paramDataAccessSuffix.Name = "paramDataAccessSuffix";
            this.paramDataAccessSuffix.ParameterCode = "DATAACCESS_SUFFIX";
            this.paramDataAccessSuffix.ParameterName = "DataAccess Suffix";
            this.paramDataAccessSuffix.ParameterValue = "DataAccess";
            this.paramDataAccessSuffix.ReadOnly = false;
            this.paramDataAccessSuffix.Required = false;
            this.paramDataAccessSuffix.Size = new System.Drawing.Size(228, 46);
            this.paramDataAccessSuffix.TabIndex = 3;
            this.paramDataAccessSuffix.Tooltip = "";
            // 
            // tabProcedures
            // 
            this.tabProcedures.Controls.Add(this.tableLayoutProcedures);
            this.tabProcedures.Location = new System.Drawing.Point(4, 22);
            this.tabProcedures.Name = "tabProcedures";
            this.tabProcedures.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcedures.Size = new System.Drawing.Size(474, 280);
            this.tabProcedures.TabIndex = 2;
            this.tabProcedures.Text = "Procedures";
            this.tabProcedures.UseVisualStyleBackColor = true;
            // 
            // tableLayoutProcedures
            // 
            this.tableLayoutProcedures.ColumnCount = 2;
            this.tableLayoutProcedures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutProcedures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutProcedures.Controls.Add(this.paramSavePrefix, 0, 0);
            this.tableLayoutProcedures.Controls.Add(this.paramSaveSuffix, 1, 0);
            this.tableLayoutProcedures.Controls.Add(this.paramGetByIdPrefix, 0, 1);
            this.tableLayoutProcedures.Controls.Add(this.paramGetByIdSuffix, 1, 1);
            this.tableLayoutProcedures.Controls.Add(this.paramListAllPrefix, 0, 2);
            this.tableLayoutProcedures.Controls.Add(this.paramListAllSuffix, 1, 2);
            this.tableLayoutProcedures.Controls.Add(this.paramDeletePrefix, 0, 3);
            this.tableLayoutProcedures.Controls.Add(this.paramDeleteSuffix, 1, 3);
            this.tableLayoutProcedures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutProcedures.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutProcedures.Name = "tableLayoutProcedures";
            this.tableLayoutProcedures.RowCount = 5;
            this.tableLayoutProcedures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutProcedures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutProcedures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutProcedures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutProcedures.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutProcedures.Size = new System.Drawing.Size(468, 274);
            this.tableLayoutProcedures.TabIndex = 0;
            // 
            // paramSavePrefix
            // 
            this.paramSavePrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramSavePrefix.Location = new System.Drawing.Point(3, 3);
            this.paramSavePrefix.Name = "paramSavePrefix";
            this.paramSavePrefix.ParameterCode = "SAVE_PREFIX";
            this.paramSavePrefix.ParameterName = "Save Prefix";
            this.paramSavePrefix.ParameterValue = "sp_";
            this.paramSavePrefix.ReadOnly = false;
            this.paramSavePrefix.Required = false;
            this.paramSavePrefix.Size = new System.Drawing.Size(228, 46);
            this.paramSavePrefix.TabIndex = 0;
            this.paramSavePrefix.Tooltip = "";
            // 
            // paramSaveSuffix
            // 
            this.paramSaveSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramSaveSuffix.Location = new System.Drawing.Point(237, 3);
            this.paramSaveSuffix.Name = "paramSaveSuffix";
            this.paramSaveSuffix.ParameterCode = "SAVE_SUFFIX";
            this.paramSaveSuffix.ParameterName = "Save Suffix";
            this.paramSaveSuffix.ParameterValue = "_Save";
            this.paramSaveSuffix.ReadOnly = false;
            this.paramSaveSuffix.Required = true;
            this.paramSaveSuffix.Size = new System.Drawing.Size(228, 46);
            this.paramSaveSuffix.TabIndex = 1;
            this.paramSaveSuffix.Tooltip = "";
            // 
            // paramGetByIdPrefix
            // 
            this.paramGetByIdPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramGetByIdPrefix.Location = new System.Drawing.Point(3, 55);
            this.paramGetByIdPrefix.Name = "paramGetByIdPrefix";
            this.paramGetByIdPrefix.ParameterCode = "GETBYID_PREFIX";
            this.paramGetByIdPrefix.ParameterName = "GetById Prefix";
            this.paramGetByIdPrefix.ParameterValue = "sp_";
            this.paramGetByIdPrefix.ReadOnly = false;
            this.paramGetByIdPrefix.Required = false;
            this.paramGetByIdPrefix.Size = new System.Drawing.Size(228, 46);
            this.paramGetByIdPrefix.TabIndex = 2;
            this.paramGetByIdPrefix.Tooltip = "";
            // 
            // paramGetByIdSuffix
            // 
            this.paramGetByIdSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramGetByIdSuffix.Location = new System.Drawing.Point(237, 55);
            this.paramGetByIdSuffix.Name = "paramGetByIdSuffix";
            this.paramGetByIdSuffix.ParameterCode = "GETBYID_SUFFIX";
            this.paramGetByIdSuffix.ParameterName = "GetById Suffix";
            this.paramGetByIdSuffix.ParameterValue = "_GetByID";
            this.paramGetByIdSuffix.ReadOnly = false;
            this.paramGetByIdSuffix.Required = true;
            this.paramGetByIdSuffix.Size = new System.Drawing.Size(228, 46);
            this.paramGetByIdSuffix.TabIndex = 3;
            this.paramGetByIdSuffix.Tooltip = "";
            // 
            // paramListAllPrefix
            // 
            this.paramListAllPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramListAllPrefix.Location = new System.Drawing.Point(3, 107);
            this.paramListAllPrefix.Name = "paramListAllPrefix";
            this.paramListAllPrefix.ParameterCode = "LISTALL_PREFIX";
            this.paramListAllPrefix.ParameterName = "ListAll Prefix";
            this.paramListAllPrefix.ParameterValue = "sp_";
            this.paramListAllPrefix.ReadOnly = false;
            this.paramListAllPrefix.Required = false;
            this.paramListAllPrefix.Size = new System.Drawing.Size(228, 46);
            this.paramListAllPrefix.TabIndex = 4;
            this.paramListAllPrefix.Tooltip = "";
            // 
            // paramListAllSuffix
            // 
            this.paramListAllSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramListAllSuffix.Location = new System.Drawing.Point(237, 107);
            this.paramListAllSuffix.Name = "paramListAllSuffix";
            this.paramListAllSuffix.ParameterCode = "LISTALL_SUFFIX";
            this.paramListAllSuffix.ParameterName = "ListAll Suffix";
            this.paramListAllSuffix.ParameterValue = "_ListAll";
            this.paramListAllSuffix.ReadOnly = false;
            this.paramListAllSuffix.Required = true;
            this.paramListAllSuffix.Size = new System.Drawing.Size(228, 46);
            this.paramListAllSuffix.TabIndex = 5;
            this.paramListAllSuffix.Tooltip = "";
            // 
            // paramDeletePrefix
            // 
            this.paramDeletePrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramDeletePrefix.Location = new System.Drawing.Point(3, 159);
            this.paramDeletePrefix.Name = "paramDeletePrefix";
            this.paramDeletePrefix.ParameterCode = "DELETE_PREFIX";
            this.paramDeletePrefix.ParameterName = "Delete Prefix";
            this.paramDeletePrefix.ParameterValue = "sp_";
            this.paramDeletePrefix.ReadOnly = false;
            this.paramDeletePrefix.Required = false;
            this.paramDeletePrefix.Size = new System.Drawing.Size(228, 46);
            this.paramDeletePrefix.TabIndex = 6;
            this.paramDeletePrefix.Tooltip = "";
            // 
            // paramDeleteSuffix
            // 
            this.paramDeleteSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramDeleteSuffix.Location = new System.Drawing.Point(237, 159);
            this.paramDeleteSuffix.Name = "paramDeleteSuffix";
            this.paramDeleteSuffix.ParameterCode = "DELETE_SUFFIX";
            this.paramDeleteSuffix.ParameterName = "Delete Suffix";
            this.paramDeleteSuffix.ParameterValue = "_Delete";
            this.paramDeleteSuffix.ReadOnly = false;
            this.paramDeleteSuffix.Required = true;
            this.paramDeleteSuffix.Size = new System.Drawing.Size(228, 46);
            this.paramDeleteSuffix.TabIndex = 7;
            this.paramDeleteSuffix.Tooltip = "";
            // 
            // tabDataAccess
            // 
            this.tabDataAccess.Controls.Add(this.tableLayoutDataAccess);
            this.tabDataAccess.Location = new System.Drawing.Point(4, 22);
            this.tabDataAccess.Name = "tabDataAccess";
            this.tabDataAccess.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataAccess.Size = new System.Drawing.Size(474, 280);
            this.tabDataAccess.TabIndex = 3;
            this.tabDataAccess.Text = "DataAccess";
            this.tabDataAccess.UseVisualStyleBackColor = true;
            // 
            // tableLayoutDataAccess
            // 
            this.tableLayoutDataAccess.ColumnCount = 1;
            this.tableLayoutDataAccess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutDataAccess.Controls.Add(this.paramSaveMethodName, 0, 0);
            this.tableLayoutDataAccess.Controls.Add(this.paramGetByIdMethodName, 0, 1);
            this.tableLayoutDataAccess.Controls.Add(this.paramListAllMethodName, 0, 2);
            this.tableLayoutDataAccess.Controls.Add(this.paramDeleteMethodName, 0, 3);
            this.tableLayoutDataAccess.Controls.Add(this.paramBuildFunctionMethodName, 0, 4);
            this.tableLayoutDataAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutDataAccess.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutDataAccess.Name = "tableLayoutDataAccess";
            this.tableLayoutDataAccess.RowCount = 6;
            this.tableLayoutDataAccess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutDataAccess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutDataAccess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutDataAccess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutDataAccess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutDataAccess.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutDataAccess.Size = new System.Drawing.Size(468, 274);
            this.tableLayoutDataAccess.TabIndex = 0;
            // 
            // paramSaveMethodName
            // 
            this.paramSaveMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramSaveMethodName.Location = new System.Drawing.Point(3, 3);
            this.paramSaveMethodName.Name = "paramSaveMethodName";
            this.paramSaveMethodName.ParameterCode = "SAVE_METHODNAME";
            this.paramSaveMethodName.ParameterName = "Save Method Name";
            this.paramSaveMethodName.ParameterValue = "Save";
            this.paramSaveMethodName.ReadOnly = false;
            this.paramSaveMethodName.Required = true;
            this.paramSaveMethodName.Size = new System.Drawing.Size(462, 46);
            this.paramSaveMethodName.TabIndex = 0;
            this.paramSaveMethodName.Tooltip = "";
            // 
            // paramGetByIdMethodName
            // 
            this.paramGetByIdMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramGetByIdMethodName.Location = new System.Drawing.Point(3, 55);
            this.paramGetByIdMethodName.Name = "paramGetByIdMethodName";
            this.paramGetByIdMethodName.ParameterCode = "GETBYID_METHODNAME";
            this.paramGetByIdMethodName.ParameterName = "GetById Method Name";
            this.paramGetByIdMethodName.ParameterValue = "GetByID";
            this.paramGetByIdMethodName.ReadOnly = false;
            this.paramGetByIdMethodName.Required = true;
            this.paramGetByIdMethodName.Size = new System.Drawing.Size(462, 46);
            this.paramGetByIdMethodName.TabIndex = 2;
            this.paramGetByIdMethodName.Tooltip = "";
            // 
            // paramListAllMethodName
            // 
            this.paramListAllMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramListAllMethodName.Location = new System.Drawing.Point(3, 107);
            this.paramListAllMethodName.Name = "paramListAllMethodName";
            this.paramListAllMethodName.ParameterCode = "LISTALL_METHODNAME";
            this.paramListAllMethodName.ParameterName = "ListAll Method Name";
            this.paramListAllMethodName.ParameterValue = "ListAll";
            this.paramListAllMethodName.ReadOnly = false;
            this.paramListAllMethodName.Required = true;
            this.paramListAllMethodName.Size = new System.Drawing.Size(462, 46);
            this.paramListAllMethodName.TabIndex = 4;
            this.paramListAllMethodName.Tooltip = "";
            // 
            // paramDeleteMethodName
            // 
            this.paramDeleteMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramDeleteMethodName.Location = new System.Drawing.Point(3, 159);
            this.paramDeleteMethodName.Name = "paramDeleteMethodName";
            this.paramDeleteMethodName.ParameterCode = "DELETE_METHODNAME";
            this.paramDeleteMethodName.ParameterName = "Delete Method Name";
            this.paramDeleteMethodName.ParameterValue = "Delete";
            this.paramDeleteMethodName.ReadOnly = false;
            this.paramDeleteMethodName.Required = true;
            this.paramDeleteMethodName.Size = new System.Drawing.Size(462, 46);
            this.paramDeleteMethodName.TabIndex = 6;
            this.paramDeleteMethodName.Tooltip = "";
            // 
            // paramBuildFunctionMethodName
            // 
            this.paramBuildFunctionMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramBuildFunctionMethodName.Location = new System.Drawing.Point(3, 211);
            this.paramBuildFunctionMethodName.Name = "paramBuildFunctionMethodName";
            this.paramBuildFunctionMethodName.ParameterCode = "BUILDFUNCTION_METHODNAME";
            this.paramBuildFunctionMethodName.ParameterName = "BuildFunction Method Name";
            this.paramBuildFunctionMethodName.ParameterValue = "BuildFunction";
            this.paramBuildFunctionMethodName.ReadOnly = false;
            this.paramBuildFunctionMethodName.Required = true;
            this.paramBuildFunctionMethodName.Size = new System.Drawing.Size(462, 46);
            this.paramBuildFunctionMethodName.TabIndex = 8;
            this.paramBuildFunctionMethodName.Tooltip = "";
            // 
            // tabAccessModel
            // 
            this.tabAccessModel.Controls.Add(this.tableLayoutPanel2);
            this.tabAccessModel.Location = new System.Drawing.Point(4, 22);
            this.tabAccessModel.Name = "tabAccessModel";
            this.tabAccessModel.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccessModel.Size = new System.Drawing.Size(474, 280);
            this.tabAccessModel.TabIndex = 4;
            this.tabAccessModel.Text = "AccessModel";
            this.tabAccessModel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.paramGetScalarMethodName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.paramGetEntityMethodName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.paramGetDataTableMethodName, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.paramExecuteStoredProcedureMethodName, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.paramDBHelperInstanceObject, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(468, 274);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // paramGetScalarMethodName
            // 
            this.paramGetScalarMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramGetScalarMethodName.Location = new System.Drawing.Point(3, 3);
            this.paramGetScalarMethodName.Name = "paramGetScalarMethodName";
            this.paramGetScalarMethodName.ParameterCode = "GETSCALAR_METHODNAME";
            this.paramGetScalarMethodName.ParameterName = "GetScalar Method Name";
            this.paramGetScalarMethodName.ParameterValue = "GetScalar";
            this.paramGetScalarMethodName.ReadOnly = false;
            this.paramGetScalarMethodName.Required = true;
            this.paramGetScalarMethodName.Size = new System.Drawing.Size(462, 46);
            this.paramGetScalarMethodName.TabIndex = 0;
            this.paramGetScalarMethodName.Tooltip = "";
            // 
            // paramGetEntityMethodName
            // 
            this.paramGetEntityMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramGetEntityMethodName.Location = new System.Drawing.Point(3, 55);
            this.paramGetEntityMethodName.Name = "paramGetEntityMethodName";
            this.paramGetEntityMethodName.ParameterCode = "GETENTITY_METHODNAME";
            this.paramGetEntityMethodName.ParameterName = "GetEntity Method Name";
            this.paramGetEntityMethodName.ParameterValue = "GetEntity";
            this.paramGetEntityMethodName.ReadOnly = false;
            this.paramGetEntityMethodName.Required = true;
            this.paramGetEntityMethodName.Size = new System.Drawing.Size(462, 46);
            this.paramGetEntityMethodName.TabIndex = 1;
            this.paramGetEntityMethodName.Tooltip = "";
            // 
            // paramGetDataTableMethodName
            // 
            this.paramGetDataTableMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramGetDataTableMethodName.Location = new System.Drawing.Point(3, 107);
            this.paramGetDataTableMethodName.Name = "paramGetDataTableMethodName";
            this.paramGetDataTableMethodName.ParameterCode = "GETDATATABLE_METHODNAME";
            this.paramGetDataTableMethodName.ParameterName = "GetDataTable Method Name";
            this.paramGetDataTableMethodName.ParameterValue = "GetDataTable";
            this.paramGetDataTableMethodName.ReadOnly = false;
            this.paramGetDataTableMethodName.Required = true;
            this.paramGetDataTableMethodName.Size = new System.Drawing.Size(462, 46);
            this.paramGetDataTableMethodName.TabIndex = 2;
            this.paramGetDataTableMethodName.Tooltip = "";
            // 
            // paramExecuteStoredProcedureMethodName
            // 
            this.paramExecuteStoredProcedureMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramExecuteStoredProcedureMethodName.Location = new System.Drawing.Point(3, 159);
            this.paramExecuteStoredProcedureMethodName.Name = "paramExecuteStoredProcedureMethodName";
            this.paramExecuteStoredProcedureMethodName.ParameterCode = "EXECUTESP_METHODNAME";
            this.paramExecuteStoredProcedureMethodName.ParameterName = "ExecuteStoredProcedure Method Name";
            this.paramExecuteStoredProcedureMethodName.ParameterValue = "ExecuteStoredProcedure";
            this.paramExecuteStoredProcedureMethodName.ReadOnly = false;
            this.paramExecuteStoredProcedureMethodName.Required = true;
            this.paramExecuteStoredProcedureMethodName.Size = new System.Drawing.Size(462, 46);
            this.paramExecuteStoredProcedureMethodName.TabIndex = 3;
            this.paramExecuteStoredProcedureMethodName.Tooltip = "";
            // 
            // paramDBHelperInstanceObject
            // 
            this.paramDBHelperInstanceObject.Location = new System.Drawing.Point(3, 211);
            this.paramDBHelperInstanceObject.Name = "paramDBHelperInstanceObject";
            this.paramDBHelperInstanceObject.ParameterCode = "DBHELPER_INSTANCEOBJECT";
            this.paramDBHelperInstanceObject.ParameterName = "DBHelper Instance Object";
            this.paramDBHelperInstanceObject.ParameterValue = "DBHelper.Instance";
            this.paramDBHelperInstanceObject.ReadOnly = false;
            this.paramDBHelperInstanceObject.Required = true;
            this.paramDBHelperInstanceObject.Size = new System.Drawing.Size(436, 46);
            this.paramDBHelperInstanceObject.TabIndex = 4;
            this.paramDBHelperInstanceObject.Tooltip = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(419, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(338, 324);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // FormCSharpCodeConfiguration
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(506, 359);
            this.Controls.Add(this.tabConfiguration);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCSharpCodeConfiguration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Template Configuration";
            this.tabConfiguration.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabClasses.ResumeLayout(false);
            this.tableLayoutClasses.ResumeLayout(false);
            this.tabProcedures.ResumeLayout(false);
            this.tableLayoutProcedures.ResumeLayout(false);
            this.tabDataAccess.ResumeLayout(false);
            this.tableLayoutDataAccess.ResumeLayout(false);
            this.tabAccessModel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConfiguration;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabClasses;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TabPage tabProcedures;
        private System.Windows.Forms.TabPage tabDataAccess;
        private Controls.TemplateParameter paramBaseNamespace;
        private Controls.TemplateParameter paramDomainNamespace;
        private Controls.TemplateParameter paramDataAccessNamespace;
        private System.Windows.Forms.TableLayoutPanel tableLayoutClasses;
        private Controls.TemplateParameter paramDomainPrefix;
        private Controls.TemplateParameter paramDataAccessSuffix;
        private Controls.TemplateParameter paramDataAccessPrefix;
        private Controls.TemplateParameter paramDomainSuffix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutProcedures;
        private Controls.TemplateParameter paramSavePrefix;
        private Controls.TemplateParameter paramSaveSuffix;
        private Controls.TemplateParameter paramGetByIdPrefix;
        private Controls.TemplateParameter paramGetByIdSuffix;
        private Controls.TemplateParameter paramListAllPrefix;
        private Controls.TemplateParameter paramListAllSuffix;
        private Controls.TemplateParameter paramDeletePrefix;
        private Controls.TemplateParameter paramDeleteSuffix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutDataAccess;
        private Controls.TemplateParameter paramSaveMethodName;
        private Controls.TemplateParameter paramGetByIdMethodName;
        private Controls.TemplateParameter paramListAllMethodName;
        private Controls.TemplateParameter paramDeleteMethodName;
        private Controls.TemplateParameter paramBuildFunctionMethodName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.TemplateParameter templateParameter10;
        private Controls.TemplateParameter templateParameter11;
        private System.Windows.Forms.TabPage tabAccessModel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controls.TemplateParameter paramGetScalarMethodName;
        private Controls.TemplateParameter paramGetEntityMethodName;
        private Controls.TemplateParameter paramGetDataTableMethodName;
        private Controls.TemplateParameter paramExecuteStoredProcedureMethodName;
        private Controls.TemplateParameter paramDBHelperInstanceObject;
    }
}