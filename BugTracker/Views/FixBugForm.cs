using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using BugTracker.Controllers;

namespace BugTracker.Views
{
    public partial class FixBugForm : Form
    {
        private int fixId;
        private int bugId;
        private string pType;
        private string bugTitle;

        private CodeEditorTextArea sourceCodeTextArea;

        private BugFixCtrl bugFixCtrl = new BugFixCtrl();

        public FixBugForm(int bugid, string bugtitle, string pType, string sourcecode)
        {
            InitializeComponent();

            this.bugId = bugid;
            this.pType = pType;
            this.bugTitle = bugtitle;

            bugTitleLabel.Text = bugtitle;

            iniCodeEditor();

            sourceCodeTextArea.setLanguage(this.pType).Refresh();

            sourceCodeTextArea.Text = sourcecode;

            this.MinimumSize = new Size(this.Width, this.Height);
        }

        public FixBugForm(int fixId)
        {
            InitializeComponent();

            iniCodeEditor();

            this.fixId = fixId;

            loadFixDetails();

            sourceCodeTextArea.setLanguage(this.pType).Refresh();

            fixBugBtn.Text = "Update Fix";
        }

        private void iniCodeEditor()
        {
            sourceCodeTextArea = new CodeEditorTextArea(this, searchBoxTxt, searchBoxPanel);
            sourceCodePanel.Controls.Add(sourceCodeTextArea);
        }

        private void loadFixDetails()
        {
            DataRow data = this.bugFixCtrl.getFixDetails(fixId).Rows[0];

            titleTxt.Text = data[1].ToString();
            descTxt.Text = data[2].ToString();
            relatedBugLabel.Text = data[4].ToString();

            sourceCodeTextArea.Text = data[7].ToString();
            this.pType = data[8].ToString();
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

        private void fixBugBtn_Click(object sender, EventArgs e)
        {
            bool result;

            if (this.bugFixCtrl.validateFixBugForm(this, bugFormErrProvider, sourceCodeTextArea.Text))
            {
                if (fixBugBtn.Text == "Fix Bug")
                {
                    result = this.bugFixCtrl.addFix(bugId, titleTxt.Text, descTxt.Text, sourceCodeTextArea.Text);

                    if (result)
                    {
                        this.Close();

                        MessageBox.Show("Bug Fix Successfully Added!!", "Info");
                    }
                }
                else if (fixBugBtn.Text == "Update Fix")
                {
                    result = this.bugFixCtrl.updateFix(fixId, titleTxt.Text, descTxt.Text, sourceCodeTextArea.Text);

                    if (result)
                    {
                        this.Close();

                        MessageBox.Show("Bug Fix Successfully Updated!!", "Info");
                    }
                }
            }
        }

        private void FixBugForm_Resize(object sender, EventArgs e)
        {
            sourceCodePanel.Width = this.Width - 290;
            sourceCodePanel.Height = this.Height - 202;

            fixBugBtn.Location = new Point(this.Width - 147, this.Height - 113);
        }
    }
}
