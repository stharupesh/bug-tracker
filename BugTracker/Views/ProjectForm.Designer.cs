namespace BugTracker.Views
{
    partial class ProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.addProjectBtn = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.projectFormErrProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pTypeLabel = new System.Windows.Forms.Label();
            this.headerBottomPanel = new System.Windows.Forms.Panel();
            this.pNamePanel = new System.Windows.Forms.Panel();
            this.pNameTxt = new System.Windows.Forms.TextBox();
            this.pNameLabel = new System.Windows.Forms.Label();
            this.descPanel = new System.Windows.Forms.Panel();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.ptypePanel = new System.Windows.Forms.Panel();
            this.ptypeCmb = new System.Windows.Forms.ComboBox();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectFormErrProvider)).BeginInit();
            this.pNamePanel.SuspendLayout();
            this.descPanel.SuspendLayout();
            this.ptypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addProjectBtn.FlatAppearance.BorderSize = 0;
            this.addProjectBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProjectBtn.ForeColor = System.Drawing.Color.White;
            this.addProjectBtn.Location = new System.Drawing.Point(251, 254);
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(102, 33);
            this.addProjectBtn.TabIndex = 96;
            this.addProjectBtn.Text = "Add Project";
            this.addProjectBtn.UseVisualStyleBackColor = false;
            this.addProjectBtn.Click += new System.EventHandler(this.addProjectBtn_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerLabel.Location = new System.Drawing.Point(26, 7);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(167, 35);
            this.headerLabel.TabIndex = 53;
            this.headerLabel.Text = "Add Project";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Gray;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.CadetBlue;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(388, 53);
            this.headerPanel.TabIndex = 97;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Silver;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 304);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(388, 27);
            this.footerPanel.TabIndex = 98;
            // 
            // projectFormErrProvider
            // 
            this.projectFormErrProvider.ContainerControl = this;
            // 
            // pTypeLabel
            // 
            this.pTypeLabel.AutoSize = true;
            this.pTypeLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTypeLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.pTypeLabel.Location = new System.Drawing.Point(202, 87);
            this.pTypeLabel.Name = "pTypeLabel";
            this.pTypeLabel.Size = new System.Drawing.Size(92, 19);
            this.pTypeLabel.TabIndex = 104;
            this.pTypeLabel.Text = "Project Type";
            // 
            // headerBottomPanel
            // 
            this.headerBottomPanel.BackColor = System.Drawing.Color.LightGray;
            this.headerBottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBottomPanel.Location = new System.Drawing.Point(0, 53);
            this.headerBottomPanel.Name = "headerBottomPanel";
            this.headerBottomPanel.Size = new System.Drawing.Size(388, 13);
            this.headerBottomPanel.TabIndex = 99;
            // 
            // pNamePanel
            // 
            this.pNamePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pNamePanel.Controls.Add(this.pNameTxt);
            this.pNamePanel.Location = new System.Drawing.Point(33, 111);
            this.pNamePanel.Name = "pNamePanel";
            this.pNamePanel.Size = new System.Drawing.Size(160, 33);
            this.pNamePanel.TabIndex = 101;
            // 
            // pNameTxt
            // 
            this.pNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pNameTxt.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pNameTxt.Location = new System.Drawing.Point(5, 6);
            this.pNameTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.pNameTxt.Name = "pNameTxt";
            this.pNameTxt.Size = new System.Drawing.Size(136, 20);
            this.pNameTxt.TabIndex = 0;
            // 
            // pNameLabel
            // 
            this.pNameLabel.AutoSize = true;
            this.pNameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.pNameLabel.Location = new System.Drawing.Point(29, 89);
            this.pNameLabel.Name = "pNameLabel";
            this.pNameLabel.Size = new System.Drawing.Size(102, 19);
            this.pNameLabel.TabIndex = 105;
            this.pNameLabel.Text = "Project Name";
            // 
            // descPanel
            // 
            this.descPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.descPanel.Controls.Add(this.descTxt);
            this.descPanel.Location = new System.Drawing.Point(33, 173);
            this.descPanel.Name = "descPanel";
            this.descPanel.Size = new System.Drawing.Size(320, 65);
            this.descPanel.TabIndex = 106;
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
            this.descTxt.Size = new System.Drawing.Size(296, 53);
            this.descTxt.TabIndex = 0;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.descLabel.Location = new System.Drawing.Point(29, 152);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(85, 19);
            this.descLabel.TabIndex = 107;
            this.descLabel.Text = "Description";
            // 
            // ptypePanel
            // 
            this.ptypePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ptypePanel.Controls.Add(this.ptypeCmb);
            this.ptypePanel.Location = new System.Drawing.Point(206, 111);
            this.ptypePanel.Name = "ptypePanel";
            this.ptypePanel.Size = new System.Drawing.Size(147, 33);
            this.ptypePanel.TabIndex = 108;
            // 
            // ptypeCmb
            // 
            this.ptypeCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ptypeCmb.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptypeCmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptypeCmb.FormattingEnabled = true;
            this.ptypeCmb.Location = new System.Drawing.Point(5, 3);
            this.ptypeCmb.Name = "ptypeCmb";
            this.ptypeCmb.Size = new System.Drawing.Size(137, 27);
            this.ptypeCmb.TabIndex = 0;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 331);
            this.Controls.Add(this.ptypePanel);
            this.Controls.Add(this.descPanel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.addProjectBtn);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.pTypeLabel);
            this.Controls.Add(this.headerBottomPanel);
            this.Controls.Add(this.pNamePanel);
            this.Controls.Add(this.pNameLabel);
            this.Controls.Add(this.headerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectFormErrProvider)).EndInit();
            this.pNamePanel.ResumeLayout(false);
            this.pNamePanel.PerformLayout();
            this.descPanel.ResumeLayout(false);
            this.descPanel.PerformLayout();
            this.ptypePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProjectBtn;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.ErrorProvider projectFormErrProvider;
        private System.Windows.Forms.Label pTypeLabel;
        private System.Windows.Forms.Panel headerBottomPanel;
        private System.Windows.Forms.Panel pNamePanel;
        private System.Windows.Forms.TextBox pNameTxt;
        private System.Windows.Forms.Label pNameLabel;
        private System.Windows.Forms.Panel descPanel;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Panel ptypePanel;
        private System.Windows.Forms.ComboBox ptypeCmb;
    }
}