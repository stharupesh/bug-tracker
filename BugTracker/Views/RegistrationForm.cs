using System;
using System.Windows.Forms;
using BugTracker.Controllers;

namespace BugTracker.Views
{
    public partial class RegistrationForm : Form
    {
        private UserCtrl userCtrl = new UserCtrl();

        public RegistrationForm()
        {
            InitializeComponent();

            this.fnameTxt.Select();

            this.iniComboBox();
        }

        public void iniComboBox()
        {
            utypeCmb.DataSource = userCtrl.getUserTypeList();

            utypeCmb.DisplayMember = "user_type_name";
            utypeCmb.ValueMember = "id";
        }

        private void userRegisterBtn_Click(object sender, EventArgs e)
        {
            if (this.userCtrl.validateRegistrationForm(this, registrationErrProvider))
            {
                if (this.userCtrl.registerUser(fnameTxt.Text, lnameTxt.Text, emailTxt.Text, ((genderMale.Checked) ? 1 : 2), unameTxt.Text, passTxt.Text, int.Parse(utypeCmb.SelectedValue.ToString())))
                {
                    this.Close();

                    MessageBox.Show("User successfully registered", "Info");
                }
            }
        }
    }
}
