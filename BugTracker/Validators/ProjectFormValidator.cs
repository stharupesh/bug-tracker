using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BugTracker.Core;

namespace BugTracker.Validators
{
    class ProjectFormValidator : Validator
    {
        // validator for project add form, also used in project edit

        public ProjectFormValidator(Form formRef, ErrorProvider err) : base(formRef, err)
        {

        }

        protected override Dictionary<String, String> rulesArr()
        {
            return new Dictionary<string, string>
                        {
                            { "pNameTxt", "required|minlength:5|maxlength:30" },
                            { "descTxt", "required|minlength:5|maxlength:150" }
                        };
        }
    }
}
