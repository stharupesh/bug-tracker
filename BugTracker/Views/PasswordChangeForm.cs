using System.Windows.Forms;
using BugTracker.Controllers;

namespace BugTracker.Views
{
    public partial class PasswordChangeForm : Form
    {
        private int userId;
        private string userName;
        private bool byAdmin = false;
        private UserCtrl userCtrl = new UserCtrl();

        public PasswordChangeForm(int userid)
        {
            userId = userid;

            InitializeComponent();
        }

        public PasswordChangeForm(int userid, bool byAdmin, string uName)
        {
            userId = userid;
            userName = uName;
            this.byAdmin = byAdmin;

            InitializeComponent();

            setUpFormForAdmin();
        }

        private void setUpFormForAdmin()
        {
            fullNameLabel.Text = userName;
            relatedUserPanel.Show();
        }

        private void updatePassword_Click(object sender, System.EventArgs e)
        {
            if (this.userCtrl.validateChangeOwnPasswordForm(this, passFormErrProvider, userId, currPassTxt.Text, byAdmin))
            {
                bool result = this.userCtrl.changePassword(userId, newPassTxt.Text);

                if (result)
                {
                    MessageBox.Show("Password Updated Successfully!!", "Info");

                    this.Hide();
                }
            }
        }

        private void PasswordChangeForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
