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
    public class LaboratoryData : DBConnection
    {
        public DataTable SelectAllLaboratories()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllLaboratories";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderLaboratories = cmd.ExecuteReader();
                    DataTable TableLaboratories = new DataTable();
                    TableLaboratories.Load(ReaderLaboratories);
                    conn.Close();
                    return TableLaboratories;
                }
            }
        }

        public void CreateLaboratory(string laboratory_name, string laboratory_phone, string laboratory_address, string created_at)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "InsertLaboratory";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@laboratory_name", laboratory_name);
                    cmd.Parameters.AddWithValue("@laboratory_phone", laboratory_phone);
                    cmd.Parameters.AddWithValue("@laboratory_address", laboratory_address);
                    cmd.Parameters.AddWithValue("@created_at", created_at);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public DataTable SearchLaboratory(string laboratory)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SearchLaboratory";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@laboratory", laboratory);
                    SqlDataReader ReaderLaboratories = cmd.ExecuteReader();
                    DataTable TableLaboratories = new DataTable();
                    TableLaboratories.Load(ReaderLaboratories);
                    conn.Close();
                    return TableLaboratories;
                }
            }
        }

        public void SelectLaboratoryById(Int64 laboratory_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectLaboratoryById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@laboratory_id", laboratory_id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Laboratory.laboratory_id = reader.GetInt64(0);
                            Laboratory.laboratory_name = reader.GetString(1);
                            Laboratory.laboratory_phone = reader.GetString(2);
                            Laboratory.laboratory_address = reader.GetString(3);
                        }
                    }
                }
            }
        }

        public void UpdateLaboratory(string name, string phone, string address, Int64 laboratory_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateLaboratory";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@laboratory_id", laboratory_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void DeleteLaboratory(Int64 laboratory_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DeleteLaboratory";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@laboratory_id", laboratory_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
