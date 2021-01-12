using System;
using System.Drawing;
using System.Windows.Forms;
using BugTracker.Controllers;

namespace BugTracker.Views
{
    public partial class BugFixList : Form
    {
        private int bugId;
        private string bugTitle;

        private BugFixCtrl bugFixCtrl = new BugFixCtrl();

        public BugFixList(int bid, string btitle)
        {
            InitializeComponent();

            this.bugId = bid;
            this.bugTitle = btitle;

            iniBugFixListGrid();
            loadBugFixList();

            this.MinimumSize = new Size(this.Width, this.Height);
        }

        private void showRelatedBugInfo()
        {
            bugTitleLabel.Text = this.bugTitle;
        }

        private void iniBugFixListGrid()
        {
            bugFixListGrid.RowsDefaultCellStyle.BackColor = Color.LightGray;
            bugFixListGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            bugFixListGrid.DefaultCellStyle.SelectionBackColor = Color.Gray;
            bugFixListGrid.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        public void loadBugFixList()
        {
            bugFixListGrid.DataSource = this.bugFixCtrl.getBugFixes(this.bugId, searchTxt.Text);
        }

        private void bugFixListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string selected = bugFixListGrid.CurrentCell.Value.ToString();

            if (selected == "View")
            {
                int fixId = (int)bugFixListGrid.CurrentRow.Cells["fixid"].Value;

                new FixView(fixId, this).Show();
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            loadBugFixList();
        }

        private void BugFixList_Resize(object sender, EventArgs e)
        {
            searchPanel.Location = new Point(this.Width - 268, searchPanel.Location.Y);

            bugFixListGrid.Width = this.Width - 81;
            bugFixListGrid.Height = this.Height - 212;
        }
    }
}
