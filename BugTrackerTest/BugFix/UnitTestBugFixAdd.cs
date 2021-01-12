using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker.Core.Database;
using BugTracker.Controllers;
using BugTracker.Services;

namespace BugTrackerTest.Bug
{
    [TestClass]
    public class UnitTestBugFixAdd
    {
        [TestMethod]
        public void TestBugFixAdd()
        {
            // bug fix details

            int bugId = 1; // bug fix with id 1 manually recorded
            string fixtitle = "fix title";
            string fixdesc = "fix description";
            string sourceCode = "<?php \n echo 'Hello'; ?>";

            bool expected = true;
            bool result = false;

            // bug fix add process

            DBConnection.setDefault();

            bool isLogin = this.loginUser();

            DBConnection.isTesting = true;

            BugFixCtrl bugFixCtrl = new BugFixCtrl();

            if (isLogin)
            {
                result = bugFixCtrl.addFix(bugId, fixtitle, fixdesc, sourceCode);
            }

            Assert.AreEqual(result, expected);
        }

        private bool loginUser()
        {
            //user details

            string username = "stharupesh";
            string password = "thehelp";

            return Auth.login(username, password);
        }
    }
}
