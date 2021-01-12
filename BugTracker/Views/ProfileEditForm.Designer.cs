namespace BugTracker.Views
{
    partial class ProfileEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileEditForm));
            this.headerBottomPanel = new System.Windows.Forms.Panel();
            this.profileEditErrProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.genderFemale = new System.Windows.Forms.RadioButton();
            this.genderMale = new System.Windows.Forms.RadioButton();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.unameTxt = new System.Windows.Forms.TextBox();
            this.unamePanel = new System.Windows.Forms.Panel();
            this.lnameTxt = new System.Windows.Forms.TextBox();
            this.lnamePanel = new System.Windows.Forms.Panel();
            this.fnameTxt = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.fnamePanel = new System.Windows.Forms.Panel();
            this.unameLabel = new System.Windows.Forms.Label();
            this.utypeLabel = new System.Windows.Forms.Label();
            this.profileUpdateBtn = new System.Windows.Forms.Button();
            this.utypeCmb = new System.Windows.Forms.ComboBox();
            this.utypePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.profileEditErrProvider)).BeginInit();
            this.emailPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.unamePanel.SuspendLayout();
            this.lnamePanel.SuspendLayout();
            this.fnamePanel.SuspendLayout();
            this.utypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerBottomPanel
            // 
            this.headerBottomPanel.BackColor = System.Drawing.Color.LightGray;
            this.headerBottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBottomPanel.Location = new System.Drawing.Point(0, 53);
            this.headerBottomPanel.Name = "headerBottomPanel";
            this.headerBottomPanel.Size = new System.Drawing.Size(585, 13);
            this.headerBottomPanel.TabIndex = 74;
            // 
            // profileEditErrProvider
            // 
            this.profileEditErrProvider.ContainerControl = this;
            // 
            // genderFemale
            // 
            this.genderFemale.AutoSize = true;
            this.genderFemale.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderFemale.Location = new System.Drawing.Point(331, 105);
            this.genderFemale.Name = "genderFemale";
            this.genderFemale.Size = new System.Drawing.Size(67, 21);
            this.genderFemale.TabIndex = 58;
            this.genderFemale.Text = "Female";
            this.genderFemale.UseVisualStyleBackColor = true;
            // 
            // genderMale
            // 
            this.genderMale.AutoSize = true;
            this.genderMale.Checked = true;
            this.genderMale.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderMale.Location = new System.Drawing.Point(265, 105);
            this.genderMale.Name = "genderMale";
            this.genderMale.Size = new System.Drawing.Size(55, 21);
            this.genderMale.TabIndex = 57;
            this.genderMale.TabStop = true;
            this.genderMale.Text = "Male";
            this.genderMale.UseVisualStyleBackColor = true;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Silver;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 335);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(585, 27);
            this.footerPanel.TabIndex = 73;
            // 
            // emailTxt
            // 
            this.emailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTxt.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTxt.Location = new System.Drawing.Point(5, 6);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(194, 20);
            this.emailTxt.TabIndex = 0;
            // 
            // emailPanel
            // 
            this.emailPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.emailPanel.Controls.Add(this.emailTxt);
            this.emailPanel.Location = new System.Drawing.Point(26, 231);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(217, 33);
            this.emailPanel.TabIndex = 56;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Gray;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.CadetBlue;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(585, 53);
            this.headerPanel.TabIndex = 72;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerLabel.Location = new System.Drawing.Point(26, 7);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(158, 35);
            this.headerLabel.TabIndex = 53;
            this.headerLabel.Text = "Edit Profile";
            // 
            // unameTxt
            // 
            this.unameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unameTxt.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.unameTxt.Location = new System.Drawing.Point(5, 6);
            this.unameTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.unameTxt.Name = "unameTxt";
            this.unameTxt.Size = new System.Drawing.Size(167, 20);
            this.unameTxt.TabIndex = 0;
            // 
            // unamePanel
            // 
            this.unamePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.unamePanel.Controls.Add(this.unameTxt);
            this.unamePanel.Location = new System.Drawing.Point(265, 164);
            this.unamePanel.Name = "unamePanel";
            this.unamePanel.Size = new System.Drawing.Size(190, 33);
            this.unamePanel.TabIndex = 59;
            // 
            // lnameTxt
            // 
            this.lnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameTxt.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnameTxt.Location = new System.Drawing.Point(5, 6);
            this.lnameTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.lnameTxt.Name = "lnameTxt";
            this.lnameTxt.Size = new System.Drawing.Size(167, 20);
            this.lnameTxt.TabIndex = 0;
            // 
            // lnamePanel
            // 
            this.lnamePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lnamePanel.Controls.Add(this.lnameTxt);
            this.lnamePanel.Location = new System.Drawing.Point(26, 164);
            this.lnamePanel.Name = "lnamePanel";
            this.lnamePanel.Size = new System.Drawing.Size(190, 33);
            this.lnamePanel.TabIndex = 55;
            // 
            // fnameTxt
            // 
            this.fnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameTxt.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fnameTxt.Location = new System.Drawing.Point(5, 6);
            this.fnameTxt.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.fnameTxt.Name = "fnameTxt";
            this.fnameTxt.Size = new System.Drawing.Size(167, 20);
            this.fnameTxt.TabIndex = 0;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.emailLabel.Location = new System.Drawing.Point(22, 209);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 19);
            this.emailLabel.TabIndex = 71;
            this.emailLabel.Text = "Email";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.genderLabel.Location = new System.Drawing.Point(261, 75);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(62, 19);
            this.genderLabel.TabIndex = 70;
            this.genderLabel.Text = "Gender";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.lnameLabel.Location = new System.Drawing.Point(22, 142);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(81, 19);
            this.lnameLabel.TabIndex = 68;
            this.lnameLabel.Text = "Last Name";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.fNameLabel.Location = new System.Drawing.Point(22, 75);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(79, 19);
            this.fNameLabel.TabIndex = 67;
            this.fNameLabel.Text = "First Name";
            // 
            // fnamePanel
            // 
            this.fnamePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.fnamePanel.Controls.Add(this.fnameTxt);
            this.fnamePanel.Location = new System.Drawing.Point(26, 97);
            this.fnamePanel.Name = "fnamePanel";
            this.fnamePanel.Size = new System.Drawing.Size(190, 33);
            this.fnamePanel.TabIndex = 54;
            // 
            // unameLabel
            // 
            this.unameLabel.AutoSize = true;
            this.unameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.unameLabel.Location = new System.Drawing.Point(261, 139);
            this.unameLabel.Name = "unameLabel";
            this.unameLabel.Size = new System.Drawing.Size(77, 19);
            this.unameLabel.TabIndex = 64;
            this.unameLabel.Text = "Username";
            // 
            // utypeLabel
            // 
            this.utypeLabel.AutoSize = true;
            this.utypeLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utypeLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.utypeLabel.Location = new System.Drawing.Point(261, 209);
            this.utypeLabel.Name = "utypeLabel";
            this.utypeLabel.Size = new System.Drawing.Size(72, 19);
            this.utypeLabel.TabIndex = 69;
            this.utypeLabel.Text = "User Type";
            // 
            // profileUpdateBtn
            // 
            this.profileUpdateBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.profileUpdateBtn.FlatAppearance.BorderSize = 0;
            this.profileUpdateBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.profileUpdateBtn.Location = new System.Drawing.Point(334, 284);
            this.profileUpdateBtn.Name = "profileUpdateBtn";
            this.profileUpdateBtn.Size = new System.Drawing.Size(121, 33);
            this.profileUpdateBtn.TabIndex = 63;
            this.profileUpdateBtn.Text = "Update Profile";
            this.profileUpdateBtn.UseVisualStyleBackColor = false;
            this.profileUpdateBtn.Click += new System.EventHandler(this.profileUpdateBtn_Click);
            // 
            // utypeCmb
            // 
            this.utypeCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.utypeCmb.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utypeCmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.utypeCmb.FormattingEnabled = true;
            this.utypeCmb.Location = new System.Drawing.Point(5, 3);
            this.utypeCmb.Name = "utypeCmb";
            this.utypeCmb.Size = new System.Drawing.Size(182, 27);
            this.utypeCmb.TabIndex = 0;
            // 
            // utypePanel
            // 
            this.utypePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.utypePanel.Controls.Add(this.utypeCmb);
            this.utypePanel.Location = new System.Drawing.Point(265, 231);
            this.utypePanel.Name = "utypePanel";
            this.utypePanel.Size = new System.Drawing.Size(190, 33);
            this.utypePanel.TabIndex = 62;
            // 
            // ProfileEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 362);
            this.Controls.Add(this.genderFemale);
            this.Controls.Add(this.genderMale);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.utypePanel);
            this.Controls.Add(this.profileUpdateBtn);
            this.Controls.Add(this.emailPanel);
            this.Controls.Add(this.unamePanel);
            this.Controls.Add(this.lnamePanel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.utypeLabel);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.fnamePanel);
            this.Controls.Add(this.unameLabel);
            this.Controls.Add(this.headerBottomPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProfileEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.profileEditErrProvider)).EndInit();
            this.emailPanel.ResumeLayout(false);
            this.emailPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.unamePanel.ResumeLayout(false);
            this.unamePanel.PerformLayout();
            this.lnamePanel.ResumeLayout(false);
            this.lnamePanel.PerformLayout();
            this.fnamePanel.ResumeLayout(false);
            this.fnamePanel.PerformLayout();
            this.utypePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerBottomPanel;
        private System.Windows.Forms.ErrorProvider profileEditErrProvider;
        private System.Windows.Forms.RadioButton genderFemale;
        private System.Windows.Forms.RadioButton genderMale;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel emailPanel;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel unamePanel;
        private System.Windows.Forms.TextBox unameTxt;
        private System.Windows.Forms.Panel lnamePanel;
        private System.Windows.Forms.TextBox lnameTxt;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Panel fnamePanel;
        private System.Windows.Forms.TextBox fnameTxt;
        private System.Windows.Forms.Label unameLabel;
        private System.Windows.Forms.Panel utypePanel;
        private System.Windows.Forms.ComboBox utypeCmb;
        private System.Windows.Forms.Button profileUpdateBtn;
        private System.Windows.Forms.Label utypeLabel;
    }
}