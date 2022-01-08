using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;

namespace DataAccess
{
   public class UserData : DBConnection
    {
        public bool Login(string username, string password)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectUserLogin";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.user_id = reader.GetInt64(0);
                            UserCache.name = reader.GetString(1);
                            UserCache.lastname = reader.GetString(2);
                            UserCache.email = reader.GetString(3);
                            UserCache.password = reader.GetString(4);
                            UserCache.role = reader.GetString(5);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public DataTable GetAllUsers()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllUsers";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderUsers = cmd.ExecuteReader();
                    DataTable TableUsers = new DataTable();
                    TableUsers.Load(ReaderUsers);
                    conn.Close();
                    return TableUsers;
                }
            }
        }

        public void InsertActionsUser(string description, string computer, string ipaddress, Int64 user_id, DateTime created_at)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "InsertActionsUser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@computer", computer);
                    cmd.Parameters.AddWithValue("@ipaddress", ipaddress);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@created_at", created_at);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void UpdateLastAccessUser(Int64 user_id, DateTime last_access)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateLastLoginUser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@last_access", last_access);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
