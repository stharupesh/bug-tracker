using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BugTracker.Controllers;

namespace BugTracker.Views
{
    public partial class ProjectList : Form
    {
        private bool isComboBoxReady = false;
        private ProjectCtrl projectCtrl = new ProjectCtrl();

        public ProjectList()
        {
            InitializeComponent();

            iniComboBox();

            loadProjects();

            iniProjectListGrid();

            isComboBoxReady = true;

            this.MinimumSize = new Size(this.Width, this.Height);
        }

        private void iniComboBox()
        {
            DataTable pTypeList = projectCtrl.getProjectTypeList();

            pTypeList.Rows.Add(new Object[] { 0, "All" });

            ptypeCmb.DataSource = pTypeList;

            ptypeCmb.DisplayMember = "project_type_name";
            ptypeCmb.ValueMember = "id";

            this.ptypeCmb.SelectedValue = 0;
        }

        private void iniProjectListGrid()
        {
            projectListGrid.RowsDefaultCellStyle.BackColor = Color.LightGray;
            projectListGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            projectListGrid.DefaultCellStyle.SelectionBackColor = Color.Gray;
            projectListGrid.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        public void loadProjects()
        {
            int pType = this.getSelectedProjectType();

            DataTable projects = this.projectCtrl.getProjectList(pType, searchTxt.Text);

            this.projectListGrid.DataSource = projects;
        }

        private int getSelectedProjectType()
        {
            if (!isComboBoxReady)
                return 0;

            string selected = ptypeCmb.SelectedValue.ToString();

            if (selected == "")
                return 0;

            return int.Parse(selected);
        }

        private void projectListDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string selected = projectListGrid.CurrentCell.Value.ToString();

            int projectId = (int)projectListGrid.CurrentRow.Cells["projectid"].Value;

            if (selected == "Edit")
            {
                new ProjectForm(this, projectId).Show();
            }

            if (selected == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure? \nThis will delete all the data related to the project", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (this.projectCtrl.deleteProject(projectId))
                    {
                        MessageBox.Show("Project Successfully Deleted!!", "Info");

                        loadProjects();
                    }
                }
            }
        }

        private void projectAdd_Click(object sender, EventArgs e)
        {
            new ProjectForm(this).Show();
        }

        private void ptypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadProjects();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            loadProjects();
        }

        private void ProjectList_Resize(object sender, EventArgs e)
        {
            searchActionsPanel.Location = new Point(this.Width - 500, searchActionsPanel.Location.Y);

            projectListGrid.Width = this.Width - 93;
            projectListGrid.Height = this.Height - 212;
        }
    }
}
