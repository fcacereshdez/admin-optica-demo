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

        public DataTable SearchCompany(string company)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SearchCompanies";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@company", company);
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
                            Company.company_id = reader.GetInt64(0);
                            Company.full_name = reader.GetString(1);
                            Company.code = reader.GetString(2);
                            Company.phone = reader.GetString(3);
                            Company.secondary_phone = reader.GetString(4);
                            Company.email = reader.GetString(5);
                            Company.address = reader.GetString(6);
                            Company.nit = reader.GetString(7);
                            Company.iva = reader.GetString(8);
                            Company.attendance_fullname = reader.GetString(9);
                            Company.attendance_role = reader.GetString(10);
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
                            Company.company_id = reader.GetInt64(0);
                            Company.full_name = reader.GetString(1);
                            Company.code = reader.GetString(2);
                            Company.phone = reader.GetString(3);
                            Company.secondary_phone = reader.GetString(4);
                            Company.email = reader.GetString(5);
                            Company.address = reader.GetString(6);
                            Company.nit = reader.GetString(7);
                            Company.iva = reader.GetString(8);
                            Company.attendance_fullname = reader.GetString(9);
                            Company.attendance_role = reader.GetString(10);
                        }
                    }
                    else
                    {
                        Company.company_id = 0;
                        Company.full_name = "";
                        Company.code = "1";
                        Company.phone = "";
                        Company.secondary_phone = "";
                        Company.email = "";
                        Company.address = "";
                        Company.nit = "";
                        Company.iva = "";
                        Company.attendance_fullname = "";
                        Company.attendance_role = "";
                    }
                }
            }
        }

    }
}