using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker.Core.Database;
using BugTracker.Controllers;

namespace BugTrackerTest.User
{
    [TestClass]
    public class UnitTestUpdateProfile
    {
        [TestMethod]
        public void TestUpdateProfile()
        {
            // user details, user with id 1 is manually recorded

            int userId = 1;

            string firstname = "Hari";
            string lastname = "Shrestha";
            string email = "sthahari@gmail.com";
            int gender = 1; // male
            string uname = "sthahari";
            int utype = 1; // programmer

            bool expected = true;

            // update profile process

            DBConnection.setDefault();
            DBConnection.isTesting = true;

            UserCtrl userCtrl = new UserCtrl();

            bool result = userCtrl.updateOwnProfile(userId, firstname, lastname, email, gender, uname, utype);

            Assert.AreEqual(result, expected);
        }
    }
}
