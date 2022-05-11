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
 public class ClientData : DBConnection
    {
        public DataTable SelectAllClients()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllClients";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderClients = cmd.ExecuteReader();
                    DataTable TableClients = new DataTable();
                    TableClients.Load(ReaderClients);
                    conn.Close();
                    return TableClients;
                }
            }
        }

        public DataTable SearchClient(string client)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SearchClient";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@client", client);
                    SqlDataReader ReaderClients = cmd.ExecuteReader();
                    DataTable TableClients = new DataTable();
                    TableClients.Load(ReaderClients);
                    conn.Close();
                    return TableClients;
                }
            }
        }

        public void SelectClientById(Int64 client_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectClientById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@client_id", client_id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Client.client_id = reader.GetInt64(0);
                            Client.name = reader.GetString(1);
                            Client.lastname = reader.GetString(2);
                            Client.code = reader.GetString(3);
                            Client.dui = reader.GetString(4);
                            Client.nit = reader.GetString(5);
                            Client.phone = reader.GetString(6);
                            Client.secondary_phone = reader.GetString(7);
                            Client.email = reader.GetString(8);
                            Client.address = reader.GetString(9);
                            Client.notes = reader.GetString(10);
                            Client.company_id = reader.GetInt64(11);
                        }
                    }
                }
            }
        }

        public void CountClients()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CountClients";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ClientCache.countClients = reader.GetInt32(0);
                        }
                    }
                }
            }
        }

        public void CreateClient(string name, string lastname, string code, string dui, string nit, string phone, string secondary_phone, string email, string address, string notes, Int64 company_id, string dateOfBirth, DateTime created_at)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CreateClient";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@dui", dui);
                    cmd.Parameters.AddWithValue("@nit", nit);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@secondary_phone", secondary_phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@notes", notes);
                    cmd.Parameters.AddWithValue("@company_id", company_id);
                    cmd.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@created_at", created_at);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void UpdateClient(string name, string lastname, string dui, string nit, string phone, string secondary_phone, string email, string address, string notes, DateTime updated_at, Int64 client_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateClient";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@dui", dui);
                    cmd.Parameters.AddWithValue("@nit", nit);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@secondary_phone", secondary_phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@notes", notes);
                    cmd.Parameters.AddWithValue("@updated_at", updated_at);
                    cmd.Parameters.AddWithValue("@client_id", client_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void DeleteClient(Int64 client_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DeleteClient";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@client_id", client_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void SelectLastCodeClient()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectLastCodeClient";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Client.client_id = reader.GetInt64(0);
                            Client.name = "";
                            Client.lastname = "";
                            Client.code = reader.GetString(3);
                            Client.dui = "";
                            Client.nit = "";
                            Client.phone = "";
                            Client.address = "";
                            Client.notes = "";
                            Client.company_id = 0;
                        }
                    }
                    else
                    {
                        Client.client_id = 0;
                        Client.name = "";
                        Client.lastname = "";
                        Client.code = "0";
                        Client.dui = "";
                        Client.nit = "";
                        Client.phone = "";
                        Client.address = "";
                        Client.notes = "";
                        Client.company_id = 0;
                    }
                }
            }
        }
    }
    
}
