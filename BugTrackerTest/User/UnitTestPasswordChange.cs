using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker.Core.Database;
using BugTracker.Controllers;
using System.Data;

namespace BugTrackerTest.User
{
    [TestClass]
    public class UnitTestPasswordChange
    {
        [TestMethod]
        public void TestPasswordChange()
        {
            // user details, user the following details is manually recorded
            int userId = 1;

            bool expected = true;

            // change password process

            DBConnection.setDefault();
            DBConnection.isTesting = true;

            UserCtrl userCtrl = new UserCtrl();

            bool result = userCtrl.changePassword(userId, "newpassword");

            Assert.AreEqual(result, expected);
        }
    }
}
