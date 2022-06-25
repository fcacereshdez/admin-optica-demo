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
    public class ClaimData : DBConnection
    {
        public DataTable SelectAllClaims()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllClaims";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderClaims = cmd.ExecuteReader();
                    DataTable TableClaims = new DataTable();
                    TableClaims.Load(ReaderClaims);
                    conn.Close();
                    return TableClaims;
                }
            }
        }

        public DataTable SearchClaims(string client)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SearchClaim";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@client", client);
                    SqlDataReader ReaderClaims = cmd.ExecuteReader();
                    DataTable TableClaims = new DataTable();
                    TableClaims.Load(ReaderClaims);
                    conn.Close();
                    return TableClaims;
                }
            }
        }

        public DataTable SelectAllTypeClaims()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllTypesClaims";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderTypeClaims = cmd.ExecuteReader();
                    DataTable TableTypeClaims = new DataTable();
                    TableTypeClaims.Load(ReaderTypeClaims);
                    conn.Close();
                    return TableTypeClaims;
                }
            }
        }

        public DataTable SelectAllMotiveClaims()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllMotiveClaims";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderTypeClaims = cmd.ExecuteReader();
                    DataTable TableTypeClaims = new DataTable();
                    TableTypeClaims.Load(ReaderTypeClaims);
                    conn.Close();
                    return TableTypeClaims;
                }
            }
        }

        public void InsertClaim(Int64 claim_type, Int64 claim_motive, Int64 client_id, string claim_details, DateTime claim_date)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "InsertClaim";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@claim_type", claim_type);
                    cmd.Parameters.AddWithValue("@claim_motive", claim_motive);
                    cmd.Parameters.AddWithValue("@client_id", client_id);
                    cmd.Parameters.AddWithValue("@claim_details", claim_details);
                    cmd.Parameters.AddWithValue("@claim_date", claim_date);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void UpdateClaim(Int64 claim_type, Int64 claim_motive, Int64 client_id, string claim_details, DateTime claim_date)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateClaim";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@claim_type", claim_type);
                    cmd.Parameters.AddWithValue("@claim_motive", claim_motive);
                    cmd.Parameters.AddWithValue("@client_id", client_id);
                    cmd.Parameters.AddWithValue("@claim_details", claim_details);
                    cmd.Parameters.AddWithValue("@claim_date", claim_date);
                    cmd.Parameters.AddWithValue("@claim_id", Claim.claim_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void SelectClaimById(Int64 claim_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectClaimById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@claim", claim_id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Claim.claim_id = reader.GetInt64(0);
                            Claim.claim_type_id = reader.GetInt64(1);
                            Claim.claim_motive_id = reader.GetInt64(2);
                            Claim.client_id = reader.GetInt64(3);
                            Claim.client_name = reader.GetString(4);
                            Claim.company_name = reader.GetString(5);
                            Claim.claim_description = reader.GetString(6);
                            Claim.claim_date = reader.GetDateTime(7);
                        }
                    }
                }
            }
        }

        public void DeleteClaim(Int64 claim_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DeleteClaim";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@claim_id", claim_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

    }
}
