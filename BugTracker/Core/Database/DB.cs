using System;
using System.Data;
using System.Data.SqlClient;

namespace BugTracker.Core.Database
{
    class DB
    {
        private String tableName; // table name

        private SqlCommand cmd = new SqlCommand();
        private SqlConnection con;

        private String whereQry; // storing where query
        private String joinQry; // storing the join queries
        private String orderTypeQry; // storing the order type query
        private String columns; // storing the columns

        private DataSet ds;
        private SqlDataAdapter da;

        public DB()
        {
            this.reset(); // reset all the variables
        }

        private void reset()
        {
            this.whereQry = "";
            this.orderTypeQry = "";
            this.columns = "*";
            this.joinQry = "";
        }

        // executes the passed query

        private void executeQuery(String qry)
        {
            SqlTransaction trans = null;
            con = DBConnection.get();

            con.Open();

            cmd.Connection = con;

            if (DBConnection.isTesting) // if testing mode then, rollback later
            {
                trans = con.BeginTransaction("TestTrans");

                cmd.Transaction = trans;
            }

            cmd.CommandText = qry;
            cmd.ExecuteNonQuery();

            if (DBConnection.isTesting)
            {
                trans.Rollback();
            }

            con.Close();

            this.reset();
        }

        // sets the table name

        public DB table(String tableName)
        {
            this.tableName = tableName;

            return this;
        }

        // left join the table with another

        public DB leftJoin(String joiningTable, String condition)
        {
            this.joinQry += " LEFT JOIN " + joiningTable + " ON " + condition;

            return this;
        }

        // add inner join to the current join query

        public DB innerJoin(String joiningTable, String condition)
        {
            this.joinQry += " INNER JOIN " + joiningTable + " ON " + condition;

            return this;
        }

        // adds right join to the current join query

        public DB rightJoin(String joiningTable, String condition)
        {
            this.joinQry += " RIGHT JOIN " + joiningTable + " ON " + condition;

            return this;
        }

        // sets the where query

        public DB where(String expression)
        {
            this.whereQry = "WHERE " + expression;

            return this;
        }

        // sets the order by query

        public DB orderBy(String orderType)
        {
            this.orderTypeQry = "ORDER BY " + orderType;

            return this;
        }

        // sets the columns

        public DB select(String columns)
        {
            this.columns = columns;

            return this;
        }

        // creates a record

        public void create(String columns, String values)
        {
            String insertQry = QueryBuilder.insertQuery(tableName, columns, values);

            this.executeQuery(insertQry);
        }

        // updates the record in the database

        public void update(String setData)
        {
            String updateQry = QueryBuilder.updateQuery(tableName, setData, whereQry);

            this.executeQuery(updateQry);
        }

        // deletes the record in the database

        public void delete()
        {
            String deleteQry = QueryBuilder.deleteQuery(tableName, whereQry);

            this.executeQuery(deleteQry);
        }

        // for writing raw insert query

        public void rawCreate(String insertQuery)
        {
            this.executeQuery(insertQuery);
        }

        // for writing raw update query

        public void rawUpdate(String updateQuery)
        {
            this.executeQuery(updateQuery);
        }

        // for writing raw delete

        public void rawDelete(String deleteQuery)
        {
            this.executeQuery(deleteQuery);
        }

        // for writing the raw select query

        public DataTable rawSelect(String selectQuery)
        {
            con = DBConnection.get();

            ds = new DataSet();

            da = new SqlDataAdapter(selectQuery, con);

            da.Fill(ds);

            this.reset();

            return ds.Tables[0];
        }

        // returns the count of the select query result

        public int count()
        {
            return this.get().Rows.Count;
        }

        // returns the data from the database

        public DataTable get()
        {
            con = DBConnection.get();

            ds = new DataSet();
            
            String selectQry = QueryBuilder.selectQuery(tableName, columns, joinQry, whereQry, orderTypeQry);
            
            da = new SqlDataAdapter(selectQry, con);

            da.Fill(ds);

            this.reset();

            return ds.Tables[0];
        }

        // escapes the single quote from the input

        public string escapeSingleQuote(string input)
        {
            return input.Replace("'", "''");
        }
    }
}
