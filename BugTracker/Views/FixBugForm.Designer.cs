namespace BugTracker.Views
{
    partial class FixBugForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixBugForm));
            this.sourceCodePanel = new System.Windows.Forms.Panel();
            this.descLabel = new System.Windows.Forms.Label();
            this.bugFormErrProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.descPanel = new System.Windows.Forms.Panel();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.searchBoxTxt = new System.Windows.Forms.TextBox();
            this.searchBoxPanel = new System.Windows.Forms.Panel();
            this.closeSearchBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.headerBottomPanel = new System.Windows.Forms.Panel();
            this.bugTitleLabel = new System.Windows.Forms.Label();
            this.relatedBugLabel = new System.Windows.Forms.Label();
            this.fixBugBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bugFormErrProvider)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.descPanel.SuspendLayout();
            this.searchBoxPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceCodePanel
            // 
            this.sourceCodePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sourceCodePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sourceCodePanel.Location = new System.Drawing.Point(262, 76);
            this.sourceCodePanel.Name = "sourceCodePanel";
            this.sourceCodePanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.sourceCodePanel.Size = new System.Drawing.Size(752, 351);
            this.sourceCodePanel.TabIndex = 81;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.descLabel.Location = new System.Drawing.Point(22, 142);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(85, 19);
            this.descLabel.TabIndex = 84;
            this.descLabel.Text = "Description";
            // 
            // bugFormErrProvider
            // 
            this.bugFormErrProvider.ContainerControl = this;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.titleLabel.Location = new System.Drawing.Point(22, 76);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(55, 19);
            this.titleLabel.TabIndex = 85;
            this.titleLabel.Text = "Fix Title";
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.titlePanel.Controls.Add(this.titleTxt);
            this.titlePanel.Location = new System.Drawing.Point(26, 97);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(213, 33);
            this.titlePanel.TabIndex = 75;
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
            // descPanel
            // 
            this.descPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.descPanel.Controls.Add(this.descTxt);
            this.descPanel.Location = new System.Drawing.Point(26, 163);
            this.descPanel.Name = "descPanel";
            this.descPanel.Size = new System.Drawing.Size(213, 65);
            this.descPanel.TabIndex = 76;
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
            this.searchBoxPanel.TabIndex = 83;
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
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Gray;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.CadetBlue;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1025, 53);
            this.headerPanel.TabIndex = 90;
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
            this.headerLabel.Text = "Fix Bug";
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Silver;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 487);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1025, 27);
            this.footerPanel.TabIndex = 91;
            // 
            // headerBottomPanel
            // 
            this.headerBottomPanel.BackColor = System.Drawing.Color.LightGray;
            this.headerBottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBottomPanel.Location = new System.Drawing.Point(0, 53);
            this.headerBottomPanel.Name = "headerBottomPanel";
            this.headerBottomPanel.Size = new System.Drawing.Size(1025, 13);
            this.headerBottomPanel.TabIndex = 92;
            // 
            // bugTitleLabel
            // 
            this.bugTitleLabel.AutoSize = true;
            this.bugTitleLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bugTitleLabel.Font = new System.Drawing.Font("Calibri", 11F);
            this.bugTitleLabel.Location = new System.Drawing.Point(23, 263);
            this.bugTitleLabel.MaximumSize = new System.Drawing.Size(213, 0);
            this.bugTitleLabel.Name = "bugTitleLabel";
            this.bugTitleLabel.Padding = new System.Windows.Forms.Padding(5);
            this.bugTitleLabel.Size = new System.Drawing.Size(69, 28);
            this.bugTitleLabel.TabIndex = 113;
            this.bugTitleLabel.Text = "bug title";
            // 
            // relatedBugLabel
            // 
            this.relatedBugLabel.AutoSize = true;
            this.relatedBugLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatedBugLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.relatedBugLabel.Location = new System.Drawing.Point(22, 240);
            this.relatedBugLabel.Name = "relatedBugLabel";
            this.relatedBugLabel.Size = new System.Drawing.Size(94, 19);
            this.relatedBugLabel.TabIndex = 112;
            this.relatedBugLabel.Text = "Related Bug";
            // 
            // fixBugBtn
            // 
            this.fixBugBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fixBugBtn.FlatAppearance.BorderSize = 0;
            this.fixBugBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixBugBtn.ForeColor = System.Drawing.Color.White;
            this.fixBugBtn.Location = new System.Drawing.Point(894, 440);
            this.fixBugBtn.Name = "fixBugBtn";
            this.fixBugBtn.Size = new System.Drawing.Size(121, 33);
            this.fixBugBtn.TabIndex = 115;
            this.fixBugBtn.Text = "Fix Bug";
            this.fixBugBtn.UseVisualStyleBackColor = false;
            this.fixBugBtn.Click += new System.EventHandler(this.fixBugBtn_Click);
            // 
            // FixBugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 514);
            this.Controls.Add(this.sourceCodePanel);
            this.Controls.Add(this.fixBugBtn);
            this.Controls.Add(this.bugTitleLabel);
            this.Controls.Add(this.relatedBugLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.descPanel);
            this.Controls.Add(this.searchBoxPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.headerBottomPanel);
            this.Controls.Add(this.headerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FixBugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker";
            this.Resize += new System.EventHandler(this.FixBugForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.bugFormErrProvider)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.descPanel.ResumeLayout(false);
            this.descPanel.PerformLayout();
            this.searchBoxPanel.ResumeLayout(false);
            this.searchBoxPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sourceCodePanel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.ErrorProvider bugFormErrProvider;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Panel descPanel;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.Panel searchBoxPanel;
        private System.Windows.Forms.Button closeSearchBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.TextBox searchBoxTxt;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel headerBottomPanel;
        private System.Windows.Forms.Label bugTitleLabel;
        private System.Windows.Forms.Label relatedBugLabel;
        private System.Windows.Forms.Button fixBugBtn;
    }
}