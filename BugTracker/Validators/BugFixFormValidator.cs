using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BugTracker.Core;

namespace BugTracker.Validators
{
    class BugFixFormValidator : Validator
    {
        // validator for bug fix form

        public BugFixFormValidator(Form formRef, ErrorProvider err) : base(formRef, err)
        {

        }

        protected override Dictionary<String, String> rulesArr()
        {
            return new Dictionary<string, string>
                        {
                            { "titleTxt", "required|minlength:5|maxlength:50" },
                            { "descTxt", "required|minlength:5|maxlength:150" }
                        };
        }
    }
}
