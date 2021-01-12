using System;
using System.Windows.Forms;
using System.Drawing;
using BugTracker.Services;
using BugTracker.Controllers;

namespace BugTracker.Views
{
    public partial class DashboardView : Form
    {
        private DashboardCtrl dashCtrl = new DashboardCtrl();

        public DashboardView()
        {
            InitializeComponent();

            iniComboBox();
            setUserLabels();
            iniPanels();

            this.MinimumSize = new Size(this.Width - 200, this.Height - 200);
        }

        private void iniComboBox()
        {
            userOptionsCmb.Items.AddRange(new object[] { "My Bugs", "View/Edit Profile", "Change Password", "Logout" });
        }

        private void iniPanels()
        {
            if (!Auth.isAdmin())
            {
                mainPanel.Width = 448;

                usersLabel.Text = "Profile";
                this.usersBtn.Image = global::BugTracker.Properties.Resources.editProfileIcon;
            }
            autosizePanels();
        }

        private void setUserLabels()
        {
            this.currentUsernameLabel.Text = Auth.user("full_name");

            this.userTypeLabel.Text = "( " + Auth.user("user_type_name") + " )";
        }

        private void userOptCaret_Click(object sender, EventArgs e)
        {
            userOptionsCmb.DroppedDown = true;
        }

        private void currentUsernameLabel_Click(object sender, EventArgs e)
        {
            userOptionsCmb.DroppedDown = true;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            if (Auth.isAdmin())
                showUserList();
            else
                showProfileEditForm();
        }

        private void userOptionsCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected = this.userOptionsCmb.SelectedItem.ToString();

            switch (selected)
            {
                case "My Bugs":
                    {
                        showBugsList(Auth.user("full_name"));
                    }
                    break;

                case "View/Edit Profile":
                    {
                        this.showProfileEditForm();
                    }
                    break;

                case "Change Password":
                    {
                        this.showPasswordChangeForm();
                    }
                    break;

                case "Logout":
                    {
                        this.dashCtrl.logoutUser();
                    }
                    break;
            }
        }

        private void DashboardView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.dashCtrl.logoutUser();
        }

        private void reportBugBtn_Click(object sender, EventArgs e)
        {
            showReportBugForm();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            showBugsList("");
        }

        private void projectsBtn_Click(object sender, EventArgs e)
        {
            showProjectList();
        }

        private void quickSearchBtn_Click(object sender, EventArgs e)
        {
            showBugsList(quickSearchTxt.Text);
        }

        private void DashboardView_Resize(object sender, EventArgs e)
        {
            autosizePanels();
        }

        private void autosizePanels()
        {
            containerPanel.Width = this.Width - 16;
            containerPanel.Height = this.Height - 134;

            int xCor = containerPanel.Width / 2 - (mainPanel.Width / 2);
            int yCor = containerPanel.Height / 2 - (mainPanel.Height / 2);

            mainPanel.Location = new Point(xCor, yCor);

            xCor = mainPanel.Width / 2 - searchPanel.Width / 2;
            yCor = mainPanel.Height / 2 + searchPanel.Height;

            searchPanel.Location = new Point(xCor, yCor);
        }

        private Form alreadyOpenedChildForm(Type type)
        {
            foreach (Control form in containerPanel.Controls)
            {
                if (form.GetType() == type)
                {
                    return (Form)form;
                }
            }

            return null;
        }


        private void showUserList()
        {
            UserList userList = (UserList)this.alreadyOpenedChildForm(typeof(UserList));

            if (userList != null)
            {
                userList.WindowState = FormWindowState.Normal;

                return;
            }

            userList = new UserList();

            userList.TopLevel = false;

            containerPanel.Controls.Add(userList);
            userList.Show();

            userList.BringToFront();
        }

        private void showProfileEditForm()
        {
            ProfileEditForm profileEditForm = (ProfileEditForm)this.alreadyOpenedChildForm(typeof(ProfileEditForm));

            if (profileEditForm != null)
            {
                profileEditForm.WindowState = FormWindowState.Normal;

                return;
            }

            profileEditForm = new ProfileEditForm(int.Parse(Auth.user("id")), true);

            profileEditForm.TopLevel = false;

            containerPanel.Controls.Add(profileEditForm);
            profileEditForm.Show();

            profileEditForm.BringToFront();
        }

        private void showPasswordChangeForm()
        {
            PasswordChangeForm passChangeForm = (PasswordChangeForm)this.alreadyOpenedChildForm(typeof(PasswordChangeForm));

            if (passChangeForm != null)
            {
                passChangeForm.WindowState = FormWindowState.Normal;

                return;
            }

            passChangeForm = new PasswordChangeForm(int.Parse(Auth.user("id")));

            passChangeForm.TopLevel = false;

            containerPanel.Controls.Add(passChangeForm);
            passChangeForm.Show();

            passChangeForm.BringToFront();
        }

        private void showReportBugForm()
        {
            ReportBugForm reportBugForm = (ReportBugForm)this.alreadyOpenedChildForm(typeof(ReportBugForm));

            if (reportBugForm != null)
            {
                reportBugForm.WindowState = FormWindowState.Normal;

                return;
            }

            reportBugForm = new ReportBugForm();

            reportBugForm.TopLevel = false;

            containerPanel.Controls.Add(reportBugForm);
            reportBugForm.Show();

            reportBugForm.BringToFront();
        }

        private void showBugsList(string search)
        {
            BugList bugList = (BugList)this.alreadyOpenedChildForm(typeof(BugList));

            if (bugList != null)
            {
                bugList.WindowState = FormWindowState.Normal;

                return;
            }

            bugList = new BugList();

            bugList.TopLevel = false;

            bugList.setSearch(search).loadBugs();

            containerPanel.Controls.Add(bugList);
            bugList.Show();

            bugList.BringToFront();
        }

        private void showProjectList()
        {
            ProjectList projectList = (ProjectList)this.alreadyOpenedChildForm(typeof(ProjectList));

            if (projectList != null)
            {
                projectList.WindowState = FormWindowState.Normal;

                return;
            }

            projectList = new ProjectList();

            projectList.TopLevel = false;

            containerPanel.Controls.Add(projectList);
            projectList.Show();

            projectList.BringToFront();
        }
    }
}
