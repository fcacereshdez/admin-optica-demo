using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace DataAccess.Data
{
    public class ClientAccountData : DBConnection
    {

        public DataTable GetInvoiceByClient(Int64 client_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "GetInvoiceByClient";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@client_id", client_id);
                    SqlDataReader ReaderInvoices = cmd.ExecuteReader();
                    DataTable TableInvoices = new DataTable();
                    TableInvoices.Load(ReaderInvoices);
                    conn.Close();
                    return TableInvoices;
                }
            }
        }

        public void GetClientAccountById(Int64 invoice_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "GetClientAccountById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@invoice_id", invoice_id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ClientAccount.id_client_account = reader.GetInt64(0);
                            ClientAccount.client_name = reader.GetString(1);
                            ClientAccount.client_lastname = reader.GetString(2);
                            ClientAccount.company_name = reader.GetString(3);
                            ClientAccount.invoice_number = reader.GetInt32(4);
                            ClientAccount.invoice_date = reader.GetDateTime(5);
                            ClientAccount.invoice_total = reader.GetDecimal(6);
                            ClientAccount.balance = reader.GetDecimal(7);
                            ClientAccount.last_payment = reader.GetDateTime(8);
                            ClientAccount.fee = reader.GetDecimal(9);
                        }
                    }
                }
            }
        }

        public void PayInovice(Int64 payment_method, decimal amount, string date, Int64 processed_by, string last_payment, Int64 bank, string reference, string note, string check, string ccf, Int64 invoice_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "PayInvoice";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@payment_method", payment_method);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@processed_by", processed_by);
                    cmd.Parameters.AddWithValue("@last_payment", last_payment);
                    cmd.Parameters.AddWithValue("@invoice", invoice_id);
                    cmd.Parameters.AddWithValue("@bank", bank);
                    cmd.Parameters.AddWithValue("@reference", reference);
                    cmd.Parameters.AddWithValue("@paynote", note);
                    cmd.Parameters.AddWithValue("@checknumber", check);
                    cmd.Parameters.AddWithValue("@ccf_number", ccf);
                    cmd.Parameters.AddWithValue("@created_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void GetTotalByCompany(Int64 company_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "TotalByCompany";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@company_id", company_id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Company.company_id = reader.GetInt64(0);
                            Company.full_name = reader.GetString(1);
                            Company.invoices = reader.GetInt32(2);
                            Company.total_invoice = reader.GetDecimal(3);
                            Company.total_clients = reader.GetInt32(4);
                        }
                    }
                }
            }
        }

        public DataTable GetClientsByCompany(Int64 company_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "GetClientsByCompany";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@company_id", company_id);
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
