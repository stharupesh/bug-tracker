using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker.Core.Database;
using BugTracker.Controllers;

namespace BugTrackerTest.User
{
    [TestClass]
    public class UnitTestChangeUserStatus
    {
        [TestMethod]
        public void TestChangeUserStatus()
        {
            // user details, user with id 1 is manually recorded

            int userId = 1;
            int status = 1;

            bool expected = true;

            // change user status process

            DBConnection.setDefault();
            DBConnection.isTesting = true;

            UserCtrl userCtrl = new UserCtrl();

            bool result = userCtrl.changeUserStatus(userId, status);

            Assert.AreEqual(result, expected);
        }
    }
}
