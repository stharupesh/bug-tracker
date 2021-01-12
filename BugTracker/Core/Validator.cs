using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;
using BugTracker.Core.Database;

namespace BugTracker.Core
{
    class Validator
    {
        // Core Validator

        private Form frm; // storing the reference of the form where the validation need to be done
        private DB db = new DB(); // used if some validation like unique username needs to be done
        private ErrorProvider errors; // reference of error provider of the form
        private Dictionary<String, String> rules; // list of rules
        private Dictionary<String, String> messages; // list of messages for errors

        public Validator(Form formRef, ErrorProvider err)
        {
            this.rules = this.rulesArr(); // fetching the rules, rulesArr() is overrided by the instance of this class

            this.messages = this.messagesArr();

            this.frm = formRef;

            this.errors = err;

            this.resetErrors(); // resetting the errors at first
        }

        // override by child class

        protected virtual Dictionary<String, String> rulesArr()
        {
            return null;
        }

        // override by child class

        protected virtual Dictionary<String, String> messagesArr()
        {
            return null;
        }

        // validates the form

        public Boolean validate()
        {
            this.resetErrors();

            String inputName;
            String rule;
            Control ctrl;
            String[] rulesInline;
            String error;
            Boolean valid = true;

            foreach (KeyValuePair<String, String> input in this.rules)
            {
                inputName = input.Key;
                rule = input.Value;
                ctrl = this.getControl(input.Key);

                rulesInline = rule.Split('|');

                error = this.processValidation(rulesInline, inputName, ctrl.Text);

                if (error == "")
                {

                }
                else
                {
                    valid = false;

                    this.errors.SetError(ctrl, error);
                }
            }

            return valid;
        }

        // sets error the the control

        public void setError(String controlName, String errorText)
        {
            this.errors.SetError(this.getControl(controlName), errorText);
        }

        // returns the reference of the control by its name

        protected Control getControl(String name)
        {
            return this.frm.Controls.Find(name, true)[0];
        }

        // resets the errors in the form

        private void resetErrors()
        {
            errors.Clear();
        }

        // process the validation

        private String processValidation(String[] rulesInline, String inputName, String value)
        {
            String customMsg = "";

            for (int i = 0; i < rulesInline.Length; i++)
            {
                String[] rulesWithParams = rulesInline[i].Split(':');
                String ruleName = rulesWithParams[0];

                if (rulesWithParams.Length == 1) // rules without parameters
                {
                    switch (ruleName)
                    {
                        case "required":
                            {
                                if (this.isEmptyString(value))
                                {
                                    customMsg = this.getCustomMessage(inputName, ruleName);

                                    if(this.isEmptyString(customMsg))
                                        return "* Required";

                                    return customMsg;
                                }
                            }
                            break;

                        case "double":
                            {
                                if (!this.isDouble(value))
                                {
                                    customMsg = this.getCustomMessage(inputName, ruleName);

                                    if (this.isEmptyString(customMsg))
                                        return "Only numeric value allowed";

                                    return customMsg;
                                }
                            }
                            break;

                        case "email":
                            {
                                if (!this.isEmail(value))
                                {
                                    customMsg = this.getCustomMessage(inputName, ruleName);

                                    if (this.isEmptyString(customMsg))
                                        return "Invalid email";

                                    return customMsg;
                                }
                            }
                            break;
                    }
                }
                else // rules with parameters
                {
                    String param = rulesWithParams[1];

                    switch (ruleName)
                    {
                        case "minlength":
                            {
                                int min = int.Parse(param);

                                if (value.Length < min)
                                {
                                    customMsg = this.getCustomMessage(inputName, ruleName);

                                    if (this.isEmptyString(customMsg))
                                        return "Minimum length is " + min;

                                    return customMsg.Replace(":min", min.ToString());
                                }
                            }
                            break;

                        case "maxlength":
                            {
                                int max = int.Parse(param);

                                if (value.Length > max)
                                {
                                    customMsg = this.getCustomMessage(inputName, ruleName);

                                    if (this.isEmptyString(customMsg))
                                        return "Maximum length is " + max;

                                    return customMsg.Replace(":max", max.ToString());
                                }
                            }
                            break;

                        case "lessthaninput":
                            {
                                if (int.Parse(value) > int.Parse(this.getControl(param).Text))
                                {
                                    customMsg = this.getCustomMessage(inputName, ruleName);

                                    if (this.isEmptyString(customMsg))
                                        return "Should be less than the value of " + param;

                                    return customMsg.Replace(":input", param.ToString());
                                }
                            }
                            break;

                        case "matchinput":
                            {
                                if (value != this.getControl(param).Text)
                                {
                                    customMsg = this.getCustomMessage(inputName, ruleName);

                                    if (this.isEmptyString(customMsg))
                                        return "Should be equal to the value of " + param;

                                    return customMsg.Replace(":input", param.ToString());
                                }
                            }
                            break;

                        case "unique": // checks uniquess in the database
                            {
                                string[] paramArr = param.Split(',');

                                string tableName = paramArr[0];

                                string[] searchArr = paramArr[1].Split('.'); // column name and data type

                                if (!this.checkUniquenessInDB(tableName, searchArr[0], searchArr[1], value))
                                {
                                    customMsg = this.getCustomMessage(inputName, ruleName);

                                    if (this.isEmptyString(customMsg))
                                        return "Should be equal to the value of " + param;

                                    return customMsg.Replace(":input", param.ToString());
                                }
                            }
                            break;
                    }
                }
            }
            return "";
        }

        // returns the custom error message if set

        private String getCustomMessage(String inputName, String ruleName)
        {
            String specificInputRule = inputName + "." + ruleName;

            if (this.messages != null)
            {
                if (this.messages.ContainsKey(specificInputRule))
                    return this.messages[specificInputRule];

                if (this.messages.ContainsKey(ruleName))
                    return this.messages[ruleName];
            }

            return "";
        }

        // checks if the string is empty

        private bool isEmptyString(String value)
        {
            return (value == "");
        }

        // checks if the string is numeric

        private bool isDouble(String value)
        {
            double a;

            return double.TryParse(value, out a);
        }
        
        // validates the email

        private bool isEmail(String email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        // check uniqueness in database like unique username in register form

        private bool checkUniquenessInDB(String tableName, String columnName, String dataType, String value)
        {
            if (dataType == "string")
                value = "'" + value + "'";

            int count = this.db.table(tableName)
                               .where(columnName + " = " + value)
                               .count();

            return (count == 0);
        }
    }
}
