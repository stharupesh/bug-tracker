using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BugTracker.Controllers;
using BugTracker.Services;

namespace BugTracker.Views
{
    public partial class FixView : Form
    {
        private int fixId;
        private int userId;
        private int bugAuthor;
        private string statusValue;
        private bool isDetailsLoaded = false;

        private BugFixList fixList;
        private BugFixCtrl fixCtrl = new BugFixCtrl();

        private CodeEditorTextArea sourceCodeTextArea;

        public FixView(int fixId, BugFixList fixList)
        {
            InitializeComponent();

            this.fixId = fixId;
            this.fixList = fixList;

            sourceCodeTextArea = new CodeEditorTextArea(this, searchBoxTxt, searchBoxPanel);
            sourceCodePanel.Controls.Add(sourceCodeTextArea);

            loadFixDetails();
            loadButtonsByPrivileges();

            this.MinimumSize = new Size(this.Width - 250, this.Height);
        }

        private void loadButtonsByPrivileges()
        {
            if (this.bugAuthor.ToString() == Auth.user("id"))
            {
                this.statusPanel.Visible = true;
                this.deleteFixBtn.Text = "Close";

                iniComboBox();
            }
            else if (this.userId.ToString() == Auth.user("id"))
            {
                this.editFixBtn.Visible = true;
            }
            else
            {
                this.deleteFixBtn.Text = "Close";
            }
        }

        private void iniComboBox()
        {
            statusCmb.DataSource = fixCtrl.getStatusList();

            statusCmb.DisplayMember = "status_name";
            statusCmb.ValueMember = "id";

            statusCmb.SelectedValue = statusValue;

            isDetailsLoaded = true;
        }

        private void loadFixDetails()
        {
            DataRow fix = this.fixCtrl.getFixDetails(fixId).Rows[0];

            this.userId = int.Parse(fix[0].ToString());
            this.bugAuthor = int.Parse(fix[10].ToString());

            fixTitle.Text = fix[1].ToString();
            descTxt.Text = fix[2].ToString();
            bugTitleLabel.Text = fix[4].ToString();
            status.Text = this.fixCtrl.getProperFixStatus((int) fix[3]);
            authorName.Text = fix[5].ToString() + " at " + fix[6].ToString();
            sourceCodeTextArea.Text = fix[7].ToString();

            statusValue = fix[9].ToString();
            
            sourceCodeTextArea.setLanguage(fix[8].ToString()).Refresh();
        }

        private void deleteFixBtn_Click(object sender, EventArgs e)
        {
            if (this.userId.ToString() == Auth.user("id"))
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (this.fixCtrl.deleteFix(fixId))
                    {
                        this.Close();
                        this.fixList.loadBugFixList();

                        MessageBox.Show("Fix successfully deleted!!", "Info");
                    }
                }
            }
            else
            {
                this.Close();
            }
        }

        private void statusCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isDetailsLoaded)
            {
                int statusVal = (int)statusCmb.SelectedValue;

                if (this.fixCtrl.changeFixStatus(this.fixId, statusVal))
                {
                    status.Text = statusCmb.Text;

                    MessageBox.Show("Status successfully changed!!");
                }
            }
        }

        private void editFixBtn_Click(object sender, EventArgs e)
        {
            new FixBugForm(fixId).Show();
        }

        private void FixView_Resize(object sender, EventArgs e)
        {
            sourceCodePanel.Width = this.Width - 290;
            sourceCodePanel.Height = this.Height - 204;
        }
    }
}
