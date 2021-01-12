using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker.Core.Database;
using BugTracker.Controllers;

namespace BugTrackerTest.Bug
{
    [TestClass]
    public class UnitTestChangeBugFixStatus
    {
        [TestMethod]
        public void TestChangeBugFixStatus()
        {
            // bug fix details

            int fixId = 1; // bug fix with id 1 manually recorded
            int status = 1;

            bool expected = true;
            bool result = false;

            // change bug fix status process

            DBConnection.setDefault();

            DBConnection.isTesting = true;

            BugFixCtrl bugFixCtrl = new BugFixCtrl();

            result = bugFixCtrl.changeFixStatus(fixId, status);

            Assert.AreEqual(result, expected);
        }
    }
}
