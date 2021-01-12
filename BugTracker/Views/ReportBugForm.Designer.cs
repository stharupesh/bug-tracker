namespace BugTracker.Views
{
    partial class ReportBugForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportBugForm));
            this.headerBottomPanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.ptypePanel = new System.Windows.Forms.Panel();
            this.pidCmb = new System.Windows.Forms.ComboBox();
            this.reportBugBtn = new System.Windows.Forms.Button();
            this.fromlineTxt = new System.Windows.Forms.TextBox();
            this.fromlinePanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.searchBoxPanel = new System.Windows.Forms.Panel();
            this.closeSearchBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.searchBoxTxt = new System.Windows.Forms.TextBox();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.descPanel = new System.Windows.Forms.Panel();
            this.cnameTxt = new System.Windows.Forms.TextBox();
            this.cnamePanel = new System.Windows.Forms.Panel();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.fromlineLabel = new System.Windows.Forms.Label();
            this.pidLabel = new System.Windows.Forms.Label();
            this.cnameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.bugFormErrProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.descLabel = new System.Windows.Forms.Label();
            this.tolinelabel = new System.Windows.Forms.Label();
            this.tolinePanel = new System.Windows.Forms.Panel();
            this.tolineTxt = new System.Windows.Forms.TextBox();
            this.sourceCodePanel = new System.Windows.Forms.Panel();
            this.projectType = new System.Windows.Forms.Label();
            this.ptypeLabel = new System.Windows.Forms.Label();
            this.ptypePanel.SuspendLayout();
            this.fromlinePanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.searchBoxPanel.SuspendLayout();
            this.descPanel.SuspendLayout();
            this.cnamePanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugFormErrProvider)).BeginInit();
            this.tolinePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerBottomPanel
            // 
            this.headerBottomPanel.BackColor = System.Drawing.Color.LightGray;
            this.headerBottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBottomPanel.Location = new System.Drawing.Point(0, 53);
            this.headerBottomPanel.Name = "headerBottomPanel";
            this.headerBottomPanel.Size = new System.Drawing.Size(1026, 13);
            this.headerBottomPanel.TabIndex = 74;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Silver;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 515);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1026, 27);
            this.footerPanel.TabIndex = 73;
            // 
            // ptypePanel
            // 
            this.ptypePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ptypePanel.Controls.Add(this.pidCmb);
            this.ptypePanel.Location = new System.Drawing.Point(26, 261);
            this.ptypePanel.Name = "ptypePanel";
            this.ptypePanel.Size = new System.Drawing.Size(213, 33);
            this.ptypePanel.TabIndex = 2;
            // 
            // pidCmb
            // 
            this.pidCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pidCmb.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pidCmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pidCmb.FormattingEnabled = true;
            this.pidCmb.Location = new System.Drawing.Point(5, 3);
            this.pidCmb.Name = "pidCmb";
            this.pidCmb.Size = new System.Drawing.Size(205, 27);
            this.pidCmb.TabIndex = 0;
            this.pidCmb.SelectedIndexChanged += new System.EventHandler(this.pidCmb_SelectedIndexChanged);
            // 
            // reportBugBtn
            // 
            this.reportBugBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reportBugBtn.FlatAppearance.BorderSize = 0;
            this.reportBugBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBugBtn.ForeColor = System.Drawing.Color.White;
            this.reportBugBtn.Location = new System.Drawing.Point(893, 471);
            this.reportBugBtn.Name = "reportBugBtn";
            this.reportBugBtn.Size = new System.Drawing.Size(121, 33);
            this.reportBugBtn.TabIndex = 8;
            this.reportBugBtn.Text = "Report Bug";
            this.reportBugBtn.UseVisualStyleBackColor = false;
            this.reportBugBtn.Click += new System.EventHandler(this.reportBugBtn_Click);
            // 
            // fromlineTxt
            // 
            this.fromlineTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fromlineTxt.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromlineTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fromlineTxt.Location = new System.Drawing.Point(5, 6);
            this.fromlineTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.fromlineTxt.Name = "fromlineTxt";
            this.fromlineTxt.Size = new System.Drawing.Size(73, 20);
            this.fromlineTxt.TabIndex = 0;
            // 
            // fromlinePanel
            // 
            this.fromlinePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.fromlinePanel.Controls.Add(this.fromlineTxt);
            this.fromlinePanel.Location = new System.Drawing.Point(26, 426);
            this.fromlinePanel.Name = "fromlinePanel";
            this.fromlinePanel.Size = new System.Drawing.Size(98, 33);
            this.fromlinePanel.TabIndex = 5;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerLabel.Location = new System.Drawing.Point(26, 7);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(156, 35);
            this.headerLabel.TabIndex = 53;
            this.headerLabel.Text = "Report Bug";
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
            this.headerPanel.TabIndex = 72;
            // 
            // searchBoxPanel
            // 
            this.searchBoxPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.searchBoxPanel.Controls.Add(this.closeSearchBtn);
            this.searchBoxPanel.Controls.Add(this.nextBtn);
            this.searchBoxPanel.Controls.Add(this.previousBtn);
            this.searchBoxPanel.Controls.Add(this.searchBoxTxt);
            this.searchBoxPanel.Location = new System.Drawing.Point(791, 35);
            this.searchBoxPanel.Name = "searchBoxPanel";
            this.searchBoxPanel.Size = new System.Drawing.Size(223, 41);
            this.searchBoxPanel.TabIndex = 54;
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
            this.closeSearchBtn.Click += new System.EventHandler(this.closeSearchBtn_Click);
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
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
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
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
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
            this.searchBoxTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBoxTxt_KeyDown);
            // 
            // descTxt
            // 
            this.descTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descTxt.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descTxt.Location = new System.Drawing.Point(5, 6);
            this.descTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.descTxt.Multiline = true;
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(187, 53);
            this.descTxt.TabIndex = 0;
            // 
            // descPanel
            // 
            this.descPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.descPanel.Controls.Add(this.descTxt);
            this.descPanel.Location = new System.Drawing.Point(26, 163);
            this.descPanel.Name = "descPanel";
            this.descPanel.Size = new System.Drawing.Size(213, 65);
            this.descPanel.TabIndex = 1;
            // 
            // cnameTxt
            // 
            this.cnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cnameTxt.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cnameTxt.Location = new System.Drawing.Point(5, 6);
            this.cnameTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.cnameTxt.Name = "cnameTxt";
            this.cnameTxt.Size = new System.Drawing.Size(185, 20);
            this.cnameTxt.TabIndex = 0;
            // 
            // cnamePanel
            // 
            this.cnamePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cnamePanel.Controls.Add(this.cnameTxt);
            this.cnamePanel.Location = new System.Drawing.Point(26, 360);
            this.cnamePanel.Name = "cnamePanel";
            this.cnamePanel.Size = new System.Drawing.Size(213, 33);
            this.cnamePanel.TabIndex = 4;
            // 
            // titleTxt
            // 
            this.titleTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTxt.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleTxt.Location = new System.Drawing.Point(5, 6);
            this.titleTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(187, 20);
            this.titleTxt.TabIndex = 0;
            // 
            // fromlineLabel
            // 
            this.fromlineLabel.AutoSize = true;
            this.fromlineLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromlineLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.fromlineLabel.Location = new System.Drawing.Point(22, 405);
            this.fromlineLabel.Name = "fromlineLabel";
            this.fromlineLabel.Size = new System.Drawing.Size(100, 19);
            this.fromlineLabel.TabIndex = 71;
            this.fromlineLabel.Text = "From Line No.";
            // 
            // pidLabel
            // 
            this.pidLabel.AutoSize = true;
            this.pidLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pidLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.pidLabel.Location = new System.Drawing.Point(22, 240);
            this.pidLabel.Name = "pidLabel";
            this.pidLabel.Size = new System.Drawing.Size(102, 19);
            this.pidLabel.TabIndex = 69;
            this.pidLabel.Text = "Project Name";
            // 
            // cnameLabel
            // 
            this.cnameLabel.AutoSize = true;
            this.cnameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.cnameLabel.Location = new System.Drawing.Point(24, 339);
            this.cnameLabel.Name = "cnameLabel";
            this.cnameLabel.Size = new System.Drawing.Size(89, 19);
            this.cnameLabel.TabIndex = 68;
            this.cnameLabel.Text = "Class Name";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.titleLabel.Location = new System.Drawing.Point(22, 76);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(34, 19);
            this.titleLabel.TabIndex = 67;
            this.titleLabel.Text = "Title";
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.titlePanel.Controls.Add(this.titleTxt);
            this.titlePanel.Location = new System.Drawing.Point(26, 97);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(213, 33);
            this.titlePanel.TabIndex = 0;
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
            this.descLabel.Location = new System.Drawing.Point(22, 142);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(85, 19);
            this.descLabel.TabIndex = 64;
            this.descLabel.Text = "Description";
            // 
            // tolinelabel
            // 
            this.tolinelabel.AutoSize = true;
            this.tolinelabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolinelabel.ForeColor = System.Drawing.Color.DarkRed;
            this.tolinelabel.Location = new System.Drawing.Point(137, 405);
            this.tolinelabel.Name = "tolinelabel";
            this.tolinelabel.Size = new System.Drawing.Size(81, 19);
            this.tolinelabel.TabIndex = 71;
            this.tolinelabel.Text = "To Line No.";
            // 
            // tolinePanel
            // 
            this.tolinePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tolinePanel.Controls.Add(this.tolineTxt);
            this.tolinePanel.Location = new System.Drawing.Point(141, 426);
            this.tolinePanel.Name = "tolinePanel";
            this.tolinePanel.Size = new System.Drawing.Size(98, 33);
            this.tolinePanel.TabIndex = 6;
            // 
            // tolineTxt
            // 
            this.tolineTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tolineTxt.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolineTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tolineTxt.Location = new System.Drawing.Point(5, 6);
            this.tolineTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.tolineTxt.Name = "tolineTxt";
            this.tolineTxt.Size = new System.Drawing.Size(73, 20);
            this.tolineTxt.TabIndex = 0;
            // 
            // sourceCodePanel
            // 
            this.sourceCodePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sourceCodePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sourceCodePanel.Location = new System.Drawing.Point(262, 76);
            this.sourceCodePanel.Name = "sourceCodePanel";
            this.sourceCodePanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.sourceCodePanel.Size = new System.Drawing.Size(752, 383);
            this.sourceCodePanel.TabIndex = 7;
            // 
            // projectType
            // 
            this.projectType.AutoSize = true;
            this.projectType.BackColor = System.Drawing.SystemColors.ControlLight;
            this.projectType.Font = new System.Drawing.Font("Calibri", 11F);
            this.projectType.Location = new System.Drawing.Point(122, 304);
            this.projectType.Name = "projectType";
            this.projectType.Padding = new System.Windows.Forms.Padding(5);
            this.projectType.Size = new System.Drawing.Size(90, 28);
            this.projectType.TabIndex = 114;
            this.projectType.Text = "projecttype";
            // 
            // ptypeLabel
            // 
            this.ptypeLabel.AutoSize = true;
            this.ptypeLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptypeLabel.ForeColor = System.Drawing.Color.Black;
            this.ptypeLabel.Location = new System.Drawing.Point(24, 308);
            this.ptypeLabel.Name = "ptypeLabel";
            this.ptypeLabel.Size = new System.Drawing.Size(96, 19);
            this.ptypeLabel.TabIndex = 113;
            this.ptypeLabel.Text = "Project Type:";
            // 
            // ReportBugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 542);
            this.Controls.Add(this.projectType);
            this.Controls.Add(this.searchBoxPanel);
            this.Controls.Add(this.ptypeLabel);
            this.Controls.Add(this.sourceCodePanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.ptypePanel);
            this.Controls.Add(this.reportBugBtn);
            this.Controls.Add(this.tolinePanel);
            this.Controls.Add(this.fromlinePanel);
            this.Controls.Add(this.descPanel);
            this.Controls.Add(this.tolinelabel);
            this.Controls.Add(this.cnamePanel);
            this.Controls.Add(this.fromlineLabel);
            this.Controls.Add(this.pidLabel);
            this.Controls.Add(this.cnameLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.headerBottomPanel);
            this.Controls.Add(this.headerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportBugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker";
            this.Resize += new System.EventHandler(this.ReportBugForm_Resize);
            this.ptypePanel.ResumeLayout(false);
            this.fromlinePanel.ResumeLayout(false);
            this.fromlinePanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.searchBoxPanel.ResumeLayout(false);
            this.searchBoxPanel.PerformLayout();
            this.descPanel.ResumeLayout(false);
            this.descPanel.PerformLayout();
            this.cnamePanel.ResumeLayout(false);
            this.cnamePanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugFormErrProvider)).EndInit();
            this.tolinePanel.ResumeLayout(false);
            this.tolinePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel headerBottomPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel ptypePanel;
        private System.Windows.Forms.ComboBox pidCmb;
        private System.Windows.Forms.Button reportBugBtn;
        private System.Windows.Forms.TextBox fromlineTxt;
        private System.Windows.Forms.Panel fromlinePanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.Panel descPanel;
        private System.Windows.Forms.TextBox cnameTxt;
        private System.Windows.Forms.Panel cnamePanel;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label fromlineLabel;
        private System.Windows.Forms.Label pidLabel;
        private System.Windows.Forms.Label cnameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.ErrorProvider bugFormErrProvider;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Panel tolinePanel;
        private System.Windows.Forms.TextBox tolineTxt;
        private System.Windows.Forms.Label tolinelabel;
        private System.Windows.Forms.Panel sourceCodePanel;
        private System.Windows.Forms.Panel searchBoxPanel;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.TextBox searchBoxTxt;
        private System.Windows.Forms.Button closeSearchBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label projectType;
        private System.Windows.Forms.Label ptypeLabel;
    }
}