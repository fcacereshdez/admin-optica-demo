using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using Common.Models;

namespace DataAccess
{
    public class CompanyData : DBConnection
    {
        public DataTable SelectAllCompanies()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllCompanies";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderCompanies = cmd.ExecuteReader();
                    DataTable TableCompanies = new DataTable();
                    TableCompanies.Load(ReaderCompanies);
                    conn.Close();
                    return TableCompanies;
                }
            }
        }

        public void SelectCompanyById(Int64 company_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectCompanyById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@company_id", company_id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Companies.company_id = reader.GetInt64(0);
                            Companies.full_name = reader.GetString(1);
                            Companies.code = reader.GetString(2);
                            Companies.phone = reader.GetString(3);
                            Companies.secondary_phone = reader.GetString(4);
                            Companies.email = reader.GetString(5);
                            Companies.address = reader.GetString(6);
                            Companies.nit = reader.GetString(7);
                            Companies.iva = reader.GetString(8);
                            Companies.attendance_fullname = reader.GetString(9);
                            Companies.attendance_role = reader.GetString(10);
                        }
                    }
                }
            }
        }

        public void CreateCompany(string fullname, string code, string phone, string secondary_phone, string email, string address, string nit, string iva, string attendance_fullname, string attendance_role, DateTime created_at)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CreateCompany";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@secondary_phone", secondary_phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@nit", nit);
                    cmd.Parameters.AddWithValue("@iva", iva);
                    cmd.Parameters.AddWithValue("@attendance_fullname", attendance_fullname);
                    cmd.Parameters.AddWithValue("@attendance_role", attendance_role);
                    cmd.Parameters.AddWithValue("@created_at", created_at);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void UpdateCompany(string fullname, string phone, string secondary_phone, string email, string address, string nit, string iva, string attendance_fullname, string attendance_role, DateTime updated_at, Int64 company_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateCompany";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@secondary_phone", secondary_phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@nit", nit);
                    cmd.Parameters.AddWithValue("@iva", iva);
                    cmd.Parameters.AddWithValue("@attendance_fullname", attendance_fullname);
                    cmd.Parameters.AddWithValue("@attendance_role", attendance_role);
                    cmd.Parameters.AddWithValue("@updated_at", updated_at);
                    cmd.Parameters.AddWithValue("@company_id", company_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void DeleteCompany(Int64 company_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DeleteCompany";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@company_id", company_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void SelectLastCodeCompany()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectLastCodeCompany";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Companies.company_id = reader.GetInt64(0);
                            Companies.full_name = reader.GetString(1);
                            Companies.code = reader.GetString(2);
                            Companies.phone = reader.GetString(3);
                            Companies.secondary_phone = reader.GetString(4);
                            Companies.email = reader.GetString(5);
                            Companies.address = reader.GetString(6);
                            Companies.nit = reader.GetString(7);
                            Companies.iva = reader.GetString(8);
                            Companies.attendance_fullname = reader.GetString(9);
                            Companies.attendance_role = reader.GetString(10);
                        }
                    }
                    else
                    {
                        Companies.company_id = 0;
                        Companies.full_name = "";
                        Companies.code = "1";
                        Companies.phone = "";
                        Companies.secondary_phone = "";
                        Companies.email = "";
                        Companies.address = "";
                        Companies.nit = "";
                        Companies.iva = "";
                        Companies.attendance_fullname = "";
                        Companies.attendance_role = "";
                    }
                }
            }
        }

    }
}