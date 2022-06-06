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
            dgv_recipe_child.Columns[0].Visible = false;
            dgv_recipe_child.Columns[1].Visible = false;
            dgv_recipe_child.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_recipe_child.Columns[4].Visible = false;
            dgv_recipe_child.Columns[5].Visible = false;
            dgv_recipe_child.Columns[6].Visible = false;
            dgv_recipe_child.Columns[7].Visible = false;
            dgv_recipe_child.Columns[8].Visible = false;
            dgv_recipe_child.Columns[9].Visible = false;
            dgv_recipe_child.Columns[10].Visible = false;
            dgv_recipe_child.Columns[11].Visible = false;
            dgv_recipe_child.Columns[12].Visible = false;
            dgv_recipe_child.Columns[13].Visible = false;
        }

        private void dgv_recipe_child_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InvoiceCreate invoiceCreate = ((InvoiceCreate)(Owner));
            invoiceCreate.txt_recipe_id.Text = dgv_recipe_child.SelectedRows[0].Cells[0].Value.ToString();
            invoiceCreate.lbl_client_name.Text = dgv_recipe_child.SelectedRows[0].Cells[3].Value.ToString();
            invoiceCreate.dgv_products.Rows.Add(dgv_recipe_child.SelectedRows[0].Cells[5].Value.ToString(),
                dgv_recipe_child.SelectedRows[0].Cells[6].Value.ToString(),
                dgv_recipe_child.SelectedRows[0].Cells[7].Value.ToString(),
                dgv_recipe_child.SelectedRows[0].Cells[13].Value.ToString(),
                dgv_recipe_child.SelectedRows[0].Cells[8].Value.ToString());
            invoiceCreate.dgv_products.Rows.Add(dgv_recipe_child.SelectedRows[0].Cells[9].Value.ToString(),
                dgv_recipe_child.SelectedRows[0].Cells[10].Value.ToString(),
                dgv_recipe_child.SelectedRows[0].Cells[11].Value.ToString(),
                dgv_recipe_child.SelectedRows[0].Cells[13].Value.ToString(),
                dgv_recipe_child.SelectedRows[0].Cells[12].Value.ToString());
            invoiceCreate.CalculateInvoice();
            Close();
        }

        private void txt_search_recipe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_recipe_child.DataSource = recipeController.SearchRecipe(txt_search_recipe.Text);
                dgv_recipe_child.Columns[0].Width = 60;
                dgv_recipe_child.Columns[3].Width = 413;
                dgv_recipe_child.Columns[1].Visible = false;
                dgv_recipe_child.Columns[4].Visible = false;
                dgv_recipe_child.Columns[5].Visible = false;
                dgv_recipe_child.Columns[6].Visible = false;
                dgv_recipe_child.Columns[7].Visible = false;
                dgv_recipe_child.Columns[8].Visible = false;
                dgv_recipe_child.Columns[9].Visible = false;
                dgv_recipe_child.Columns[10].Visible = false;
                dgv_recipe_child.Columns[11].Visible = false;
            }
            catch (Exception errRecipes)
            {
                MessageBox.Show("Ocurrió un error al intentar ejecutar esto.\n\nError: " + errRecipes.Message, "Recetas");
            }
        }
    }
}
