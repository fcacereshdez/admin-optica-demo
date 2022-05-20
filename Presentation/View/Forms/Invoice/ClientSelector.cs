using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;
using Presentation.View.Forms.Invoice;

namespace Presentation.View.Forms.Client
{
    public partial class ClientSelector : Form
    {
        public ClientSelector()
        {
            InitializeComponent();
            SelectAllClients();
            InsertAction("está seleccionando un cliente desde el creador de facturas.");
        }

        ClientController clientController = new ClientController();
        private void dgv_companies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InvoiceCreate invoiceCreate = ((InvoiceCreate)(Owner));
            invoiceCreate.lbl_client_name.Text = dgv_clients_child.CurrentRow.Cells[1].Value.ToString();
            invoiceCreate.txt_client_id.Text = dgv_clients_child.CurrentRow.Cells[0].Value.ToString();
            Close(); 
        }

        private void SelectAllClients()
        {
            dgv_clients_child.DataSource = clientController.SelectAllClients();
            dgv_clients_child.Columns[0].Width = 25;
            dgv_clients_child.Columns[1].Width = 170;
            dgv_clients_child.Columns[2].Width = 75;
            dgv_clients_child.Columns[3].Width = 90;
            dgv_clients_child.Columns[4].Width = 130;
            dgv_clients_child.Columns[5].Width = 90;
        }

        private void pcb_close_create_client_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
