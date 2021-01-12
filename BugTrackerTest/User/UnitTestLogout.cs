using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTracker.Services;
using BugTracker.Core.Database;

namespace BugTrackerTest.User
{
    [TestClass]
    public class UnitTestLogout
    {
        [TestMethod]
        public void TestLogout()
        {
            bool expected = false;
            bool result = true;

            // login and then logout

            DBConnection.setDefault();

            bool isLogin = this.loginUser();


            if (isLogin)
            {
                Auth.logout();

                result = Auth.isLoggedIn();
            }

            Assert.AreEqual(result, expected);
        }

        private bool loginUser()
        {
            //user details, user the following details is manually recorded

            string username = "stharupesh";
            string password = "thehelp";

            return Auth.login(username, password);
        }
    }
}
