using Common.Cache;
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
            InsertAction("está en el gestor de facturas.");
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

        private void txt_search_company_TextChanged(object sender, EventArgs e)
        {

        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
