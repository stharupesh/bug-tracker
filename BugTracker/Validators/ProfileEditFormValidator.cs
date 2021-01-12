using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BugTracker.Core;

namespace BugTracker.Validators
{
    class ProfileEditFormValidator : Validator
    {
        // validator for edit profile form

        private Dictionary<string, string> rulesList = new Dictionary<string, string>
                        {
                            { "fnameTxt", "required|minlength:3|maxlength:20" },
                            { "lnameTxt", "required|minlength:3|maxlength:20" },
                            { "emailTxt", "required|email|maxlength:100" },
                            { "unameTxt", "required|minlength:3|maxlength:20|unique:users,user_name.string" }
                        };

        public ProfileEditFormValidator(Form formRef, ErrorProvider err) : base(formRef, err)
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
                            { "unameTxt.unique", "Username already exist in the database" }
                        };
        }

        // remvoves the validation  for unique username in database

        public void withoutUniqueUsernameValidation()
        {
            this.rulesList["unameTxt"] = "required|minlength:3";
        }
    }
}
