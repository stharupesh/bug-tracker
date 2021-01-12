using BugTracker.Controllers;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BugTracker.Views
{
    public partial class ReportBugForm : Form
    {
        private int bugId;
        private BugList bugListRef;
        private CodeEditorTextArea sourceCodeTextArea;

        private BugCtrl bugCtrl = new BugCtrl();

        public ReportBugForm()
        {
            this.iniForm();
        }

        public ReportBugForm(int bugId, BugList bugListRef)
        {
            this.iniForm();

            this.bugListRef = bugListRef;

            this.Text = "Edit Bug";
            this.headerLabel.Text = "Edit Bug";
            this.reportBugBtn.Text = "Update Bug";

            this.bugId = bugId;

            this.loadBugDetails();
        }

        public void loadBugDetails()
        {
            DataRow data = this.bugCtrl.getBugData(bugId).Rows[0];

            titleTxt.Text = data[2].ToString();
            descTxt.Text = data[6].ToString();
            pidCmb.SelectedValue = data[7].ToString();
            cnameTxt.Text = data[5].ToString();
            fromlineTxt.Text = data[3].ToString();
            tolineTxt.Text = data[4].ToString();
            sourceCodeTextArea.Text = data[8].ToString();
        }

        private void iniForm()
        {
            InitializeComponent();

            this.iniComboBox();

            sourceCodeTextArea = new CodeEditorTextArea(this, searchBoxTxt, searchBoxPanel);
            sourceCodePanel.Controls.Add(sourceCodeTextArea);

            this.setProjectType();

            this.MinimumSize = new Size(this.Width - 250, this.Height);
        }

        private void iniComboBox()
        {
            pidCmb.DataSource = bugCtrl.getProjectList();

            pidCmb.DisplayMember = "project_name";
            pidCmb.ValueMember = "project_id";
        }

        private void reportBugBtn_Click(object sender, EventArgs e)
        {
            bool result;
            
            if (this.bugCtrl.validateReportBugForm(this, bugFormErrProvider, sourceCodeTextArea.Text))
            {
                if (reportBugBtn.Text == "Report Bug")
                {
                    result = this.bugCtrl.addBug(titleTxt.Text, int.Parse(fromlineTxt.Text), int.Parse(tolineTxt.Text), cnameTxt.Text, descTxt.Text, int.Parse(pidCmb.SelectedValue.ToString()), sourceCodeTextArea.Text);

                    if (result)
                    {
                        this.Close();

                        MessageBox.Show("Bug Successfully Added!!", "Info");
                    }
                }
                else
                {
                    result = this.bugCtrl.updateBug(bugId, titleTxt.Text, int.Parse(fromlineTxt.Text), int.Parse(tolineTxt.Text), cnameTxt.Text, descTxt.Text, int.Parse(pidCmb.SelectedValue.ToString()), sourceCodeTextArea.Text);

                    if (result)
                    {
                        this.bugListRef.loadBugs();

                        this.Close();

                        MessageBox.Show("Bug Successfully Updated!!", "Info");
                    }
                }
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

        private void pidCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.setProjectType();
            
        }

        private void setProjectType()
        {
            if (this.sourceCodeTextArea != null)
            {
                DataRowView selected = (DataRowView)this.pidCmb.SelectedItem;

                if (selected == null)
                {
                    this.Hide();

                    MessageBox.Show("No Project Created !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                String selectedType = selected.Row[2].ToString();

                projectType.Text = selectedType;
                this.sourceCodeTextArea.setLanguage(selectedType).Refresh();
            }
        }

        private void ReportBugForm_Resize(object sender, EventArgs e)
        {
            sourceCodePanel.Width = this.Width - 290;
            sourceCodePanel.Height = this.Height - 198;

            reportBugBtn.Location = new Point(this.Width - 149, this.Height - 110);
        }
    }
}
