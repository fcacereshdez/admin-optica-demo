using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
   public class CommonData : DBConnection
    {
        public DataTable SelectAllBank()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllBanks";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderBanks = cmd.ExecuteReader();
                    DataTable TableBanks = new DataTable();
                    TableBanks.Load(ReaderBanks);
                    conn.Close();
                    return TableBanks;
                }
            }
        }

        public DataTable SelectAllPaymentMethod()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllTypePayments";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderPaymentMethods = cmd.ExecuteReader();
                    DataTable TablePaymentMethods = new DataTable();
                    TablePaymentMethods.Load(ReaderPaymentMethods);
                    conn.Close();
                    return TablePaymentMethods;
                }
            }
        }

    }
}
