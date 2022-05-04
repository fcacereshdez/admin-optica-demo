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

namespace Presentation.View.Forms.Client
{
    public partial class ClientForm : Form
    {
        ClientController clientController = new ClientController();
        public ClientForm()
        {
            InitializeComponent();
            SelectAllClients();
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
            dgv_clients.DataSource = clientController.SelectAllClients();
            dgv_clients.Columns[0].Width = 25;
            dgv_clients.Columns[1].Width = 170;
            dgv_clients.Columns[2].Width = 75;
            dgv_clients.Columns[3].Width = 90;
            dgv_clients.Columns[4].Width = 126;
            dgv_clients.Columns[5].Width = 90;
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
                SelectClientById(dgv_clients.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro de la tabla para modificar", "Aviso");
            }
        }

        private void SelectClientById(string client_id)
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
    }
}
