using System;
using System.Data;
using System.Windows.Forms;
using BugTracker.Models;
using BugTracker.Services;
using BugTracker.Validators;

namespace BugTracker.Controllers
{
    public class BugCtrl
    {
        // models

        Bug bug = new Bug();
        Fix fix = new Fix();

        BugAddFormValidator bugAddFormValidator; // validator

        // returns the project list for combo box

        public DataTable getProjectList()
        {
            return new Project().getComboList();
        }

        // return the project type list for combo box

        public DataTable getProjectTypeList()
        {
            return new ProjectType().getComboList();
        }

        // return the bug list

        public DataTable getBugList(int projectType, String search)
        {
            return this.bug.getList(projectType, search);
        }

        // validates the report bug or bug edit form

        public bool validateReportBugForm(Form formRef, ErrorProvider errProvider, string sourceCode)
        {
            bugAddFormValidator = new BugAddFormValidator(formRef, errProvider);

            if (!bugAddFormValidator.validate())
                return false;

            if (sourceCode != "")
                return true;

            MessageBox.Show("Souce Code can't be empty!!", "Error");

            return false;
        }

        // add a new bug to the database

        public bool addBug(string ttl, int fln, int tlo, string cname, string desc, int pid, string scode)
        {
            int uid = int.Parse(Auth.user("id"));

            try
            {
                this.bug.setProperties(uid, ttl, fln, tlo, cname, desc, pid, scode)
                        .save();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());

                return false;
            }
        }

        // udpates the bug in the database
        
        public bool updateBug(int bugId, string ttl, int fln, int tlo, string cname, string desc, int pid, string scode)
        {
            int uid = int.Parse(Auth.user("id"));

            try
            {
                this.bug.setProperties(uid, ttl, fln, tlo, cname, desc, pid, scode)
                        .updateBug(bugId);

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());

                return false;
            }
        }

        // returns the bug details for bug view form

        public DataTable getBugDetails(int bugId)
        {
            return this.bug.getDetails(bugId);
        }

        // returns the bug data by bug id for bug edit form

        public DataTable getBugData(int bugId)
        {
            return this.bug.find(bugId.ToString());
        }

        // deletes the bug from the database

        public bool deleteBug(int bugId)
        {
            try
            {
                this.fix.deleteFixesByBug(bugId);

                this.bug.destroy(bugId.ToString());

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
