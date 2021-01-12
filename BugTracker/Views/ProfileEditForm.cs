using System;
using System.Data;
using System.Windows.Forms;
using BugTracker.Controllers;
using BugTracker.Services;

namespace BugTracker.Views
{
    public partial class ProfileEditForm : Form
    {
        private int userId;
        private bool ownProfile;
        private string previousUserName;
        private UserCtrl userCtrl = new UserCtrl();

        public ProfileEditForm(int userid, bool op)
        {
            InitializeComponent();

            this.userId = userid;
            this.ownProfile = op;

            this.iniComboBox();
            this.loadUserDetails();
        }

        public void iniComboBox()
        {
            DataTable userTypeList = userCtrl.getUserTypeList();
            
            if(Auth.isAdmin())
            userTypeList.Rows.Add(new Object[] { 4, "Admin" });

            utypeCmb.DataSource = userTypeList;

            utypeCmb.DisplayMember = "user_type_name";
            utypeCmb.ValueMember = "id";
        }

        private void loadUserDetails()
        {
            DataRow usr = this.userCtrl.getUserDetails(userId).Rows[0];

            previousUserName = usr[1].ToString();

            unameTxt.Text = usr[1].ToString();
            fnameTxt.Text = usr[3].ToString();
            lnameTxt.Text = usr[4].ToString();
            utypeCmb.SelectedValue = usr[5].ToString();

            if (usr[6].ToString() == "1")
                genderMale.Checked = true;
            else
                genderFemale.Checked = true;

            emailTxt.Text = usr[7].ToString();
        }

        private void profileUpdateBtn_Click(object sender, EventArgs e)
        {
            bool result;

            if (ownProfile)
            {
                if (this.userCtrl.validateOwnProfileEditForm(this, profileEditErrProvider, previousUserName, unameTxt.Text))
                {
                    result = this.userCtrl.updateOwnProfile(userId, fnameTxt.Text, lnameTxt.Text, emailTxt.Text, ((genderMale.Checked) ? 1 : 2), unameTxt.Text, int.Parse(utypeCmb.SelectedValue.ToString()));

                    if (result)
                    {
                        this.Close();

                        MessageBox.Show("Profile Successfully Updated!!", "Info");
                    }
                }
                
            }
        }
    }
}
