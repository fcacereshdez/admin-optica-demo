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

namespace Presentation.View.Forms.Bank
{
    public partial class BankForm : Form
    {
        BankController bankController = new BankController();

        public BankForm()
        {
            InitializeComponent();
        }

        private void BankForm_Load(object sender, EventArgs e)
        {
            SelectAllBanks();
            Dock = DockStyle.Fill;
        }

        private void SelectAllBanks()
        {
            dgv_banks.DataSource = bankController.SelectAllBanks();
            dgv_banks.Columns[0].Visible = false;
            dgv_banks.Columns[1].Width = 300;
            dgv_banks.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_banks.Columns[2].Width = 200;
        }

        private void txt_search_bank_TextChanged(object sender, EventArgs e)
        {
            SearchBanks(txt_search_bank.Text);
        }

        private void SearchBanks(string bank)
        {
            dgv_banks.DataSource = bankController.SearchBank(bank);
            dgv_banks.Columns[0].Visible = false;
            dgv_banks.Columns[1].Width = 300;
            dgv_banks.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_banks.Columns[2].Width = 200;
        }

        private void btn_create_bank_Click(object sender, EventArgs e)
        {
            BankCreate bankCreate = new BankCreate();
            bankCreate.FormClosed += new FormClosedEventHandler(BankCreate_FormClosed);
            bankCreate.ShowDialog();
        }

        private void btn_edit_bank_Click(object sender, EventArgs e)
        {
            bankController.SelectBankById(dgv_banks.SelectedRows[0].Cells[0].Value.ToString());
            BankEdit bankEdit = new BankEdit();
            bankEdit.FormClosed += new FormClosedEventHandler(BankEdit_FormClosed);
            bankEdit.ShowDialog();
        }

        private void BankCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelectAllBanks();
        }

        private void BankEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelectAllBanks();
        }

        private void btn_delete_bank_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminación", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                UserController userController = new UserController();
                try
                {
                    bankController.DeleteBankt(dgv_banks.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("Registro eliminado", "Procesado", MessageBoxButtons.OK);
                    userController.InsertActionsUser("Eliminió un banco", Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    SelectAllBanks();
                }
                catch (Exception errBanks)
                {
                    MessageBox.Show("Ocurrió un error al intentar ejecutar esto.\n\nError: " + errBanks.Message, "Bancos");
                }

            }
        }
    }
}
