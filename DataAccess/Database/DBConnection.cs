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
            bool DEVELOPMENT_MODE = false;
            string server, user, password, database;

            if (DEVELOPMENT_MODE == true)
            {
                server = "localhost\\SQLEXPRESS";
                user = "MangoStudios";
                password = "Frank0089hdez@";
                database = "INTERLENSSV";
            }
            else
            {
                server = "WILFREDO";
                user = "InterlenssvNetwork";
                password = "Frank0089hdez@";
                database = "INTERLENSSV";
            }
            connectionString = "Server=" + server + ";User ID=" + user + ";Password=" + password+";Initial Catalog="+database+";Integrated Security=False";

        }
        
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
