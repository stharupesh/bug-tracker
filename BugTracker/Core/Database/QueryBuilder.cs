using System;

namespace BugTracker.Core.Database
{
    static class QueryBuilder
    {
        // generates select query

        static public String selectQuery(String tableName, String columns, String joinQuery, String whereQry, String OrderTypeQry)
        {
            return "SELECT " + columns + " FROM " + tableName + " " + joinQuery + " " + whereQry + " " + OrderTypeQry;
        }

        // generates insert query

        static public String insertQuery(String tableName, String columns, String Values)
        {
            return "INSERT INTO " + tableName + "(" + columns + ")" + " VALUES(" + Values + ")";
        }

        // generates update query

        static public String updateQuery(String tableName, String setData, String whereQry)
        {
            return "UPDATE " + tableName + " SET " + setData + " " + whereQry;
        }

        //generaters delte query

        static public String deleteQuery(String tableName, String whereQry)
        {
            return "DELETE FROM " + tableName + " " + whereQry;
        }
    }
}
