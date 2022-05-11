using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProductController
    {
        ProductData productData = new ProductData();
        public DataTable SelectAllProducts()
        {
            DataTable TableProducts = new DataTable();
            TableProducts = productData.SelectAllProducts();
            return TableProducts;
        }
        public void CreateProduct(string product_name, string product_quantity, string product_description, string product_color, string category_id, string model_id, string brand_id)
        {
            productData.CreateProduct(product_name, Convert.ToInt32(product_quantity), product_description, product_color, Convert.ToInt64(category_id), Convert.ToInt64(model_id), Convert.ToInt64(brand_id), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
        public DataTable SelectAllBrands()
        {
            DataTable TableBrands = new DataTable();
            TableBrands = productData.SelectAllBrands();
            return TableBrands;
        }
        public void CreateBrand(string brand)
        {
            productData.CreateBrand(brand);
        }
        public void EditBrand(string brand, string brand_id)
        {
            productData.EditBrand(brand, Convert.ToInt64(brand_id));
        }
        public void DeleteBrand(string brand_id)
        {
            productData.DeleteBrand(Convert.ToInt64(brand_id));
        }

        public DataTable SelectAllCategories()
        {
            DataTable TableCategories = new DataTable();
            TableCategories = productData.SelectAllCategories();
            return TableCategories;
        }
        public void CreateCategory(string category)
        {
            productData.CreateCategory(category);
        }
        public void EditCategory(string category, string category_id)
        {
            productData.EditCategory(category, Convert.ToInt64(category_id));
        }
        public void DeleteCategory(string category_id)
        {
            productData.DeleteCategory(Convert.ToInt64(category_id));
        }

        public DataTable SelectAllModels()
        {
            DataTable TableModels = new DataTable();
            TableModels = productData.SelectAllModels();
            return TableModels;
        }
        public void CreateModel(string model)
        {
            productData.CreateModel(model);
        }
        public void EditModel(string model, string model_id)
        {
            productData.EditModel(model, Convert.ToInt64(model_id));
        }
        public void DeleteModel(string model_id)
        {
            productData.DeleteModel(Convert.ToInt64(model_id));
        }
    }
}