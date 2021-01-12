using System;
using System.Data;
using BugTracker.Core.Database;

namespace BugTracker.Models
{
    class Fix : Model
    {
        // properties

        public int bug_id;
        public int user_id;
        public DateTime fix_date;
        public string fix_title;
        public string fix_desc;
        public string fix_source_code;
        public int status;

        protected override string tableName
        {
            get
            {
                return "fixes";
            }
        }

        protected override string primaryKey
        {
            get
            {
                return "id";
            }
        }

        // sets the properties of a bug fix

        public Fix setProperties(int bid, int uid, string ftitle, string fdesc, string fsourcecode)
        {
            bug_id = bid;
            user_id = uid;
            fix_title = ftitle;
            fix_desc = fdesc;
            fix_source_code = this.escapeSingleQuote(fsourcecode);

            return this;
        }

        // resets the properties of a fix

        public void resetProperties()
        {
            bug_id = 0;
            user_id = 0;
            fix_title = "";
            fix_desc = "";
            fix_source_code = "";
            status = 0;
        }

        // saves a new fix in the database

        public void save()
        {
            fix_date = DateTime.Now;
            status = 3; // pending

            string keys = "bug_id,user_id,fix_date,fix_title,fix_desc,fix_source_code,status";
            string values = bug_id + "," + user_id + ",'" + fix_date.ToString("yyyy-MM-dd HH:MM:ss") + "','" + fix_title + "','" + fix_desc + "','" + fix_source_code + "'," + status;

            this.create(keys, values);

            this.resetProperties();
        }

        // udpates the fix in the database

        public void updateFix(int fixId)
        {
            string setData = "fix_title='" + fix_title + "', fix_desc='" + fix_desc + "', fix_source_code='" + fix_source_code + "'";

            this.where("id=" + fixId)
                .update(setData);
        }

        // changes the status of a fix in the database

        public void changeStatus(int fixId, int statusValue)
        {
            this.where("id=" + fixId)
                .update("status=" + statusValue);
        }

        // deletes all the fixes written by a user

        public void deleteFixesByUser(int userid)
        {
            this.where("user_id = " + userid)
                .delete();
        }

        // deletes all fixes of a bug

        public void deleteFixesByBug(int bugid)
        {
            this.where("bug_id = " + bugid)
                .delete();
        }

        // deletes all fixes of the bugs of a project

        public void deleteFixesByProject(int projectId)
        {
            this.where("fixes.bug_id IN (select bugs.id from bugs where project_id = " + projectId + ")")
                .delete();
        }

        // retuns full fix status name

        public string getFullFixStatus(int status)
        {
            switch (status)
            {
                case 1:
                    return "Correct";

                case 2:
                    return "Incorrect";

                default:
                    return "Pending";
            }
        }

        // returns the status list for combo box from temporary table

        public DataTable getStatusList()
        {
            DB dbCore = new DB();

            return dbCore.rawSelect("select 1 as id, 'Correct' as status_name union select 2 as id, 'Incorrect' as status_name union select 3 as id, 'Pending' as status_name");
        }

        // returns the details of a fix

        public DataTable getDetails(int id)
        {
            return this.select("fixes.user_id, fix_title, fix_desc, status, bug_title, CONCAT(users.first_name, ' ', users.last_name) as full_name, CAST(fix_date AS varchar) AS fix_date, fix_source_code, project_type_name, fixes.status, p2.user_id as bug_author")
                       .leftJoin("users", "users.id = fixes.user_id")
                       .leftJoin("(select bugs.id as bug_id, bugs.title as bug_title, project_type_name, bugs.user_id from bugs left join projects p on bugs.project_id = p.id left join project_types pt on pt.id = p.project_type_id) as p2", "p2.bug_id = fixes.bug_id")
                       .where("fixes.id = " + id)
                       .get();
        }

        // returns all the fixes of a bug

        public DataTable getFixesOfABug(int bugId, string search)
        {
            return this.select("ROW_NUMBER() OVER(ORDER BY fix_title ASC) AS sn, fixes.id as fix_id, user_id, CAST(fix_date as varchar) fix_date, fix_title, fix_desc, CONCAT(users.first_name, ' ', users.last_name) as full_name, fix_status_name")
                       .leftJoin("(select 1 as id, 'Correct' as fix_status_name union select 2 as id, 'Incorrect' as fix_status_name union select 3 as id, 'Pending' as fix_status_name) as fix_status", "fix_status.id = fixes.status")
                       .leftJoin("users", "users.id = fixes.user_id")
                       .where("bug_id=" + bugId + " AND fix_title like '%" + search + "%'")
                       .get();
        }
    }
}
