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

namespace Presentation.View.Forms.Bank
{
    public partial class BankCreate : Form
    {
        BankController bankController = new BankController();

        public BankCreate()
        {
            InitializeComponent();
        }

        private void pcb_close_create_bank_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_bank_Click(object sender, EventArgs e)
        {
            if (txt_bank_name.Text == "")
            {
                lbl_error.Text = "El banco debe poseer un nombre";
            }else if(txt_bank_account.Text == "")
            {
                lbl_error.Text = "Sugerimos asignar el número de cuenta del banco";
            }else if(txt_last_check.Text == "")
            {
                lbl_error.Text = "El último cheque debe ser por lo menos 0";
            }else if (txt_balance.Text == "")
            {
                lbl_error.Text = "Debes ingresar al menos 0.00 en el balance actual";
            }
            else
            {
                try
                {
                    bankController.CreateBank(txt_bank_name.Text, txt_last_check.Text, txt_bank_account.Text, txt_balance.Text);
                    MessageBox.Show("Banco generado con éxito.", "Bancos");
                    Close();
                }
                catch (Exception bankErr)
                {
                    MessageBox.Show("Ocurrió un error mientras intentabamos ejecutar esto.\n\nError: " + bankErr.Message, "Bancos");
                }
            }
        }
    }
}
