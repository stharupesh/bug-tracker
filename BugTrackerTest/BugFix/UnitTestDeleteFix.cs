using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker.Core.Database;
using BugTracker.Controllers;

namespace BugTrackerTest.Bug
{
    [TestClass]
    public class UnitTestDeleteFix
    {
        [TestMethod]
        public void TestDeleteFix()
        {
            // bug fix details

            int fixId = 1; // bug fix with id 1 manually recorded

            bool expected = true;
            bool result = false;

            // delete bug fix status process

            DBConnection.setDefault();

            DBConnection.isTesting = true;

            BugFixCtrl bugFixCtrl = new BugFixCtrl();

            result = bugFixCtrl.deleteFix(fixId);

            Assert.AreEqual(result, expected);
        }
    }
}
