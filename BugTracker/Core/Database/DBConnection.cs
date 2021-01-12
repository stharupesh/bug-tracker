using System;
using System.Data.SqlClient;
using BugTracker.Configuration.Config;

namespace BugTracker.Core.Database
{
    public class DBConnection
    {
        public static bool isTesting = false; // for testing mode, rollback the transactions

        public static SqlConnection con;

        static public SqlConnection get()
        {
            return con;
        }

        static public void set(String db)
        {
            con = new SqlConnection("Data Source= " + Config.SERVER + ";Initial Catalog=" + db + ";Integrated Security=False;User ID=" + Config.USERID + ";Password=" + Config.PASSWORD + ";Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        static public void setDefault()
        {
            set(Config.DB);
        }
    }
}
