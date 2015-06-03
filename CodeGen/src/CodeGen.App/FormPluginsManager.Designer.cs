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
            this.groupPluginsList = new System.Windows.Forms.GroupBox();
            this.tablePluginsList = new System.Windows.Forms.TableLayoutPanel();
            this.groupPluginDetails = new System.Windows.Forms.GroupBox();
            this.pnlPluginDetails = new System.Windows.Forms.Panel();
            this.listPluginsList = new System.Windows.Forms.ListView();
            this.imageListPlugins = new System.Windows.Forms.ImageList(this.components);
            this.btnImportPlugins = new System.Windows.Forms.Button();
            this.openDialogImportPlugins = new System.Windows.Forms.OpenFileDialog();
            this.workerCheckPlugins = new System.ComponentModel.BackgroundWorker();
            this.progressBarCheckPlugins = new System.Windows.Forms.ProgressBar();
            this.workerImportPlugins = new System.ComponentModel.BackgroundWorker();
            this.groupPluginsList.SuspendLayout();
            this.tablePluginsList.SuspendLayout();
            this.groupPluginDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(600, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // groupPluginsList
            // 
            this.groupPluginsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPluginsList.Controls.Add(this.tablePluginsList);
            this.groupPluginsList.Location = new System.Drawing.Point(0, 0);
            this.groupPluginsList.Name = "groupPluginsList";
            this.groupPluginsList.Size = new System.Drawing.Size(675, 428);
            this.groupPluginsList.TabIndex = 0;
            this.groupPluginsList.TabStop = false;
            this.groupPluginsList.Text = "Plugins";
            // 
            // tablePluginsList
            // 
            this.tablePluginsList.ColumnCount = 2;
            this.tablePluginsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tablePluginsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tablePluginsList.Controls.Add(this.groupPluginDetails, 1, 0);
            this.tablePluginsList.Controls.Add(this.listPluginsList, 0, 0);
            this.tablePluginsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePluginsList.Location = new System.Drawing.Point(3, 16);
            this.tablePluginsList.Name = "tablePluginsList";
            this.tablePluginsList.RowCount = 1;
            this.tablePluginsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePluginsList.Size = new System.Drawing.Size(669, 409);
            this.tablePluginsList.TabIndex = 0;
            // 
            // groupPluginDetails
            // 
            this.groupPluginDetails.Controls.Add(this.pnlPluginDetails);
            this.groupPluginDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPluginDetails.Location = new System.Drawing.Point(270, 3);
            this.groupPluginDetails.Name = "groupPluginDetails";
            this.groupPluginDetails.Size = new System.Drawing.Size(396, 403);
            this.groupPluginDetails.TabIndex = 6;
            this.groupPluginDetails.TabStop = false;
            this.groupPluginDetails.Text = "Plugin Details";
            // 
            // pnlPluginDetails
            // 
            this.pnlPluginDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPluginDetails.Location = new System.Drawing.Point(3, 16);
            this.pnlPluginDetails.Name = "pnlPluginDetails";
            this.pnlPluginDetails.Size = new System.Drawing.Size(390, 384);
            this.pnlPluginDetails.TabIndex = 1;
            // 
            // listPluginsList
            // 
            this.listPluginsList.CheckBoxes = true;
            this.listPluginsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPluginsList.Location = new System.Drawing.Point(3, 3);
            this.listPluginsList.MultiSelect = false;
            this.listPluginsList.Name = "listPluginsList";
            this.listPluginsList.Size = new System.Drawing.Size(261, 403);
            this.listPluginsList.SmallImageList = this.imageListPlugins;
            this.listPluginsList.TabIndex = 0;
            this.listPluginsList.UseCompatibleStateImageBehavior = false;
            this.listPluginsList.View = System.Windows.Forms.View.SmallIcon;
            this.listPluginsList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listPluginsList_ItemChecked);
            this.listPluginsList.SelectedIndexChanged += new System.EventHandler(this.listPluginsList_SelectedIndexChanged);
            // 
            // imageListPlugins
            // 
            this.imageListPlugins.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPlugins.ImageStream")));
            this.imageListPlugins.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPlugins.Images.SetKeyName(0, "GeneratorTemplate");
            this.imageListPlugins.Images.SetKeyName(1, "AccessModelController");
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
            this.openDialogImportPlugins.Filter = "Compatible Plugin file (*.dll, *.zip)|*.dll;*.zip|Assembly file (*.dll)|*.dll";
            this.openDialogImportPlugins.Multiselect = true;
            // 
            // workerCheckPlugins
            // 
            this.workerCheckPlugins.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerCheckPlugins_DoWork);
            this.workerCheckPlugins.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerCheckPlugins_RunWorkerCompleted);
            // 
            // progressBarCheckPlugins
            // 
            this.progressBarCheckPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarCheckPlugins.Location = new System.Drawing.Point(153, 434);
            this.progressBarCheckPlugins.Name = "progressBarCheckPlugins";
            this.progressBarCheckPlugins.Size = new System.Drawing.Size(441, 23);
            this.progressBarCheckPlugins.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarCheckPlugins.TabIndex = 6;
            this.progressBarCheckPlugins.Visible = false;
            // 
            // workerImportPlugins
            // 
            this.workerImportPlugins.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerImportPlugins_DoWork);
            this.workerImportPlugins.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerImportPlugins_RunWorkerCompleted);
            // 
            // FormPluginsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(687, 469);
            this.Controls.Add(this.groupPluginsList);
            this.Controls.Add(this.btnImportPlugins);
            this.Controls.Add(this.progressBarCheckPlugins);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPluginsManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plugins Manager";
            this.Load += new System.EventHandler(this.FormPluginsManager_Load);
            this.groupPluginsList.ResumeLayout(false);
            this.tablePluginsList.ResumeLayout(false);
            this.groupPluginDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupPluginsList;
        private System.Windows.Forms.TableLayoutPanel tablePluginsList;
        private System.Windows.Forms.ListView listPluginsList;
        private System.Windows.Forms.Button btnImportPlugins;
        private System.Windows.Forms.Panel pnlPluginDetails;
        private System.Windows.Forms.OpenFileDialog openDialogImportPlugins;
        private System.Windows.Forms.GroupBox groupPluginDetails;
        private System.Windows.Forms.ImageList imageListPlugins;
        private System.ComponentModel.BackgroundWorker workerCheckPlugins;
        private System.Windows.Forms.ProgressBar progressBarCheckPlugins;
        private System.ComponentModel.BackgroundWorker workerImportPlugins;
    }
}