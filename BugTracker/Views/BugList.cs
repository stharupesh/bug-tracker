using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BugTracker.Controllers;

namespace BugTracker.Views
{
    public partial class BugList : Form
    {
        private bool isComboxReady = false;

        private BugCtrl bugCtrl = new BugCtrl();

        public BugList()
        {
            InitializeComponent();

            iniComboBox();

            iniToolTips();

            iniBugListGrid();

            loadBugs();

            this.MinimumSize = new Size(this.Width, this.Height);
        }

        public BugList setSearch(string search)
        {
            searchTxt.Text = search;

            return this;
        }

        private void iniBugListGrid()
        {
            bugListDataGrid.RowsDefaultCellStyle.BackColor = Color.LightGray;
            bugListDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            bugListDataGrid.DefaultCellStyle.SelectionBackColor = Color.Gray;
            bugListDataGrid.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void iniComboBox()
        {
            DataTable pTypeList = bugCtrl.getProjectTypeList();

            pTypeList.Rows.Add(new Object[] { 0, "All" });

            ptypeCmb.DataSource = pTypeList;

            ptypeCmb.DisplayMember = "project_type_name";
            ptypeCmb.ValueMember = "id";

            this.ptypeCmb.SelectedValue = 0;

            isComboxReady = true;
        }

        public void iniToolTips()
        {
            bugListToolTip.SetToolTip(ptypeCmb, "Choose Project Type");
            bugListToolTip.SetToolTip(searchTxt, "Bug Title or Project Name");
        }

        public void loadBugs()
        {
            int pType = this.getSelectedProjectType();

            DataTable bugs = this.bugCtrl.getBugList(pType, searchTxt.Text);

            this.bugListDataGrid.DataSource = bugs;
        }

        public int getSelectedProjectType()
        {
            if (!isComboxReady)
                return 0;

            string selected = ptypeCmb.SelectedValue.ToString();

            if (selected == "")
                return 0;

            return int.Parse(selected);
        }

        private void bugListDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string selected = bugListDataGrid.CurrentCell.Value.ToString();

            if (selected == "View/Fix" || selected == "View/Edit/Fix")
            {
                int bugId = (int)bugListDataGrid.CurrentRow.Cells["bugid"].Value;

                new BugView(bugId, this).Show();
            }
        }

        private void ptypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.loadBugs();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            this.loadBugs();
        }

        private void BugList_Resize(object sender, EventArgs e)
        {
            searchActionsPanel.Location = new Point(this.Width - 498, searchActionsPanel.Location.Y);

            bugListDataGrid.Width = this.Width - 92;
            bugListDataGrid.Height = this.Height - 214;
        }

        private void bugListDataGrid_Paint(object sender, PaintEventArgs e)
        {
            foreach (DataGridViewRow row in bugListDataGrid.Rows)
            {
                string value = row.Cells["isfixed"].Value.ToString();

                if (value == "1")
                    row.Cells["isfixed"].Style.BackColor = Color.LightGreen;
                else
                    row.Cells["isfixed"].Style.BackColor = Color.OrangeRed;
            }
        }
    }
}
