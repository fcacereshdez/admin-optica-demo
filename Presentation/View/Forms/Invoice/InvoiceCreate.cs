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
    }
}
