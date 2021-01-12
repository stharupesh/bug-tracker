using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BugTracker.Core;

namespace BugTracker.Validators
{
    class BugAddFormValidator : Validator
    {
        // validator for bug add form

        public BugAddFormValidator(Form formRef, ErrorProvider err) : base(formRef, err)
        {

        }

        protected override Dictionary<String, String> rulesArr()
        {
            return new Dictionary<string, string>
                        {
                            { "titleTxt", "required|minlength:5|maxlength:50" },
                            { "descTxt", "required|minlength:5|maxlength:150" },
                            { "cnameTxt", "required|minlength:3|maxlength:20" },
                            { "fromlineTxt", "required|double|maxlength:99999999|lessthaninput:tolineTxt" },
                            { "tolineTxt", "required|double|maxlength:99999999" }
                        };
        }
        protected override Dictionary<String, String> messagesArr()
        {
            return new Dictionary<string, string>
                        {
                            { "fromlineTxt.lessthaninput", "Should be less than to line" }
                        };
        }
    }
}
