﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ProductData : DBConnection
    {
        public DataTable SelectAllProducts()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllProducts";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderProducts = cmd.ExecuteReader();
                    DataTable TableProducts = new DataTable();
                    TableProducts.Load(ReaderProducts);
                    conn.Close();
                    return TableProducts;
                }
            }
        }

        public void CreateProduct(string product_name, int product_quantity, string product_description, string product_color, Int64 category_id, Int64 model_id, Int64 brand_id, string created_at)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "InsertProduct";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@product_name", product_name);
                    cmd.Parameters.AddWithValue("@product_quantity", product_quantity);
                    cmd.Parameters.AddWithValue("@product_description", product_description);
                    cmd.Parameters.AddWithValue("@product_color", product_color);
                    cmd.Parameters.AddWithValue("@category_id", category_id);
                    cmd.Parameters.AddWithValue("@model_id", model_id);
                    cmd.Parameters.AddWithValue("@brand_id", brand_id);
                    cmd.Parameters.AddWithValue("@created_at", created_at);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public DataTable SelectAllBrands()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllBrands";
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
                    cmd.CommandText = "InsertBrand";
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
                    cmd.CommandText = "UpdateBrand";
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
                    cmd.CommandText = "DeleteBrand";
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
                    cmd.CommandText = "SelectAllCategories";
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
                    cmd.CommandText = "InsertCategory";
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
                    cmd.CommandText = "UpdateCategory";
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
                    cmd.CommandText = "DeleteCategory";
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
                    cmd.CommandText = "SelectAllModels";
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
                    cmd.CommandText = "InsertModel";
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
                    cmd.CommandText = "UpdateModel";
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
                    cmd.CommandText = "DeleteModel";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@model_id", model_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

    }
}