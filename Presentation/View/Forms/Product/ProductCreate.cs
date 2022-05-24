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
    public partial class ProductCreate : Form
    {
        ProductController productController = new ProductController();
        public ProductCreate()
        {
            InitializeComponent();
            LoadData();
        }

        private void pcb_close_product_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadData()
        {
            cb_brand.DataSource = productController.SelectAllBrands();
            cb_brand.DisplayMember = "MARCA";
            cb_brand.ValueMember = "ID";

            cb_model.DataSource = productController.SelectAllModels();
            cb_model.DisplayMember = "MODELO";
            cb_model.ValueMember = "ID";

            cb_category.DataSource = productController.SelectAllCategories();
            cb_category.DisplayMember = "CATEGORIA";
            cb_category.ValueMember = "ID";
        }

        private void btn_save_product_Click(object sender, EventArgs e)
        {
            if(txt_quantity.Text == "")
            {
                lbl_error.Text = "El producto debe contener al menos un valor 0";
            }
            else if(txt_price_cost.Text == "")
            {
                lbl_error.Text = "El producto debe contener un precio de costo";
            }else if(txt_price_sale.Text == "")
            {
                lbl_error.Text = "El producto debe contener al menos un precio de venta";
            }else if (txt_code_product.Text == "")
            {
                lbl_error.Text = "El producto debe contener un código";
            }else
            {
                productController.CreateProduct("", txt_quantity.Text, txt_notes.Text, txt_color.Text, txt_code_product.Text, txt_price_cost.Text, txt_price_sale.Text, cb_category.SelectedValue.ToString(), cb_model.SelectedValue.ToString(), cb_brand.SelectedValue.ToString());
                txt_quantity.Clear();
                txt_notes.Clear();
                txt_color.Clear();
                InsertAction("creó un producto.");
                MessageBox.Show("Producto registrado correctamente.");
                Close();
            }
        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
