namespace BugTracker.Views
{
    partial class PasswordChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChangeForm));
            this.updatePassword = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.passFormErrProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.headerBottomPanel = new System.Windows.Forms.Panel();
            this.confirmPassLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.confirmNewPassPanel = new System.Windows.Forms.Panel();
            this.confirmNewPassTxt = new System.Windows.Forms.TextBox();
            this.newPassPanel = new System.Windows.Forms.Panel();
            this.newPassTxt = new System.Windows.Forms.TextBox();
            this.currPassPanel = new System.Windows.Forms.Panel();
            this.currPassTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.relatedUserPanel = new System.Windows.Forms.Panel();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.uNameLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passFormErrProvider)).BeginInit();
            this.confirmNewPassPanel.SuspendLayout();
            this.newPassPanel.SuspendLayout();
            this.currPassPanel.SuspendLayout();
            this.relatedUserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // updatePassword
            // 
            this.updatePassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.updatePassword.FlatAppearance.BorderSize = 0;
            this.updatePassword.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePassword.ForeColor = System.Drawing.Color.White;
            this.updatePassword.Location = new System.Drawing.Point(32, 285);
            this.updatePassword.Name = "updatePassword";
            this.updatePassword.Size = new System.Drawing.Size(190, 33);
            this.updatePassword.TabIndex = 82;
            this.updatePassword.Text = "Change Password";
            this.updatePassword.UseVisualStyleBackColor = false;
            this.updatePassword.Click += new System.EventHandler(this.updatePassword_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerLabel.Location = new System.Drawing.Point(26, 7);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(233, 35);
            this.headerLabel.TabIndex = 53;
            this.headerLabel.Text = "Change Password";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Gray;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.CadetBlue;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(354, 53);
            this.headerPanel.TabIndex = 89;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Silver;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 334);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(354, 27);
            this.footerPanel.TabIndex = 90;
            // 
            // passFormErrProvider
            // 
            this.passFormErrProvider.ContainerControl = this;
            // 
            // headerBottomPanel
            // 
            this.headerBottomPanel.BackColor = System.Drawing.Color.LightGray;
            this.headerBottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBottomPanel.Location = new System.Drawing.Point(0, 53);
            this.headerBottomPanel.Name = "headerBottomPanel";
            this.headerBottomPanel.Size = new System.Drawing.Size(354, 13);
            this.headerBottomPanel.TabIndex = 91;
            // 
            // confirmPassLabel
            // 
            this.confirmPassLabel.AutoSize = true;
            this.confirmPassLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.confirmPassLabel.Location = new System.Drawing.Point(28, 214);
            this.confirmPassLabel.Name = "confirmPassLabel";
            this.confirmPassLabel.Size = new System.Drawing.Size(164, 19);
            this.confirmPassLabel.TabIndex = 94;
            this.confirmPassLabel.Text = "Confirm New Password";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.passLabel.Location = new System.Drawing.Point(28, 150);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(107, 19);
            this.passLabel.TabIndex = 95;
            this.passLabel.Text = "New Password";
            // 
            // confirmNewPassPanel
            // 
            this.confirmNewPassPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.confirmNewPassPanel.Controls.Add(this.confirmNewPassTxt);
            this.confirmNewPassPanel.Location = new System.Drawing.Point(32, 236);
            this.confirmNewPassPanel.Name = "confirmNewPassPanel";
            this.confirmNewPassPanel.Size = new System.Drawing.Size(190, 33);
            this.confirmNewPassPanel.TabIndex = 93;
            // 
            // confirmNewPassTxt
            // 
            this.confirmNewPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmNewPassTxt.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmNewPassTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirmNewPassTxt.Location = new System.Drawing.Point(5, 6);
            this.confirmNewPassTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.confirmNewPassTxt.Name = "confirmNewPassTxt";
            this.confirmNewPassTxt.PasswordChar = '*';
            this.confirmNewPassTxt.Size = new System.Drawing.Size(167, 20);
            this.confirmNewPassTxt.TabIndex = 0;
            // 
            // newPassPanel
            // 
            this.newPassPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.newPassPanel.Controls.Add(this.newPassTxt);
            this.newPassPanel.Location = new System.Drawing.Point(32, 172);
            this.newPassPanel.Name = "newPassPanel";
            this.newPassPanel.Size = new System.Drawing.Size(190, 33);
            this.newPassPanel.TabIndex = 92;
            // 
            // newPassTxt
            // 
            this.newPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPassTxt.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPassTxt.Location = new System.Drawing.Point(5, 6);
            this.newPassTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.newPassTxt.Name = "newPassTxt";
            this.newPassTxt.PasswordChar = '*';
            this.newPassTxt.Size = new System.Drawing.Size(167, 20);
            this.newPassTxt.TabIndex = 0;
            // 
            // currPassPanel
            // 
            this.currPassPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.currPassPanel.Controls.Add(this.currPassTxt);
            this.currPassPanel.Location = new System.Drawing.Point(32, 110);
            this.currPassPanel.Name = "currPassPanel";
            this.currPassPanel.Size = new System.Drawing.Size(190, 33);
            this.currPassPanel.TabIndex = 92;
            // 
            // currPassTxt
            // 
            this.currPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currPassTxt.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currPassTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currPassTxt.Location = new System.Drawing.Point(5, 6);
            this.currPassTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.currPassTxt.Name = "currPassTxt";
            this.currPassTxt.PasswordChar = '*';
            this.currPassTxt.Size = new System.Drawing.Size(167, 20);
            this.currPassTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(28, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 95;
            this.label1.Text = "Current Password";
            // 
            // relatedUserPanel
            // 
            this.relatedUserPanel.Controls.Add(this.fullNameLabel);
            this.relatedUserPanel.Controls.Add(this.uNameLabel);
            this.relatedUserPanel.Location = new System.Drawing.Point(32, 86);
            this.relatedUserPanel.Name = "relatedUserPanel";
            this.relatedUserPanel.Size = new System.Drawing.Size(190, 60);
            this.relatedUserPanel.TabIndex = 96;
            this.relatedUserPanel.Visible = false;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fullNameLabel.Font = new System.Drawing.Font("Calibri", 11F);
            this.fullNameLabel.Location = new System.Drawing.Point(2, 27);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Padding = new System.Windows.Forms.Padding(5);
            this.fullNameLabel.Size = new System.Drawing.Size(67, 28);
            this.fullNameLabel.TabIndex = 113;
            this.fullNameLabel.Text = "but title";
            // 
            // uNameLabel
            // 
            this.uNameLabel.AutoSize = true;
            this.uNameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uNameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.uNameLabel.Location = new System.Drawing.Point(1, 5);
            this.uNameLabel.Name = "uNameLabel";
            this.uNameLabel.Size = new System.Drawing.Size(36, 19);
            this.uNameLabel.TabIndex = 112;
            this.uNameLabel.Text = "User";
            // 
            // PasswordChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 361);
            this.Controls.Add(this.relatedUserPanel);
            this.Controls.Add(this.confirmPassLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.confirmNewPassPanel);
            this.Controls.Add(this.currPassPanel);
            this.Controls.Add(this.newPassPanel);
            this.Controls.Add(this.updatePassword);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.headerBottomPanel);
            this.Controls.Add(this.headerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker";
            this.Load += new System.EventHandler(this.PasswordChangeForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passFormErrProvider)).EndInit();
            this.confirmNewPassPanel.ResumeLayout(false);
            this.confirmNewPassPanel.PerformLayout();
            this.newPassPanel.ResumeLayout(false);
            this.newPassPanel.PerformLayout();
            this.currPassPanel.ResumeLayout(false);
            this.currPassPanel.PerformLayout();
            this.relatedUserPanel.ResumeLayout(false);
            this.relatedUserPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button updatePassword;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.ErrorProvider passFormErrProvider;
        private System.Windows.Forms.Panel headerBottomPanel;
        private System.Windows.Forms.Label confirmPassLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Panel confirmNewPassPanel;
        private System.Windows.Forms.TextBox confirmNewPassTxt;
        private System.Windows.Forms.Panel newPassPanel;
        private System.Windows.Forms.TextBox newPassTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel currPassPanel;
        private System.Windows.Forms.TextBox currPassTxt;
        private System.Windows.Forms.Panel relatedUserPanel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label uNameLabel;
    }
}