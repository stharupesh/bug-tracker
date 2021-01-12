using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker.Core.Database;
using BugTracker.Controllers;

namespace BugTrackerTest.User
{
    [TestClass]
    public class UnitTestDeleteUser
    {
        [TestMethod]
        public void TestChangeDeleteUser()
        {
            // user details

            int userId = 1; // user with id 1 is manually recorded

            bool expected = true;

            // delete user process

            DBConnection.setDefault();
            DBConnection.isTesting = true;

            UserCtrl userCtrl = new UserCtrl();

            bool result = userCtrl.deleteUser(userId);

            Assert.AreEqual(result, expected);
        }
    }
}
