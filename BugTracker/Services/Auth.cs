using System;
using System.Data;
using BugTracker.Models;
using System.Windows.Forms;

namespace BugTracker.Services
{
    public class Auth
    {
        private static DataRow currUser = null;
        private static User userModel = new User();
        private static UserType userType = new UserType();

        public static bool login(string username, string password)
        {
            password = encryptPassword(password);

            DataTable foundUser = userModel.getUser(username, password);

            if (foundUser.Rows.Count == 0)
                return false;

            currUser = foundUser.Rows[0];

            return true;
        }

        public static bool loginUsingId(int userId)
        {
            DataTable foundUser = userModel.find(userId.ToString());

            if (foundUser.Rows.Count == 0)
                return false;

            currUser = foundUser.Rows[0];

            return true;
        }

        public static bool isLoggedIn()
        {
            return (currUser != null);
        }

        public static bool isTester()
        {
            return (user("user_type_id") == "1");
        }

        public static bool isProgrammer()
        {
            return (user("user_type_id") == "2");
        }

        public static bool isDeveloper()
        {
            return (user("user_type_id") == "3");
        }

        public static bool isAdmin()
        {
            return (user("user_type_id") == "4");
        }

        public static bool isActive()
        {
            return (user("status") == "True");
        }

        public static String encryptPassword(String rawPass)
        {
            return MD5Encrypter.encryptString(rawPass);
        }

        public static String user(String prop)
        {
            String val;

            switch (prop)
            {
                case "id":
                    val = currUser[0].ToString();
                    break;

                case "user_name":
                    val = currUser[1].ToString();
                    break;

                case "first_name":
                    val = currUser[3].ToString();
                    break;

                case "last_name":
                    val = currUser[4].ToString();
                    break;

                case "full_name":
                    val = currUser[3].ToString() + " " + currUser[4].ToString();
                    break;

                case "user_type_id":
                    val = currUser[5].ToString();
                    break;

                case "user_type_name":
                    {
                        String userTypeId = currUser[5].ToString();

                        val = userType.getTypeName(userTypeId).Trim();
                    }
                    break;

                case "gender":
                    val = currUser[6].ToString();
                    break;

                case "gender_name":
                    {
                        if (currUser[6].ToString() == "1")
                            val = "Male";
                        else
                            val = "Female";
                    }
                    break;

                case "email":
                    val = currUser[7].ToString();
                    break;

                case "status":
                    val = currUser[8].ToString();
                    break;


                default:
                    {
                        val = "";
                    }
                    break;
            }

            return val;
        }
    
        public static void logout()
        {
            currUser = null;
        }
    }
}
