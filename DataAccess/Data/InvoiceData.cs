using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class InvoiceData : DBConnection
    {
        public DataTable SelectAllInvoices()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllInvoices";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderInvoices = cmd.ExecuteReader();
                    DataTable TableInvoices = new DataTable();
                    TableInvoices.Load(ReaderInvoices);
                    conn.Close();
                    return TableInvoices;
                }
            }
        }
    }
}
