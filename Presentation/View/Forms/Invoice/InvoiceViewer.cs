using Common.Models;
using DataAccess.Data;
using Domain;
using Presentation.View.Forms.Payment;
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
    public partial class InvoiceViewer : Form
    {
        ClientAccountData clientAccountData = new ClientAccountData();
        public InvoiceViewer()
        {
            InitializeComponent();
        }

        private void pcb_close_invoice_client_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_get_invoice_Click(object sender, EventArgs e)
        {
            ClientController clientController = new ClientController();
            if (dgv_invoices_client.SelectedRows.Count > 0)
            {
                clientController.GetClientAccountById(Convert.ToInt64(dgv_invoices_client.SelectedRows[0].Cells[0].Value));
                PayFee payFee = new PayFee();
                payFee.lbl_client_name.Text = ClientAccount.client_name + " " + ClientAccount.client_lastname;
                payFee.lbl_company_name.Text = ClientAccount.company_name;
                payFee.lbl_invoice.Text = ClientAccount.invoice_number.ToString();
                payFee.lbl_date_invoice.Text = ClientAccount.invoice_date.ToString();
                payFee.lbl_fee.Text = "$" + ClientAccount.fee.ToString();
                payFee.lbl_balance.Text = "$" + ClientAccount.balance.ToString();
                payFee.lbl_invoice_payment.Text = "$" + ClientAccount.invoice_total.ToString();
                // payFee.txt_invoice_id.Text = ClientAccount.id_client_account.ToString();
                payFee.txt_invoice_id.Text = dgv_invoices_client.SelectedRows[0].Cells[0].Value.ToString();
                payFee.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro de la tabla para modificar", "Aviso");
            }
        }

        private void InvoiceViewer_Load(object sender, EventArgs e)
        {
            dgv_invoices_client.Columns[0].HeaderText = "FACTURA";
            dgv_invoices_client.Columns[0].Width = 75;
            dgv_invoices_client.Columns[0].Frozen = true;
            dgv_invoices_client.Columns[1].Visible = false;
            dgv_invoices_client.Columns[2].Visible = false;
            dgv_invoices_client.Columns[3].HeaderText = "SALDO";
            dgv_invoices_client.Columns[4].HeaderText = "TOTAL";
            dgv_invoices_client.Columns[5].HeaderText = "FECHA";
            dgv_invoices_client.Columns[6].HeaderText = "ÚLTIMO PAGO";
        }
    }
}
