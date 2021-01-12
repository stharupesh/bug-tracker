using System;
using System.Data;
using System.Windows.Forms;
using BugTracker.Models;
using BugTracker.Services;
using BugTracker.Validators;

namespace BugTracker.Controllers
{
    public class UserCtrl
    {
        // Models
        
        private User user = new User();
        private UserType userType = new UserType();

        // Validators

        private LoginFormValidator loginValidator;
        private RegistrationFormValidator registrationValidator;
        private ProfileEditFormValidator profileEditFormValidator;
        private PasswordFormValidator passwordFormValidator;

        // returns the user types list for user type combo box

        public DataTable getUserTypeList()
        {
            return this.userType.getComboList();
        }

        // return the user details for user edit

        public DataTable getUserDetails(int userid)
        {
            return this.user.find(userid.ToString());
        }

        /***** USER LOGIN *****/

        public bool login(Form formRef, ErrorProvider err, string username, string password)
        {
            loginValidator = new LoginFormValidator(formRef, err);

            if (loginValidator.validate())
            {
                if (!Auth.login(username, password))
                {
                    loginValidator.setError("usernameTxt", "Invalid Credentials!!");

                    return false;
                }

                if (!Auth.isActive())
                {
                    Auth.logout();

                    loginValidator.setError("usernameTxt", "User is Inactive!!");

                    return false;
                }

                return true;
            }

            return false;
        }

        /***** USER REGISTRATION *****/

        public bool validateRegistrationForm(Form formRef, ErrorProvider errProvider) // validating user registration
        {
            registrationValidator = new RegistrationFormValidator(formRef, errProvider);

            return registrationValidator.validate();
        }

        // registering user

        public bool registerUser(string fname, string lname, string email, int gender, string uname, string pass, int utype)
        {
            try
            {
                this.user.setProperties(uname, fname, lname, utype, gender, email)
                            .setPassword(pass)
                            .save();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());

                return false;
            }
        }

        /***** USER PROFILE *****/

        public bool validateOwnProfileEditForm(Form formRef, ErrorProvider errProvider, string previousUserName, string uname) // user profile edit validation
        {
            profileEditFormValidator = new ProfileEditFormValidator(formRef, errProvider);

            if (previousUserName == uname)
                profileEditFormValidator.withoutUniqueUsernameValidation();

            return profileEditFormValidator.validate();
        }

        // update the profile of currently logged in user

        public bool updateOwnProfile(int userId, string fname, string lname, string email, int gender, string uname, int utype)
        {
            try
            {
                this.user.setProperties(uname, fname, lname, utype, gender, email)
                         .updateProfile(userId);

                Auth.loginUsingId(userId);

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());

                return false;
            }
        }

        /***** USER PASSWORD CHANGE *****/

        public bool validateChangeOwnPasswordForm(Form formRef, ErrorProvider errProvider, int userId, string currPass, bool byAdmin) // validate the password change form
        {
            passwordFormValidator = new PasswordFormValidator(formRef, errProvider);

            if (byAdmin)
                passwordFormValidator.withoutCurrentPassValidation();

            if (passwordFormValidator.validate())
            {
                if (byAdmin)
                    return true;

                if (this.user.matchesPassword(userId, currPass))
                    return true;

                passwordFormValidator.setError("currPassTxt", "Current Password doesn't match");
            }

            return false;
        }

        // change the password of the user

        public bool changePassword(int userId, string newPass)
        {
            try
            {
                this.user.setPassword(newPass)
                            .updatePassword(userId);

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());

                return false;
            }
        }

        /***** USER MANAGE BY ADMIN *****/

        public bool changeUserStatus(int userId, int status) // changing the user status
        {
            try
            {
                this.user.changeStatus(userId, status);

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());

                return false;
            }
        }

        // delete user

        public bool deleteUser(int uid)
        {
            try
            {
                new Bug().deleteBugsByUser(uid);
                new Fix().deleteFixesByUser(uid);
                this.user.destroy(uid.ToString());

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());

                return false;
            }
        }

        // returns the list of users except admin

        public DataTable getUserList(int uType, string search)
        {
            return this.user.getList(uType, search);
        }
    }
}