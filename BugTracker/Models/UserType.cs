using System.Data;
using BugTracker.Core.Database;

namespace BugTracker.Models
{
    class UserType : Model
    {
        public string user_type_name;

        protected override string tableName
        {
            get
            {
                return "user_types";
            }
        }

        protected override string primaryKey
        {
            get
            {
                return "id";
            }
        }

        // returns the user type name by user type id

        public string getTypeName(string id)
        {
            return this.find(id).Rows[0][1].ToString();
        }

        // retuns the user types to user in combo box

        public DataTable getComboList()
        {
            return this.where("id <> 4")
                       .get();
        }

        // sets the user type name property

        public UserType setUserTypeName(string utype)
        {
            user_type_name = utype;

            return this;
        }

        // adds a new user type in the databaser

        public void save()
        {
            this.create("user_type_name", user_type_name);
        }
    }
}