using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ShippmentController
    {
        ShippmentData shippmentData = new ShippmentData();
        public DataTable SelectAllBrands()
        {
            DataTable TableBrands = new DataTable();
            TableBrands = shippmentData.SelectAllBrands();
            return TableBrands;
        }
        public void CreateBrand(string brand)
        {
            shippmentData.CreateBrand(brand);
        }
        public void EditBrand(string brand, string brand_id)
        {
            shippmentData.EditBrand(brand, Convert.ToInt64(brand_id));
        }
        public void DeleteBrand(string brand_id)
        {
            shippmentData.DeleteBrand(Convert.ToInt64(brand_id));
        }
        public DataTable SelectAllCategories()
        {
            DataTable TableCategories = new DataTable();
            TableCategories = shippmentData.SelectAllCategories();
            return TableCategories;
        }
        public void CreateCategory(string category)
        {
            shippmentData.CreateCategory(category);
        }
        public void EditCategory(string category, string category_id)
        {
            shippmentData.EditCategory(category, Convert.ToInt64(category_id));
        }
        public void DeleteCategory(string category_id)
        {
            shippmentData.DeleteCategory(Convert.ToInt64(category_id));
        }

        public DataTable SelectAllModels()
        {
            DataTable TableModels = new DataTable();
            TableModels = shippmentData.SelectAllModels();
            return TableModels;
        }
        public void CreateModel(string model)
        {
            shippmentData.CreateModel(model);
        }
        public void EditModel(string model, string model_id)
        {
            shippmentData.EditModel(model, Convert.ToInt64(model_id));
        }
        public void DeleteModel(string model_id)
        {
            shippmentData.DeleteModel(Convert.ToInt64(model_id));
        }
        public DataTable SelectAllCarriers()
        {
            DataTable TableCarriers = new DataTable();
            TableCarriers = shippmentData.SelectAllCarriers();
            return TableCarriers;
        }
        public void CreateCarrier(string brand, string model, string category, string identification, string fullname)
        {
            shippmentData.CreateCarrier(Convert.ToInt64(brand), Convert.ToInt64(model), Convert.ToInt64(category), identification, fullname);
        }
        public void UpdatedCarrier(string brand, string model, string category, string identification, string fullname, string carrier_id)
        {
            shippmentData.UpdateCarrier(Convert.ToInt64(brand), Convert.ToInt64(model), Convert.ToInt64(category), identification, fullname, Convert.ToInt64(carrier_id));
        }
        public void DeleteCarrier(string carrier_id)
        {
            shippmentData.DeleteCarrier(Convert.ToInt64(carrier_id));
        }
    }
}
