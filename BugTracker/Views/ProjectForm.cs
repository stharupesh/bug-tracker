using System;
using System.Data;
using System.Windows.Forms;
using BugTracker.Controllers;

namespace BugTracker.Views
{
    public partial class ProjectForm : Form
    {
        private int projectId;
        private ProjectList projectList;
        private ProjectCtrl projectCtrl = new ProjectCtrl();

        public ProjectForm(ProjectList projectList)
        {
            InitializeComponent();

            this.projectList = projectList;

            iniComboBox();
        }

        public ProjectForm(ProjectList projectList, int projectId)
        {
            InitializeComponent();

            this.projectId = projectId;
            this.projectList = projectList;

            iniComboBox();

            loadProjectDetails();

            addProjectBtn.Text = "Update Project";
        }

        private void iniComboBox()
        {
            ptypeCmb.DataSource = projectCtrl.getProjectTypeList();

            ptypeCmb.DisplayMember = "project_type_name";
            ptypeCmb.ValueMember = "id";

            this.ptypeCmb.SelectedValue = 1;
        }

        private void loadProjectDetails()
        {
            DataRow project = this.projectCtrl.getProjectDetails(projectId).Rows[0];

            pNameTxt.Text = project[1].ToString();
            descTxt.Text = project[3].ToString();

            ptypeCmb.SelectedValue = project[2].ToString();
        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            bool result;

            if (this.projectCtrl.validateProjectForm(this, projectFormErrProvider))
            {
                if (addProjectBtn.Text == "Update Project")
                {
                    result = this.projectCtrl.updateProject(projectId, pNameTxt.Text, int.Parse(ptypeCmb.SelectedValue.ToString()), descTxt.Text);

                    if (result)
                    {
                        this.resetForm();
                        this.projectList.loadProjects();
                        this.Hide();

                        MessageBox.Show("Project SuccessFully Updated!!", "Info");
                    }
                }
                else
                {
                    result = this.projectCtrl.addProject(pNameTxt.Text, int.Parse(ptypeCmb.SelectedValue.ToString()), descTxt.Text);

                    if (result)
                    {
                        this.resetForm();
                        this.projectList.loadProjects();
                        this.Hide();

                        MessageBox.Show("Project SuccessFully Added!!", "Info");
                    }
                }
            }
        }

        private void resetForm()
        {
            pNameTxt.Text = "";
            descTxt.Text = "";

            ptypeCmb.SelectedValue = 1;
        }
    }
}
