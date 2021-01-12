using System;
using System.Data;
using System.Windows.Forms;
using BugTracker.Models;
using BugTracker.Validators;

namespace BugTracker.Controllers
{
    public class ProjectCtrl
    {
        // Models
        
        Project project = new Project();
        ProjectType projectType = new ProjectType();

        // Validator

        ProjectFormValidator projectFormValidator;

        // returns the project details for project edit

        public DataTable getProjectDetails(int projectId)
        {
            return this.project.getDetails(projectId);
        }

        // return the project type list for using in project type combo box

        public DataTable getProjectTypeList()
        {
            return this.projectType.getComboList();
        }

        // returns the list of projects

        public DataTable getProjectList(int projectType, string search)
        {
            return this.project.getList(projectType, search);
        }

        // validates both the project add and edit form

        public bool validateProjectForm(Form formRef, ErrorProvider errProvider)
        {
            projectFormValidator = new ProjectFormValidator(formRef, errProvider);

            return projectFormValidator.validate();
        }

        // add the project to the database

        public bool addProject(string pName, int pType, string description)
        {
            try
            {
                this.project.setProperties(pName, pType, description)
                            .save();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());

                return false;
            }
        }

        // udpate the project in the database

        public bool updateProject(int projectId, string pName, int pType, string description)
        {
            try
            {
                this.project.setProperties(pName, pType, description)
                            .updateProject(projectId);

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());

                return false;
            }
        }

        // delete the project in the database

        public bool deleteProject(int projectId)
        {
            try
            {
                new Fix().deleteFixesByProject(projectId);
                new Bug().deleteBugsByProject(projectId);

                this.project.destroy(projectId.ToString());

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());

                return false;
            }
        }
    }
}
