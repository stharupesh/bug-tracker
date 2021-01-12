using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker.Core.Database;
using BugTracker.Controllers;

namespace BugTrackerTest.User
{
    [TestClass]
    public class UnitTestRegister
    {
        [TestMethod]
        public void TestRegister()
        {
            // user details

            string firstname = "Hari";
            string lastname = "Shrestha";
            string email = "sthahari@gmail.com";
            int gender = 1; // male
            string uname = "sthahari";
            string pass = "hari123";
            int utype = 1; // programmer

            bool expected = true;

            // user register process

            DBConnection.setDefault();
            DBConnection.isTesting = true;

            UserCtrl userCtrl = new UserCtrl();

            bool result = userCtrl.registerUser(firstname, lastname, email, gender, uname, pass, utype);

            Assert.AreEqual(result, expected);
        }
    }
}
