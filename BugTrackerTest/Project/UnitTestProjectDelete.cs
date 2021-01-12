using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker.Core.Database;
using BugTracker.Controllers;
using BugTracker.Services;

namespace BugTrackerTest.Bug
{
    [TestClass]
    public class UnitTestProjectDelete
    {
        [TestMethod]
        public void TestProjectDelete()
        {
            // project details

            int projectId = 1; // project with id 1 manually recorded

            bool expected = true;
            bool result = false;

            // project delete process

            DBConnection.setDefault();

            DBConnection.isTesting = true;

            ProjectCtrl projectCtrl = new ProjectCtrl();

            result = projectCtrl.deleteProject(projectId);

            Assert.AreEqual(result, expected);
        }
    }
}
