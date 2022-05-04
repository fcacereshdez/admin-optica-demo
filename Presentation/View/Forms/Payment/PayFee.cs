using Domain;
using Presentation.View.Forms.Invoice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.View.Forms.Payment
{
    public partial class PayFee : Form
    {
        ClientController clientController = new ClientController();
        public PayFee()
        {
            InitializeComponent();
        }

        private void pcb_close_payment_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (txt_amount.Text == "")
            {
                lbl_error.Text = "El abono no puede estar vacío";
            }
            else
            {
                clientController.PayInovice(txt_amount.Text, txt_invoice_id.Text);
                MessageBox.Show("Abono aplicado", "Abonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
