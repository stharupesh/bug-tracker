using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BugTracker.Core;

namespace BugTracker.Validators
{
    class PasswordFormValidator : Validator
    {
        // validator for password form

        private Dictionary<string, string> rulesList = new Dictionary<string, string>
                        {
                            { "currPassTxt", "required|minlength:6|maxlength:20" },
                            { "newPassTxt", "required|minlength:6|maxlength:20" },
                            { "confirmNewPassTxt", "required|matchinput:newPassTxt" }
                        };

        public PasswordFormValidator(Form formRef, ErrorProvider err) : base(formRef, err)
        {

        }

        protected override Dictionary<String, String> rulesArr()
        {
            return rulesList;
        }

        protected override Dictionary<String, String> messagesArr()
        {
            return new Dictionary<string, string>
                        {
                            { "confirmNewPassTxt.matchinput", "Password confirmation failed" }
                        };
        }

        // removes the validation of checking current password, used by admin for changing the password

        public void withoutCurrentPassValidation()
        {
            this.rulesList.Remove("currPassTxt");
        }
    }
}
