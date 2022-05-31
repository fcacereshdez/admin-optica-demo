using Common.Cache;
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
        CommonController commonController = new CommonController();
        public PayFee()
        {
            InitializeComponent();
            LoadCommonData();
            lbl_error.Visible = false;
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
                lbl_error.Visible = true;
                lbl_error.Text = "El abono no puede estar vacío";
            }
            else
            {
                try
                {
                    clientController.PayInovice(cmb_method_payment.SelectedValue.ToString(), txt_amount.Text, cmb_bank.SelectedValue.ToString(), txt_ref_bank.Text, txt_invoice_id.Text);
                    MessageBox.Show("Abono aplicado", "Abonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InsertAction("abonó " + txt_amount.Text + " al cliente " + lbl_client_name.Text + " en la factura " + lbl_invoice.Text);
                    this.Close();
                }
                catch (Exception errPayments)
                {
                    MessageBox.Show("Ocurrió un error al intentar ejecutar esto.\n\nError: " + errPayments.Message, "Abonos");
                }
            }
        }

        private void LoadCommonData()
        {
            cmb_bank.DataSource = commonController.SelectAllBank();
            cmb_bank.DisplayMember = "bank_name";
            cmb_bank.ValueMember = "bank_id";
            cmb_method_payment.DataSource = commonController.SelectAllPaymentMethod();
            cmb_method_payment.DisplayMember = "payment_method";
            cmb_method_payment.ValueMember = "payment_method_id";
            cmb_method_payment.SelectedValue = 1;
        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

    }
}
