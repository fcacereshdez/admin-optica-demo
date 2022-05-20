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
using Presentation.View.Forms.Client;

namespace Presentation.View.Forms.Company
{
    public partial class CompanyForm : Form
    {
        CompanyController companyController = new CompanyController();

        public CompanyForm()
        {
            InitializeComponent();
            SelectAllCompanies();
            InsertActionUser();
        }

        private void SelectAllCompanies()
        {
            dgv_companies.DataSource = companyController.SelectAllCompanies();
            // dgv_companies.Columns[0].Width = 30;
            dgv_companies.Columns[1].Width = 225;
            dgv_companies.Columns[2].Width = 75;
            dgv_companies.Columns[3].Width = 90;
            dgv_companies.Columns[4].Width = 130;
            dgv_companies.Columns[5].Width = 90;
        }

        private void btn_create_company_Click(object sender, EventArgs e)
        {
            CompanyCreate companyCreate = new CompanyCreate();
            companyCreate.FormClosed += new FormClosedEventHandler(CompanyCreate_FormClosed);
            companyCreate.ShowDialog();
        }

        private void CompanyCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelectAllCompanies();
        }

        private void btn_edit_company_Click(object sender, EventArgs e)
        {
            companyController.SelectCompanyById(dgv_companies.SelectedRows[0].Cells[0].Value.ToString());
            CompanyEdit companyEdit = new CompanyEdit();
            companyEdit.FormClosed += new FormClosedEventHandler(CompanyEdit_FormClosed);
            companyEdit.ShowDialog();
        }

        private void CompanyEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelectAllCompanies();
        }

        private void InsertActionUser()
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " accedió a la gestión de empresas", Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void btn_delete_company_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminación", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                UserController userController = new UserController();
                try
                {
                    companyController.DeleteCompany(Convert.ToInt64(dgv_companies.SelectedRows[0].Cells[0].Value.ToString()));
                    MessageBox.Show("Registro eliminado", "Procesado", MessageBoxButtons.OK);
                    userController.InsertActionsUser("Eliminió una empresa", Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    SelectAllCompanies();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error MSSQLSERVER (0x000001): " + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_view_company_Click(object sender, EventArgs e)
        {
            companyController.SelectCompanyById(dgv_companies.SelectedRows[0].Cells[0].Value.ToString());
            CompanyView companyView  = new CompanyView();
            companyView.ShowDialog();
        }

        private void pcb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_company_report_Click(object sender, EventArgs e)
        {
            companyController.GetTotalByCompany(Convert.ToInt64(dgv_companies.SelectedRows[0].Cells[0].Value));
            CompanyReportBySelected companyReportBySelected = new CompanyReportBySelected();
            companyReportBySelected.dgv_clients_by_company.DataSource = companyController.GetClientsByCompany(Convert.ToInt64(dgv_companies.SelectedRows[0].Cells[0].Value));
            companyReportBySelected.lbl_company.Text = Common.Models.Company.full_name;
            companyReportBySelected.lbl_invoices.Text = Common.Models.Company.invoices.ToString();
            companyReportBySelected.lbl_total_clients.Text = Common.Models.Company.total_clients.ToString();
            companyReportBySelected.lbl_sales_total.Text = "$" + Common.Models.Company.total_invoice.ToString();
            companyReportBySelected.ShowDialog();
        }

        private void btn_report_companies_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_search_company_TextChanged(object sender, EventArgs e)
        {
            dgv_companies.DataSource = companyController.SearchCompany(txt_search_company.Text);
        }
    }
}
