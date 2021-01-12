using System;
using System.Data;
using System.Windows.Forms;
using BugTracker.Models;
using BugTracker.Services;
using BugTracker.Validators;

namespace BugTracker.Controllers
{
    public class BugFixCtrl
    {
        Fix fix = new Fix(); // model

        BugFixFormValidator bugFixFormValidator; // validator

        // validate the fix bug add or edit form

        public bool validateFixBugForm(Form formRef, ErrorProvider errProvider, string sourceCode)
        {
            bugFixFormValidator = new BugFixFormValidator(formRef, errProvider);

            if (!bugFixFormValidator.validate())
                return false;

            if (sourceCode != "")
                return true;

            MessageBox.Show("Souce Code can't be empty!!", "Error");

            return false;
        }

        // add the bug fix in the database

        public bool addFix(int bid, string ftitle, string fdesc, string fsourcecode)
        {
            int uid = int.Parse(Auth.user("id"));

            try
            {
                this.fix.setProperties(bid, uid, ftitle, fdesc, fsourcecode)
                        .save();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());

                return false;
            }
        }

        // update the bug fix in the database

        public bool updateFix(int fixId, string ftitle, string fdesc, string fsourcecode)
        {
            try
            {
                this.fix.setProperties(0, 0, ftitle, fdesc, fsourcecode)
                        .updateFix(fixId);

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());

                return false;
            }
        }

        // change the status of the bug fix. status are correct, incorrect or pending which are recorded as integer value 1, 2, 3

        public bool changeFixStatus(int fixId, int status)
        {
            try
            {
                this.fix.changeStatus(fixId, status);

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());

                return false;
            }
        }
        
        // return the status list for the combo box

        public DataTable getStatusList()
        {
            return this.fix.getStatusList();
        }

        // returns the details of the fix for bug fix edit form

        public DataTable getFixDetails(int bugId)
        {
            return this.fix.getDetails(bugId);
        }

        // returns the bug fixes by bug id and the search string

        public DataTable getBugFixes(int bugId, string search)
        {
            return this.fix.getFixesOfABug(bugId, search);
        }

        // returns the converted status name from status code

        public string getProperFixStatus(int status)
        {
            return this.fix.getFullFixStatus(status);
        }

        // delete the bug fix from the database

        public bool deleteFix(int fixId)
        {
            try
            {
                this.fix.destroy(fixId.ToString());

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
