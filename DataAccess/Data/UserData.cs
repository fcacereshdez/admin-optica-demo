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

        public DataTable SearchUser(string user)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SearchUser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user", user);
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

        public void SelectUserById(Int64 user_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectUserById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Users.user_id = reader.GetInt64(0);
                            Users.name = reader.GetString(1);
                            Users.lastname = reader.GetString(2);
                            Users.username = reader.GetString(3);
                            Users.password = reader.GetString(4);
                            Users.email = reader.GetString(5);
                            Users.phone = reader.GetString(6);
                            Users.role = reader.GetInt64(7);
                            Users.status = reader.GetInt64(8);
                        }
                    }
                }
            }
        }

        public void UpdateUser(string name, string lastname, string username, string password, string email, string phone, Int64 role_id, Int64 user_status_id ,Int64 user_id, DateTime updated_at)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateUser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@role_id", role_id);
                    cmd.Parameters.AddWithValue("@user_status_id", user_status_id);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@updated_at", updated_at);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void CreateUser(string name, string lastname, string username, string password, string email, string phone, Int64 role_id, Int64 user_status_id, DateTime created_at)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CreateUser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@role_id", role_id);
                    cmd.Parameters.AddWithValue("@user_status_id", user_status_id);
                    cmd.Parameters.AddWithValue("@created_at", created_at);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void DeleteUser(Int64 user_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DeleteUser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public DataTable SelectAllRoles()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectRoles";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderRoles = cmd.ExecuteReader();
                    DataTable TableRoles = new DataTable();
                    TableRoles.Load(ReaderRoles);
                    conn.Close();
                    return TableRoles;
                }
            }
        }

        public DataTable SelectUsersByRoleId(Int64 role_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectUsersByRoleId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@role_id", role_id);
                    SqlDataReader ReaderUsers = cmd.ExecuteReader();
                    DataTable TableUsers = new DataTable();
                    TableUsers.Load(ReaderUsers);
                    conn.Close();
                    return TableUsers;
                }
            }
        }

        public DataTable SelectAllStatus()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectUserStatus";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderStatus= cmd.ExecuteReader();
                    DataTable TableStatus = new DataTable();
                    TableStatus.Load(ReaderStatus);
                    conn.Close();
                    return TableStatus;
                }
            }
        }
    }
}
