using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ReportsData : DBConnection
    {
        public DataTable GetSalesBook()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "GetSalesBook";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderSales = cmd.ExecuteReader();
                    DataTable TableSales = new DataTable();
                    TableSales.Load(ReaderSales);
                    conn.Close();
                    return TableSales;
                }
            }

        }
        public DataTable GetAuditAllUsers()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "AuditAllUsers";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderActions = cmd.ExecuteReader();
                    DataTable TableUsers = new DataTable();
                    TableUsers.Load(ReaderActions);
                    conn.Close();
                    return TableUsers;
                }
            }

        }

        public DataTable GetAccountStatusAllClients()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "AccountStatusAllClients";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderClients = cmd.ExecuteReader();
                    DataTable TableClients = new DataTable();
                    TableClients.Load(ReaderClients);
                    conn.Close();
                    return TableClients;
                }
            }

        }

    }
}
