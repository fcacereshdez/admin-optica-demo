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
            Dock = DockStyle.Fill;
        }

        private void SelectAllInvoice()
        {
            dgv_invoices.DataSource = invoiceController.SelectAllInvoices();
            dgv_invoices.Columns[0].Width = 60;
            dgv_invoices.Columns[1].Visible = false;
            dgv_invoices.Columns[2].Width = 353;
            dgv_invoices.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_invoices.Columns[3].Width = 60;
        }

        private void btn_create_invoice_Click(object sender, EventArgs e)
        {
            InvoiceCreate invoiceCreate = new InvoiceCreate();
            invoiceCreate.FormClosed += new FormClosedEventHandler(InvoiceCreate_FormClosed);
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

        private void btn_delete_invoice_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminación", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                UserController userController = new UserController();
                try
                {
                    invoiceController.DeleteInvoice(dgv_invoices.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("Registro eliminado", "Procesado", MessageBoxButtons.OK);
                    userController.InsertActionsUser("Eliminió una factura", Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    SelectAllInvoice();
                }
                catch (Exception errInvoice)
                {
                    MessageBox.Show("Ocurrió un error al intentar ejecutar esto.\n\nError: " + errInvoice.Message, "Facturas");
                }

            }
        }

        private void btn_edit_invoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario en desarrollo.", "Facturas");
        }
        private void InvoiceCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelectAllInvoice();
        }
    }
}
