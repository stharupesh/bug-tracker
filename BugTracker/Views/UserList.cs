using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BugTracker.Controllers;

namespace BugTracker.Views
{
    public partial class UserList : Form
    {
        private bool isComboBoxReady = false;

        private UserCtrl userCtrl = new UserCtrl();

        public UserList()
        {
            InitializeComponent();

            iniComboBox();
            iniUserListGrid();

            loadUsers();

            this.MinimumSize = new Size(this.Width, this.Height);
        }

        private void iniComboBox()
        {
            DataTable uTypeList = userCtrl.getUserTypeList();

            uTypeList.Rows.Add(new Object[] { 0, "All" });

            utypeCmb.DataSource = uTypeList;

            utypeCmb.DisplayMember = "user_type_name";
            utypeCmb.ValueMember = "id";

            this.utypeCmb.SelectedValue = 0;

            isComboBoxReady = true;
        }

        private void iniUserListGrid()
        {
            userListGrid.RowsDefaultCellStyle.BackColor = Color.LightGray;
            userListGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            userListGrid.DefaultCellStyle.SelectionBackColor = Color.Gray;
            userListGrid.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private int getSelectedUserType()
        {
            if (!isComboBoxReady)
                return 0;

            string selected = utypeCmb.SelectedValue.ToString();

            if (selected == "")
                return 0;

            return int.Parse(selected);
        }

        public void loadUsers()
        {
            int uType = this.getSelectedUserType();

            DataTable users = this.userCtrl.getUserList(uType, searchTxt.Text);

            this.userListGrid.DataSource = users;
        }

        private void userListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string selected = userListGrid.CurrentCell.Value.ToString();

            int userId = (int)userListGrid.CurrentRow.Cells["userid"].Value;

            if (selected == "Activate" || selected == "Disactivate")
            {
                string status = (string)userListGrid.CurrentRow.Cells["status"].Value;

                int newStatus = (status == "Active") ? 0 : 1;

                if (this.userCtrl.changeUserStatus(userId, newStatus))
                {
                    loadUsers();
                }
            }

            if (selected == "Change")
            {
                string fullName = (string)userListGrid.CurrentRow.Cells["fullname"].Value;

                new PasswordChangeForm(userId, true, fullName).Show();
            }

            if (selected == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure? \n\nThis deletes all the data related to the user.", "Delete", MessageBoxButtons.YesNo);
                
                if (result == DialogResult.Yes)
                {
                    if (this.userCtrl.deleteUser(userId))
                    {
                        loadUsers();

                        MessageBox.Show("User successfully deleted!!", "Info");
                    }
                }
            }
        }

        private void utypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void UserList_Resize(object sender, EventArgs e)
        {
            searchActionsPanel.Location = new Point(this.Width - 500, searchActionsPanel.Location.Y);

            userListGrid.Width = this.Width - 92;
            userListGrid.Height = this.Height - 211;
        }
    }
}
