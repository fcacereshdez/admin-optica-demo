using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ShippmentData : DBConnection
    {
        public DataTable SelectAllBrands()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllBrandCarriers";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderBrands = cmd.ExecuteReader();
                    DataTable TableBrands = new DataTable();
                    TableBrands.Load(ReaderBrands);
                    conn.Close();
                    return TableBrands;
                }
            }
        }

        public void CreateBrand(string brand)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "InsertBrandCarrier";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void EditBrand(string brand, Int64 brand_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateBrandCarrier";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@brand_id", brand_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }


        public void DeleteBrand(Int64 brand_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DeleteBrandCarriers";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@brand_id", brand_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public DataTable SelectAllCategories()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllCategoriesCarriers";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderCategories = cmd.ExecuteReader();
                    DataTable TableCategories = new DataTable();
                    TableCategories.Load(ReaderCategories);
                    conn.Close();
                    return TableCategories;
                }
            }
        }

        public void CreateCategory(string category)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "InsertCategoryCarrier";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void EditCategory(string category, Int64 category_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateCategoryCarrier";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@category_id", category_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }


        public void DeleteCategory(Int64 category_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DeleteCategoryCarriers";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@category_id", category_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public DataTable SelectAllModels()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllModelsCarriers";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderModels = cmd.ExecuteReader();
                    DataTable TableModels = new DataTable();
                    TableModels.Load(ReaderModels);
                    conn.Close();
                    return TableModels;
                }
            }
        }

        public void CreateModel(string model)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "InsertModelCarrier";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void EditModel(string model, Int64 model_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateModelCarrier";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@model_id", model_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }


        public void DeleteModel(Int64 model_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DeleteModelCarriers";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@model_id", model_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public DataTable SelectAllCarriers()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllCarriers";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderCarriers = cmd.ExecuteReader();
                    DataTable TableCarriers = new DataTable();
                    TableCarriers.Load(ReaderCarriers);
                    conn.Close();
                    return TableCarriers;
                }
            }
        }

        public void CreateCarrier(Int64 brand, Int64 model, Int64 category, string identification, string fullname)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "InsertCarrier";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@identification", identification);
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void UpdateCarrier(Int64 brand, Int64 model, Int64 category, string identification, string fullname, Int64 carrier_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateCarrier";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@identification", identification);
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.Parameters.AddWithValue("@carrier_id", carrier_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void DeleteCarrier(Int64 carrier_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DeleteCarrier";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@carrier_id", carrier_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
