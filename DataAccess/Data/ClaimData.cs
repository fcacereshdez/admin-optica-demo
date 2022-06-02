using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ClaimData : DBConnection
    {
        public DataTable SelectAllClaims()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllClaims";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderClaims = cmd.ExecuteReader();
                    DataTable TableClaims = new DataTable();
                    TableClaims.Load(ReaderClaims);
                    conn.Close();
                    return TableClaims;
                }
            }
        }

        public DataTable SelectAllTypeClaims()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllTypesClaims";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderTypeClaims = cmd.ExecuteReader();
                    DataTable TableTypeClaims = new DataTable();
                    TableTypeClaims.Load(ReaderTypeClaims);
                    conn.Close();
                    return TableTypeClaims;
                }
            }
        }
    }
}
