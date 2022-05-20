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
            recipeCreate.lbl_client_age.Text = dgv_clients_child.CurrentRow.Cells[6].Value.ToString();
            recipeCreate.txt_id_client.Text = dgv_clients_child.CurrentRow.Cells[0].Value.ToString();
            recipeCreate.dgv_recipes.DataSource = recipeController.SelectAllRecipesById(dgv_clients_child.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void SelectAllClients()
        {
            dgv_clients_child.DataSource = clientController.SelectAllClients();
        }

    }
}
