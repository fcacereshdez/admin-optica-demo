using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.Models;
using Presentation.View.Forms.Payment;
using Presentation.View.Forms.Invoice;
using Common.Cache;

namespace Presentation.View.Forms.Client
{
    public partial class ClientForm : Form
    {
        ClientController clientController = new ClientController();
        public ClientForm()
        {
            InitializeComponent();
            SelectAllClients();
            ClientsLoaded();

            Dock = DockStyle.Fill;
        }

        private void ClientCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelectAllClients();
        }

        private void ClientEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelectAllClients();
        }

        public void SelectAllClients()
        {
            try
            {
                dgv_clients.DataSource = clientController.SelectAllClients();
                dgv_clients.ClearSelection();
                dgv_clients.Columns[0].Visible = false;
                dgv_clients.Columns[1].Width = 275;
                dgv_clients.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_clients.Columns[2].Visible = false;
                dgv_clients.Columns[3].Width = 90;
                dgv_clients.Columns[4].Visible = false;
                dgv_clients.Columns[5].Width = 275;
                dgv_clients.Columns[6].Visible = false;
            }
            catch (Exception LClients)
            {
                MessageBox.Show("Ocurrió un error al intentar cargar a los clientes. \n\nError: " + LClients.Message, "Clientes");
            }
        }

        private void btn_create_client_Click(object sender, EventArgs e)
        {
            ClientCreate clientCreate = new ClientCreate();
            clientCreate.ShowDialog();
        }

        private void btn_edit_client_Click(object sender, EventArgs e)
        {
            if (dgv_clients.SelectedRows.Count > 0)
            {
                try
                {
                    SelectClientById(dgv_clients.CurrentRow.Cells[0].Value.ToString());
                }
                catch (Exception EClient)
                {
                    MessageBox.Show("Ocurrió un error al iniciar el editor de clientes. \n\nError: " + EClient.Message, "Clientes");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro de la tabla para modificar", "Clientes");
            }
        }

        private void SelectClientById(string client_id)
        {
            try
            {
                ClientController clientController = new ClientController();
                clientController.SelectClientById(client_id);
                ClientEdit clientEdit = new ClientEdit();
                clientEdit.txt_name_client.Text = Common.Models.Client.name;
                clientEdit.txt_lastname_client.Text = Common.Models.Client.lastname;
                clientEdit.txt_dui_client.Text = Common.Models.Client.dui;
                clientEdit.txt_nit_client.Text = Common.Models.Client.nit;
                clientEdit.txt_address_client.Text = Common.Models.Client.address;
                clientEdit.txt_phone_client.Text = Common.Models.Client.phone;
                clientEdit.txt_secondary_phone_client.Text = Common.Models.Client.secondary_phone;
                clientEdit.txt_email_client.Text = Common.Models.Client.email;
                clientEdit.txt_notes_client.Text = Common.Models.Client.notes;
                clientEdit.txt_id_client.Text = Common.Models.Client.client_id.ToString();
                clientEdit.ShowDialog();
            }
            catch (Exception SelClient)
            {
                MessageBox.Show("Ocurrió un error al seleccionar este cliente. \n\nError: " + SelClient.Message, "Clientes");
            }
        }

        private void btn_pay_fee_Click(object sender, EventArgs e)
        {
            ClientController clientController = new ClientController();
            if (dgv_clients.SelectedRows.Count > 0)
            {
                InvoiceView invoiceView = new InvoiceView();
                try
                {
                    invoiceView.dgv_invoices_client.DataSource = clientController.GetInvoiceByClient(Convert.ToInt64(dgv_clients.CurrentRow.Cells[0].Value));
                    invoiceView.dgv_invoices_client.Columns[0].Width = 25;
                    invoiceView.dgv_invoices_client.Columns[1].Width = 75;
                    invoiceView.dgv_invoices_client.Columns[2].Width = 130;
                    invoiceView.dgv_invoices_client.Columns[3].Width = 100;
                    invoiceView.ShowDialog();
                }
                catch (Exception PClients)
                {
                    MessageBox.Show("Ocurrió un error al iniciar el proceso de abono. \n\nError: " + PClients.Message, "Clientes");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro de la tabla para modificar", "Aviso");
            }
        }
        private void txt_search_client_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_clients.DataSource = clientController.SearchClient(txt_search_client.Text);
            }
            catch (Exception SClients)
            {

                MessageBox.Show("Tuvimos un problema al intentar buscar los clientes para ti. \n\nError: " + SClients.Message, "Clientes");
            }
        }

        private void ClientsLoaded()
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " ingresó al gestor de clientes", Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void btn_delete_client_Click(object sender, EventArgs e)
        {
            DialogResult msgDelete = MessageBox.Show("¿Desea eliminar este registro?", "Clientes", MessageBoxButtons.OKCancel);

            if (msgDelete == DialogResult.OK)
            {
                try
                {
                    clientController.DeleteClient(dgv_clients.SelectedRows[0].Cells[0].Value.ToString());
                    SelectAllClients();
                    MessageBox.Show("Cliente eliminado.", "Clientes", MessageBoxButtons.OK);
                }
                catch (Exception dClients)
                {

                    MessageBox.Show("Ocurrión un error al eliminarlo. \n\nError: " + dClients.Message, "Clientes");
                }
            }
        }
    }
}
