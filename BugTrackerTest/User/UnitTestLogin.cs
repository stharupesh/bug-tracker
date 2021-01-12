using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker.Services;
using BugTracker.Core.Database;

namespace BugTrackerTest.User
{
    [TestClass]
    public class UnitTestLogin
    {
        [TestMethod]
        public void TestLogin()
        {
            // login credentials, user the following details is manually recorded

            string username = "stharupesh";
            string password = "thehelp";

            bool expected = true;

            // login process

            DBConnection.setDefault();

            bool result = Auth.login(username, password);

            Assert.AreEqual(result, expected);
        }
    }
}
