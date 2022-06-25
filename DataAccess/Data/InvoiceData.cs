using Common.Cache;
using Common.Models;
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

        public DataTable SearchInvoice(string client)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SearchInvoice";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@client", client);
                    SqlDataReader ReaderInvoices = cmd.ExecuteReader();
                    DataTable TableInvoices = new DataTable();
                    TableInvoices.Load(ReaderInvoices);
                    conn.Close();
                    return TableInvoices;
                }
            }
        }

        public void InsertInvoice(decimal firstpayment, DateTime date, int number, Int64 optometryst_id, int recurrency, Int64 seller_id, Int64 manager_id, Int64 recipe_id, Int64 payment_method, decimal subtotal, decimal discount, decimal total, int n_fee, decimal fee, string notes, string fday, string sday, decimal subtotal_secondary, decimal discount_secondary)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "InsertInvoice";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstpayment", firstpayment);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@number_invoice", number);
                    cmd.Parameters.AddWithValue("@optometryst_id", optometryst_id);
                    cmd.Parameters.AddWithValue("@recurrency", recurrency);
                    cmd.Parameters.AddWithValue("@seller_id", seller_id);
                    cmd.Parameters.AddWithValue("@manager_id", manager_id);
                    cmd.Parameters.AddWithValue("@recipe_id", recipe_id);
                    cmd.Parameters.AddWithValue("@payment_method", payment_method);
                    cmd.Parameters.AddWithValue("@subtotal_primary", subtotal);
                    cmd.Parameters.AddWithValue("@discount_primary", discount);
                    cmd.Parameters.AddWithValue("@subtotal_secondary", subtotal_secondary);
                    cmd.Parameters.AddWithValue("@discount_secondary", discount_secondary);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@n_fee", n_fee);
                    cmd.Parameters.AddWithValue("@fee", fee);
                    cmd.Parameters.AddWithValue("@notes", notes);
                    cmd.Parameters.AddWithValue("@fday", fday);
                    cmd.Parameters.AddWithValue("@sday", sday);
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

        public void DeleteInvoice(Int64 invoice_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DeleteInvoice";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@invoice_id", invoice_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void SelectInvoiceById(Int64 invoice_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectInvoiceById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@invoice", invoice_id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Invoice.id_invoice = reader.GetInt64(0);
                            Invoice.date = reader.GetDateTime(1);
                            Invoice.client_name = reader.GetString(2);
                            Invoice.payment_method = reader.GetInt64(3);
                            Invoice.recurrence = reader.GetInt32(4);
                            Invoice.first_pay_day = reader.GetString(5);
                            Invoice.secondary_pay_day = reader.GetString(6);
                            Invoice.n_payments = reader.GetInt32(7);
                            Invoice.fee = reader.GetDecimal(8);
                            Invoice.optometrist = reader.GetString(9);
                            Invoice.optometrist_id = reader.GetInt64(10);
                            Invoice.consultant = reader.GetString(11);
                            Invoice.consultant_id = reader.GetInt64(12);
                            Invoice.manager = reader.GetString(13);
                            Invoice.manager_id = reader.GetInt64(14);
                            Invoice.subtotal = reader.GetDecimal(15);
                            Invoice.discount = reader.GetDecimal(16);
                            Invoice.total = reader.GetDecimal(17);
                            Invoice.notes = reader.GetString(18);
                            Invoice.discount_secondary = reader.GetDecimal(19);
                            Invoice.subtotal_secondary = reader.GetDecimal(20);
                        }
                    }
                }
            }
        }

        public DataTable SelectInvoiceDetailById(Int64 invoice_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectInvoiceDetailById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@invoice", invoice_id);
                    SqlDataReader ReaderProducts = cmd.ExecuteReader();
                    DataTable TableProducts = new DataTable();
                    TableProducts.Load(ReaderProducts);
                    conn.Close();
                    return TableProducts;
                }
            }
        }

        public void UpdateInvoice(decimal first_payment, DateTime date, Int64 optometrist, int recurrency, Int64 consultant, Int64 manager, Int64 payment_method, decimal subtotal, decimal discount, decimal total, int n_fee, decimal fee, string notes, string fday, string sday, decimal subtotal_secondary, decimal discount_secondary, Int64 invoice_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateInvoice";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstpayment", first_payment);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@optometryst_id", optometrist);
                    cmd.Parameters.AddWithValue("@recurrency", recurrency);
                    cmd.Parameters.AddWithValue("@seller_id", consultant);
                    cmd.Parameters.AddWithValue("@manager_id", manager);
                    cmd.Parameters.AddWithValue("@payment_method", payment_method);
                    cmd.Parameters.AddWithValue("@subtotal", subtotal);
                    cmd.Parameters.AddWithValue("@discount", discount);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@n_fee", n_fee);
                    cmd.Parameters.AddWithValue("@fee", fee);
                    cmd.Parameters.AddWithValue("@notes", notes);
                    cmd.Parameters.AddWithValue("@fday", fday);
                    cmd.Parameters.AddWithValue("@sday", sday);
                    cmd.Parameters.AddWithValue("@subtotal_secondary", subtotal_secondary);
                    cmd.Parameters.AddWithValue("@discount_secondary", discount_secondary);
                    cmd.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@invoice", invoice_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void UpdateDetailInvoice(Int64 id, int quantity, decimal value, decimal total)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateInvoiceDetails";   
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void SumSalesDay(string date)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SumSalesDay";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@day", date);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            
                            if (reader.GetValue(0) == DBNull.Value)
                            {
                                HomeCache.sum_sales_day = 0;
                            }
                            else
                            {
                                HomeCache.sum_sales_day = reader.GetDecimal(0);
                            }
                        }
                    }
                }
            }
        }
    }
}
