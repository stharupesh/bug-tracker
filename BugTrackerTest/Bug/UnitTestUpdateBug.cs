using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker.Core.Database;
using BugTracker.Controllers;
using BugTracker.Services;

namespace BugTrackerTest.Bug
{
    [TestClass]
    public class UnitTestUpdateBug
    {
        [TestMethod]
        public void TestUpdateBug()
        {
            // bug details

            int bugId = 1; // bug with id 1 manually recorded
            string title = "bug title";
            int fromlineno = 3;
            int tolineno = 5;
            string classname = "classname";
            string desc = "description";
            int pid = 1; // project type
            string sourceCode = "<?php \n echo 'Hello'; ?>";

            bool expected = true;
            bool result = false;

            // bug update process

            DBConnection.setDefault();

            bool isLogin = this.loginUser();

            DBConnection.isTesting = true;

            BugCtrl bugCtrl = new BugCtrl();

            if (isLogin)
            {
                result = bugCtrl.updateBug(bugId, title, fromlineno, tolineno, classname, desc, pid, sourceCode);
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
