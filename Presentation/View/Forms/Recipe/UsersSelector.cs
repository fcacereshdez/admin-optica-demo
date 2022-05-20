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
    public partial class UsersSelector : Form
    {
        UserController userController = new UserController();
        public UsersSelector()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            cmb_roles.DataSource = userController.SelectAllRoles();
            cmb_roles.DisplayMember = "role";
            cmb_roles.ValueMember = "role_id";
        }

        private void dgv_users_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RecipeCreate recipeCreate = ((RecipeCreate)(Owner));
            if (txt_search.Text == "optometryst")
            {
                recipeCreate.txt_optometryst.Text = dgv_users.SelectedRows[0].Cells[1].Value.ToString();
                recipeCreate.txt_id_optometryst.Text = dgv_users.SelectedRows[0].Cells[0].Value.ToString();
            }else if (txt_search.Text == "seller")
            {
                recipeCreate.txt_seller.Text = dgv_users.SelectedRows[0].Cells[1].Value.ToString();
                recipeCreate.txt_seller_id.Text = dgv_users.SelectedRows[0].Cells[0].Value.ToString();
            }
            Close();
        }

        private void btn_search_roles_Click(object sender, EventArgs e)
        {
            dgv_users.DataSource = userController.SelectUsersByRoleId(cmb_roles.SelectedValue.ToString());
        }
    }
}
