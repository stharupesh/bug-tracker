namespace BugTracker.Views
{
    partial class ProjectList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectList));
            this.ptypeCmb = new System.Windows.Forms.ComboBox();
            this.projectListToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchMiniPic = new System.Windows.Forms.PictureBox();
            this.ptypePanel = new System.Windows.Forms.Panel();
            this.projectListGrid = new System.Windows.Forms.DataGridView();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projecttypename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.addProjectPanel = new System.Windows.Forms.Panel();
            this.projectAdd = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.headerBottomPanel = new System.Windows.Forms.Panel();
            this.searchActionsPanel = new System.Windows.Forms.Panel();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchMiniPic)).BeginInit();
            this.ptypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.addProjectPanel.SuspendLayout();
            this.searchActionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptypeCmb
            // 
            this.ptypeCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ptypeCmb.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptypeCmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptypeCmb.FormattingEnabled = true;
            this.ptypeCmb.Location = new System.Drawing.Point(5, 3);
            this.ptypeCmb.Name = "ptypeCmb";
            this.ptypeCmb.Size = new System.Drawing.Size(205, 27);
            this.ptypeCmb.TabIndex = 0;
            this.ptypeCmb.SelectedIndexChanged += new System.EventHandler(this.ptypeCmb_SelectedIndexChanged);
            // 
            // projectListToolTip
            // 
            this.projectListToolTip.AutomaticDelay = 1;
            this.projectListToolTip.AutoPopDelay = 5000;
            this.projectListToolTip.InitialDelay = 1;
            this.projectListToolTip.ReshowDelay = 0;
            // 
            // searchTxt
            // 
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchTxt.Location = new System.Drawing.Point(5, 6);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(181, 20);
            this.searchTxt.TabIndex = 32;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.searchPanel.Controls.Add(this.searchMiniPic);
            this.searchPanel.Controls.Add(this.searchTxt);
            this.searchPanel.Location = new System.Drawing.Point(228, 8);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(219, 33);
            this.searchPanel.TabIndex = 83;
            // 
            // searchMiniPic
            // 
            this.searchMiniPic.Image = global::BugTracker.Properties.Resources.searchMiniIcon;
            this.searchMiniPic.Location = new System.Drawing.Point(192, 5);
            this.searchMiniPic.Name = "searchMiniPic";
            this.searchMiniPic.Size = new System.Drawing.Size(24, 24);
            this.searchMiniPic.TabIndex = 9;
            this.searchMiniPic.TabStop = false;
            // 
            // ptypePanel
            // 
            this.ptypePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ptypePanel.Controls.Add(this.ptypeCmb);
            this.ptypePanel.Location = new System.Drawing.Point(9, 8);
            this.ptypePanel.Name = "ptypePanel";
            this.ptypePanel.Size = new System.Drawing.Size(213, 33);
            this.ptypePanel.TabIndex = 85;
            // 
            // projectListGrid
            // 
            this.projectListGrid.AllowUserToAddRows = false;
            this.projectListGrid.AllowUserToDeleteRows = false;
            this.projectListGrid.AllowUserToOrderColumns = true;
            this.projectListGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.projectListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sn,
            this.projectid,
            this.projectname,
            this.projectdescription,
            this.projecttypename,
            this.edit,
            this.delete});
            this.projectListGrid.Location = new System.Drawing.Point(39, 123);
            this.projectListGrid.Name = "projectListGrid";
            this.projectListGrid.ReadOnly = true;
            this.projectListGrid.Size = new System.Drawing.Size(640, 345);
            this.projectListGrid.TabIndex = 82;
            this.projectListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectListDataGrid_CellContentClick);
            // 
            // sn
            // 
            this.sn.DataPropertyName = "sn";
            this.sn.FillWeight = 40F;
            this.sn.HeaderText = "SN";
            this.sn.Name = "sn";
            this.sn.ReadOnly = true;
            this.sn.Width = 37;
            // 
            // projectid
            // 
            this.projectid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.projectid.DataPropertyName = "project_id";
            this.projectid.HeaderText = "Project Id";
            this.projectid.Name = "projectid";
            this.projectid.ReadOnly = true;
            this.projectid.Visible = false;
            // 
            // projectname
            // 
            this.projectname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.projectname.DataPropertyName = "project_name";
            this.projectname.FillWeight = 120F;
            this.projectname.HeaderText = "Project Name";
            this.projectname.Name = "projectname";
            this.projectname.ReadOnly = true;
            // 
            // projectdescription
            // 
            this.projectdescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.projectdescription.DataPropertyName = "project_description";
            this.projectdescription.FillWeight = 150F;
            this.projectdescription.HeaderText = "Description";
            this.projectdescription.Name = "projectdescription";
            this.projectdescription.ReadOnly = true;
            // 
            // projecttypename
            // 
            this.projecttypename.DataPropertyName = "project_type_name";
            this.projecttypename.HeaderText = "Project Type";
            this.projecttypename.Name = "projecttypename";
            this.projecttypename.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.DataPropertyName = "project_id";
            this.edit.HeaderText = "Edit";
            this.edit.LinkColor = System.Drawing.Color.MediumBlue;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForLinkValue = true;
            this.edit.Width = 107;
            // 
            // delete
            // 
            this.delete.DataPropertyName = "project_id";
            this.delete.HeaderText = "Delete";
            this.delete.LinkColor = System.Drawing.Color.MediumBlue;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForLinkValue = true;
            this.delete.Width = 107;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Gray;
            this.headerPanel.Controls.Add(this.addProjectPanel);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.CadetBlue;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(717, 53);
            this.headerPanel.TabIndex = 79;
            // 
            // addProjectPanel
            // 
            this.addProjectPanel.BackColor = System.Drawing.Color.Transparent;
            this.addProjectPanel.Controls.Add(this.projectAdd);
            this.addProjectPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.addProjectPanel.Location = new System.Drawing.Point(540, 0);
            this.addProjectPanel.Name = "addProjectPanel";
            this.addProjectPanel.Size = new System.Drawing.Size(177, 53);
            this.addProjectPanel.TabIndex = 85;
            // 
            // projectAdd
            // 
            this.projectAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.projectAdd.FlatAppearance.BorderSize = 0;
            this.projectAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectAdd.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectAdd.ForeColor = System.Drawing.Color.White;
            this.projectAdd.Location = new System.Drawing.Point(41, 12);
            this.projectAdd.Name = "projectAdd";
            this.projectAdd.Size = new System.Drawing.Size(98, 29);
            this.projectAdd.TabIndex = 84;
            this.projectAdd.Text = "Add";
            this.projectAdd.UseVisualStyleBackColor = false;
            this.projectAdd.Click += new System.EventHandler(this.projectAdd_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerLabel.Location = new System.Drawing.Point(26, 7);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(163, 35);
            this.headerLabel.TabIndex = 53;
            this.headerLabel.Text = "Project List";
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Silver;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 491);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(717, 27);
            this.footerPanel.TabIndex = 80;
            // 
            // headerBottomPanel
            // 
            this.headerBottomPanel.BackColor = System.Drawing.Color.LightGray;
            this.headerBottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBottomPanel.Location = new System.Drawing.Point(0, 53);
            this.headerBottomPanel.Name = "headerBottomPanel";
            this.headerBottomPanel.Size = new System.Drawing.Size(717, 13);
            this.headerBottomPanel.TabIndex = 81;
            // 
            // searchActionsPanel
            // 
            this.searchActionsPanel.Controls.Add(this.searchPanel);
            this.searchActionsPanel.Controls.Add(this.ptypePanel);
            this.searchActionsPanel.Location = new System.Drawing.Point(233, 70);
            this.searchActionsPanel.Name = "searchActionsPanel";
            this.searchActionsPanel.Size = new System.Drawing.Size(447, 50);
            this.searchActionsPanel.TabIndex = 86;
            // 
            // ProjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 518);
            this.Controls.Add(this.searchActionsPanel);
            this.Controls.Add(this.headerBottomPanel);
            this.Controls.Add(this.projectListGrid);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.footerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker";
            this.Resize += new System.EventHandler(this.ProjectList_Resize);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchMiniPic)).EndInit();
            this.ptypePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectListGrid)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.addProjectPanel.ResumeLayout(false);
            this.searchActionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ptypeCmb;
        private System.Windows.Forms.ToolTip projectListToolTip;
        private System.Windows.Forms.PictureBox searchMiniPic;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel ptypePanel;
        private System.Windows.Forms.DataGridView projectListGrid;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel headerBottomPanel;
        private System.Windows.Forms.Button projectAdd;
        private System.Windows.Forms.Panel addProjectPanel;
        private System.Windows.Forms.Panel searchActionsPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectid;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectname;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectdescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn projecttypename;
        private System.Windows.Forms.DataGridViewLinkColumn edit;
        private System.Windows.Forms.DataGridViewLinkColumn delete;
    }
}