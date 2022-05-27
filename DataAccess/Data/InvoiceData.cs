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

        public void InsertInvoice(DateTime date, int number, Int64 optometryst_id, int recurrency, Int64 seller_id, Int64 manager_id, Int64 recipe_id, Int64 payment_method, decimal subtotal, decimal discount, decimal total, int n_fee, decimal fee, string notes)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "InsertInvoice";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@number_invoice", number);
                    cmd.Parameters.AddWithValue("@optometryst_id", optometryst_id);
                    cmd.Parameters.AddWithValue("@recurrency", recurrency);
                    cmd.Parameters.AddWithValue("@seller_id", seller_id);
                    cmd.Parameters.AddWithValue("@manager_id", manager_id);
                    cmd.Parameters.AddWithValue("@recipe_id", recipe_id);
                    cmd.Parameters.AddWithValue("@payment_method", payment_method);
                    cmd.Parameters.AddWithValue("@subtotal", subtotal);
                    cmd.Parameters.AddWithValue("@discount", discount);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@n_fee", n_fee);
                    cmd.Parameters.AddWithValue("@fee", fee);
                    cmd.Parameters.AddWithValue("@notes", notes);
                    cmd.Parameters.AddWithValue("@created_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void InsertDetailInvoice(Int64 product_id, int quantity, decimal value, decimal total)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "InsertDetailInvoice";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@product_id", product_id);
                    cmd.Parameters.AddWithValue("@quantity_product", quantity);
                    cmd.Parameters.AddWithValue("@value_product", value);
                    cmd.Parameters.AddWithValue("@total_product", total);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
