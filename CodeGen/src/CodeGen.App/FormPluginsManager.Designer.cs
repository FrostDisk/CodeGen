namespace CodeGen
{
    partial class FormPluginsManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPluginsManager));
            this.btnClose = new System.Windows.Forms.Button();
            this.splitPluginsSeparator = new System.Windows.Forms.SplitContainer();
            this.groupAssemblyList = new System.Windows.Forms.GroupBox();
            this.listAssemblyList = new System.Windows.Forms.ListView();
            this.groupPluginsList = new System.Windows.Forms.GroupBox();
            this.tablePluginsList = new System.Windows.Forms.TableLayoutPanel();
            this.groupPluginDetails = new System.Windows.Forms.GroupBox();
            this.pnlPluginDetails = new System.Windows.Forms.Panel();
            this.listPluginsList = new System.Windows.Forms.ListView();
            this.tablePluginsManager = new System.Windows.Forms.TableLayoutPanel();
            this.groupAssemblyDetails = new System.Windows.Forms.GroupBox();
            this.pnlAssemblyDetails = new System.Windows.Forms.Panel();
            this.btnImportPlugins = new System.Windows.Forms.Button();
            this.openDialogImportPlugins = new System.Windows.Forms.OpenFileDialog();
            this.imageListAssemblies = new System.Windows.Forms.ImageList(this.components);
            this.imageListPlugins = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitPluginsSeparator)).BeginInit();
            this.splitPluginsSeparator.Panel1.SuspendLayout();
            this.splitPluginsSeparator.Panel2.SuspendLayout();
            this.splitPluginsSeparator.SuspendLayout();
            this.groupAssemblyList.SuspendLayout();
            this.groupPluginsList.SuspendLayout();
            this.tablePluginsList.SuspendLayout();
            this.groupPluginDetails.SuspendLayout();
            this.tablePluginsManager.SuspendLayout();
            this.groupAssemblyDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(619, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // splitPluginsSeparator
            // 
            this.splitPluginsSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitPluginsSeparator.Location = new System.Drawing.Point(153, 3);
            this.splitPluginsSeparator.Name = "splitPluginsSeparator";
            this.splitPluginsSeparator.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPluginsSeparator.Panel1
            // 
            this.splitPluginsSeparator.Panel1.Controls.Add(this.groupAssemblyList);
            // 
            // splitPluginsSeparator.Panel2
            // 
            this.splitPluginsSeparator.Panel2.Controls.Add(this.groupPluginsList);
            this.splitPluginsSeparator.Size = new System.Drawing.Size(526, 410);
            this.splitPluginsSeparator.SplitterDistance = 122;
            this.splitPluginsSeparator.TabIndex = 3;
            // 
            // groupAssemblyList
            // 
            this.groupAssemblyList.Controls.Add(this.listAssemblyList);
            this.groupAssemblyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupAssemblyList.Location = new System.Drawing.Point(0, 0);
            this.groupAssemblyList.Name = "groupAssemblyList";
            this.groupAssemblyList.Size = new System.Drawing.Size(526, 122);
            this.groupAssemblyList.TabIndex = 4;
            this.groupAssemblyList.TabStop = false;
            this.groupAssemblyList.Text = "Assembly List";
            // 
            // listAssemblyList
            // 
            this.listAssemblyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAssemblyList.Location = new System.Drawing.Point(3, 16);
            this.listAssemblyList.MultiSelect = false;
            this.listAssemblyList.Name = "listAssemblyList";
            this.listAssemblyList.Size = new System.Drawing.Size(520, 103);
            this.listAssemblyList.SmallImageList = this.imageListAssemblies;
            this.listAssemblyList.TabIndex = 0;
            this.listAssemblyList.UseCompatibleStateImageBehavior = false;
            this.listAssemblyList.View = System.Windows.Forms.View.SmallIcon;
            this.listAssemblyList.SelectedIndexChanged += new System.EventHandler(this.listAssemblyList_SelectedIndexChanged);
            // 
            // groupPluginsList
            // 
            this.groupPluginsList.Controls.Add(this.tablePluginsList);
            this.groupPluginsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPluginsList.Location = new System.Drawing.Point(0, 0);
            this.groupPluginsList.Name = "groupPluginsList";
            this.groupPluginsList.Size = new System.Drawing.Size(526, 284);
            this.groupPluginsList.TabIndex = 0;
            this.groupPluginsList.TabStop = false;
            this.groupPluginsList.Text = "Plugins";
            // 
            // tablePluginsList
            // 
            this.tablePluginsList.ColumnCount = 2;
            this.tablePluginsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tablePluginsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tablePluginsList.Controls.Add(this.groupPluginDetails, 1, 0);
            this.tablePluginsList.Controls.Add(this.listPluginsList, 0, 0);
            this.tablePluginsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePluginsList.Location = new System.Drawing.Point(3, 16);
            this.tablePluginsList.Name = "tablePluginsList";
            this.tablePluginsList.RowCount = 1;
            this.tablePluginsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePluginsList.Size = new System.Drawing.Size(520, 265);
            this.tablePluginsList.TabIndex = 0;
            // 
            // groupPluginDetails
            // 
            this.groupPluginDetails.Controls.Add(this.pnlPluginDetails);
            this.groupPluginDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPluginDetails.Location = new System.Drawing.Point(315, 3);
            this.groupPluginDetails.Name = "groupPluginDetails";
            this.groupPluginDetails.Size = new System.Drawing.Size(202, 259);
            this.groupPluginDetails.TabIndex = 6;
            this.groupPluginDetails.TabStop = false;
            this.groupPluginDetails.Text = "Plugin Details";
            // 
            // pnlPluginDetails
            // 
            this.pnlPluginDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPluginDetails.Location = new System.Drawing.Point(3, 16);
            this.pnlPluginDetails.Name = "pnlPluginDetails";
            this.pnlPluginDetails.Size = new System.Drawing.Size(196, 240);
            this.pnlPluginDetails.TabIndex = 1;
            // 
            // listPluginsList
            // 
            this.listPluginsList.CheckBoxes = true;
            this.listPluginsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPluginsList.Location = new System.Drawing.Point(3, 3);
            this.listPluginsList.MultiSelect = false;
            this.listPluginsList.Name = "listPluginsList";
            this.listPluginsList.Size = new System.Drawing.Size(306, 259);
            this.listPluginsList.SmallImageList = this.imageListPlugins;
            this.listPluginsList.TabIndex = 0;
            this.listPluginsList.UseCompatibleStateImageBehavior = false;
            this.listPluginsList.View = System.Windows.Forms.View.SmallIcon;
            this.listPluginsList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listPluginsList_ItemChecked);
            this.listPluginsList.SelectedIndexChanged += new System.EventHandler(this.listPluginsList_SelectedIndexChanged);
            // 
            // tablePluginsManager
            // 
            this.tablePluginsManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePluginsManager.ColumnCount = 2;
            this.tablePluginsManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tablePluginsManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePluginsManager.Controls.Add(this.groupAssemblyDetails, 0, 0);
            this.tablePluginsManager.Controls.Add(this.splitPluginsSeparator, 1, 0);
            this.tablePluginsManager.Location = new System.Drawing.Point(12, 12);
            this.tablePluginsManager.Name = "tablePluginsManager";
            this.tablePluginsManager.RowCount = 1;
            this.tablePluginsManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePluginsManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 416F));
            this.tablePluginsManager.Size = new System.Drawing.Size(682, 416);
            this.tablePluginsManager.TabIndex = 4;
            // 
            // groupAssemblyDetails
            // 
            this.groupAssemblyDetails.Controls.Add(this.pnlAssemblyDetails);
            this.groupAssemblyDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupAssemblyDetails.Location = new System.Drawing.Point(3, 3);
            this.groupAssemblyDetails.Name = "groupAssemblyDetails";
            this.groupAssemblyDetails.Size = new System.Drawing.Size(144, 410);
            this.groupAssemblyDetails.TabIndex = 0;
            this.groupAssemblyDetails.TabStop = false;
            this.groupAssemblyDetails.Text = "Assembly Details";
            // 
            // pnlAssemblyDetails
            // 
            this.pnlAssemblyDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAssemblyDetails.Location = new System.Drawing.Point(3, 16);
            this.pnlAssemblyDetails.Name = "pnlAssemblyDetails";
            this.pnlAssemblyDetails.Size = new System.Drawing.Size(138, 391);
            this.pnlAssemblyDetails.TabIndex = 4;
            // 
            // btnImportPlugins
            // 
            this.btnImportPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportPlugins.Location = new System.Drawing.Point(12, 434);
            this.btnImportPlugins.Name = "btnImportPlugins";
            this.btnImportPlugins.Size = new System.Drawing.Size(135, 23);
            this.btnImportPlugins.TabIndex = 5;
            this.btnImportPlugins.Text = "Import Plugins...";
            this.btnImportPlugins.UseVisualStyleBackColor = true;
            this.btnImportPlugins.Click += new System.EventHandler(this.btnImportPlugins_Click);
            // 
            // openDialogImportPlugins
            // 
            this.openDialogImportPlugins.FileName = "openFileDialog1";
            // 
            // imageListAssemblies
            // 
            this.imageListAssemblies.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAssemblies.ImageStream")));
            this.imageListAssemblies.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAssemblies.Images.SetKeyName(0, "file_extension_dll");
            // 
            // imageListPlugins
            // 
            this.imageListPlugins.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPlugins.ImageStream")));
            this.imageListPlugins.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPlugins.Images.SetKeyName(0, "file_extension_bin");
            // 
            // FormPluginsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(706, 469);
            this.Controls.Add(this.tablePluginsManager);
            this.Controls.Add(this.btnImportPlugins);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPluginsManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plugins Manager";
            this.splitPluginsSeparator.Panel1.ResumeLayout(false);
            this.splitPluginsSeparator.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPluginsSeparator)).EndInit();
            this.splitPluginsSeparator.ResumeLayout(false);
            this.groupAssemblyList.ResumeLayout(false);
            this.groupPluginsList.ResumeLayout(false);
            this.tablePluginsList.ResumeLayout(false);
            this.groupPluginDetails.ResumeLayout(false);
            this.tablePluginsManager.ResumeLayout(false);
            this.groupAssemblyDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SplitContainer splitPluginsSeparator;
        private System.Windows.Forms.GroupBox groupAssemblyList;
        private System.Windows.Forms.GroupBox groupPluginsList;
        private System.Windows.Forms.TableLayoutPanel tablePluginsManager;
        private System.Windows.Forms.TableLayoutPanel tablePluginsList;
        private System.Windows.Forms.ListView listAssemblyList;
        private System.Windows.Forms.ListView listPluginsList;
        private System.Windows.Forms.Button btnImportPlugins;
        private System.Windows.Forms.Panel pnlPluginDetails;
        private System.Windows.Forms.Panel pnlAssemblyDetails;
        private System.Windows.Forms.OpenFileDialog openDialogImportPlugins;
        private System.Windows.Forms.GroupBox groupPluginDetails;
        private System.Windows.Forms.GroupBox groupAssemblyDetails;
        private System.Windows.Forms.ImageList imageListAssemblies;
        private System.Windows.Forms.ImageList imageListPlugins;
    }
}