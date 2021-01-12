using System;
using System.Windows.Forms;
using BugTracker.Controllers;
using BugTracker.Core.Database;

namespace BugTracker.Views
{
    public partial class HomeView : Form
    {
        private UserCtrl userCtrl = new UserCtrl();

        public HomeView()
        {
            InitializeComponent();

            DBConnection.setDefault();

            this.setToolTips();
        }

        private void setToolTips()
        {
            this.loginToolTip.SetToolTip(this.usernameTxt, "Username");
            this.loginToolTip.SetToolTip(this.passwordTxt, "Password");
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            bool isCredentialsCorrect = this.userCtrl.login(this, loginErrProvider, usernameTxt.Text, passwordTxt.Text);

            if (isCredentialsCorrect)
            {
                new DashboardView().Show();

                this.Hide();
            }
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
        }

        private void HomeView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
