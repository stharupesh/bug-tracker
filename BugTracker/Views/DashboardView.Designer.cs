namespace BugTracker.Views
{
    partial class DashboardView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardView));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.headerRightPanel = new System.Windows.Forms.Panel();
            this.userStatusPanel = new System.Windows.Forms.Panel();
            this.userTypeLabel = new System.Windows.Forms.Label();
            this.userOptCaret = new System.Windows.Forms.PictureBox();
            this.currentUsernameLabel = new System.Windows.Forms.Label();
            this.userAvatarPic = new System.Windows.Forms.PictureBox();
            this.userOptionsPanel = new System.Windows.Forms.Panel();
            this.userOptionsCmb = new System.Windows.Forms.ComboBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.quickSearchPanel = new System.Windows.Forms.Panel();
            this.searchMiniPic = new System.Windows.Forms.PictureBox();
            this.quickSearchTxt = new System.Windows.Forms.TextBox();
            this.quickSearchBtn = new System.Windows.Forms.Button();
            this.projectsLabel = new System.Windows.Forms.Label();
            this.usersLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.reportBugLabel = new System.Windows.Forms.Label();
            this.usersBtn = new System.Windows.Forms.Button();
            this.reportBugBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.projectsBtn = new System.Windows.Forms.Button();
            this.headerBottomPanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.headerRightPanel.SuspendLayout();
            this.userStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userOptCaret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatarPic)).BeginInit();
            this.userOptionsPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.quickSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchMiniPic)).BeginInit();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Controls.Add(this.headerRightPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(977, 53);
            this.headerPanel.TabIndex = 26;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerLabel.Location = new System.Drawing.Point(26, 7);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(147, 35);
            this.headerLabel.TabIndex = 54;
            this.headerLabel.Text = "Dashboard";
            // 
            // headerRightPanel
            // 
            this.headerRightPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.headerRightPanel.Controls.Add(this.userStatusPanel);
            this.headerRightPanel.Controls.Add(this.userOptionsPanel);
            this.headerRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.headerRightPanel.Location = new System.Drawing.Point(728, 0);
            this.headerRightPanel.Name = "headerRightPanel";
            this.headerRightPanel.Size = new System.Drawing.Size(249, 53);
            this.headerRightPanel.TabIndex = 52;
            // 
            // userStatusPanel
            // 
            this.userStatusPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.userStatusPanel.Controls.Add(this.userTypeLabel);
            this.userStatusPanel.Controls.Add(this.userOptCaret);
            this.userStatusPanel.Controls.Add(this.currentUsernameLabel);
            this.userStatusPanel.Controls.Add(this.userAvatarPic);
            this.userStatusPanel.Location = new System.Drawing.Point(3, 3);
            this.userStatusPanel.Name = "userStatusPanel";
            this.userStatusPanel.Size = new System.Drawing.Size(243, 49);
            this.userStatusPanel.TabIndex = 50;
            // 
            // userTypeLabel
            // 
            this.userTypeLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.userTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeLabel.ForeColor = System.Drawing.Color.White;
            this.userTypeLabel.Location = new System.Drawing.Point(74, 30);
            this.userTypeLabel.Name = "userTypeLabel";
            this.userTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userTypeLabel.Size = new System.Drawing.Size(136, 15);
            this.userTypeLabel.TabIndex = 43;
            this.userTypeLabel.Text = "( Admin )";
            this.userTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userOptCaret
            // 
            this.userOptCaret.Image = global::BugTracker.Properties.Resources.caretIcon;
            this.userOptCaret.Location = new System.Drawing.Point(205, 17);
            this.userOptCaret.Name = "userOptCaret";
            this.userOptCaret.Padding = new System.Windows.Forms.Padding(3);
            this.userOptCaret.Size = new System.Drawing.Size(18, 16);
            this.userOptCaret.TabIndex = 27;
            this.userOptCaret.TabStop = false;
            this.userOptCaret.Click += new System.EventHandler(this.userOptCaret_Click);
            // 
            // currentUsernameLabel
            // 
            this.currentUsernameLabel.AutoSize = true;
            this.currentUsernameLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUsernameLabel.ForeColor = System.Drawing.Color.White;
            this.currentUsernameLabel.Location = new System.Drawing.Point(39, 12);
            this.currentUsernameLabel.Name = "currentUsernameLabel";
            this.currentUsernameLabel.Size = new System.Drawing.Size(75, 20);
            this.currentUsernameLabel.TabIndex = 27;
            this.currentUsernameLabel.Text = "full name";
            this.currentUsernameLabel.Click += new System.EventHandler(this.currentUsernameLabel_Click);
            // 
            // userAvatarPic
            // 
            this.userAvatarPic.Image = global::BugTracker.Properties.Resources.userAvatar;
            this.userAvatarPic.Location = new System.Drawing.Point(3, 3);
            this.userAvatarPic.Name = "userAvatarPic";
            this.userAvatarPic.Padding = new System.Windows.Forms.Padding(3);
            this.userAvatarPic.Size = new System.Drawing.Size(37, 37);
            this.userAvatarPic.TabIndex = 27;
            this.userAvatarPic.TabStop = false;
            // 
            // userOptionsPanel
            // 
            this.userOptionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.userOptionsPanel.Controls.Add(this.userOptionsCmb);
            this.userOptionsPanel.Location = new System.Drawing.Point(113, 21);
            this.userOptionsPanel.Name = "userOptionsPanel";
            this.userOptionsPanel.Size = new System.Drawing.Size(133, 29);
            this.userOptionsPanel.TabIndex = 51;
            // 
            // userOptionsCmb
            // 
            this.userOptionsCmb.BackColor = System.Drawing.SystemColors.Window;
            this.userOptionsCmb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userOptionsCmb.FormattingEnabled = true;
            this.userOptionsCmb.ItemHeight = 17;
            this.userOptionsCmb.Location = new System.Drawing.Point(3, 3);
            this.userOptionsCmb.Name = "userOptionsCmb";
            this.userOptionsCmb.Size = new System.Drawing.Size(130, 25);
            this.userOptionsCmb.TabIndex = 27;
            this.userOptionsCmb.SelectedIndexChanged += new System.EventHandler(this.userOptionsCmb_SelectedIndexChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.searchPanel);
            this.mainPanel.Controls.Add(this.projectsLabel);
            this.mainPanel.Controls.Add(this.usersLabel);
            this.mainPanel.Controls.Add(this.searchLabel);
            this.mainPanel.Controls.Add(this.reportBugLabel);
            this.mainPanel.Controls.Add(this.usersBtn);
            this.mainPanel.Controls.Add(this.reportBugBtn);
            this.mainPanel.Controls.Add(this.searchBtn);
            this.mainPanel.Controls.Add(this.projectsBtn);
            this.mainPanel.Location = new System.Drawing.Point(168, 106);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(600, 271);
            this.mainPanel.TabIndex = 43;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.quickSearchPanel);
            this.searchPanel.Controls.Add(this.quickSearchBtn);
            this.searchPanel.Location = new System.Drawing.Point(87, 192);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(448, 60);
            this.searchPanel.TabIndex = 50;
            // 
            // quickSearchPanel
            // 
            this.quickSearchPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quickSearchPanel.Controls.Add(this.searchMiniPic);
            this.quickSearchPanel.Controls.Add(this.quickSearchTxt);
            this.quickSearchPanel.Location = new System.Drawing.Point(21, 13);
            this.quickSearchPanel.Name = "quickSearchPanel";
            this.quickSearchPanel.Size = new System.Drawing.Size(274, 33);
            this.quickSearchPanel.TabIndex = 49;
            // 
            // searchMiniPic
            // 
            this.searchMiniPic.Image = global::BugTracker.Properties.Resources.searchMiniIcon;
            this.searchMiniPic.Location = new System.Drawing.Point(245, 4);
            this.searchMiniPic.Name = "searchMiniPic";
            this.searchMiniPic.Size = new System.Drawing.Size(24, 24);
            this.searchMiniPic.TabIndex = 9;
            this.searchMiniPic.TabStop = false;
            // 
            // quickSearchTxt
            // 
            this.quickSearchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quickSearchTxt.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickSearchTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quickSearchTxt.Location = new System.Drawing.Point(5, 6);
            this.quickSearchTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.quickSearchTxt.Name = "quickSearchTxt";
            this.quickSearchTxt.Size = new System.Drawing.Size(234, 20);
            this.quickSearchTxt.TabIndex = 7;
            // 
            // quickSearchBtn
            // 
            this.quickSearchBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.quickSearchBtn.FlatAppearance.BorderSize = 0;
            this.quickSearchBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickSearchBtn.ForeColor = System.Drawing.Color.White;
            this.quickSearchBtn.Location = new System.Drawing.Point(306, 13);
            this.quickSearchBtn.Name = "quickSearchBtn";
            this.quickSearchBtn.Size = new System.Drawing.Size(121, 33);
            this.quickSearchBtn.TabIndex = 48;
            this.quickSearchBtn.Text = "Quick Search";
            this.quickSearchBtn.UseVisualStyleBackColor = false;
            this.quickSearchBtn.Click += new System.EventHandler(this.quickSearchBtn_Click);
            // 
            // projectsLabel
            // 
            this.projectsLabel.AutoSize = true;
            this.projectsLabel.BackColor = System.Drawing.Color.Transparent;
            this.projectsLabel.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsLabel.Location = new System.Drawing.Point(496, 151);
            this.projectsLabel.Name = "projectsLabel";
            this.projectsLabel.Size = new System.Drawing.Size(76, 23);
            this.projectsLabel.TabIndex = 47;
            this.projectsLabel.Text = "Projects";
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.BackColor = System.Drawing.Color.Transparent;
            this.usersLabel.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersLabel.Location = new System.Drawing.Point(355, 151);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(53, 23);
            this.usersLabel.TabIndex = 47;
            this.usersLabel.Text = "Users";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(172, 151);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(105, 23);
            this.searchLabel.TabIndex = 46;
            this.searchLabel.Text = "Search Bugs";
            // 
            // reportBugLabel
            // 
            this.reportBugLabel.AutoSize = true;
            this.reportBugLabel.BackColor = System.Drawing.SystemColors.Control;
            this.reportBugLabel.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBugLabel.Location = new System.Drawing.Point(25, 151);
            this.reportBugLabel.Name = "reportBugLabel";
            this.reportBugLabel.Size = new System.Drawing.Size(97, 23);
            this.reportBugLabel.TabIndex = 45;
            this.reportBugLabel.Text = "Report Bug";
            // 
            // usersBtn
            // 
            this.usersBtn.AutoSize = true;
            this.usersBtn.BackColor = System.Drawing.Color.Transparent;
            this.usersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersBtn.FlatAppearance.BorderSize = 0;
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.usersBtn.Image = global::BugTracker.Properties.Resources.usersManageIcon;
            this.usersBtn.Location = new System.Drawing.Point(308, 10);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 40);
            this.usersBtn.Size = new System.Drawing.Size(138, 176);
            this.usersBtn.TabIndex = 44;
            this.usersBtn.UseVisualStyleBackColor = false;
            this.usersBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // reportBugBtn
            // 
            this.reportBugBtn.AutoSize = true;
            this.reportBugBtn.BackColor = System.Drawing.Color.Transparent;
            this.reportBugBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportBugBtn.FlatAppearance.BorderSize = 0;
            this.reportBugBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBugBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.reportBugBtn.Image = global::BugTracker.Properties.Resources.bugsIcon;
            this.reportBugBtn.Location = new System.Drawing.Point(2, 10);
            this.reportBugBtn.Name = "reportBugBtn";
            this.reportBugBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 40);
            this.reportBugBtn.Size = new System.Drawing.Size(138, 176);
            this.reportBugBtn.TabIndex = 42;
            this.reportBugBtn.Tag = "";
            this.reportBugBtn.UseVisualStyleBackColor = false;
            this.reportBugBtn.Click += new System.EventHandler(this.reportBugBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.AutoSize = true;
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.searchBtn.Image = global::BugTracker.Properties.Resources.searchIcon;
            this.searchBtn.Location = new System.Drawing.Point(155, 10);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 40);
            this.searchBtn.Size = new System.Drawing.Size(138, 176);
            this.searchBtn.TabIndex = 43;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // projectsBtn
            // 
            this.projectsBtn.AutoSize = true;
            this.projectsBtn.BackColor = System.Drawing.Color.Transparent;
            this.projectsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projectsBtn.FlatAppearance.BorderSize = 0;
            this.projectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.projectsBtn.Image = global::BugTracker.Properties.Resources.projectsManageIcon;
            this.projectsBtn.Location = new System.Drawing.Point(461, 10);
            this.projectsBtn.Name = "projectsBtn";
            this.projectsBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 40);
            this.projectsBtn.Size = new System.Drawing.Size(138, 176);
            this.projectsBtn.TabIndex = 44;
            this.projectsBtn.UseVisualStyleBackColor = false;
            this.projectsBtn.Click += new System.EventHandler(this.projectsBtn_Click);
            // 
            // headerBottomPanel
            // 
            this.headerBottomPanel.BackColor = System.Drawing.Color.LightGray;
            this.headerBottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBottomPanel.Location = new System.Drawing.Point(0, 53);
            this.headerBottomPanel.Name = "headerBottomPanel";
            this.headerBottomPanel.Size = new System.Drawing.Size(977, 13);
            this.headerBottomPanel.TabIndex = 93;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Silver;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 542);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(977, 27);
            this.footerPanel.TabIndex = 42;
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.mainPanel);
            this.containerPanel.Location = new System.Drawing.Point(3, 66);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(971, 470);
            this.containerPanel.TabIndex = 94;
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(977, 569);
            this.Controls.Add(this.headerBottomPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.containerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardView_FormClosed);
            this.Resize += new System.EventHandler(this.DashboardView_Resize);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.headerRightPanel.ResumeLayout(false);
            this.userStatusPanel.ResumeLayout(false);
            this.userStatusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userOptCaret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatarPic)).EndInit();
            this.userOptionsPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.quickSearchPanel.ResumeLayout(false);
            this.quickSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchMiniPic)).EndInit();
            this.containerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label currentUsernameLabel;
        private System.Windows.Forms.PictureBox userAvatarPic;
        private System.Windows.Forms.PictureBox userOptCaret;
        private System.Windows.Forms.ComboBox userOptionsCmb;
        private System.Windows.Forms.Label userTypeLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel quickSearchPanel;
        private System.Windows.Forms.PictureBox searchMiniPic;
        private System.Windows.Forms.TextBox quickSearchTxt;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label reportBugLabel;
        private System.Windows.Forms.Button quickSearchBtn;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Button reportBugBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel userStatusPanel;
        private System.Windows.Forms.Panel userOptionsPanel;
        private System.Windows.Forms.Panel headerRightPanel;
        private System.Windows.Forms.Button projectsBtn;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label projectsLabel;
        private System.Windows.Forms.Panel headerBottomPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel containerPanel;
    }
}