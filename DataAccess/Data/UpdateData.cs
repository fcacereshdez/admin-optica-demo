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
   public class UpdateData : DBConnection
    {
        public void SearchRecentUpdate()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SearchRecentUpdate";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Update.id_version = reader.GetInt64(0);
                            Update.description = reader.GetString(1);
                            Update.version = reader.GetString(2);
                            Update.status = reader.GetInt32(3);
                        }
                    }
                    else
                    {
                        Update.id_version = 0;
                    }
                }
            }
        }

        public void CloseUpdate(Int64 update_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CloseUpdate";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@version", update_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

    }
}
