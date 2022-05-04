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

        public void PayInovice(decimal amount, string date, Int64 processed_by, string last_payment, Int64 invoice_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "PayInvoice";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@processed_by", processed_by);
                    cmd.Parameters.AddWithValue("@last_payment", last_payment);
                    cmd.Parameters.AddWithValue("@invoice", invoice_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

    }
}
