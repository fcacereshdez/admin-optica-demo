using Domain;
using Presentation.View.Forms.Recipe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.View.Forms.Invoice
{
    public partial class RecipeSelector : Form
    {
        RecipeController recipeController = new RecipeController();
        public RecipeSelector()
        {
            InitializeComponent();
            SelectAllData();
        }

        private void pcb_close_search_recipe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectAllData()
        {
            dgv_recipe_child.DataSource = recipeController.SelectAllRecipes();
            dgv_recipe_child.Columns[5].Visible = false;
            dgv_recipe_child.Columns[6].Visible = false;
            dgv_recipe_child.Columns[7].Visible = false;
            dgv_recipe_child.Columns[8].Visible = false;
            dgv_recipe_child.Columns[9].Visible = false;
            dgv_recipe_child.Columns[10].Visible = false;
            dgv_recipe_child.Columns[11].Visible = false;
        }

        private void dgv_recipe_child_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InvoiceCreate invoiceCreate = ((InvoiceCreate)(Owner));
            invoiceCreate.txt_recipe_id.Text = dgv_recipe_child.SelectedRows[0].Cells[0].Value.ToString();
            invoiceCreate.lbl_client_name.Text = dgv_recipe_child.SelectedRows[0].Cells[3].Value.ToString();
            invoiceCreate.dgv_products.Rows.Add(dgv_recipe_child.SelectedRows[0].Cells[5].Value.ToString(),
                dgv_recipe_child.SelectedRows[0].Cells[6].Value.ToString(),
                dgv_recipe_child.SelectedRows[0].Cells[7].Value.ToString(),
                dgv_recipe_child.SelectedRows[0].Cells[11].Value.ToString(),
                0.00);
            invoiceCreate.dgv_products.Rows.Add(dgv_recipe_child.SelectedRows[0].Cells[8].Value.ToString(),
                dgv_recipe_child.SelectedRows[0].Cells[9].Value.ToString(),
                dgv_recipe_child.SelectedRows[0].Cells[10].Value.ToString(),
                dgv_recipe_child.SelectedRows[0].Cells[11].Value.ToString(),
                0.00);
            Close();
        }
    }
}
