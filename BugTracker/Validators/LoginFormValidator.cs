using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BugTracker.Core;

namespace BugTracker.Validators
{
    class LoginFormValidator : Validator
    {
        // validator for login form

        public LoginFormValidator(Form formRef, ErrorProvider err) : base(formRef, err)
        {

        }

        protected override Dictionary<String, String> rulesArr()
        {
            return new Dictionary<string, string>
                        {
                            { "usernameTxt", "required|minlength:3" },
                            { "passwordTxt", "required|minlength:6" }
                        };
        }
    }
}
