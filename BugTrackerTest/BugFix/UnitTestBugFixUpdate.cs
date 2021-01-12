using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker.Core.Database;
using BugTracker.Controllers;

namespace BugTrackerTest.Bug
{
    [TestClass]
    public class UnitTestBugFixUpdate
    {
        [TestMethod]
        public void TestBugFixUpdate()
        {
            // bug fix details

            int fixId = 1; // bug fix with id 1 manually recorded
            string fixtitle = "fix title";
            string fixdesc = "fix description";
            string sourceCode = "<?php \n echo 'Hello'; ?>";

            bool expected = true;
            bool result = false;

            // bug fix update process

            DBConnection.setDefault();

            DBConnection.isTesting = true;

            BugFixCtrl bugFixCtrl = new BugFixCtrl();
            
            result = bugFixCtrl.updateFix(fixId, fixtitle, fixdesc, sourceCode);

            Assert.AreEqual(result, expected);
        }
    }
}
