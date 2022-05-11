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
    }
}
