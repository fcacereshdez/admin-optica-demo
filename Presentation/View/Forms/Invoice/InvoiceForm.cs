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
    public partial class InvoiceForm : Form
    {
        InvoiceController invoiceController = new InvoiceController();
        public InvoiceForm()
        {
            InitializeComponent();
            SelectAllInvoice();
        }

        private void SelectAllInvoice()
        {
            dgv_invoices.DataSource = invoiceController.SelectAllInvoices();
        }

        private void btn_create_invoice_Click(object sender, EventArgs e)
        {
            InvoiceCreate invoiceCreate = new InvoiceCreate();
            invoiceCreate.ShowDialog();
        }
    }
}
