using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class DBConnection
    {
        private readonly string connectionString;
        public DBConnection()
        {
            string server = "localhost\\SQLEXPRESS", user = "MangoStudios", password = "Frank0089hdez@", database = "INTERLENSSV";
           // string server = "(localdb)\\mssqllocaldb", database = "INTERLENSSV";
            connectionString = "Server=" + server + ";User ID=" + user + ";Password=" + password+";Initial Catalog="+database+";Integrated Security=True";
           // connectionString = "Server=" + server + ";Initial Catalog=" + database + ";Integrated Security=True";

        }
        
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
