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
            if (txt_product.Text == "")
            {
                lbl_error.Visible = true;
                lbl_error.Text = "No puede crear un producto sin nombre.";
            }else if(txt_quantity.Text == "")
            {
                lbl_error.Text = "El producto debe contener al menos un valor 0";
            }
            else
            {
                productController.CreateProduct(txt_product.Text, txt_quantity.Text, txt_notes.Text, txt_color.Text, cb_category.SelectedValue.ToString(), cb_model.SelectedValue.ToString(), cb_brand.SelectedValue.ToString());
                txt_product.Clear();
                txt_quantity.Clear();
                txt_notes.Clear();
                txt_color.Clear();
                txt_product.Focus();
                MessageBox.Show("Producto registrado correctamente.");
                Close();
            }
        }
    }
}
