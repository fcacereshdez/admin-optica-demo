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
    public partial class InvoiceView : Form
    {
        ClientAccountData clientAccountData = new ClientAccountData();
        public InvoiceView()
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
                clientController.GetClientAccountById(Convert.ToInt64(dgv_invoices_client.CurrentRow.Cells[1].Value));
                PayFee payFee = new PayFee();
                payFee.lbl_client_name.Text = ClientAccount.client_name + " " + ClientAccount.client_lastname;
                payFee.lbl_company_name.Text = ClientAccount.company_name;
                payFee.lbl_invoice.Text = ClientAccount.invoice_number.ToString();
                payFee.lbl_date_invoice.Text = ClientAccount.invoice_date.ToString();
                payFee.lbl_fee.Text = "$" + ClientAccount.fee.ToString();
                payFee.lbl_balance.Text = "$" + ClientAccount.balance.ToString();
                payFee.lbl_type_payment.Text = "Próximamente";
                payFee.txt_invoice_id.Text = ClientAccount.id_client_account.ToString();
                payFee.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro de la tabla para modificar", "Aviso");
            }
        }
    }
}
