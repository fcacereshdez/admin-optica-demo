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
            try
            {
                dgv_companies.DataSource = companyController.SelectAllCompanies();
                dgv_companies.Columns[0].Width = 35;
                dgv_companies.Columns[1].Width = 275;
                dgv_companies.Columns[2].Visible = false;
                dgv_companies.Columns[3].Width = 85;
                dgv_companies.Columns[4].Width = 128;
                dgv_companies.Columns[5].Width = 75;
            }
            catch (Exception ECompanies)
            {
                MessageBox.Show("Occurió un error mientras intentabamos cargar los datos.\n\nError: " + ECompanies.Message, "Empresas");
            }
        }

        private void btn_create_company_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyCreate companyCreate = new CompanyCreate();
                companyCreate.FormClosed += new FormClosedEventHandler(CompanyCreate_FormClosed);
                companyCreate.ShowDialog();
            }
            catch (Exception errCompanies)
            {
                MessageBox.Show("Ocurrió un error al intentar ejecutar esto.\n\nError: "+errCompanies.Message, "Empresas");
            }
        }

        private void CompanyCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelectAllCompanies();
        }

        private void btn_edit_company_Click(object sender, EventArgs e)
        {
            try
            {
                companyController.SelectCompanyById(dgv_companies.SelectedRows[0].Cells[0].Value.ToString());
                CompanyEdit companyEdit = new CompanyEdit();
                companyEdit.FormClosed += new FormClosedEventHandler(CompanyEdit_FormClosed);
                companyEdit.ShowDialog();
            }
            catch (Exception errCompanies)
            {
                MessageBox.Show("Ocurrió un error al intentar ejecutar esto.\n\nError: " + errCompanies.Message, "Empresas");
            }
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
                catch (Exception errCompanies)
                {
                    MessageBox.Show("Ocurrió un error al intentar ejecutar esto.\n\nError: " + errCompanies.Message, "Empresas");
                }

            }
        }

        private void btn_view_company_Click(object sender, EventArgs e)
        {
            try
            {
                companyController.SelectCompanyById(dgv_companies.SelectedRows[0].Cells[0].Value.ToString());
                CompanyView companyView = new CompanyView();
                companyView.ShowDialog();
            }
            catch (Exception errCompanies)
            {
                MessageBox.Show("Ocurrió un error al intentar ejecutar esto.\n\nError: " + errCompanies.Message, "Empresas");
            }
        }

        private void pcb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_company_report_Click(object sender, EventArgs e)
        {
            try
            {
                companyController.GetTotalByCompany(Convert.ToInt64(dgv_companies.SelectedRows[0].Cells[0].Value));
                CompanyReportBySelected companyReportBySelected = new CompanyReportBySelected();
                companyReportBySelected.dgv_clients_by_company.DataSource = companyController.GetClientsByCompany(Convert.ToInt64(dgv_companies.SelectedRows[0].Cells[0].Value));
                companyReportBySelected.lbl_company.Text = Common.Models.Company.full_name;
                companyReportBySelected.lbl_invoices.Text = Common.Models.Company.invoices.ToString();
                companyReportBySelected.lbl_total_clients.Text = Common.Models.Company.total_clients.ToString();
                //companyReportBySelected.lbl_sales_total.Text = "$" + Common.Models.Company.total_invoice.ToString();
                companyReportBySelected.ShowDialog();
            }
            catch (Exception errCompanies)
            {
                MessageBox.Show("Ocurrió un error al intentar ejecutar esto.\n\nError: " + errCompanies.Message, "Empresas");
            }    
        }

        private void txt_search_company_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_companies.DataSource = companyController.SearchCompany(txt_search_company.Text);
            }
            catch (Exception errCompanies)
            {
                MessageBox.Show("Ocurrió un error al intentar ejecutar esto.\n\nError: " + errCompanies.Message, "Empresas");
            }
        }
    }
}
