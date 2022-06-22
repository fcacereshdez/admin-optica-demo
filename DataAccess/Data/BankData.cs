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
    public class BankData : DBConnection
    {
        public DataTable SelectAllBanks()
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

        public DataTable SearchBank(string bank)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SearchBank";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@bank", bank);
                    SqlDataReader ReaderBanks = cmd.ExecuteReader();
                    DataTable TableBanks = new DataTable();
                    TableBanks.Load(ReaderBanks);
                    conn.Close();
                    return TableBanks;
                }
            }
        }

        public void SelectBankById(Int64 bank_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectBankById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@bank_id", bank_id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Bank.bank_id = reader.GetInt64(0);
                            Bank.bank_name = reader.GetString(1);
                            Bank.last_check = reader.GetInt32(2);
                            Bank.number_account = reader.GetString(3);
                            Bank.bank_balance = reader.GetDecimal(4);
                        }
                    }
                }
            }
        }

        public void InsertBank(string bank_name, int last_check, string number_account, decimal balance)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "InsertBank";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", bank_name);
                    cmd.Parameters.AddWithValue("@last", last_check);
                    cmd.Parameters.AddWithValue("@account", number_account);
                    cmd.Parameters.AddWithValue("@balance", balance);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void UpdateBank(string bank_name, int last_check, string number_account, decimal balance, Int64 bank_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateBank";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", bank_name);
                    cmd.Parameters.AddWithValue("@last", last_check);
                    cmd.Parameters.AddWithValue("@account", number_account);
                    cmd.Parameters.AddWithValue("@balance", balance);
                    cmd.Parameters.AddWithValue("@bank_id", bank_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void DeleteBank(Int64 bank_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DeleteBank";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@bank_id", bank_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

    }
}
