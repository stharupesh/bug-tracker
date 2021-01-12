using System.Data;
using BugTracker.Services;
using BugTracker.Core.Database;

namespace BugTracker.Models
{
    class User: Model
    {
        public string user_name;
        public string first_name;
        public string last_name;
        public int user_type_id;
        public int gender;
        public string email;
        private int active = 1;
        private string password;

        protected override string tableName
        {
            get
            {
                return "users";
            }
        }

        protected override string primaryKey
        {
            get
            {
                return "id";
            }
        }

        // returns the user data by username and password

        public DataTable getUser(string username, string password)
        {
            return this.where("user_name='" + username + "' AND password='" + password + "'")
                                           .get();
        }

        // sets the properties of a user

        public User setProperties(string uname, string fname, string lname, int utype, int gen, string em)
        {
            user_name = uname;
            first_name = fname;
            last_name = lname;
            user_type_id = utype;
            gender = gen;
            email = em;

            return this;
        }

        // resets the properties

        public void resetProperties()
        {
            user_name = "";
            first_name = "";
            last_name = "";
            user_type_id = 1;
            gender = 1;
            email = "";
            password = "";
            active = 1;
        }

        // saves a new user to the database

        public void save()
        {
            string keys = "user_name,password,first_name,last_name,user_type_id,gender,email,active";

            string values = "'" + user_name + "','" + password + "','" + first_name + "','" + last_name + "'," + user_type_id + "," + gender + ",'" + email + "'," + active;

            this.create(keys, values);

            this.resetProperties();
        }

        // udpates the profiles of a user

        public void updateProfile(int id)
        {
            string setData = "user_name='" + user_name + "',first_name='" + first_name + "',last_name='" + last_name + "',user_type_id=" + user_type_id + ",gender=" + gender + ",email='" + email + "'";

            this.where("id=" + id).update(setData);

            this.resetProperties();
        }

        // sets the password by encrypting

        public User setPassword(string rawPass)
        {
            this.password = Auth.encryptPassword(rawPass);

            return this;
        }

        // updates the password of a user

        public void updatePassword(int id)
        {
            string setData = "password='" + this.password + "'";

            this.where("id=" + id).update(setData);

            this.resetProperties();
        }

        // changes the status of a user

        public void changeStatus(int uid, int status)
        {
            string setData = "active=" + status;

            this.where("id=" + uid).update(setData);
        }

        // matches the encrypted password in the database

        public bool matchesPassword(int userid, string rawPass)
        {
            string currEncryptedPass = this.find(userid.ToString()).Rows[0][2].ToString();

            return (currEncryptedPass == Auth.encryptPassword(rawPass));
        }

        // returns the list of users from the database except admin

        public DataTable getList(int uType, string search)
        {
            return this.select("ROW_NUMBER() OVER(ORDER BY user_name ASC) AS sn, users.id as user_id, user_name, CONCAT(users.first_name, ' ', users.last_name) as full_name, user_type_name, email, status_labels.status, status_labels.action, gender_name")
                       .leftJoin("user_types", "users.user_type_id = user_types.id")
                       .leftJoin("(select 1 as id, 'Male' as gender_name union select 2 as id, 'Female' as gender_name) as gender_types", "gender_types.id = users.gender")
                       .leftJoin("(select 0 as id, 'Inactive' as status, 'Activate' as action union select 1 as id, 'Active' as status, 'Disactivate' as action) as status_labels", "status_labels.id = users.active")
                       .where("((first_name like '%" + search + "%' OR last_name like '%" + search + "%' OR email like '%" + search + "%' OR gender like '%" + search + "%') AND users.user_type_id <> 4 " + ((uType != 0) ? " AND user_type_id = " + uType : "") + ")")
                       .get();
        }
    }
}
