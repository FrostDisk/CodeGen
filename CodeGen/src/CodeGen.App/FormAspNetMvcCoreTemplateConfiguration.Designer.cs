namespace CodeGen
{
    partial class FormAspNetMvcCoreTemplateConfiguration
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
            this.tableLayoutGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.tabClasses = new System.Windows.Forms.TabPage();
            this.tableLayoutClasses = new System.Windows.Forms.TableLayoutPanel();
            this.tabController = new System.Windows.Forms.TabPage();
            this.tableLayoutController = new System.Windows.Forms.TableLayoutPanel();
            this.tabDatabase = new System.Windows.Forms.TabPage();
            this.tableLayoutDatabase = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.paramAuthorName = new CodeGen.Controls.TemplateParameter();
            this.paramModelsNamespace = new CodeGen.Controls.TemplateParameter();
            this.paramControllerNamespace = new CodeGen.Controls.TemplateParameter();
            this.paramDatabaseContextNamespace = new CodeGen.Controls.TemplateParameter();
            this.paramModelPrefix = new CodeGen.Controls.TemplateParameter();
            this.paramModelSuffix = new CodeGen.Controls.TemplateParameter();
            this.paramControllerPrefix = new CodeGen.Controls.TemplateParameter();
            this.paramControllerSuffix = new CodeGen.Controls.TemplateParameter();
            this.paramViewPrefix = new CodeGen.Controls.TemplateParameter();
            this.paramViewSuffix = new CodeGen.Controls.TemplateParameter();
            this.paramDetailsMethodName = new CodeGen.Controls.TemplateParameter();
            this.paramCreateMethodName = new CodeGen.Controls.TemplateParameter();
            this.paramEditMethodName = new CodeGen.Controls.TemplateParameter();
            this.paramDeleteMethodName = new CodeGen.Controls.TemplateParameter();
            this.paramDatabaseContextClassName = new CodeGen.Controls.TemplateParameter();
            this.tabConfiguration.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tableLayoutGeneral.SuspendLayout();
            this.tabClasses.SuspendLayout();
            this.tableLayoutClasses.SuspendLayout();
            this.tabController.SuspendLayout();
            this.tableLayoutController.SuspendLayout();
            this.tabDatabase.SuspendLayout();
            this.tableLayoutDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabConfiguration.Controls.Add(this.tabGeneral);
            this.tabConfiguration.Controls.Add(this.tabClasses);
            this.tabConfiguration.Controls.Add(this.tabController);
            this.tabConfiguration.Controls.Add(this.tabDatabase);
            this.tabConfiguration.Location = new System.Drawing.Point(12, 12);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.SelectedIndex = 0;
            this.tabConfiguration.Size = new System.Drawing.Size(482, 304);
            this.tabConfiguration.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tableLayoutGeneral);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(474, 278);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tableLayoutGeneral
            // 
            this.tableLayoutGeneral.ColumnCount = 1;
            this.tableLayoutGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutGeneral.Controls.Add(this.paramAuthorName, 0, 0);
            this.tableLayoutGeneral.Controls.Add(this.paramModelsNamespace, 0, 1);
            this.tableLayoutGeneral.Controls.Add(this.paramControllerNamespace, 0, 2);
            this.tableLayoutGeneral.Controls.Add(this.paramDatabaseContextNamespace, 0, 3);
            this.tableLayoutGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutGeneral.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutGeneral.Name = "tableLayoutGeneral";
            this.tableLayoutGeneral.RowCount = 6;
            this.tableLayoutGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutGeneral.Size = new System.Drawing.Size(468, 272);
            this.tableLayoutGeneral.TabIndex = 3;
            // 
            // tabClasses
            // 
            this.tabClasses.Controls.Add(this.tableLayoutClasses);
            this.tabClasses.Location = new System.Drawing.Point(4, 22);
            this.tabClasses.Name = "tabClasses";
            this.tabClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabClasses.Size = new System.Drawing.Size(474, 278);
            this.tabClasses.TabIndex = 1;
            this.tabClasses.Text = "Classes";
            this.tabClasses.UseVisualStyleBackColor = true;
            // 
            // tableLayoutClasses
            // 
            this.tableLayoutClasses.ColumnCount = 2;
            this.tableLayoutClasses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutClasses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutClasses.Controls.Add(this.paramModelPrefix, 0, 0);
            this.tableLayoutClasses.Controls.Add(this.paramModelSuffix, 1, 0);
            this.tableLayoutClasses.Controls.Add(this.paramControllerPrefix, 0, 1);
            this.tableLayoutClasses.Controls.Add(this.paramControllerSuffix, 1, 1);
            this.tableLayoutClasses.Controls.Add(this.paramViewPrefix, 0, 2);
            this.tableLayoutClasses.Controls.Add(this.paramViewSuffix, 1, 2);
            this.tableLayoutClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutClasses.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutClasses.Name = "tableLayoutClasses";
            this.tableLayoutClasses.RowCount = 4;
            this.tableLayoutClasses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutClasses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutClasses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutClasses.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutClasses.Size = new System.Drawing.Size(468, 272);
            this.tableLayoutClasses.TabIndex = 4;
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tableLayoutController);
            this.tabController.Location = new System.Drawing.Point(4, 22);
            this.tabController.Name = "tabController";
            this.tabController.Padding = new System.Windows.Forms.Padding(3);
            this.tabController.Size = new System.Drawing.Size(474, 278);
            this.tabController.TabIndex = 3;
            this.tabController.Text = "Controller";
            this.tabController.UseVisualStyleBackColor = true;
            // 
            // tableLayoutController
            // 
            this.tableLayoutController.ColumnCount = 1;
            this.tableLayoutController.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutController.Controls.Add(this.paramDetailsMethodName, 0, 0);
            this.tableLayoutController.Controls.Add(this.paramCreateMethodName, 0, 1);
            this.tableLayoutController.Controls.Add(this.paramEditMethodName, 0, 2);
            this.tableLayoutController.Controls.Add(this.paramDeleteMethodName, 0, 3);
            this.tableLayoutController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutController.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutController.Name = "tableLayoutController";
            this.tableLayoutController.RowCount = 6;
            this.tableLayoutController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutController.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutController.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutController.Size = new System.Drawing.Size(468, 272);
            this.tableLayoutController.TabIndex = 0;
            // 
            // tabDatabase
            // 
            this.tabDatabase.Controls.Add(this.tableLayoutDatabase);
            this.tabDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatabase.Size = new System.Drawing.Size(474, 278);
            this.tabDatabase.TabIndex = 4;
            this.tabDatabase.Text = "Database";
            this.tabDatabase.UseVisualStyleBackColor = true;
            // 
            // tableLayoutDatabase
            // 
            this.tableLayoutDatabase.ColumnCount = 1;
            this.tableLayoutDatabase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutDatabase.Controls.Add(this.paramDatabaseContextClassName, 0, 0);
            this.tableLayoutDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutDatabase.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutDatabase.Name = "tableLayoutDatabase";
            this.tableLayoutDatabase.RowCount = 6;
            this.tableLayoutDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutDatabase.Size = new System.Drawing.Size(468, 272);
            this.tableLayoutDatabase.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(419, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 101;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Location = new System.Drawing.Point(338, 322);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 100;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // paramAuthorName
            // 
            this.paramAuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramAuthorName.DefaultValue = "";
            this.paramAuthorName.IsUpdated = false;
            this.paramAuthorName.Location = new System.Drawing.Point(3, 3);
            this.paramAuthorName.Name = "paramAuthorName";
            this.paramAuthorName.ParameterCode = "AUTHOR_NAME";
            this.paramAuthorName.ParameterName = "Author Name";
            this.paramAuthorName.ParameterValue = "";
            this.paramAuthorName.ReadOnly = false;
            this.paramAuthorName.Required = true;
            this.paramAuthorName.Size = new System.Drawing.Size(462, 46);
            this.paramAuthorName.TabIndex = 0;
            this.paramAuthorName.Tooltip = "";
            // 
            // paramModelsNamespace
            // 
            this.paramModelsNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramModelsNamespace.DefaultValue = "MyProject.Models";
            this.paramModelsNamespace.IsUpdated = false;
            this.paramModelsNamespace.Location = new System.Drawing.Point(3, 55);
            this.paramModelsNamespace.Name = "paramModelsNamespace";
            this.paramModelsNamespace.ParameterCode = "NAMESPACE_MODELS";
            this.paramModelsNamespace.ParameterName = "Models Namespace";
            this.paramModelsNamespace.ParameterValue = "MyProject.Models";
            this.paramModelsNamespace.ReadOnly = false;
            this.paramModelsNamespace.Required = true;
            this.paramModelsNamespace.Size = new System.Drawing.Size(462, 46);
            this.paramModelsNamespace.TabIndex = 1;
            this.paramModelsNamespace.Tooltip = "";
            // 
            // paramControllerNamespace
            // 
            this.paramControllerNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramControllerNamespace.DefaultValue = "MyProject.Controller";
            this.paramControllerNamespace.IsUpdated = false;
            this.paramControllerNamespace.Location = new System.Drawing.Point(3, 107);
            this.paramControllerNamespace.Name = "paramControllerNamespace";
            this.paramControllerNamespace.ParameterCode = "NAMESPACE_CONTROLLER";
            this.paramControllerNamespace.ParameterName = "Controller Namespace";
            this.paramControllerNamespace.ParameterValue = "MyProject.Controller";
            this.paramControllerNamespace.ReadOnly = false;
            this.paramControllerNamespace.Required = true;
            this.paramControllerNamespace.Size = new System.Drawing.Size(462, 46);
            this.paramControllerNamespace.TabIndex = 2;
            this.paramControllerNamespace.Tooltip = "";
            // 
            // paramDatabaseContextNamespace
            // 
            this.paramDatabaseContextNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramDatabaseContextNamespace.DefaultValue = "MyProject.Data";
            this.paramDatabaseContextNamespace.IsUpdated = false;
            this.paramDatabaseContextNamespace.Location = new System.Drawing.Point(3, 159);
            this.paramDatabaseContextNamespace.Name = "paramDatabaseContextNamespace";
            this.paramDatabaseContextNamespace.ParameterCode = "NAMESPACE_DBCONTEXT";
            this.paramDatabaseContextNamespace.ParameterName = "Database Context Namespace";
            this.paramDatabaseContextNamespace.ParameterValue = "MyProject.Data";
            this.paramDatabaseContextNamespace.ReadOnly = false;
            this.paramDatabaseContextNamespace.Required = true;
            this.paramDatabaseContextNamespace.Size = new System.Drawing.Size(462, 46);
            this.paramDatabaseContextNamespace.TabIndex = 3;
            this.paramDatabaseContextNamespace.Tooltip = "";
            // 
            // paramModelPrefix
            // 
            this.paramModelPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramModelPrefix.DefaultValue = null;
            this.paramModelPrefix.IsUpdated = false;
            this.paramModelPrefix.Location = new System.Drawing.Point(3, 3);
            this.paramModelPrefix.Name = "paramModelPrefix";
            this.paramModelPrefix.ParameterCode = "MODEL_PREFIX";
            this.paramModelPrefix.ParameterName = "Model Prefix";
            this.paramModelPrefix.ParameterValue = "";
            this.paramModelPrefix.ReadOnly = false;
            this.paramModelPrefix.Required = false;
            this.paramModelPrefix.Size = new System.Drawing.Size(228, 46);
            this.paramModelPrefix.TabIndex = 10;
            this.paramModelPrefix.Tooltip = "";
            // 
            // paramModelSuffix
            // 
            this.paramModelSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramModelSuffix.DefaultValue = null;
            this.paramModelSuffix.IsUpdated = false;
            this.paramModelSuffix.Location = new System.Drawing.Point(237, 3);
            this.paramModelSuffix.Name = "paramModelSuffix";
            this.paramModelSuffix.ParameterCode = "MODEL_SUFFIX";
            this.paramModelSuffix.ParameterName = "Model Suffix";
            this.paramModelSuffix.ParameterValue = "";
            this.paramModelSuffix.ReadOnly = false;
            this.paramModelSuffix.Required = false;
            this.paramModelSuffix.Size = new System.Drawing.Size(228, 46);
            this.paramModelSuffix.TabIndex = 11;
            this.paramModelSuffix.Tooltip = "";
            // 
            // paramControllerPrefix
            // 
            this.paramControllerPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramControllerPrefix.DefaultValue = null;
            this.paramControllerPrefix.IsUpdated = false;
            this.paramControllerPrefix.Location = new System.Drawing.Point(3, 55);
            this.paramControllerPrefix.Name = "paramControllerPrefix";
            this.paramControllerPrefix.ParameterCode = "CONTROLLER_PREFIX";
            this.paramControllerPrefix.ParameterName = "Controller Prefix";
            this.paramControllerPrefix.ParameterValue = "";
            this.paramControllerPrefix.ReadOnly = false;
            this.paramControllerPrefix.Required = false;
            this.paramControllerPrefix.Size = new System.Drawing.Size(228, 46);
            this.paramControllerPrefix.TabIndex = 12;
            this.paramControllerPrefix.Tooltip = "";
            // 
            // paramControllerSuffix
            // 
            this.paramControllerSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramControllerSuffix.DefaultValue = "Controller";
            this.paramControllerSuffix.IsUpdated = false;
            this.paramControllerSuffix.Location = new System.Drawing.Point(237, 55);
            this.paramControllerSuffix.Name = "paramControllerSuffix";
            this.paramControllerSuffix.ParameterCode = "CONTROLLER_SUFFIX";
            this.paramControllerSuffix.ParameterName = "Controller Suffix";
            this.paramControllerSuffix.ParameterValue = "Controller";
            this.paramControllerSuffix.ReadOnly = false;
            this.paramControllerSuffix.Required = false;
            this.paramControllerSuffix.Size = new System.Drawing.Size(228, 46);
            this.paramControllerSuffix.TabIndex = 13;
            this.paramControllerSuffix.Tooltip = "";
            // 
            // paramViewPrefix
            // 
            this.paramViewPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramViewPrefix.DefaultValue = null;
            this.paramViewPrefix.IsUpdated = false;
            this.paramViewPrefix.Location = new System.Drawing.Point(3, 107);
            this.paramViewPrefix.Name = "paramViewPrefix";
            this.paramViewPrefix.ParameterCode = "VIEW_PREFIX";
            this.paramViewPrefix.ParameterName = "View Prefix";
            this.paramViewPrefix.ParameterValue = "";
            this.paramViewPrefix.ReadOnly = false;
            this.paramViewPrefix.Required = false;
            this.paramViewPrefix.Size = new System.Drawing.Size(228, 46);
            this.paramViewPrefix.TabIndex = 14;
            this.paramViewPrefix.Tooltip = "";
            // 
            // paramViewSuffix
            // 
            this.paramViewSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramViewSuffix.DefaultValue = "";
            this.paramViewSuffix.IsUpdated = false;
            this.paramViewSuffix.Location = new System.Drawing.Point(237, 107);
            this.paramViewSuffix.Name = "paramViewSuffix";
            this.paramViewSuffix.ParameterCode = "VIEW_SUFFIX";
            this.paramViewSuffix.ParameterName = "View Suffix";
            this.paramViewSuffix.ParameterValue = "";
            this.paramViewSuffix.ReadOnly = false;
            this.paramViewSuffix.Required = false;
            this.paramViewSuffix.Size = new System.Drawing.Size(228, 46);
            this.paramViewSuffix.TabIndex = 15;
            this.paramViewSuffix.Tooltip = "";
            // 
            // paramDetailsMethodName
            // 
            this.paramDetailsMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramDetailsMethodName.DefaultValue = "Details";
            this.paramDetailsMethodName.IsUpdated = false;
            this.paramDetailsMethodName.Location = new System.Drawing.Point(3, 3);
            this.paramDetailsMethodName.Name = "paramDetailsMethodName";
            this.paramDetailsMethodName.ParameterCode = "DETAILS_METHODNAME";
            this.paramDetailsMethodName.ParameterName = "Details Method Name";
            this.paramDetailsMethodName.ParameterValue = "Details";
            this.paramDetailsMethodName.ReadOnly = false;
            this.paramDetailsMethodName.Required = true;
            this.paramDetailsMethodName.Size = new System.Drawing.Size(462, 46);
            this.paramDetailsMethodName.TabIndex = 20;
            this.paramDetailsMethodName.Tooltip = "";
            // 
            // paramCreateMethodName
            // 
            this.paramCreateMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramCreateMethodName.DefaultValue = "Create";
            this.paramCreateMethodName.IsUpdated = false;
            this.paramCreateMethodName.Location = new System.Drawing.Point(3, 55);
            this.paramCreateMethodName.Name = "paramCreateMethodName";
            this.paramCreateMethodName.ParameterCode = "CREATE_METHODNAME";
            this.paramCreateMethodName.ParameterName = "Create Method Name";
            this.paramCreateMethodName.ParameterValue = "Create";
            this.paramCreateMethodName.ReadOnly = false;
            this.paramCreateMethodName.Required = true;
            this.paramCreateMethodName.Size = new System.Drawing.Size(462, 46);
            this.paramCreateMethodName.TabIndex = 21;
            this.paramCreateMethodName.Tooltip = "";
            // 
            // paramEditMethodName
            // 
            this.paramEditMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramEditMethodName.DefaultValue = "Edit";
            this.paramEditMethodName.IsUpdated = false;
            this.paramEditMethodName.Location = new System.Drawing.Point(3, 107);
            this.paramEditMethodName.Name = "paramEditMethodName";
            this.paramEditMethodName.ParameterCode = "EDIT_METHODNAME";
            this.paramEditMethodName.ParameterName = "Edit Method Name";
            this.paramEditMethodName.ParameterValue = "Edit";
            this.paramEditMethodName.ReadOnly = false;
            this.paramEditMethodName.Required = true;
            this.paramEditMethodName.Size = new System.Drawing.Size(462, 46);
            this.paramEditMethodName.TabIndex = 22;
            this.paramEditMethodName.Tooltip = "";
            // 
            // paramDeleteMethodName
            // 
            this.paramDeleteMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramDeleteMethodName.DefaultValue = "Delete";
            this.paramDeleteMethodName.IsUpdated = false;
            this.paramDeleteMethodName.Location = new System.Drawing.Point(3, 159);
            this.paramDeleteMethodName.Name = "paramDeleteMethodName";
            this.paramDeleteMethodName.ParameterCode = "DELETE_METHODNAME";
            this.paramDeleteMethodName.ParameterName = "Delete Method Name";
            this.paramDeleteMethodName.ParameterValue = "Delete";
            this.paramDeleteMethodName.ReadOnly = false;
            this.paramDeleteMethodName.Required = true;
            this.paramDeleteMethodName.Size = new System.Drawing.Size(462, 46);
            this.paramDeleteMethodName.TabIndex = 23;
            this.paramDeleteMethodName.Tooltip = "";
            // 
            // paramDatabaseContextClassName
            // 
            this.paramDatabaseContextClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramDatabaseContextClassName.DefaultValue = "ApplicationDbContext";
            this.paramDatabaseContextClassName.IsUpdated = false;
            this.paramDatabaseContextClassName.Location = new System.Drawing.Point(3, 3);
            this.paramDatabaseContextClassName.Name = "paramDatabaseContextClassName";
            this.paramDatabaseContextClassName.ParameterCode = "DBCONTEXT_NAME";
            this.paramDatabaseContextClassName.ParameterName = "Database Context Class Name";
            this.paramDatabaseContextClassName.ParameterValue = "ApplicationDbContext";
            this.paramDatabaseContextClassName.ReadOnly = false;
            this.paramDatabaseContextClassName.Required = true;
            this.paramDatabaseContextClassName.Size = new System.Drawing.Size(462, 46);
            this.paramDatabaseContextClassName.TabIndex = 30;
            this.paramDatabaseContextClassName.Tooltip = "";
            // 
            // FormAspNetMvcCoreTemplateConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 357);
            this.Controls.Add(this.tabConfiguration);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAspNetMvcCoreTemplateConfiguration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Template Configuration";
            this.tabConfiguration.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tableLayoutGeneral.ResumeLayout(false);
            this.tabClasses.ResumeLayout(false);
            this.tableLayoutClasses.ResumeLayout(false);
            this.tabController.ResumeLayout(false);
            this.tableLayoutController.ResumeLayout(false);
            this.tabDatabase.ResumeLayout(false);
            this.tableLayoutDatabase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConfiguration;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabClasses;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TabPage tabController;
        private Controls.TemplateParameter paramAuthorName;
        private Controls.TemplateParameter paramModelsNamespace;
        private Controls.TemplateParameter paramControllerNamespace;
        private System.Windows.Forms.TableLayoutPanel tableLayoutClasses;
        private Controls.TemplateParameter paramModelPrefix;
        private Controls.TemplateParameter paramControllerSuffix;
        private Controls.TemplateParameter paramControllerPrefix;
        private Controls.TemplateParameter paramModelSuffix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutController;
        private Controls.TemplateParameter paramDetailsMethodName;
        private Controls.TemplateParameter paramCreateMethodName;
        private Controls.TemplateParameter paramEditMethodName;
        private Controls.TemplateParameter paramDeleteMethodName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutGeneral;
        private Controls.TemplateParameter paramDatabaseContextClassName;
        private Controls.TemplateParameter paramDatabaseContextNamespace;
        private System.Windows.Forms.TabPage tabDatabase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutDatabase;
        private Controls.TemplateParameter paramViewPrefix;
        private Controls.TemplateParameter paramViewSuffix;
    }
}