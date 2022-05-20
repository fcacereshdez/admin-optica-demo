using Common.Cache;
using Domain;
using Presentation.View.Forms.Client;
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
    public partial class InvoiceCreate : Form
    {
        public InvoiceCreate()
        {
            InitializeComponent();
            InsertAction("está en el creador de facturas.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pcb_close_create_invoice_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_search_client_Click(object sender, EventArgs e)
        {
            ClientSelector clientSelector = new ClientSelector();
            AddOwnedForm(clientSelector);
            clientSelector.ShowDialog();
        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
