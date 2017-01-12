namespace Patient_Database.Manager
{
    partial class ManagerUC
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
            this.mnuCommands = new System.Windows.Forms.MenuStrip();
            this.queryManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectionOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.queryOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tvManager = new System.Windows.Forms.TreeView();
            this.pDisplay = new System.Windows.Forms.Panel();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.mnuCommands.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuCommands
            // 
            this.mnuCommands.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuCommands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryManagerToolStripMenuItem});
            this.mnuCommands.Location = new System.Drawing.Point(0, 0);
            this.mnuCommands.Name = "mnuCommands";
            this.mnuCommands.Size = new System.Drawing.Size(1005, 29);
            this.mnuCommands.TabIndex = 2;
            this.mnuCommands.Text = "menuStrip1";
            // 
            // queryManagerToolStripMenuItem
            // 
            this.queryManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collectionOptionsToolStripMenuItem,
            this.groupOptionsToolStripMenuItem,
            this.queryOptionsToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.queryManagerToolStripMenuItem.Name = "queryManagerToolStripMenuItem";
            this.queryManagerToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.queryManagerToolStripMenuItem.Text = "Manager";
            // 
            // collectionOptionsToolStripMenuItem
            // 
            this.collectionOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.createNewCollectionToolStripMenuItem,
            this.updateInfoToolStripMenuItem});
            this.collectionOptionsToolStripMenuItem.Name = "collectionOptionsToolStripMenuItem";
            this.collectionOptionsToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.collectionOptionsToolStripMenuItem.Text = "Collection Options";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // createNewCollectionToolStripMenuItem
            // 
            this.createNewCollectionToolStripMenuItem.Name = "createNewCollectionToolStripMenuItem";
            this.createNewCollectionToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.createNewCollectionToolStripMenuItem.Text = "Create New";
            // 
            // updateInfoToolStripMenuItem
            // 
            this.updateInfoToolStripMenuItem.Name = "updateInfoToolStripMenuItem";
            this.updateInfoToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.updateInfoToolStripMenuItem.Text = "Update Info";
            // 
            // groupOptionsToolStripMenuItem
            // 
            this.groupOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewQueryToolStripMenuItem,
            this.renameGroupToolStripMenuItem,
            this.createNewToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.updateDescriptionToolStripMenuItem,
            this.importToolStripMenuItem1,
            this.exportToolStripMenuItem1});
            this.groupOptionsToolStripMenuItem.Name = "groupOptionsToolStripMenuItem";
            this.groupOptionsToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.groupOptionsToolStripMenuItem.Text = "Group Options";
            // 
            // addNewQueryToolStripMenuItem
            // 
            this.addNewQueryToolStripMenuItem.Name = "addNewQueryToolStripMenuItem";
            this.addNewQueryToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.addNewQueryToolStripMenuItem.Text = "Add New Query";
            // 
            // renameGroupToolStripMenuItem
            // 
            this.renameGroupToolStripMenuItem.Name = "renameGroupToolStripMenuItem";
            this.renameGroupToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.renameGroupToolStripMenuItem.Text = "Rename";
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.createNewToolStripMenuItem.Text = "Create New";
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.moveToolStripMenuItem.Text = "Move";
            // 
            // updateDescriptionToolStripMenuItem
            // 
            this.updateDescriptionToolStripMenuItem.Name = "updateDescriptionToolStripMenuItem";
            this.updateDescriptionToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.updateDescriptionToolStripMenuItem.Text = "Update Info";
            // 
            // importToolStripMenuItem1
            // 
            this.importToolStripMenuItem1.Name = "importToolStripMenuItem1";
            this.importToolStripMenuItem1.Size = new System.Drawing.Size(191, 26);
            this.importToolStripMenuItem1.Text = "Import";
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(191, 26);
            this.exportToolStripMenuItem1.Text = "Export";
            // 
            // queryOptionsToolStripMenuItem
            // 
            this.queryOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.renameToolStripMenuItem1,
            this.moveToolStripMenuItem1,
            this.updateInfoToolStripMenuItem1,
            this.importToolStripMenuItem2,
            this.exportToolStripMenuItem2});
            this.queryOptionsToolStripMenuItem.Name = "queryOptionsToolStripMenuItem";
            this.queryOptionsToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.queryOptionsToolStripMenuItem.Text = "Query Options";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // renameToolStripMenuItem1
            // 
            this.renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
            this.renameToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.renameToolStripMenuItem1.Text = "Rename";
            // 
            // moveToolStripMenuItem1
            // 
            this.moveToolStripMenuItem1.Name = "moveToolStripMenuItem1";
            this.moveToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.moveToolStripMenuItem1.Text = "Move";
            // 
            // updateInfoToolStripMenuItem1
            // 
            this.updateInfoToolStripMenuItem1.Name = "updateInfoToolStripMenuItem1";
            this.updateInfoToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.updateInfoToolStripMenuItem1.Text = "Update Info";
            // 
            // importToolStripMenuItem2
            // 
            this.importToolStripMenuItem2.Name = "importToolStripMenuItem2";
            this.importToolStripMenuItem2.Size = new System.Drawing.Size(161, 26);
            this.importToolStripMenuItem2.Text = "Import";
            // 
            // exportToolStripMenuItem2
            // 
            this.exportToolStripMenuItem2.Name = "exportToolStripMenuItem2";
            this.exportToolStripMenuItem2.Size = new System.Drawing.Size(161, 26);
            this.exportToolStripMenuItem2.Text = "Export";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnShowInfo);
            this.panel1.Controls.Add(this.pDisplay);
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tvManager);
            this.panel1.Location = new System.Drawing.Point(3, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 526);
            this.panel1.TabIndex = 3;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(3, 424);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(327, 44);
            this.btnAddNew.TabIndex = 14;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Manager";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Data Analysis";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tvManager
            // 
            this.tvManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvManager.ItemHeight = 26;
            this.tvManager.Location = new System.Drawing.Point(3, 28);
            this.tvManager.Name = "tvManager";
            this.tvManager.Size = new System.Drawing.Size(327, 340);
            this.tvManager.TabIndex = 10;
            this.tvManager.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvManager_AfterSelect);
            this.tvManager.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvManager_MouseDown);
            // 
            // pDisplay
            // 
            this.pDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDisplay.Location = new System.Drawing.Point(336, 7);
            this.pDisplay.Name = "pDisplay";
            this.pDisplay.Size = new System.Drawing.Size(661, 513);
            this.pDisplay.TabIndex = 15;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfo.Location = new System.Drawing.Point(3, 374);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(327, 44);
            this.btnShowInfo.TabIndex = 16;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            // 
            // ManagerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuCommands);
            this.Name = "ManagerUC";
            this.Size = new System.Drawing.Size(1005, 561);
            this.Load += new System.EventHandler(this.ManagerUC_Load);
            this.mnuCommands.ResumeLayout(false);
            this.mnuCommands.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuCommands;
        private System.Windows.Forms.ToolStripMenuItem queryManagerToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ToolStripMenuItem collectionOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Panel pDisplay;
        private System.Windows.Forms.Button btnShowInfo;
    }
}
