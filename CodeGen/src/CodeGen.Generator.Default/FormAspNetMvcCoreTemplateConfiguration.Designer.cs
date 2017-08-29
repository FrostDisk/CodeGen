namespace CodeGen.Generator.Default
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
            this.paramAuthorName = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.paramModelsNamespace = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.paramControllerNamespace = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.paramDatabaseContextNamespace = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.tabClasses = new System.Windows.Forms.TabPage();
            this.tableLayoutClasses = new System.Windows.Forms.TableLayoutPanel();
            this.paramModelPrefix = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.paramModelSuffix = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.paramControllerPrefix = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.paramControllerSuffix = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.tabController = new System.Windows.Forms.TabPage();
            this.tableLayoutController = new System.Windows.Forms.TableLayoutPanel();
            this.paramDetailsMethodName = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.paramCreateMethodName = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.paramEditMethodName = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.paramDeleteMethodName = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.tabViews = new System.Windows.Forms.TabPage();
            this.tableLayoutViews = new System.Windows.Forms.TableLayoutPanel();
            this.paramDetailsViewName = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.paramCreateViewName = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.paramEditViewName = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.paramDeleteViewName = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.paramIndexViewName = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.paramDatabaseContextClassName = new CodeGen.Generator.Default.Controls.TemplateParameter();
            this.tabConfiguration.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tableLayoutGeneral.SuspendLayout();
            this.tabClasses.SuspendLayout();
            this.tableLayoutClasses.SuspendLayout();
            this.tabController.SuspendLayout();
            this.tableLayoutController.SuspendLayout();
            this.tabViews.SuspendLayout();
            this.tableLayoutViews.SuspendLayout();
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
            this.tabConfiguration.Controls.Add(this.tabViews);
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
            this.tableLayoutGeneral.Controls.Add(this.paramDatabaseContextClassName, 0, 4);
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
            // tabViews
            // 
            this.tabViews.Controls.Add(this.tableLayoutViews);
            this.tabViews.Location = new System.Drawing.Point(4, 22);
            this.tabViews.Name = "tabViews";
            this.tabViews.Padding = new System.Windows.Forms.Padding(3);
            this.tabViews.Size = new System.Drawing.Size(474, 278);
            this.tabViews.TabIndex = 5;
            this.tabViews.Text = "Views";
            this.tabViews.UseVisualStyleBackColor = true;
            // 
            // tableLayoutViews
            // 
            this.tableLayoutViews.ColumnCount = 1;
            this.tableLayoutViews.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutViews.Controls.Add(this.paramDetailsViewName, 0, 0);
            this.tableLayoutViews.Controls.Add(this.paramCreateViewName, 0, 1);
            this.tableLayoutViews.Controls.Add(this.paramEditViewName, 0, 2);
            this.tableLayoutViews.Controls.Add(this.paramDeleteViewName, 0, 3);
            this.tableLayoutViews.Controls.Add(this.paramIndexViewName, 0, 4);
            this.tableLayoutViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutViews.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutViews.Name = "tableLayoutViews";
            this.tableLayoutViews.RowCount = 6;
            this.tableLayoutViews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutViews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutViews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutViews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutViews.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutViews.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutViews.Size = new System.Drawing.Size(468, 272);
            this.tableLayoutViews.TabIndex = 0;
            // 
            // paramDetailsViewName
            // 
            this.paramDetailsViewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramDetailsViewName.DefaultValue = "Details";
            this.paramDetailsViewName.IsUpdated = false;
            this.paramDetailsViewName.Location = new System.Drawing.Point(3, 3);
            this.paramDetailsViewName.Name = "paramDetailsViewName";
            this.paramDetailsViewName.ParameterCode = "DETAILS_VIEWNAME";
            this.paramDetailsViewName.ParameterName = "Details View Name";
            this.paramDetailsViewName.ParameterValue = "Details";
            this.paramDetailsViewName.ReadOnly = false;
            this.paramDetailsViewName.Required = true;
            this.paramDetailsViewName.Size = new System.Drawing.Size(462, 46);
            this.paramDetailsViewName.TabIndex = 20;
            this.paramDetailsViewName.Tooltip = "";
            // 
            // paramCreateViewName
            // 
            this.paramCreateViewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramCreateViewName.DefaultValue = "Create";
            this.paramCreateViewName.IsUpdated = false;
            this.paramCreateViewName.Location = new System.Drawing.Point(3, 55);
            this.paramCreateViewName.Name = "paramCreateViewName";
            this.paramCreateViewName.ParameterCode = "CREATE_VIEWNAME";
            this.paramCreateViewName.ParameterName = "Create View Name";
            this.paramCreateViewName.ParameterValue = "Create";
            this.paramCreateViewName.ReadOnly = false;
            this.paramCreateViewName.Required = true;
            this.paramCreateViewName.Size = new System.Drawing.Size(462, 46);
            this.paramCreateViewName.TabIndex = 21;
            this.paramCreateViewName.Tooltip = "";
            // 
            // paramEditViewName
            // 
            this.paramEditViewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramEditViewName.DefaultValue = "Edit";
            this.paramEditViewName.IsUpdated = false;
            this.paramEditViewName.Location = new System.Drawing.Point(3, 107);
            this.paramEditViewName.Name = "paramEditViewName";
            this.paramEditViewName.ParameterCode = "EDIT_VIEWNAME";
            this.paramEditViewName.ParameterName = "Edit View Name";
            this.paramEditViewName.ParameterValue = "Edit";
            this.paramEditViewName.ReadOnly = false;
            this.paramEditViewName.Required = true;
            this.paramEditViewName.Size = new System.Drawing.Size(462, 46);
            this.paramEditViewName.TabIndex = 22;
            this.paramEditViewName.Tooltip = "";
            // 
            // paramDeleteViewName
            // 
            this.paramDeleteViewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramDeleteViewName.DefaultValue = "Delete";
            this.paramDeleteViewName.IsUpdated = false;
            this.paramDeleteViewName.Location = new System.Drawing.Point(3, 159);
            this.paramDeleteViewName.Name = "paramDeleteViewName";
            this.paramDeleteViewName.ParameterCode = "DELETE_VIEWNAME";
            this.paramDeleteViewName.ParameterName = "Delete View Name";
            this.paramDeleteViewName.ParameterValue = "Delete";
            this.paramDeleteViewName.ReadOnly = false;
            this.paramDeleteViewName.Required = true;
            this.paramDeleteViewName.Size = new System.Drawing.Size(462, 46);
            this.paramDeleteViewName.TabIndex = 23;
            this.paramDeleteViewName.Tooltip = "";
            // 
            // paramIndexViewName
            // 
            this.paramIndexViewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramIndexViewName.DefaultValue = "Index";
            this.paramIndexViewName.IsUpdated = false;
            this.paramIndexViewName.Location = new System.Drawing.Point(3, 211);
            this.paramIndexViewName.Name = "paramIndexViewName";
            this.paramIndexViewName.ParameterCode = "INDEX_VIEWNAME";
            this.paramIndexViewName.ParameterName = "Index View Name";
            this.paramIndexViewName.ParameterValue = "Index";
            this.paramIndexViewName.ReadOnly = false;
            this.paramIndexViewName.Required = true;
            this.paramIndexViewName.Size = new System.Drawing.Size(462, 46);
            this.paramIndexViewName.TabIndex = 24;
            this.paramIndexViewName.Tooltip = "";
            // 
            // paramDatabaseContextClassName
            // 
            this.paramDatabaseContextClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paramDatabaseContextClassName.DefaultValue = "MyProjectDbContext";
            this.paramDatabaseContextClassName.IsUpdated = false;
            this.paramDatabaseContextClassName.Location = new System.Drawing.Point(3, 211);
            this.paramDatabaseContextClassName.Name = "paramDatabaseContextClassName";
            this.paramDatabaseContextClassName.ParameterCode = "DBCONTEXT_NAME";
            this.paramDatabaseContextClassName.ParameterName = "Database Context Class Name";
            this.paramDatabaseContextClassName.ParameterValue = "MyProjectDbContext";
            this.paramDatabaseContextClassName.ReadOnly = false;
            this.paramDatabaseContextClassName.Required = true;
            this.paramDatabaseContextClassName.Size = new System.Drawing.Size(462, 46);
            this.paramDatabaseContextClassName.TabIndex = 31;
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
            this.tabViews.ResumeLayout(false);
            this.tableLayoutViews.ResumeLayout(false);
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
        private Controls.TemplateParameter paramDatabaseContextNamespace;
        private System.Windows.Forms.TabPage tabViews;
        private System.Windows.Forms.TableLayoutPanel tableLayoutViews;
        private Controls.TemplateParameter paramDetailsViewName;
        private Controls.TemplateParameter paramCreateViewName;
        private Controls.TemplateParameter paramEditViewName;
        private Controls.TemplateParameter paramDeleteViewName;
        private Controls.TemplateParameter paramIndexViewName;
        private Controls.TemplateParameter paramDatabaseContextClassName;
    }
}