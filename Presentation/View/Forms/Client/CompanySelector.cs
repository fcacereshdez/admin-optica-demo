using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace Presentation.View.Forms.Client
{
    public partial class CompanySelector : Form
    {
        public CompanySelector()
        {
            InitializeComponent();
            SelectAllCompanies();
            InsertAction("está seleccionando una empresa desde el creador de clientes.");
        }

        CompanyController companyController = new CompanyController();
        private void dgv_companies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientCreate clientCreate = ((ClientCreate)(Owner));
            clientCreate.txt_company_client_view.Text = dgv_companies_child.CurrentRow.Cells[1].Value.ToString();
            clientCreate.txt_company_client.Text = dgv_companies_child.CurrentRow.Cells[0].Value.ToString();
            InsertAction("seleccionó una empresa para asignarlo a un cliente");
            Close();
        }

        private void SelectAllCompanies()
        {
            dgv_companies_child.DataSource = companyController.SelectAllCompanies();
            dgv_companies_child.Columns[0].Width = 25;
            dgv_companies_child.Columns[1].Width = 170;
            dgv_companies_child.Columns[2].Width = 75;
            dgv_companies_child.Columns[3].Width = 90;
            dgv_companies_child.Columns[4].Width = 130;
            dgv_companies_child.Columns[5].Width = 90;
        }

        private void pcb_close_create_client_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void txt_search_company_TextChanged(object sender, EventArgs e)
        {
            dgv_companies_child.DataSource = companyController.SearchCompany(txt_search_company.Text);
        }
    }
}
