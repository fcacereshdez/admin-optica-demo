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
    public partial class GetAllTransactionsByClientParams : Form
    {
        ClientController clientController = new ClientController();
        CommonController commonController = new CommonController();

        public GetAllTransactionsByClientParams()
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
            if (dgv_clients.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debes seleccionar un cliente para continuar");
            }
            else
            {
                CommonController commonController = new CommonController();
                ViewerForm viewerForm = new ViewerForm();
                ReportDataSource rds = new ReportDataSource("ds_all_transactions_by_client", commonController.GetAllTransactionsByClient(dgv_clients.SelectedRows[0].Cells[0].Value.ToString()));
                viewerForm.rv_viewer.Reset();
                viewerForm.rv_viewer.ProcessingMode = ProcessingMode.Local;
                viewerForm.rv_viewer.LocalReport.ReportEmbeddedResource = "Presentation.View.Reports.GetAllTransactionsByClient.rdlc";
                viewerForm.rv_viewer.LocalReport.DataSources.Add(rds);
                InsertAction("generó un reporte de todas las transacciones por client.");
                Close();
                viewerForm.ShowDialog();
            }
        }

        private void pcb_close_create_report_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadClients()
        {
            try
            {
                dgv_clients.DataSource = clientController.SelectAllClients();
                dgv_clients.ClearSelection();
                dgv_clients.Columns[0].Visible = false;
                dgv_clients.Columns[1].Width = 275;
               // dgv_clients.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_clients.Columns[2].Visible = false;
                dgv_clients.Columns[3].Width = 90;
                dgv_clients.Columns[4].Visible = false;
                dgv_clients.Columns[5].Width = 275;
                dgv_clients.Columns[6].Visible = false;
            }
            catch (Exception LClients)
            {
                MessageBox.Show("Ocurrió un error al intentar cargar a los clientes. \n\nError: " + LClients.Message, "Clientes");
            }
        }

        private void GetAllTransactionsByClientParams_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void txt_search_client_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_clients.DataSource = clientController.SearchClient(txt_search_client.Text);
            }
            catch (Exception SClients)
            {

                MessageBox.Show("Tuvimos un problema al intentar buscar los clientes para ti. \n\nError: " + SClients.Message, "Clientes");
            }
        }

    }
}
