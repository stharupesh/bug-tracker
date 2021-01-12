using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker.Core.Database;
using BugTracker.Controllers;
using BugTracker.Services;

namespace BugTrackerTest.Bug
{
    [TestClass]
    public class UnitTestProjectAdd
    {
        [TestMethod]
        public void TestProjectAdd()
        {
            // project details
            
            string projectname = "project name";
            int projecttype = 1; // project type with id 1 manually recorded
            string description = "project description";

            bool expected = true;
            bool result = false;

            // project add process

            DBConnection.setDefault();

            DBConnection.isTesting = true;

            ProjectCtrl projectCtrl = new ProjectCtrl();
            
            result = projectCtrl.addProject(projectname, projecttype, description);

            Assert.AreEqual(result, expected);
        }
    }
}
