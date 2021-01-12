using System;
using System.Data;

namespace BugTracker.Core.Database
{
    abstract class Model
    {
        abstract protected String tableName { get; }
        abstract protected String primaryKey { get; }

        private DB db = new DB();

        public Model()
        {
            this.db.table(this.tableName);
        }

        // insert data in the database

        public void create(String columns, String values)
        {
            this.db.create(columns, values);
        }

        // finds the first data by its primary key

        public DataTable find(String id)
        {
            return this.db.where(this.primaryKey + "=" + id).get();
        }

        // udpates the data

        public void update(String setData)
        {
            this.db.update(setData);
        }

        // deletes the record by primary key

        public void destroy(String id)
        {
            this.db.where(this.primaryKey + "=" + id).delete();
        }

        // deletes the record

        public void delete()
        {
            this.db.delete();
        }

        // left join on a table

        public Model leftJoin(String joinTable, String condition)
        {
            this.db.leftJoin(joinTable, condition);

            return this;
        }

        // right join on a table

        public Model rightJoin(String joinTable, String condition)
        {
            this.db.rightJoin(joinTable, condition);

            return this;
        }

        // inner join on a table

        public Model innerJoin(String joinTable, String condition)
        {
            this.db.innerJoin(joinTable, condition);

            return this;
        }

        // sets where query

        public Model where(String whereQry)
        {
            this.db.where(whereQry);

            return this;
        }

        // sets the columns

        public Model select(String columns)
        {
            this.db.select(columns);

            return this;
        }

        // sets the order by

        public Model orderBy(String orderType)
        {
            this.db.orderBy(orderType);

            return this;
        }

        // counts the result data

        public int count()
        {
            return this.db.count();
        }

        // returns data

        public DataTable get()
        {
            return this.db.get();
        }

        // escapes the single quote

        public string escapeSingleQuote(string input)
        {
            return this.db.escapeSingleQuote(input);
        }
    }
}
