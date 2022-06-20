using Common.Cache;
using Domain;
using Microsoft.Reporting.WinForms;
using Presentation.View.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.View.Forms.Reports
{
    public partial class SalesByCompany : Form
    {
        public SalesByCompany()
        {
            InitializeComponent();
        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void btn_generate_report_Click(object sender, EventArgs e)
        {
            CommonController commonController = new CommonController();
            ViewerForm viewerForm = new ViewerForm();
            ReportDataSource rds = new ReportDataSource("ds_sales_by_optometrist", commonController.SelectAllSalesByOptometrist(dtp_from.Value.ToString("yyyy-MM-dd"), dtp_to.Value.ToString("yyyy-MM-dd")));
            viewerForm.rv_viewer.Reset();
            viewerForm.rv_viewer.ProcessingMode = ProcessingMode.Local;
            viewerForm.rv_viewer.LocalReport.ReportEmbeddedResource = "Presentation.View.Reports.SalesByOptometrist.rdlc";
            viewerForm.rv_viewer.LocalReport.DataSources.Add(rds);
            InsertAction("generó un reporte de todas las ventas por optómetra.");
            Close();
            viewerForm.ShowDialog(); 
        }

        private void pcb_close_create_report_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
