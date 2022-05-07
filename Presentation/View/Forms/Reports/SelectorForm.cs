using Domain;
using Presentation.DataSets;
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
    public partial class SelectorForms : Form
    {
        CommonController commonController = new CommonController();
        public SelectorForms()
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
            viewerForm.rv_viewer.Clear();
            viewerForm.rv_viewer.LocalReport.ReportPath = @"..\..\View\Reports\SalesBook.rdlc";
            commonController.GetSalesBook();
            viewerForm.rv_viewer.RefreshReport();
            viewerForm.ShowDialog();
        }
    }
}
