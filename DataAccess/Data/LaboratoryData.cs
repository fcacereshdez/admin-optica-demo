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
    }
}
