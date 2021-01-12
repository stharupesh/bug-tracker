namespace BugTracker.Views
{
    partial class BugList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugList));
            this.headerBottomPanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.bugListDataGrid = new System.Windows.Forms.DataGridView();
            this.bugid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bugdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bugtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bugdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isfixed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.view = new System.Windows.Forms.DataGridViewLinkColumn();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchMiniPic = new System.Windows.Forms.PictureBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.bugListToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ptypePanel = new System.Windows.Forms.Panel();
            this.ptypeCmb = new System.Windows.Forms.ComboBox();
            this.searchActionsPanel = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugListDataGrid)).BeginInit();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchMiniPic)).BeginInit();
            this.ptypePanel.SuspendLayout();
            this.searchActionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerBottomPanel
            // 
            this.headerBottomPanel.BackColor = System.Drawing.Color.LightGray;
            this.headerBottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBottomPanel.Location = new System.Drawing.Point(0, 53);
            this.headerBottomPanel.Name = "headerBottomPanel";
            this.headerBottomPanel.Size = new System.Drawing.Size(936, 13);
            this.headerBottomPanel.TabIndex = 74;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Silver;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 493);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(936, 27);
            this.footerPanel.TabIndex = 73;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerLabel.Location = new System.Drawing.Point(26, 7);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(115, 35);
            this.headerLabel.TabIndex = 53;
            this.headerLabel.Text = "Bug List";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Gray;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.CadetBlue;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(936, 53);
            this.headerPanel.TabIndex = 72;
            // 
            // bugListDataGrid
            // 
            this.bugListDataGrid.AllowUserToAddRows = false;
            this.bugListDataGrid.AllowUserToDeleteRows = false;
            this.bugListDataGrid.AllowUserToOrderColumns = true;
            this.bugListDataGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.bugListDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bugListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bugListDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bugid,
            this.userid,
            this.sn,
            this.bugdate,
            this.bugtitle,
            this.bugdesc,
            this.Project,
            this.fullname,
            this.fixes,
            this.isfixed,
            this.view});
            this.bugListDataGrid.Location = new System.Drawing.Point(38, 123);
            this.bugListDataGrid.Name = "bugListDataGrid";
            this.bugListDataGrid.ReadOnly = true;
            this.bugListDataGrid.Size = new System.Drawing.Size(860, 345);
            this.bugListDataGrid.TabIndex = 75;
            this.bugListDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bugListDataGrid_CellContentClick);
            this.bugListDataGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.bugListDataGrid_Paint);
            // 
            // bugid
            // 
            this.bugid.DataPropertyName = "bug_id";
            this.bugid.HeaderText = "Bug Id";
            this.bugid.Name = "bugid";
            this.bugid.ReadOnly = true;
            this.bugid.Visible = false;
            // 
            // userid
            // 
            this.userid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userid.DataPropertyName = "user_id";
            this.userid.HeaderText = "User Id";
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Visible = false;
            // 
            // sn
            // 
            this.sn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sn.DataPropertyName = "sn";
            this.sn.FillWeight = 30F;
            this.sn.HeaderText = "SN";
            this.sn.Name = "sn";
            this.sn.ReadOnly = true;
            // 
            // bugdate
            // 
            this.bugdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bugdate.DataPropertyName = "bug_date";
            this.bugdate.HeaderText = "Bug Date";
            this.bugdate.Name = "bugdate";
            this.bugdate.ReadOnly = true;
            // 
            // bugtitle
            // 
            this.bugtitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bugtitle.DataPropertyName = "bug_title";
            this.bugtitle.FillWeight = 80F;
            this.bugtitle.HeaderText = "Bug Title";
            this.bugtitle.Name = "bugtitle";
            this.bugtitle.ReadOnly = true;
            // 
            // bugdesc
            // 
            this.bugdesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bugdesc.DataPropertyName = "bug_desc";
            this.bugdesc.FillWeight = 110F;
            this.bugdesc.HeaderText = "Description";
            this.bugdesc.Name = "bugdesc";
            this.bugdesc.ReadOnly = true;
            // 
            // Project
            // 
            this.Project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Project.DataPropertyName = "project_name";
            this.Project.HeaderText = "Project Name";
            this.Project.Name = "Project";
            this.Project.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullname.DataPropertyName = "full_name";
            this.fullname.HeaderText = "Reported By";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // fixes
            // 
            this.fixes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fixes.DataPropertyName = "total_fixes";
            this.fixes.FillWeight = 70F;
            this.fixes.HeaderText = "Total Fixes";
            this.fixes.Name = "fixes";
            this.fixes.ReadOnly = true;
            // 
            // isfixed
            // 
            this.isfixed.DataPropertyName = "is_fixed";
            this.isfixed.FillWeight = 30F;
            this.isfixed.HeaderText = "Fixed";
            this.isfixed.Name = "isfixed";
            this.isfixed.ReadOnly = true;
            this.isfixed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isfixed.Width = 35;
            // 
            // view
            // 
            this.view.DataPropertyName = "action_label";
            this.view.FillWeight = 80F;
            this.view.HeaderText = "Action";
            this.view.LinkColor = System.Drawing.Color.MediumBlue;
            this.view.Name = "view";
            this.view.ReadOnly = true;
            this.view.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.view.Text = "";
            this.view.Width = 94;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.searchPanel.Controls.Add(this.searchMiniPic);
            this.searchPanel.Controls.Add(this.searchTxt);
            this.searchPanel.Location = new System.Drawing.Point(227, 8);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(219, 33);
            this.searchPanel.TabIndex = 76;
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
            // bugListToolTip
            // 
            this.bugListToolTip.AutomaticDelay = 1;
            this.bugListToolTip.AutoPopDelay = 5000;
            this.bugListToolTip.InitialDelay = 1;
            this.bugListToolTip.ReshowDelay = 0;
            // 
            // ptypePanel
            // 
            this.ptypePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ptypePanel.Controls.Add(this.ptypeCmb);
            this.ptypePanel.Location = new System.Drawing.Point(8, 8);
            this.ptypePanel.Name = "ptypePanel";
            this.ptypePanel.Size = new System.Drawing.Size(213, 33);
            this.ptypePanel.TabIndex = 78;
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
            // searchActionsPanel
            // 
            this.searchActionsPanel.Controls.Add(this.ptypePanel);
            this.searchActionsPanel.Controls.Add(this.searchPanel);
            this.searchActionsPanel.Location = new System.Drawing.Point(453, 69);
            this.searchActionsPanel.Name = "searchActionsPanel";
            this.searchActionsPanel.Size = new System.Drawing.Size(452, 50);
            this.searchActionsPanel.TabIndex = 79;
            // 
            // BugList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 520);
            this.Controls.Add(this.searchActionsPanel);
            this.Controls.Add(this.bugListDataGrid);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.headerBottomPanel);
            this.Controls.Add(this.headerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BugList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker";
            this.Resize += new System.EventHandler(this.BugList_Resize);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugListDataGrid)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchMiniPic)).EndInit();
            this.ptypePanel.ResumeLayout(false);
            this.searchActionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerBottomPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.DataGridView bugListDataGrid;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.PictureBox searchMiniPic;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.ToolTip bugListToolTip;
        private System.Windows.Forms.Panel ptypePanel;
        private System.Windows.Forms.ComboBox ptypeCmb;
        private System.Windows.Forms.Panel searchActionsPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn bugid;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bugdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bugtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn bugdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isfixed;
        private System.Windows.Forms.DataGridViewLinkColumn view;
    }
}