using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BugTracker.Controllers;
using BugTracker.Services;

namespace BugTracker.Views
{
    public partial class BugView : Form
    {
        private int bugId;
        private int userId;
        private BugList bugListRef;

        private BugCtrl bugCtrl = new BugCtrl();

        private CodeEditorTextArea sourceCodeTextArea;

        public BugView(int bugId, BugList bugListRef)
        {
            InitializeComponent();

            this.bugId = bugId;
            this.bugListRef = bugListRef;

            sourceCodeTextArea = new CodeEditorTextArea(this, searchBoxTxt, searchBoxPanel);
            sourceCodePanel.Controls.Add(sourceCodeTextArea);

            loadBugDetails();

            loadButtonsByPrivileges();

            this.MinimumSize = new Size(this.Width - 250, this.Height);
        }

        private void loadBugDetails()
        {
            DataRow bug = this.bugCtrl.getBugDetails(bugId).Rows[0];

            this.userId = int.Parse(bug[0].ToString());
            bugTitle.Text = bug[1].ToString();
            descTxt.Text = bug[2].ToString();
            status.Text = bug[4].ToString();
            projectType.Text = bug[5].ToString();
            className.Text = bug[6].ToString();
            projectDesc.Text = bug[7].ToString();
            sourceCodeTextArea.Text = bug[8].ToString();
            authorName.Text = bug[9].ToString() + " at " + bug[3].ToString();
            linesDesc.Text = bug[10].ToString() + " to " + bug[11].ToString();
            pname.Text = bug[11].ToString();

            if (status.Text == "0")
            {
                status.Text = "Not Fixed";

                addFix.Visible = true;
            }
            else
            {
                status.Text = "Fixed";

                addFix.Visible = false;

                panel1.Width -= 127;
                panel1.Location = new Point(panel1.Location.X + 126, panel1.Location.Y);
            }

            sourceCodeTextArea.setLanguage(projectType.Text).Refresh();
        }

        private void loadButtonsByPrivileges()
        {
            if (this.userId.ToString() == Auth.user("id"))
            {
                this.editBugBtn.Visible = this.delBugBtn.Visible = true;
            }
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            sourceCodeTextArea.previousSearch();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            sourceCodeTextArea.nextSearch();
        }

        private void closeSearchBtn_Click(object sender, EventArgs e)
        {
            sourceCodeTextArea.clearSearch();
        }

        private void searchBoxTxt_KeyDown(object sender, KeyEventArgs e)
        {
            sourceCodeTextArea.searchKeyDown(e);
        }

        private void viewFixes_Click(object sender, EventArgs e)
        {
            new BugFixList(bugId, bugTitle.Text).Show();
        }

        private void addFix_Click(object sender, EventArgs e)
        {
            new FixBugForm(bugId, bugTitle.Text, projectType.Text, sourceCodeTextArea.Text).Show();
        }

        private void editBugBtn_Click(object sender, EventArgs e)
        {
            new ReportBugForm(bugId, bugListRef).Show();
        }

        private void BugView_Resize(object sender, EventArgs e)
        {
            sourceCodePanel.Width = this.Width - 290;
            sourceCodePanel.Height = this.Height - 200;
            
            actionsPanel.Location = new Point(this.Width - 542, this.Height - 118);
        }

        private void delBugBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? \nThis will delete all the data related to the bug.", "Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (this.bugCtrl.deleteBug(bugId))
                {
                    this.Close();

                    this.bugListRef.loadBugs();

                    MessageBox.Show("Bug successfully deleted!!", "Info");
                }
            }
        }
    }
}
