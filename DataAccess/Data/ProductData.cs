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


        public DataTable SelectProductMovements()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "ProductsMovements";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderProducts = cmd.ExecuteReader();
                    DataTable TableProducts = new DataTable();
                    TableProducts.Load(ReaderProducts);
                    conn.Close();
                    return TableProducts;
                }
            }
        }

        public void CreateProduct(string product_name, int product_quantity, string product_description, string product_color, string code_product, double price_cost, double price_sale, Int64 category_id, Int64 model_id, Int64 brand_id, string created_at)
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
                    cmd.Parameters.AddWithValue("@product_code", code_product);
                    cmd.Parameters.AddWithValue("@product_cost_price", price_cost);
                    cmd.Parameters.AddWithValue("@product_sale_price", price_sale);
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

        public DataTable SelectProductsByCategoryId(Int64 category_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectProductsByCategoryId";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@category_id", category_id);
                    SqlDataReader ReaderProducts = cmd.ExecuteReader();
                    DataTable TableProducts = new DataTable();
                    TableProducts.Load(ReaderProducts);
                    conn.Close();
                    return TableProducts;
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

        public DataTable SearchProduct(string product)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SearchProduct";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@product", product);
                    SqlDataReader ReaderProducts = cmd.ExecuteReader();
                    DataTable TableProducts = new DataTable();
                    TableProducts.Load(ReaderProducts);
                    conn.Close();
                    return TableProducts;
                }
            }
        }

        public void SelectProductsById(Int64 product_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectProductById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@product_id", product_id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Product.product_id = reader.GetInt64(0);
                            Product.product_name = reader.GetString(1);
                            Product.product_quantity = reader.GetInt32(2);
                            Product.product_notes = reader.GetString(3);
                            Product.product_color = reader.GetString(4);
                            Product.product_code = reader.GetString(5);
                            Product.price_cost = reader.GetDecimal(6);
                            Product.price_sale = reader.GetDecimal(7);
                            Product.category_id = reader.GetInt64(8);
                            Product.model_id = reader.GetInt64(9);
                            Product.brand_id = reader.GetInt64(10);
                        }
                    }
                }
            }
        }
        public void UpdateProduct(string name, Int32 quantity, string description, string color, string code, decimal cost, decimal sale, Int64 category, Int64 model, Int64 brand)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateProduct";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@color", color);
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@cost", cost);
                    cmd.Parameters.AddWithValue("@sale", sale);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@update", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@product_id", Product.product_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        public void DeleteProduct(Int64 product_id) 
        { 
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DeleteProduct";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@product_id", product_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
