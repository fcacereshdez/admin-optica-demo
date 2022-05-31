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
            dgv_products.Columns[0].Width = 25;
            dgv_products.Columns[1].Width = 170;
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
            productCreate.FormClosed += new FormClosedEventHandler(ProductCreate_FormClosed);
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

        private void btn_edit_product_Click(object sender, EventArgs e)
        {
            try
            {
                productController.SelectProductById(dgv_products.SelectedRows[0].Cells[0].Value.ToString());
                ProductCreate productCreate = new ProductCreate();
                productCreate.lbl_action.Text = "Editar producto";
                productCreate.btn_save_product.Text = "Actualizar";
                productCreate.cb_model.SelectedValue = Common.Models.Product.model_id;
                productCreate.cb_category.SelectedValue = Common.Models.Product.category_id;
                productCreate.cb_brand.SelectedValue = Common.Models.Product.brand_id;
                productCreate.txt_quantity.Text = Common.Models.Product.product_quantity.ToString();
                productCreate.txt_code_product.Text = Common.Models.Product.product_code;
                productCreate.txt_color.Text = Common.Models.Product.product_color;
                productCreate.txt_notes.Text = Common.Models.Product.product_notes;
                productCreate.txt_price_cost.Text = Common.Models.Product.price_cost.ToString();
                productCreate.txt_price_sale.Text = Common.Models.Product.price_sale.ToString();
                productCreate.txt_method.Text = "update";
                productCreate.FormClosed += new FormClosedEventHandler(ProductCreate_FormClosed);
                productCreate.ShowDialog();
            }
            catch (Exception errProduct)
            {
                MessageBox.Show("Ocurrió un error mientras intentabamos seleccionar el producto.\n\nError: " + errProduct.Message, "Productos");
            }
        }

        private void btn_delete_product_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminación", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                UserController userController = new UserController();
                try
                {
                    productController.DeleteProduct(dgv_products.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("Registro eliminado", "Procesado", MessageBoxButtons.OK);
                    userController.InsertActionsUser("Eliminió un producto", Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    SelectAllProducts();
                }
                catch (Exception errProducts)
                {
                    MessageBox.Show("Ocurrió un error al intentar ejecutar esto.\n\nError: " + errProducts.Message, "Productos");
                }

            }
        }

        private void txt_search_product_TextChanged(object sender, EventArgs e)
        {
            try
            {
              dgv_products.DataSource = productController.SearchProduct(txt_search_product.Text);
            }
            catch (Exception errProducts)
            {
                MessageBox.Show("Ocurrió un error al intentar ejecutar esto.\n\nError: " + errProducts.Message, "Productos");
            }
        }

    }
}
