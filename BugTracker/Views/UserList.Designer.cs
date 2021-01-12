namespace BugTracker.Views
{
    partial class UserList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserList));
            this.headerBottomPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchMiniPic = new System.Windows.Forms.PictureBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.utypePanel = new System.Windows.Forms.Panel();
            this.utypeCmb = new System.Windows.Forms.ComboBox();
            this.userListGrid = new System.Windows.Forms.DataGridView();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.changepass = new System.Windows.Forms.DataGridViewLinkColumn();
            this.delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.projectListToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.footerPanel = new System.Windows.Forms.Panel();
            this.searchActionsPanel = new System.Windows.Forms.Panel();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchMiniPic)).BeginInit();
            this.utypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userListGrid)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.searchActionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerBottomPanel
            // 
            this.headerBottomPanel.BackColor = System.Drawing.Color.LightGray;
            this.headerBottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBottomPanel.Location = new System.Drawing.Point(0, 53);
            this.headerBottomPanel.Name = "headerBottomPanel";
            this.headerBottomPanel.Size = new System.Drawing.Size(1026, 13);
            this.headerBottomPanel.TabIndex = 88;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerLabel.Location = new System.Drawing.Point(26, 7);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(127, 35);
            this.headerLabel.TabIndex = 53;
            this.headerLabel.Text = "User List";
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.searchPanel.Controls.Add(this.searchMiniPic);
            this.searchPanel.Controls.Add(this.searchTxt);
            this.searchPanel.Location = new System.Drawing.Point(229, 6);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(219, 33);
            this.searchPanel.TabIndex = 90;
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
            // utypePanel
            // 
            this.utypePanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.utypePanel.Controls.Add(this.utypeCmb);
            this.utypePanel.Location = new System.Drawing.Point(10, 6);
            this.utypePanel.Name = "utypePanel";
            this.utypePanel.Size = new System.Drawing.Size(213, 33);
            this.utypePanel.TabIndex = 92;
            // 
            // utypeCmb
            // 
            this.utypeCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.utypeCmb.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utypeCmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.utypeCmb.FormattingEnabled = true;
            this.utypeCmb.Location = new System.Drawing.Point(5, 3);
            this.utypeCmb.Name = "utypeCmb";
            this.utypeCmb.Size = new System.Drawing.Size(205, 27);
            this.utypeCmb.TabIndex = 0;
            this.utypeCmb.SelectedIndexChanged += new System.EventHandler(this.utypeCmb_SelectedIndexChanged);
            // 
            // userListGrid
            // 
            this.userListGrid.AllowUserToAddRows = false;
            this.userListGrid.AllowUserToDeleteRows = false;
            this.userListGrid.AllowUserToOrderColumns = true;
            this.userListGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.userListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sn,
            this.userid,
            this.username,
            this.fullname,
            this.usertype,
            this.email,
            this.status,
            this.gender,
            this.action,
            this.changepass,
            this.delete});
            this.userListGrid.Location = new System.Drawing.Point(39, 123);
            this.userListGrid.Name = "userListGrid";
            this.userListGrid.ReadOnly = true;
            this.userListGrid.Size = new System.Drawing.Size(950, 345);
            this.userListGrid.TabIndex = 89;
            this.userListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userListGrid_CellContentClick);
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
            // userid
            // 
            this.userid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userid.DataPropertyName = "user_id";
            this.userid.HeaderText = "User Id";
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Visible = false;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.DataPropertyName = "user_name";
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullname.DataPropertyName = "full_name";
            this.fullname.HeaderText = "Full Name";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // usertype
            // 
            this.usertype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usertype.DataPropertyName = "user_type_name";
            this.usertype.HeaderText = "User Type";
            this.usertype.Name = "usertype";
            this.usertype.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "status";
            this.status.FillWeight = 70F;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.DataPropertyName = "gender_name";
            this.gender.FillWeight = 80F;
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // action
            // 
            this.action.DataPropertyName = "action";
            this.action.HeaderText = "Action";
            this.action.LinkColor = System.Drawing.Color.MediumBlue;
            this.action.Name = "action";
            this.action.ReadOnly = true;
            // 
            // changepass
            // 
            this.changepass.DataPropertyName = "user_id";
            this.changepass.FillWeight = 120F;
            this.changepass.HeaderText = "Change Password";
            this.changepass.LinkColor = System.Drawing.Color.MediumBlue;
            this.changepass.Name = "changepass";
            this.changepass.ReadOnly = true;
            this.changepass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.changepass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.changepass.Text = "Change";
            this.changepass.UseColumnTextForLinkValue = true;
            this.changepass.Width = 120;
            // 
            // delete
            // 
            this.delete.DataPropertyName = "user_id";
            this.delete.HeaderText = "Delete";
            this.delete.LinkColor = System.Drawing.Color.MediumBlue;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForLinkValue = true;
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
            this.headerPanel.TabIndex = 86;
            // 
            // projectListToolTip
            // 
            this.projectListToolTip.AutomaticDelay = 1;
            this.projectListToolTip.AutoPopDelay = 5000;
            this.projectListToolTip.InitialDelay = 1;
            this.projectListToolTip.ReshowDelay = 0;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Silver;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 490);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1026, 27);
            this.footerPanel.TabIndex = 87;
            // 
            // searchActionsPanel
            // 
            this.searchActionsPanel.Controls.Add(this.utypePanel);
            this.searchActionsPanel.Controls.Add(this.searchPanel);
            this.searchActionsPanel.Location = new System.Drawing.Point(542, 72);
            this.searchActionsPanel.Name = "searchActionsPanel";
            this.searchActionsPanel.Size = new System.Drawing.Size(450, 47);
            this.searchActionsPanel.TabIndex = 93;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 517);
            this.Controls.Add(this.searchActionsPanel);
            this.Controls.Add(this.headerBottomPanel);
            this.Controls.Add(this.userListGrid);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.footerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker";
            this.Resize += new System.EventHandler(this.UserList_Resize);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchMiniPic)).EndInit();
            this.utypePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userListGrid)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.searchActionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox searchMiniPic;
        private System.Windows.Forms.Panel headerBottomPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Panel utypePanel;
        private System.Windows.Forms.ComboBox utypeCmb;
        private System.Windows.Forms.DataGridView userListGrid;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.ToolTip projectListToolTip;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel searchActionsPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn usertype;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewLinkColumn action;
        private System.Windows.Forms.DataGridViewLinkColumn changepass;
        private System.Windows.Forms.DataGridViewLinkColumn delete;
    }
}