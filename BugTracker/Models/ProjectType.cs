using System.Data;
using BugTracker.Core.Database;

namespace BugTracker.Models
{
    class ProjectType : Model
    {
        public string project_type_name;

        protected override string tableName
        {
            get
            {
                return "project_types";
            }
        }

        protected override string primaryKey
        {
            get
            {
                return "id";
            }
        }

        // returns the project type name by project type id

        public string getTypeName(string id)
        {
            return this.find(id).Rows[0][1].ToString();
        }

        // returns the list of project types for using in combo box

        public DataTable getComboList()
        {
            return this.get();
        }

        // sets the project type property

        public ProjectType setProjectTypeName(string utype)
        {
            project_type_name = utype;

            return this;
        }

        // saves the new projec type in the database

        public void save()
        {
            this.create("project_type_name", project_type_name);
        }
    }
}
