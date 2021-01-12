namespace BugTracker.Views
{
    partial class BugFixList
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
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchMiniPic = new System.Windows.Forms.PictureBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.bugFixListGrid = new System.Windows.Forms.DataGridView();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.headerBottomPanel = new System.Windows.Forms.Panel();
            this.bugTitleLabel = new System.Windows.Forms.Label();
            this.relatedBugLabel = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.bugFixToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchMiniPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugFixListGrid)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.searchPanel.Controls.Add(this.searchMiniPic);
            this.searchPanel.Controls.Add(this.searchTxt);
            this.searchPanel.Location = new System.Drawing.Point(615, 76);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(219, 33);
            this.searchPanel.TabIndex = 79;
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
            // bugFixListGrid
            // 
            this.bugFixListGrid.AllowUserToAddRows = false;
            this.bugFixListGrid.AllowUserToDeleteRows = false;
            this.bugFixListGrid.AllowUserToOrderColumns = true;
            this.bugFixListGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.bugFixListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bugFixListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bugFixListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sn,
            this.fixid,
            this.userid,
            this.fixdate,
            this.fixtitle,
            this.fixdesc,
            this.status,
            this.fixedby,
            this.action});
            this.bugFixListGrid.Location = new System.Drawing.Point(32, 119);
            this.bugFixListGrid.Name = "bugFixListGrid";
            this.bugFixListGrid.ReadOnly = true;
            this.bugFixListGrid.Size = new System.Drawing.Size(802, 345);
            this.bugFixListGrid.TabIndex = 78;
            this.bugFixListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bugFixListGrid_CellContentClick);
            // 
            // sn
            // 
            this.sn.DataPropertyName = "sn";
            this.sn.FillWeight = 40F;
            this.sn.HeaderText = "SN";
            this.sn.Name = "sn";
            this.sn.ReadOnly = true;
            this.sn.Width = 40;
            // 
            // fixid
            // 
            this.fixid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fixid.DataPropertyName = "fix_id";
            this.fixid.HeaderText = "Fix Id";
            this.fixid.Name = "fixid";
            this.fixid.ReadOnly = true;
            this.fixid.Visible = false;
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
            // fixdate
            // 
            this.fixdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fixdate.DataPropertyName = "fix_date";
            this.fixdate.FillWeight = 120F;
            this.fixdate.HeaderText = "Fix Date";
            this.fixdate.Name = "fixdate";
            this.fixdate.ReadOnly = true;
            // 
            // fixtitle
            // 
            this.fixtitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fixtitle.DataPropertyName = "fix_title";
            this.fixtitle.FillWeight = 120F;
            this.fixtitle.HeaderText = "Title";
            this.fixtitle.Name = "fixtitle";
            this.fixtitle.ReadOnly = true;
            // 
            // fixdesc
            // 
            this.fixdesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fixdesc.DataPropertyName = "fix_desc";
            this.fixdesc.FillWeight = 160F;
            this.fixdesc.HeaderText = "Description";
            this.fixdesc.Name = "fixdesc";
            this.fixdesc.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "fix_status_name";
            this.status.FillWeight = 80F;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // fixedby
            // 
            this.fixedby.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fixedby.DataPropertyName = "full_name";
            this.fixedby.FillWeight = 140F;
            this.fixedby.HeaderText = "Fixed By";
            this.fixedby.Name = "fixedby";
            this.fixedby.ReadOnly = true;
            // 
            // action
            // 
            this.action.DataPropertyName = "fix_id";
            this.action.HeaderText = "Action";
            this.action.LinkColor = System.Drawing.Color.MediumBlue;
            this.action.Name = "action";
            this.action.ReadOnly = true;
            this.action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.action.Text = "View";
            this.action.UseColumnTextForLinkValue = true;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Gray;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.CadetBlue;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(867, 53);
            this.headerPanel.TabIndex = 81;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerLabel.Location = new System.Drawing.Point(26, 7);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(108, 35);
            this.headerLabel.TabIndex = 53;
            this.headerLabel.Text = "Fix List";
            // 
            // headerBottomPanel
            // 
            this.headerBottomPanel.BackColor = System.Drawing.Color.LightGray;
            this.headerBottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBottomPanel.Location = new System.Drawing.Point(0, 53);
            this.headerBottomPanel.Name = "headerBottomPanel";
            this.headerBottomPanel.Size = new System.Drawing.Size(867, 13);
            this.headerBottomPanel.TabIndex = 82;
            // 
            // bugTitleLabel
            // 
            this.bugTitleLabel.AutoSize = true;
            this.bugTitleLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bugTitleLabel.Font = new System.Drawing.Font("Calibri", 11F);
            this.bugTitleLabel.Location = new System.Drawing.Point(129, 76);
            this.bugTitleLabel.MaximumSize = new System.Drawing.Size(213, 0);
            this.bugTitleLabel.Name = "bugTitleLabel";
            this.bugTitleLabel.Padding = new System.Windows.Forms.Padding(5);
            this.bugTitleLabel.Size = new System.Drawing.Size(69, 28);
            this.bugTitleLabel.TabIndex = 117;
            this.bugTitleLabel.Text = "bug title";
            // 
            // relatedBugLabel
            // 
            this.relatedBugLabel.AutoSize = true;
            this.relatedBugLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatedBugLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.relatedBugLabel.Location = new System.Drawing.Point(28, 80);
            this.relatedBugLabel.Name = "relatedBugLabel";
            this.relatedBugLabel.Size = new System.Drawing.Size(98, 19);
            this.relatedBugLabel.TabIndex = 116;
            this.relatedBugLabel.Text = "Related Bug:";
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Silver;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 491);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(867, 27);
            this.footerPanel.TabIndex = 118;
            // 
            // bugFixToolTip
            // 
            this.bugFixToolTip.AutomaticDelay = 1;
            this.bugFixToolTip.AutoPopDelay = 5000;
            this.bugFixToolTip.InitialDelay = 1;
            this.bugFixToolTip.ReshowDelay = 0;
            // 
            // BugFixList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 518);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.bugTitleLabel);
            this.Controls.Add(this.relatedBugLabel);
            this.Controls.Add(this.headerBottomPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.bugFixListGrid);
            this.Controls.Add(this.headerPanel);
            this.Name = "BugFixList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker";
            this.Resize += new System.EventHandler(this.BugFixList_Resize);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchMiniPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugFixListGrid)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.PictureBox searchMiniPic;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.DataGridView bugFixListGrid;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel headerBottomPanel;
        private System.Windows.Forms.Label bugTitleLabel;
        private System.Windows.Forms.Label relatedBugLabel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.ToolTip bugFixToolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixid;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixedby;
        private System.Windows.Forms.DataGridViewLinkColumn action;
    }
}