using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BugTracker.Core;

namespace BugTracker.Validators
{
    class RegistrationFormValidator : Validator
    {
        // validator for user registration form form

        public RegistrationFormValidator(Form formRef, ErrorProvider err) : base(formRef, err)
        {

        }

        protected override Dictionary<String, String> rulesArr()
        {
            return new Dictionary<string, string>
                        {
                            { "fnameTxt", "required|minlength:3|maxlength:20" },
                            { "lnameTxt", "required|minlength:3|maxlength:20" },
                            { "emailTxt", "required|email|maxlength:100" },
                            { "unameTxt", "required|minlength:3|maxlength:20|unique:users,user_name.string" },
                            { "passTxt", "required|minlength:6|maxlength:20" },
                            { "confirmPassTxt", "required|matchinput:passTxt" }
                        };
        }

        protected override Dictionary<String, String> messagesArr()
        {
            return new Dictionary<string, string>
                        {
                            { "confirmPassTxt.matchinput", "Password confirmation failed" },
                            { "unameTxt.unique", "Username already exist in the database" }
                        };
        }
    }
}
