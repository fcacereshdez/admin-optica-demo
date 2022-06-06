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
    public partial class ClientsSelector : Form
    {
        ClientController clientController = new ClientController();
        RecipeController recipeController = new RecipeController();
        public ClientsSelector()
        {
            InitializeComponent();
            SelectAllClients();
        }

        private void dgv_clients_child_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RecipeCreate recipeCreate = ((RecipeCreate)(Owner));
            recipeCreate.lbl_client_name.Text = dgv_clients_child.CurrentRow.Cells[1].Value.ToString();
            recipeCreate.lbl_company_name.Text = dgv_clients_child.CurrentRow.Cells[5].Value.ToString();
            recipeCreate.lbl_phone_client.Text = dgv_clients_child.CurrentRow.Cells[4].Value.ToString();
       //     recipeCreate.lbl_client_age.Text = dgv_clients_child.CurrentRow.Cells[6].Value.ToString(); problema de la edad
            recipeCreate.txt_id_client.Text = dgv_clients_child.CurrentRow.Cells[0].Value.ToString();
            recipeCreate.dgv_recipes.DataSource = recipeController.SelectAllRecipesById(dgv_clients_child.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void SelectAllClients()
        {
            dgv_clients_child.DataSource = clientController.SelectAllClients();
            dgv_clients_child.Columns[0].Visible = false;
            dgv_clients_child.Columns[1].Width = 275;
            dgv_clients_child.Columns[2].Visible = false;
            dgv_clients_child.Columns[3].Visible = false;
            dgv_clients_child.Columns[4].Visible = false;
            dgv_clients_child.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_clients_child.Columns[6].Visible = false;
        }

        private void pcb_close_create_client_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_search_client_TextChanged(object sender, EventArgs e)
        {
            dgv_clients_child.DataSource = clientController.SearchClient(txt_search_client.Text);
        }
    }
}
