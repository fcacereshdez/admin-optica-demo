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

namespace Presentation.View.Forms.Recipe
{
    public partial class ProductsSelector : Form
    {
        ProductController productController = new ProductController();
        public ProductsSelector()
        {
            InitializeComponent();
            LoadData();
        }

        private void ProductsSelector_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_ring_Click(object sender, EventArgs e)
        {
           dgv_products.DataSource = productController.SelectProductsByCategoryId(cmb_categories.SelectedValue.ToString());
            dgv_products.Columns[0].Width = 25;
            dgv_products.Columns[1].Width = 170;
        }

        private void LoadData()
        {
            cmb_categories.DataSource = productController.SelectAllCategories();
            cmb_categories.DisplayMember = "CATEGORIA";
            cmb_categories.ValueMember = "ID";
        }

        private void dgv_products_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RecipeCreate recipeCreate = ((RecipeCreate)(Owner));
            if (txt_search.Text == "ring")
            {
                recipeCreate.txt_ring_name.Text = dgv_products.SelectedRows[0].Cells[1].Value.ToString();
                recipeCreate.txt_ring_id.Text = dgv_products.SelectedRows[0].Cells[0].Value.ToString();
            }else if(txt_search.Text == "glasses")
            {
                recipeCreate.txt_glasses_name.Text = dgv_products.SelectedRows[0].Cells[1].Value.ToString();
                recipeCreate.txt_glasses_id.Text = dgv_products.SelectedRows[0].Cells[0].Value.ToString();
            }
            Close();
        }

        private void pcb_close_create_client_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_product_search_TextChanged(object sender, EventArgs e)
        {
          dgv_products.DataSource = productController.SearchProduct(txt_product_search.Text);
            dgv_products.Columns[0].Width = 25;
            dgv_products.Columns[1].Width = 170;
        }
    }
}
