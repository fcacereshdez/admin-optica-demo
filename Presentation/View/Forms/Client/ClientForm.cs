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

namespace Presentation.View.Forms.Client
{
    public partial class ClientForm : Form
    {
        ClientController clientController = new ClientController();
        public ClientForm()
        {
            InitializeComponent();
        }

        public void SelectAllClients()
        {
            dgv_clients.DataSource = clientController.SelectAllClients();
            dgv_clients.Columns[0].Width = 25;
            dgv_clients.Columns[1].Width = 170;
            dgv_clients.Columns[2].Width = 75;
            dgv_clients.Columns[3].Width = 90;
            dgv_clients.Columns[4].Width = 130;
            dgv_clients.Columns[5].Width = 90;
        }

        private void btn_create_client_Click(object sender, EventArgs e)
        {
            ClientCreate clientCreate = new ClientCreate();
            clientCreate.ShowDialog();
        }
    }
}
