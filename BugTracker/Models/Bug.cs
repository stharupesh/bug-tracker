using System;
using System.Data;
using BugTracker.Services;
using BugTracker.Core.Database;

namespace BugTracker.Models
{
    class Bug : Model
    {
        // properties

        public int user_id;
        public string title;
        public int from_line_no;
        public int to_line_no;
        public string class_name;
        public string description;
        public int project_id;
        public string source_code;
        public DateTime bug_date;

        protected override string tableName
        {
            get
            {
                return "bugs";
            }
        }

        protected override string primaryKey
        {
            get
            {
                return "id";
            }
        }

        // sets the properties of a bug

        public Bug setProperties(int uid, string ttl, int fln, int tlo, string cname, string desc, int pid, string scode)
        {
            user_id = uid;
            title = ttl;
            from_line_no = fln;
            to_line_no = tlo;
            class_name = cname;
            description = desc;
            project_id = pid;
            source_code = this.escapeSingleQuote(scode);

            return this;
        }

        // resets the properties of a bug

        public void resetProperties()
        {
            user_id = 0;
            title = "";
            from_line_no = 0;
            to_line_no = 0;
            class_name = "";
            description = "";
            project_id = 0;
            source_code = "";
        }

        // saves the new bug to the database

        public void save()
        {
            bug_date = DateTime.Now;

            string keys = "user_id,title,from_line_no,to_line_no,class_name,description,project_id,source_code,bug_date";
            string values = user_id + ",'" + title + "'," + from_line_no + "," + to_line_no + ",'" + class_name + "','" + description + "'," + project_id + ",'" + source_code + "','" + bug_date.ToString("yyyy-MM-dd HH:MM:ss") + "'";

            this.create(keys, values);

            this.resetProperties();
        }

        // udpates the bug in the database

        public void updateBug(int bugId)
        {
            string setData = "title='" + title + "',from_line_no=" + from_line_no + ",to_line_no=" + to_line_no + ",class_name='" + class_name + "',description='" + description + "',project_id=" + project_id + ",source_code='" + source_code + "'";

            this.where("id=" + bugId).update(setData);

            this.resetProperties();
        }

        // returns the details of a single bug

        public DataTable getDetails(int id)
        {
            return this.select("user_id, title, description, CAST(bug_date as varchar) AS bug_date, 0 as is_fixed, project_type_name, class_name, project_description, source_code, CONCAT(users.first_name, ' ', users.last_name) as full_name, from_line_no, to_line_no, project_name")
                       .leftJoin("users", "users.id = bugs.user_id")
                       .leftJoin("(select p.id as project_id, project_name, project_type_id, project_type_name, project_description from projects p left join project_types pt on pt.id = p.project_type_id) as p2", "p2.project_id = bugs.project_id")
                       .where("bugs.id="+id)
                       .get();
        }

        // deletes the bug which are written by a particular user

        public void deleteBugsByUser(int userid)
        {
            this.where("user_id = " + userid)
                .delete();
        }

        // deletes all bugs of a project

        public void deleteBugsByProject(int projectId)
        {
            this.where("project_id = " + projectId)
                .delete();
        }

        // retuns all the bugs filtered by project type and search string

        public DataTable getList(int projectType, String search)
        {
            search = search.ToLower();

            return this.select("ROW_NUMBER() OVER(ORDER BY title ASC) AS sn, bugs.id as bug_id, user_id, title as bug_title, SUBSTRING(description, 0, 30) AS bug_desc, CAST(bug_date as varchar) AS bug_date, f2.count_fixes_correct as is_fixed, project_name, CONCAT(users.first_name, ' ', users.last_name) as full_name, COALESCE(action_label, 'View/Fix') as action_label, f1.count_fixes as total_fixes")
                       .leftJoin("users","users.id = bugs.user_id")
                       .leftJoin("(select bug_id, count(id) as count_fixes from fixes group by bug_id) as f1", "f1.bug_id = bugs.id")
                       .leftJoin("(select bug_id, count(id) as count_fixes_correct from fixes where status = 1 group by bug_id) as f2", "f2.bug_id = bugs.id")
                       .leftJoin("(select " + Auth.user("id") + " as uid, 'View/Edit/Fix' as action_label) as action_labels", "action_labels.uid = bugs.user_id")
                       .leftJoin("(select p.id as project_id, project_name, project_type_id, project_type_name from projects p left join project_types pt on pt.id = p.project_type_id) as p2", "p2.project_id = bugs.project_id")
                       .where("(title like '%" + search + "%' OR Lower(project_name) like '%" + search + "%' OR Lower(CONCAT(users.first_name, ' ', users.last_name)) like '%" + search + "%')" + ((projectType != 0)?" AND project_type_id="+projectType:""))
                       .get();
        }
    }
}
