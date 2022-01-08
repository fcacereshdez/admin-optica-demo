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
            connectionString = "Server=(localdb)\\mssqllocaldb;Database=INTERLENSSV; integrated security=true";
        }
        
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
