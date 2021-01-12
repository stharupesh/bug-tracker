using System.Windows.Forms;

namespace BugTracker.Views
{
    partial class HomeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            this.loginBtn = new System.Windows.Forms.Button();
            this.usernamePanel = new System.Windows.Forms.Panel();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.logoTitlePic = new System.Windows.Forms.PictureBox();
            this.miniLogo = new System.Windows.Forms.PictureBox();
            this.registerLabel = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.loginErrProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.loginToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.unameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.usernamePanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoTitlePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginErrProvider)).BeginInit();
            this.registerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(208, 230);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(107, 33);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usernamePanel
            // 
            this.usernamePanel.BackColor = System.Drawing.Color.DarkGray;
            this.usernamePanel.Controls.Add(this.usernameTxt);
            this.usernamePanel.Location = new System.Drawing.Point(146, 128);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.Size = new System.Drawing.Size(169, 31);
            this.usernamePanel.TabIndex = 8;
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.DarkGray;
            this.usernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxt.Font = new System.Drawing.Font("Calibri Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usernameTxt.Location = new System.Drawing.Point(5, 6);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(142, 18);
            this.usernameTxt.TabIndex = 7;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.DarkGray;
            this.passwordPanel.Controls.Add(this.passwordTxt);
            this.passwordPanel.Location = new System.Drawing.Point(146, 177);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(169, 31);
            this.passwordPanel.TabIndex = 8;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.DarkGray;
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxt.Font = new System.Drawing.Font("Calibri Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordTxt.Location = new System.Drawing.Point(5, 6);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(142, 18);
            this.passwordTxt.TabIndex = 8;
            // 
            // logoTitlePic
            // 
            this.logoTitlePic.Image = global::BugTracker.Properties.Resources.logoTitleIcon;
            this.logoTitlePic.Location = new System.Drawing.Point(146, 52);
            this.logoTitlePic.Name = "logoTitlePic";
            this.logoTitlePic.Size = new System.Drawing.Size(177, 45);
            this.logoTitlePic.TabIndex = 34;
            this.logoTitlePic.TabStop = false;
            // 
            // miniLogo
            // 
            this.miniLogo.Image = global::BugTracker.Properties.Resources.mainIconMini;
            this.miniLogo.Location = new System.Drawing.Point(88, 52);
            this.miniLogo.Name = "miniLogo";
            this.miniLogo.Padding = new System.Windows.Forms.Padding(2);
            this.miniLogo.Size = new System.Drawing.Size(47, 45);
            this.miniLogo.TabIndex = 26;
            this.miniLogo.TabStop = false;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.registerLabel.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.Location = new System.Drawing.Point(35, 141);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(74, 23);
            this.registerLabel.TabIndex = 31;
            this.registerLabel.Text = "Register";
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Silver;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 320);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(574, 27);
            this.footerPanel.TabIndex = 34;
            // 
            // loginErrProvider
            // 
            this.loginErrProvider.ContainerControl = this;
            // 
            // loginToolTip
            // 
            this.loginToolTip.AutomaticDelay = 1;
            this.loginToolTip.AutoPopDelay = 5000;
            this.loginToolTip.InitialDelay = 1;
            this.loginToolTip.ReshowDelay = 0;
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.AutoSize = true;
            this.createAccountBtn.BackColor = System.Drawing.SystemColors.Control;
            this.createAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountBtn.FlatAppearance.BorderSize = 0;
            this.createAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.createAccountBtn.Image = global::BugTracker.Properties.Resources.registerIcon;
            this.createAccountBtn.Location = new System.Drawing.Point(3, 0);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Padding = new System.Windows.Forms.Padding(10, 10, 10, 40);
            this.createAccountBtn.Size = new System.Drawing.Size(139, 176);
            this.createAccountBtn.TabIndex = 28;
            this.createAccountBtn.UseVisualStyleBackColor = false;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // unameLabel
            // 
            this.unameLabel.AutoSize = true;
            this.unameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.unameLabel.Location = new System.Drawing.Point(63, 132);
            this.unameLabel.Name = "unameLabel";
            this.unameLabel.Size = new System.Drawing.Size(77, 19);
            this.unameLabel.TabIndex = 68;
            this.unameLabel.Text = "Username";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.passLabel.Location = new System.Drawing.Point(63, 182);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(72, 19);
            this.passLabel.TabIndex = 68;
            this.passLabel.Text = "Password";
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.registerPanel.Controls.Add(this.registerLabel);
            this.registerPanel.Controls.Add(this.createAccountBtn);
            this.registerPanel.Location = new System.Drawing.Point(356, 87);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.registerPanel.Size = new System.Drawing.Size(142, 176);
            this.registerPanel.TabIndex = 69;
            // 
            // HomeView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(574, 347);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.unameLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.usernamePanel);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.logoTitlePic);
            this.Controls.Add(this.miniLogo);
            this.Controls.Add(this.footerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeView_FormClosed);
            this.usernamePanel.ResumeLayout(false);
            this.usernamePanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoTitlePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginErrProvider)).EndInit();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button loginBtn;
        private Panel usernamePanel;
        private TextBox usernameTxt;
        private Panel passwordPanel;
        private TextBox passwordTxt;
        private PictureBox miniLogo;
        private Label registerLabel;
        private Button createAccountBtn;
        private PictureBox logoTitlePic;
        private Panel footerPanel;
        private ErrorProvider loginErrProvider;
        private ToolTip loginToolTip;
        private Label passLabel;
        private Label unameLabel;
        private Panel registerPanel;
    }
}