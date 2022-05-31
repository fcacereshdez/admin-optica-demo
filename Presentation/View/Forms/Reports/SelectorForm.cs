using Common.Cache;
using Domain;
using Microsoft.Reporting.WinForms;
using Presentation.Datasets;
using Presentation.View.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.View.Forms
{
    public partial class SelectorForm : Form
    {
        CommonController commonController = new CommonController();
        ClientController clientController = new ClientController();
        CompanyController companyController = new CompanyController();
        ProductController productController = new ProductController();
        public SelectorForm()
        {
            InitializeComponent();
            InsertAction("está en el gestor de informes.");
        }

        private void pcb_close_edit_company_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_book_sales_Click(object sender, EventArgs e)
        {
            ViewerForm viewerForm = new ViewerForm();
            ReportDataSource rds = new ReportDataSource("ds_sales_book", commonController.GetSalesBook());
            viewerForm.rv_viewer.Reset();
            viewerForm.rv_viewer.ProcessingMode = ProcessingMode.Local;
            viewerForm.rv_viewer.LocalReport.ReportEmbeddedResource = "Presentation.View.Reports.SalesBook.rdlc";
            viewerForm.rv_viewer.LocalReport.DataSources.Add(rds);
            InsertAction("generó un libro de ventas.");
            viewerForm.ShowDialog();
        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void btn_audit_actions_users_Click(object sender, EventArgs e)
        {
            ViewerForm viewerForm = new ViewerForm();
            ReportDataSource rds = new ReportDataSource("ds_audit_all_users", commonController.GetAuditAllUsers());
            viewerForm.rv_viewer.Reset();
            viewerForm.rv_viewer.ProcessingMode = ProcessingMode.Local;
            viewerForm.rv_viewer.LocalReport.ReportEmbeddedResource = "Presentation.View.Reports.UserGeneralAudit.rdlc";
            viewerForm.rv_viewer.LocalReport.DataSources.Add(rds);
            InsertAction("generó una auditoría de todos los usuarios.");
            viewerForm.ShowDialog();
        }

        private void SelectorForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_client_status_all_Click(object sender, EventArgs e)
        {
            ViewerForm viewerForm = new ViewerForm();
            ReportDataSource rds = new ReportDataSource("ds_client_status_all", commonController.GetAccountStatusAllClients());
            viewerForm.rv_viewer.Reset();
            viewerForm.rv_viewer.ProcessingMode = ProcessingMode.Local;
            viewerForm.rv_viewer.LocalReport.ReportEmbeddedResource = "Presentation.View.Reports.AccountStatusAllClients.rdlc";
            viewerForm.rv_viewer.LocalReport.DataSources.Add(rds);
            InsertAction("generó un estado de cuenta de todos los clientes.");
            viewerForm.ShowDialog();
        }

        private void btn_clients_Click(object sender, EventArgs e)
        {
            ViewerForm viewerForm = new ViewerForm();
            ReportDataSource rds = new ReportDataSource("ds_all_clients", clientController.SelectAllClients());
            viewerForm.rv_viewer.Reset();
            viewerForm.rv_viewer.ProcessingMode = ProcessingMode.Local;
            viewerForm.rv_viewer.LocalReport.ReportEmbeddedResource = "Presentation.View.Reports.AllClients.rdlc";
            viewerForm.rv_viewer.LocalReport.DataSources.Add(rds);
            InsertAction("generó un reporte de todos los clientes.");
            viewerForm.ShowDialog();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            ViewerForm viewerForm = new ViewerForm();
            ReportDataSource rds = new ReportDataSource("ds_all_products", productController.SelectAllProducts());
            viewerForm.rv_viewer.Reset();
            viewerForm.rv_viewer.ProcessingMode = ProcessingMode.Local;
            viewerForm.rv_viewer.LocalReport.ReportEmbeddedResource = "Presentation.View.Reports.AllProducts.rdlc";
            viewerForm.rv_viewer.LocalReport.DataSources.Add(rds);
            InsertAction("generó un reporte de todos los productos.");
            viewerForm.ShowDialog();
        }

        private void btn_companies_Click(object sender, EventArgs e)
        {
            ViewerForm viewerForm = new ViewerForm();
            ReportDataSource rds = new ReportDataSource("ds_all_companies", companyController.SelectAllCompanies());
            viewerForm.rv_viewer.Reset();
            viewerForm.rv_viewer.ProcessingMode = ProcessingMode.Local;
            viewerForm.rv_viewer.LocalReport.ReportEmbeddedResource = "Presentation.View.Reports.AllCompanies.rdlc";
            viewerForm.rv_viewer.LocalReport.DataSources.Add(rds);
            InsertAction("generó un reporte de todas las empresas.");
            viewerForm.ShowDialog();
        }

        private void product_movements_Click(object sender, EventArgs e)
        {
            ViewerForm viewerForm = new ViewerForm();
            ReportDataSource rds = new ReportDataSource("ds_product_movements", productController.SelectProductMovements());
            viewerForm.rv_viewer.Reset();
            viewerForm.rv_viewer.ProcessingMode = ProcessingMode.Local;
            viewerForm.rv_viewer.LocalReport.ReportEmbeddedResource = "Presentation.View.Reports.ProductMovements.rdlc";
            viewerForm.rv_viewer.LocalReport.DataSources.Add(rds);
            InsertAction("generó un reporte de todos los movimientos de productos.");
            viewerForm.ShowDialog();
        }
    }
}
