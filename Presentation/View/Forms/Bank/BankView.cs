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
    public partial class BankView : Form
    {
        BankController bankController = new BankController();

        public BankView()
        {
            InitializeComponent();
        }

        private void pcb_close_create_bank_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void LoadData()
        {
            txt_bank_name.Text = Common.Models.Bank.bank_name;
            txt_last_check.Text = Common.Models.Bank.last_check.ToString();
            txt_bank_account.Text = Common.Models.Bank.number_account;
            txt_balance.Text = Common.Models.Bank.bank_balance.ToString();
        }

        private void BankEdit_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
