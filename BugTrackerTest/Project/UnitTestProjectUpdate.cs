using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker.Core.Database;
using BugTracker.Controllers;
using BugTracker.Services;

namespace BugTrackerTest.Bug
{
    [TestClass]
    public class UnitTestProjectUpdate
    {
        [TestMethod]
        public void TestProjectUpdate()
        {
            // project details

            int projectId = 1; //  project with id 1 manually recorded
            string projectname = "project name";
            int projecttype = 1;
            string description = "project description";

            bool expected = true;
            bool result = false;

            // project update process

            DBConnection.setDefault();

            DBConnection.isTesting = true;

            ProjectCtrl projectCtrl = new ProjectCtrl();

            result = projectCtrl.updateProject(projectId, projectname, projecttype, description);

            Assert.AreEqual(result, expected);
        }
    }
}
