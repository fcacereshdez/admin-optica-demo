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

namespace Presentation.View.Forms.Invoice
{
    public partial class UserSelector : Form
    {
        UserController userController = new UserController();
        public UserSelector()
        {
            InitializeComponent();
            SelectAllUsersByRole();
        }

        private void dgv_users_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InvoiceCreate invoiceCreate = ((InvoiceCreate)(Owner));
            if (txt_search.Text == "optometryst")
            {
               invoiceCreate.txt_optometryst.Text = dgv_users.SelectedRows[0].Cells[1].Value.ToString();
               invoiceCreate.txt_optometryst_id.Text = dgv_users.SelectedRows[0].Cells[0].Value.ToString();
               Close();
            }
            else if (txt_search.Text == "seller")
            {
                invoiceCreate.txt_seller.Text = dgv_users.SelectedRows[0].Cells[1].Value.ToString();
                invoiceCreate.txt_seller_id.Text = dgv_users.SelectedRows[0].Cells[0].Value.ToString();
                Close();
            }
            else if (txt_search.Text == "manager")
            {
                invoiceCreate.txt_manager.Text = dgv_users.SelectedRows[0].Cells[1].Value.ToString();
                invoiceCreate.txt_manager_id.Text = dgv_users.SelectedRows[0].Cells[0].Value.ToString();
                Close();
            }
        }

        private void SelectAllUsersByRole()
        {
            cmb_roles.DataSource = userController.SelectAllRoles();
            cmb_roles.DisplayMember = "role";
            cmb_roles.ValueMember = "role_id";
        }

        private void btn_search_roles_Click(object sender, EventArgs e)
        {
            dgv_users.DataSource = userController.SelectUsersByRoleId(cmb_roles.SelectedValue.ToString());
            dgv_users.Columns[0].Visible = false;
            dgv_users.Columns[1].Width = 375;
        }
    }
}
