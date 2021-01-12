namespace BugTracker.Views
{
    partial class BugView
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
            this.searchBoxTxt = new System.Windows.Forms.TextBox();
            this.searchBoxPanel = new System.Windows.Forms.Panel();
            this.closeSearchBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.projectDesc = new System.Windows.Forms.TextBox();
            this.projectDescPanel = new System.Windows.Forms.Panel();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.descPanel = new System.Windows.Forms.Panel();
            this.authorName = new System.Windows.Forms.Label();
            this.linesDesc = new System.Windows.Forms.Label();
            this.projectType = new System.Windows.Forms.Label();
            this.bugTitle = new System.Windows.Forms.Label();
            this.sourceCodePanel = new System.Windows.Forms.Panel();
            this.linesDescLabel = new System.Windows.Forms.Label();
            this.cnameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pdescLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.ptypeLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.viewFixes = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.bugFormErrProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.headerBottomPanel = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.addFix = new System.Windows.Forms.Button();
            this.pname = new System.Windows.Forms.Label();
            this.pnameLabel = new System.Windows.Forms.Label();
            this.delBugBtn = new System.Windows.Forms.Button();
            this.editBugBtn = new System.Windows.Forms.Button();
            this.cnamePanel = new System.Windows.Forms.Panel();
            this.className = new System.Windows.Forms.TextBox();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBoxPanel.SuspendLayout();
            this.projectDescPanel.SuspendLayout();
            this.descPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugFormErrProvider)).BeginInit();
            this.cnamePanel.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.searchBoxPanel.Location = new System.Drawing.Point(792, 35);
            this.searchBoxPanel.Name = "searchBoxPanel";
            this.searchBoxPanel.Size = new System.Drawing.Size(223, 41);
            this.searchBoxPanel.TabIndex = 98;
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
            // projectDesc
            // 
            this.projectDesc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.projectDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectDesc.Font = new System.Drawing.Font("Calibri Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.projectDesc.Location = new System.Drawing.Point(5, 6);
            this.projectDesc.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.projectDesc.Multiline = true;
            this.projectDesc.Name = "projectDesc";
            this.projectDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.projectDesc.Size = new System.Drawing.Size(203, 53);
            this.projectDesc.TabIndex = 0;
            // 
            // projectDescPanel
            // 
            this.projectDescPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.projectDescPanel.Controls.Add(this.projectDesc);
            this.projectDescPanel.Location = new System.Drawing.Point(26, 313);
            this.projectDescPanel.Name = "projectDescPanel";
            this.projectDescPanel.Size = new System.Drawing.Size(213, 65);
            this.projectDescPanel.TabIndex = 117;
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
            // descPanel
            // 
            this.descPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.descPanel.Controls.Add(this.descTxt);
            this.descPanel.Location = new System.Drawing.Point(26, 155);
            this.descPanel.Name = "descPanel";
            this.descPanel.Size = new System.Drawing.Size(213, 65);
            this.descPanel.TabIndex = 116;
            // 
            // authorName
            // 
            this.authorName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.authorName.Font = new System.Drawing.Font("Calibri", 11F);
            this.authorName.Location = new System.Drawing.Point(21, 535);
            this.authorName.Name = "authorName";
            this.authorName.Padding = new System.Windows.Forms.Padding(5);
            this.authorName.Size = new System.Drawing.Size(218, 56);
            this.authorName.TabIndex = 115;
            this.authorName.Text = "full name at datetime";
            // 
            // linesDesc
            // 
            this.linesDesc.AutoSize = true;
            this.linesDesc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.linesDesc.Font = new System.Drawing.Font("Calibri", 11F);
            this.linesDesc.Location = new System.Drawing.Point(162, 409);
            this.linesDesc.Name = "linesDesc";
            this.linesDesc.Padding = new System.Windows.Forms.Padding(5);
            this.linesDesc.Size = new System.Drawing.Size(51, 28);
            this.linesDesc.TabIndex = 114;
            this.linesDesc.Text = "1 to 5";
            // 
            // projectType
            // 
            this.projectType.AutoSize = true;
            this.projectType.BackColor = System.Drawing.SystemColors.ControlLight;
            this.projectType.Font = new System.Drawing.Font("Calibri", 11F);
            this.projectType.Location = new System.Drawing.Point(23, 410);
            this.projectType.Name = "projectType";
            this.projectType.Padding = new System.Windows.Forms.Padding(5);
            this.projectType.Size = new System.Drawing.Size(90, 28);
            this.projectType.TabIndex = 112;
            this.projectType.Text = "projecttype";
            // 
            // bugTitle
            // 
            this.bugTitle.AutoSize = true;
            this.bugTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bugTitle.Font = new System.Drawing.Font("Calibri", 11F);
            this.bugTitle.Location = new System.Drawing.Point(23, 98);
            this.bugTitle.Name = "bugTitle";
            this.bugTitle.Padding = new System.Windows.Forms.Padding(5);
            this.bugTitle.Size = new System.Drawing.Size(69, 28);
            this.bugTitle.TabIndex = 111;
            this.bugTitle.Text = "bug title";
            // 
            // sourceCodePanel
            // 
            this.sourceCodePanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sourceCodePanel.Location = new System.Drawing.Point(262, 76);
            this.sourceCodePanel.Name = "sourceCodePanel";
            this.sourceCodePanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.sourceCodePanel.Size = new System.Drawing.Size(752, 470);
            this.sourceCodePanel.TabIndex = 99;
            // 
            // linesDescLabel
            // 
            this.linesDescLabel.AutoSize = true;
            this.linesDescLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linesDescLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.linesDescLabel.Location = new System.Drawing.Point(161, 388);
            this.linesDescLabel.Name = "linesDescLabel";
            this.linesDescLabel.Size = new System.Drawing.Size(41, 19);
            this.linesDescLabel.TabIndex = 106;
            this.linesDescLabel.Text = "Lines";
            // 
            // cnameLabel
            // 
            this.cnameLabel.AutoSize = true;
            this.cnameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.cnameLabel.Location = new System.Drawing.Point(22, 447);
            this.cnameLabel.Name = "cnameLabel";
            this.cnameLabel.Size = new System.Drawing.Size(89, 19);
            this.cnameLabel.TabIndex = 104;
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
            this.titleLabel.TabIndex = 103;
            this.titleLabel.Text = "Title";
            // 
            // pdescLabel
            // 
            this.pdescLabel.AutoSize = true;
            this.pdescLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdescLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.pdescLabel.Location = new System.Drawing.Point(20, 290);
            this.pdescLabel.Name = "pdescLabel";
            this.pdescLabel.Size = new System.Drawing.Size(136, 19);
            this.pdescLabel.TabIndex = 102;
            this.pdescLabel.Text = "Project Description";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.descLabel.Location = new System.Drawing.Point(22, 133);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(85, 19);
            this.descLabel.TabIndex = 101;
            this.descLabel.Text = "Description";
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorNameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.authorNameLabel.Location = new System.Drawing.Point(22, 512);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(94, 19);
            this.authorNameLabel.TabIndex = 107;
            this.authorNameLabel.Text = "Reported By";
            // 
            // ptypeLabel
            // 
            this.ptypeLabel.AutoSize = true;
            this.ptypeLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptypeLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ptypeLabel.Location = new System.Drawing.Point(22, 388);
            this.ptypeLabel.Name = "ptypeLabel";
            this.ptypeLabel.Size = new System.Drawing.Size(92, 19);
            this.ptypeLabel.TabIndex = 105;
            this.ptypeLabel.Text = "Project Type";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerLabel.Location = new System.Drawing.Point(26, 7);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(155, 35);
            this.headerLabel.TabIndex = 53;
            this.headerLabel.Text = "Bug Details";
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Silver;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 604);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1026, 27);
            this.footerPanel.TabIndex = 109;
            // 
            // viewFixes
            // 
            this.viewFixes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.viewFixes.FlatAppearance.BorderSize = 0;
            this.viewFixes.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFixes.ForeColor = System.Drawing.Color.White;
            this.viewFixes.Location = new System.Drawing.Point(257, 3);
            this.viewFixes.Name = "viewFixes";
            this.viewFixes.Size = new System.Drawing.Size(121, 33);
            this.viewFixes.TabIndex = 100;
            this.viewFixes.Text = "View Fixes";
            this.viewFixes.UseVisualStyleBackColor = false;
            this.viewFixes.Click += new System.EventHandler(this.viewFixes_Click);
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
            this.headerPanel.TabIndex = 108;
            // 
            // bugFormErrProvider
            // 
            this.bugFormErrProvider.ContainerControl = this;
            // 
            // headerBottomPanel
            // 
            this.headerBottomPanel.BackColor = System.Drawing.Color.LightGray;
            this.headerBottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBottomPanel.Location = new System.Drawing.Point(0, 53);
            this.headerBottomPanel.Name = "headerBottomPanel";
            this.headerBottomPanel.Size = new System.Drawing.Size(1026, 13);
            this.headerBottomPanel.TabIndex = 110;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.statusLabel.Location = new System.Drawing.Point(161, 448);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 19);
            this.statusLabel.TabIndex = 106;
            this.statusLabel.Text = "Status";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.SystemColors.ControlLight;
            this.status.Font = new System.Drawing.Font("Calibri", 11F);
            this.status.Location = new System.Drawing.Point(162, 470);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(5);
            this.status.Size = new System.Drawing.Size(49, 28);
            this.status.TabIndex = 114;
            this.status.Text = "fixed";
            // 
            // addFix
            // 
            this.addFix.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addFix.FlatAppearance.BorderSize = 0;
            this.addFix.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFix.ForeColor = System.Drawing.Color.White;
            this.addFix.Location = new System.Drawing.Point(384, 3);
            this.addFix.Name = "addFix";
            this.addFix.Size = new System.Drawing.Size(121, 33);
            this.addFix.TabIndex = 100;
            this.addFix.Text = "Add Fix";
            this.addFix.UseVisualStyleBackColor = false;
            this.addFix.Click += new System.EventHandler(this.addFix_Click);
            // 
            // pname
            // 
            this.pname.AutoSize = true;
            this.pname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pname.Font = new System.Drawing.Font("Calibri", 11F);
            this.pname.Location = new System.Drawing.Point(23, 252);
            this.pname.Name = "pname";
            this.pname.Padding = new System.Windows.Forms.Padding(5);
            this.pname.Size = new System.Drawing.Size(97, 28);
            this.pname.TabIndex = 119;
            this.pname.Text = "projectname";
            // 
            // pnameLabel
            // 
            this.pnameLabel.AutoSize = true;
            this.pnameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.pnameLabel.Location = new System.Drawing.Point(22, 229);
            this.pnameLabel.Name = "pnameLabel";
            this.pnameLabel.Size = new System.Drawing.Size(102, 19);
            this.pnameLabel.TabIndex = 118;
            this.pnameLabel.Text = "Project Name";
            // 
            // delBugBtn
            // 
            this.delBugBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.delBugBtn.FlatAppearance.BorderSize = 0;
            this.delBugBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBugBtn.ForeColor = System.Drawing.Color.White;
            this.delBugBtn.Location = new System.Drawing.Point(130, 3);
            this.delBugBtn.Name = "delBugBtn";
            this.delBugBtn.Size = new System.Drawing.Size(121, 33);
            this.delBugBtn.TabIndex = 120;
            this.delBugBtn.Text = "Delete";
            this.delBugBtn.UseVisualStyleBackColor = false;
            this.delBugBtn.Visible = false;
            this.delBugBtn.Click += new System.EventHandler(this.delBugBtn_Click);
            // 
            // editBugBtn
            // 
            this.editBugBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.editBugBtn.FlatAppearance.BorderSize = 0;
            this.editBugBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBugBtn.ForeColor = System.Drawing.Color.White;
            this.editBugBtn.Location = new System.Drawing.Point(3, 3);
            this.editBugBtn.Name = "editBugBtn";
            this.editBugBtn.Size = new System.Drawing.Size(121, 33);
            this.editBugBtn.TabIndex = 121;
            this.editBugBtn.Text = "Edit";
            this.editBugBtn.UseVisualStyleBackColor = false;
            this.editBugBtn.Visible = false;
            this.editBugBtn.Click += new System.EventHandler(this.editBugBtn_Click);
            // 
            // cnamePanel
            // 
            this.cnamePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cnamePanel.Controls.Add(this.className);
            this.cnamePanel.Location = new System.Drawing.Point(26, 469);
            this.cnamePanel.Name = "cnamePanel";
            this.cnamePanel.Size = new System.Drawing.Size(125, 33);
            this.cnamePanel.TabIndex = 125;
            // 
            // className
            // 
            this.className.BackColor = System.Drawing.SystemColors.ControlLight;
            this.className.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.className.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.className.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.className.Location = new System.Drawing.Point(5, 6);
            this.className.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(114, 20);
            this.className.TabIndex = 0;
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.panel1);
            this.actionsPanel.Location = new System.Drawing.Point(498, 552);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(517, 46);
            this.actionsPanel.TabIndex = 126;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viewFixes);
            this.panel1.Controls.Add(this.editBugBtn);
            this.panel1.Controls.Add(this.delBugBtn);
            this.panel1.Controls.Add(this.addFix);
            this.panel1.Location = new System.Drawing.Point(11, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 40);
            this.panel1.TabIndex = 127;
            // 
            // BugView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 631);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.cnamePanel);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.pnameLabel);
            this.Controls.Add(this.searchBoxPanel);
            this.Controls.Add(this.projectDescPanel);
            this.Controls.Add(this.descPanel);
            this.Controls.Add(this.authorName);
            this.Controls.Add(this.status);
            this.Controls.Add(this.linesDesc);
            this.Controls.Add(this.projectType);
            this.Controls.Add(this.bugTitle);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.sourceCodePanel);
            this.Controls.Add(this.linesDescLabel);
            this.Controls.Add(this.cnameLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pdescLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.authorNameLabel);
            this.Controls.Add(this.ptypeLabel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.headerBottomPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "BugView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker";
            this.Resize += new System.EventHandler(this.BugView_Resize);
            this.searchBoxPanel.ResumeLayout(false);
            this.searchBoxPanel.PerformLayout();
            this.projectDescPanel.ResumeLayout(false);
            this.projectDescPanel.PerformLayout();
            this.descPanel.ResumeLayout(false);
            this.descPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugFormErrProvider)).EndInit();
            this.cnamePanel.ResumeLayout(false);
            this.cnamePanel.PerformLayout();
            this.actionsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeSearchBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TextBox searchBoxTxt;
        private System.Windows.Forms.Panel searchBoxPanel;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.TextBox projectDesc;
        private System.Windows.Forms.Panel projectDescPanel;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.Panel descPanel;
        private System.Windows.Forms.Label authorName;
        private System.Windows.Forms.Label linesDesc;
        private System.Windows.Forms.Label projectType;
        private System.Windows.Forms.Label bugTitle;
        private System.Windows.Forms.Panel sourceCodePanel;
        private System.Windows.Forms.Label linesDescLabel;
        private System.Windows.Forms.Label cnameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label pdescLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label authorNameLabel;
        private System.Windows.Forms.Label ptypeLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button viewFixes;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.ErrorProvider bugFormErrProvider;
        private System.Windows.Forms.Panel headerBottomPanel;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button addFix;
        private System.Windows.Forms.Label pname;
        private System.Windows.Forms.Label pnameLabel;
        private System.Windows.Forms.Button delBugBtn;
        private System.Windows.Forms.Button editBugBtn;
        private System.Windows.Forms.Panel cnamePanel;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.Panel panel1;
    }
}