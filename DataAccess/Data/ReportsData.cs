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
        public DataSet GetSalesBook()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "GetSalesBook";
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet("ds_sales_book");
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    conn.Close();
                    return ds;
                }
            }
        }
    }
}
