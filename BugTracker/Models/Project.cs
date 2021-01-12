using System.Data;
using BugTracker.Core.Database;

namespace BugTracker.Models
{
    class Project : Model
    {
        public string project_name;
        public int project_type_id;
        public string project_description;

        protected override string tableName
        {
            get
            {
                return "projects";
            }
        }

        protected override string primaryKey
        {
            get
            {
                return "id";
            }
        }

        // returns only project name of a project by its id

        public string getProjectName(string id)
        {
            return this.find(id).Rows[0][1].ToString();
        }

        // retuns the project list for combo box

        public DataTable getComboList()
        {
            return this.select("projects.id as project_id, project_name, project_type_name")
                       .leftJoin("project_types", "project_types.id = projects.project_type_id")
                       .get();
        }

        // sets the properties of a project

        public Project setProperties(string pname, int ptypeid, string pdesc)
        {
            project_name = pname;
            project_type_id = ptypeid;
            project_description = pdesc;

            return this;
        }

        // returns the details of project

        public DataTable getDetails(int pid)
        {
            return this.find(pid.ToString());
        }

        // saves a new project in the database

        public void save()
        {
            string keys = "project_name,project_type_id,project_description";
            string values = "'" + project_name + "'," + project_type_id + ",'" + project_description + "'";

            this.create(keys, values);
        }

        // updates the project in the database

        public void updateProject(int projectId)
        {
            string setData = "project_name='" + project_name + "', project_type_id=" + project_type_id + ", project_description='" + project_description + "'";

            this.where("id=" + projectId)
                .update(setData);
        }

        // returns the list of projects by its project type and search string

        public DataTable getList(int projectType, string search)
        {
            return this.select("ROW_NUMBER() OVER(ORDER BY project_name ASC) AS sn, projects.id as project_id, project_name, project_description, project_type_name")
                       .leftJoin("project_types", "projects.project_type_id = project_types.id")
                       .where("(project_name like '%" + search + "%'" + ((projectType != 0)? " AND project_type_id = " + projectType : "") + ")")
                       .get();
        }
    }
}
