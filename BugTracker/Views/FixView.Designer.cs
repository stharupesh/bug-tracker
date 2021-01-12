namespace BugTracker.Views
{
    partial class FixView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixView));
            this.bugTitleLabel = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.headerBottomPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.relatedBugLabel = new System.Windows.Forms.Label();
            this.searchBoxPanel = new System.Windows.Forms.Panel();
            this.closeSearchBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.searchBoxTxt = new System.Windows.Forms.TextBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.bugFormErrProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.descLabel = new System.Windows.Forms.Label();
            this.sourceCodePanel = new System.Windows.Forms.Panel();
            this.fixTitle = new System.Windows.Forms.Label();
            this.descPanel = new System.Windows.Forms.Panel();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.authorName = new System.Windows.Forms.Label();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.actionsOuterPanel = new System.Windows.Forms.Panel();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.statusCmb = new System.Windows.Forms.ComboBox();
            this.editFixBtn = new System.Windows.Forms.Button();
            this.deleteFixBtn = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.searchBoxPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugFormErrProvider)).BeginInit();
            this.descPanel.SuspendLayout();
            this.actionsOuterPanel.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bugTitleLabel
            // 
            this.bugTitleLabel.AutoSize = true;
            this.bugTitleLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bugTitleLabel.Font = new System.Drawing.Font("Calibri", 11F);
            this.bugTitleLabel.Location = new System.Drawing.Point(24, 160);
            this.bugTitleLabel.MaximumSize = new System.Drawing.Size(213, 0);
            this.bugTitleLabel.Name = "bugTitleLabel";
            this.bugTitleLabel.Padding = new System.Windows.Forms.Padding(5);
            this.bugTitleLabel.Size = new System.Drawing.Size(69, 28);
            this.bugTitleLabel.TabIndex = 126;
            this.bugTitleLabel.Text = "bug title";
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Silver;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 489);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1026, 27);
            this.footerPanel.TabIndex = 123;
            // 
            // headerBottomPanel
            // 
            this.headerBottomPanel.BackColor = System.Drawing.Color.LightGray;
            this.headerBottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBottomPanel.Location = new System.Drawing.Point(0, 53);
            this.headerBottomPanel.Name = "headerBottomPanel";
            this.headerBottomPanel.Size = new System.Drawing.Size(1026, 13);
            this.headerBottomPanel.TabIndex = 124;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerLabel.Location = new System.Drawing.Point(26, 7);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(148, 35);
            this.headerLabel.TabIndex = 53;
            this.headerLabel.Text = "Fix Details";
            // 
            // relatedBugLabel
            // 
            this.relatedBugLabel.AutoSize = true;
            this.relatedBugLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatedBugLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.relatedBugLabel.Location = new System.Drawing.Point(23, 137);
            this.relatedBugLabel.Name = "relatedBugLabel";
            this.relatedBugLabel.Size = new System.Drawing.Size(94, 19);
            this.relatedBugLabel.TabIndex = 125;
            this.relatedBugLabel.Text = "Related Bug";
            // 
            // searchBoxPanel
            // 
            this.searchBoxPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.searchBoxPanel.Controls.Add(this.closeSearchBtn);
            this.searchBoxPanel.Controls.Add(this.nextBtn);
            this.searchBoxPanel.Controls.Add(this.previousBtn);
            this.searchBoxPanel.Controls.Add(this.searchBoxTxt);
            this.searchBoxPanel.Location = new System.Drawing.Point(792, 35);
            this.searchBoxPanel.Name = "searchBoxPanel";
            this.searchBoxPanel.Size = new System.Drawing.Size(223, 41);
            this.searchBoxPanel.TabIndex = 119;
            this.searchBoxPanel.Visible = false;
            // 
            // closeSearchBtn
            // 
            this.closeSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeSearchBtn.FlatAppearance.BorderSize = 0;
            this.closeSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeSearchBtn.Image = global::BugTracker.Properties.Resources.closeSearchIcon;
            this.closeSearchBtn.Location = new System.Drawing.Point(194, 7);
            this.closeSearchBtn.Name = "closeSearchBtn";
            this.closeSearchBtn.Size = new System.Drawing.Size(19, 24);
            this.closeSearchBtn.TabIndex = 1;
            this.closeSearchBtn.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Image = global::BugTracker.Properties.Resources.nextSearchIcon;
            this.nextBtn.Location = new System.Drawing.Point(171, 7);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(19, 24);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // previousBtn
            // 
            this.previousBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousBtn.FlatAppearance.BorderSize = 0;
            this.previousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousBtn.Image = global::BugTracker.Properties.Resources.previousSearchIcon;
            this.previousBtn.Location = new System.Drawing.Point(147, 7);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(19, 24);
            this.previousBtn.TabIndex = 1;
            this.previousBtn.UseVisualStyleBackColor = true;
            // 
            // searchBoxTxt
            // 
            this.searchBoxTxt.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBoxTxt.Location = new System.Drawing.Point(5, 6);
            this.searchBoxTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.searchBoxTxt.Name = "searchBoxTxt";
            this.searchBoxTxt.Size = new System.Drawing.Size(137, 27);
            this.searchBoxTxt.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Gray;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.CadetBlue;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1026, 53);
            this.headerPanel.TabIndex = 122;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.titleLabel.Location = new System.Drawing.Point(23, 76);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(55, 19);
            this.titleLabel.TabIndex = 121;
            this.titleLabel.Text = "Fix Title";
            // 
            // bugFormErrProvider
            // 
            this.bugFormErrProvider.ContainerControl = this;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.descLabel.Location = new System.Drawing.Point(23, 252);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(85, 19);
            this.descLabel.TabIndex = 120;
            this.descLabel.Text = "Description";
            // 
            // sourceCodePanel
            // 
            this.sourceCodePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sourceCodePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sourceCodePanel.Location = new System.Drawing.Point(263, 76);
            this.sourceCodePanel.Name = "sourceCodePanel";
            this.sourceCodePanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.sourceCodePanel.Size = new System.Drawing.Size(752, 351);
            this.sourceCodePanel.TabIndex = 118;
            // 
            // fixTitle
            // 
            this.fixTitle.AutoSize = true;
            this.fixTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fixTitle.Font = new System.Drawing.Font("Calibri", 11F);
            this.fixTitle.Location = new System.Drawing.Point(26, 99);
            this.fixTitle.Name = "fixTitle";
            this.fixTitle.Padding = new System.Windows.Forms.Padding(5);
            this.fixTitle.Size = new System.Drawing.Size(61, 28);
            this.fixTitle.TabIndex = 128;
            this.fixTitle.Text = "fix title";
            // 
            // descPanel
            // 
            this.descPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.descPanel.Controls.Add(this.descTxt);
            this.descPanel.Location = new System.Drawing.Point(27, 276);
            this.descPanel.Name = "descPanel";
            this.descPanel.Size = new System.Drawing.Size(213, 65);
            this.descPanel.TabIndex = 129;
            // 
            // descTxt
            // 
            this.descTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.descTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descTxt.Font = new System.Drawing.Font("Calibri Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descTxt.Location = new System.Drawing.Point(5, 6);
            this.descTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.descTxt.Multiline = true;
            this.descTxt.Name = "descTxt";
            this.descTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descTxt.Size = new System.Drawing.Size(203, 53);
            this.descTxt.TabIndex = 0;
            // 
            // authorName
            // 
            this.authorName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.authorName.Font = new System.Drawing.Font("Calibri", 11F);
            this.authorName.Location = new System.Drawing.Point(22, 371);
            this.authorName.Name = "authorName";
            this.authorName.Padding = new System.Windows.Forms.Padding(5);
            this.authorName.Size = new System.Drawing.Size(218, 56);
            this.authorName.TabIndex = 131;
            this.authorName.Text = "full name at datetime";
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorNameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.authorNameLabel.Location = new System.Drawing.Point(23, 348);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(79, 19);
            this.authorNameLabel.TabIndex = 130;
            this.authorNameLabel.Text = "Written By";
            // 
            // actionsOuterPanel
            // 
            this.actionsOuterPanel.BackColor = System.Drawing.Color.Transparent;
            this.actionsOuterPanel.Controls.Add(this.actionsPanel);
            this.actionsOuterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionsOuterPanel.Location = new System.Drawing.Point(0, 429);
            this.actionsOuterPanel.Name = "actionsOuterPanel";
            this.actionsOuterPanel.Size = new System.Drawing.Size(1026, 60);
            this.actionsOuterPanel.TabIndex = 132;
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.statusPanel);
            this.actionsPanel.Controls.Add(this.editFixBtn);
            this.actionsPanel.Controls.Add(this.deleteFixBtn);
            this.actionsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.actionsPanel.Location = new System.Drawing.Point(594, 0);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(432, 60);
            this.actionsPanel.TabIndex = 133;
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.statusPanel.Controls.Add(this.statusCmb);
            this.statusPanel.Location = new System.Drawing.Point(9, 12);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(160, 33);
            this.statusPanel.TabIndex = 128;
            this.statusPanel.Visible = false;
            // 
            // statusCmb
            // 
            this.statusCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusCmb.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusCmb.FormattingEnabled = true;
            this.statusCmb.Location = new System.Drawing.Point(5, 3);
            this.statusCmb.Name = "statusCmb";
            this.statusCmb.Size = new System.Drawing.Size(152, 27);
            this.statusCmb.TabIndex = 0;
            this.statusCmb.SelectedIndexChanged += new System.EventHandler(this.statusCmb_SelectedIndexChanged);
            // 
            // editFixBtn
            // 
            this.editFixBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.editFixBtn.FlatAppearance.BorderSize = 0;
            this.editFixBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFixBtn.ForeColor = System.Drawing.Color.White;
            this.editFixBtn.Location = new System.Drawing.Point(175, 12);
            this.editFixBtn.Name = "editFixBtn";
            this.editFixBtn.Size = new System.Drawing.Size(121, 33);
            this.editFixBtn.TabIndex = 127;
            this.editFixBtn.Text = "Edit";
            this.editFixBtn.UseVisualStyleBackColor = false;
            this.editFixBtn.Visible = false;
            this.editFixBtn.Click += new System.EventHandler(this.editFixBtn_Click);
            // 
            // deleteFixBtn
            // 
            this.deleteFixBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.deleteFixBtn.FlatAppearance.BorderSize = 0;
            this.deleteFixBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFixBtn.ForeColor = System.Drawing.Color.White;
            this.deleteFixBtn.Location = new System.Drawing.Point(302, 12);
            this.deleteFixBtn.Name = "deleteFixBtn";
            this.deleteFixBtn.Size = new System.Drawing.Size(121, 33);
            this.deleteFixBtn.TabIndex = 127;
            this.deleteFixBtn.Text = "Delete";
            this.deleteFixBtn.UseVisualStyleBackColor = false;
            this.deleteFixBtn.Click += new System.EventHandler(this.deleteFixBtn_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.SystemColors.ControlLight;
            this.status.Font = new System.Drawing.Font("Calibri", 11F);
            this.status.Location = new System.Drawing.Point(24, 217);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(5);
            this.status.Size = new System.Drawing.Size(49, 28);
            this.status.TabIndex = 134;
            this.status.Text = "fixed";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.statusLabel.Location = new System.Drawing.Point(23, 195);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 19);
            this.statusLabel.TabIndex = 133;
            this.statusLabel.Text = "Status";
            // 
            // FixView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 516);
            this.Controls.Add(this.status);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.actionsOuterPanel);
            this.Controls.Add(this.authorName);
            this.Controls.Add(this.authorNameLabel);
            this.Controls.Add(this.descPanel);
            this.Controls.Add(this.fixTitle);
            this.Controls.Add(this.bugTitleLabel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.relatedBugLabel);
            this.Controls.Add(this.searchBoxPanel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.sourceCodePanel);
            this.Controls.Add(this.headerBottomPanel);
            this.Controls.Add(this.headerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FixView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker";
            this.Resize += new System.EventHandler(this.FixView_Resize);
            this.searchBoxPanel.ResumeLayout(false);
            this.searchBoxPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugFormErrProvider)).EndInit();
            this.descPanel.ResumeLayout(false);
            this.descPanel.PerformLayout();
            this.actionsOuterPanel.ResumeLayout(false);
            this.actionsPanel.ResumeLayout(false);
            this.statusPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bugTitleLabel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel headerBottomPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label relatedBugLabel;
        private System.Windows.Forms.Panel searchBoxPanel;
        private System.Windows.Forms.Button closeSearchBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.TextBox searchBoxTxt;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ErrorProvider bugFormErrProvider;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Panel sourceCodePanel;
        private System.Windows.Forms.Label fixTitle;
        private System.Windows.Forms.Panel descPanel;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.Label authorName;
        private System.Windows.Forms.Label authorNameLabel;
        private System.Windows.Forms.Panel actionsOuterPanel;
        private System.Windows.Forms.Button editFixBtn;
        private System.Windows.Forms.Button deleteFixBtn;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.ComboBox statusCmb;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label statusLabel;
    }
}