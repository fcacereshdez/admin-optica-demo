using Domain;
using Microsoft.Reporting.WinForms;
using Presentation.Datasets;
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

namespace Presentation.View.Forms
{
    public partial class SelectorForm : Form
    {
        CommonController commonController = new CommonController();
        string PATH = AppDomain.CurrentDomain.BaseDirectory;
        public SelectorForm()
        {
            InitializeComponent();
        }

        private void pcb_close_edit_company_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_book_sales_Click(object sender, EventArgs e)
        {
            ViewerForm viewerForm = new ViewerForm();
            ReportDataSource rds = new ReportDataSource("ds_sales_book", commonController.GetSalesBook());
            viewerForm.rv_viewer.Clear();
            viewerForm.rv_viewer.LocalReport.ReportPath = PATH + @"..\..\View\Reports\SalesBook.rdlc";
            viewerForm.rv_viewer.LocalReport.DataSources.Add(rds);
            viewerForm.rv_viewer.RefreshReport();
            viewerForm.ShowDialog();
        }
    }
}
