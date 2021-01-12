using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker.Core.Database;
using BugTracker.Controllers;
using BugTracker.Services;

namespace BugTrackerTest.Bug
{
    [TestClass]
    public class UnitTestDeleteBug
    {
        [TestMethod]
        public void TestDeleteBug()
        {
            // bug details

            int bugId = 1; // bug with id 1 manually recorded for the test

            bool expected = true;
            bool result = false;


            // bug delete process

            DBConnection.setDefault();

            DBConnection.isTesting = true;

            BugCtrl bugCtrl = new BugCtrl();
            
            result = bugCtrl.deleteBug(bugId);

            Assert.AreEqual(result, expected);
        }
    }
}
