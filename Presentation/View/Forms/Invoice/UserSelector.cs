using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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
                try
                {
                    invoiceCreate.txt_optometryst.Text = dgv_users.SelectedRows[0].Cells[1].Value.ToString();
                    invoiceCreate.txt_optometryst_id.Text = dgv_users.SelectedRows[0].Cells[0].Value.ToString();
                    Close();
                }
                catch (Exception errOptometyst)
                {
                    MessageBox.Show("Ocurrió un error mientras intentabamos seleccionar el Optómetra.\n\nError: " + errOptometyst.Message, "Selector de Usuarios");
                }
            }
            else if (txt_search.Text == "seller")
            {
                try
                {
                    invoiceCreate.txt_seller.Text = dgv_users.SelectedRows[0].Cells[1].Value.ToString();
                    invoiceCreate.txt_seller_id.Text = dgv_users.SelectedRows[0].Cells[0].Value.ToString();
                    Close();
                }
                catch (Exception errOptometyst)
                {
                    MessageBox.Show("Ocurrió un error mientras intentabamos seleccionar el Vendedor.\n\nError: " + errOptometyst.Message, "Selector de Usuarios");
                }
            }
            else if (txt_search.Text == "manager")
            {
                try
                {
                    invoiceCreate.txt_manager.Text = dgv_users.SelectedRows[0].Cells[1].Value.ToString();
                    invoiceCreate.txt_manager_id.Text = dgv_users.SelectedRows[0].Cells[0].Value.ToString();
                    Close();
                }
                catch (Exception errOptometyst)
                {
                    MessageBox.Show("Ocurrió un error mientras intentabamos seleccionar el Gestor.\n\nError: " + errOptometyst.Message, "Selector de Usuarios");
                }
            }
        }

        private void SelectAllUsersByRole()
        {
            cmb_roles.DisplayMember = "Text";
            cmb_roles.ValueMember = "Value";

            var items = new[]
            {
                new { Text = "Seleccionar", Value = "0" },
                new { Text = "Optometra", Value = "1"},
                new { Text = "Asesor", Value = "2" },
                new { Text = "Gestor", Value = "3" }
            };

            cmb_roles.DataSource = items;
        }

        private void btn_search_roles_Click(object sender, EventArgs e)
        {
            if (cmb_roles.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Debes seleccionar un rol para continuar", "Selector de Usuarios");
            }else if (cmb_roles.SelectedValue.ToString() == "1")
            {
                dgv_users.DataSource = userController.SelectUsersIsOptometrist();
                dgv_users.Columns[0].Visible = false;
                dgv_users.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_users.Columns[2].Visible = false;
                dgv_users.Columns[3].Visible = false;
                dgv_users.Columns[4].Visible = false;
            }
            else if (cmb_roles.SelectedValue.ToString() == "2")
            {
                dgv_users.DataSource = userController.SelectUsersIsConsultant();
                dgv_users.Columns[0].Visible = false;
                dgv_users.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_users.Columns[2].Visible = false;
                dgv_users.Columns[3].Visible = false;
                dgv_users.Columns[4].Visible = false;
            }
            else if (cmb_roles.SelectedValue.ToString() == "3")
            {
                dgv_users.DataSource = userController.SelectUsersIsManager();
                dgv_users.Columns[0].Visible = false;
                dgv_users.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_users.Columns[2].Visible = false;
                dgv_users.Columns[3].Visible = false;
                dgv_users.Columns[4].Visible = false;
            }
        }

        private void pcb_close_create_invoice_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
