using Common.Cache;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.View.Forms.Product
{
    public partial class ProductForm : Form
    {
        ProductController productController = new ProductController();
        public ProductForm()
        {
            InitializeComponent();
            SelectAllProducts();
            InsertAction("está en el gestor de productos.");
        }

        private void SelectAllProducts()
        {
             dgv_products.DataSource = productController.SelectAllProducts();
        }

        private void btn_report_products_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_brands_Click(object sender, EventArgs e)
        {
            BrandsForm brandForm = new BrandsForm();
            brandForm.ShowDialog();
        }

        private void btn_types_Click(object sender, EventArgs e)
        {
            ModelsForm modelsForm = new ModelsForm();
            modelsForm.ShowDialog();
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.ShowDialog();
        }

        private void btn_create_product_Click(object sender, EventArgs e)
        {
            ProductCreate productCreate = new ProductCreate();
            productCreate.ShowDialog();
        }

        private void ProductCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelectAllProducts();
        }
        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

    }
}
