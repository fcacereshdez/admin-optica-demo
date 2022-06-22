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

namespace Presentation.View.Forms.Home
{
    public partial class AdminForm : Form
    {
        CommonController commonController = new CommonController();
        ClientController clientController = new ClientController();
        InvoiceController invoiceController = new InvoiceController();

        public AdminForm()
        {
            InitializeComponent();
            LoadHome();
            InsertAction("está revisando el resumen del sistema.");
        }

        private void pcb_close_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadHome()
        {
            clientController.CountClients();
            invoiceController.SumSalesDay();
            lbl_client_count.Text = HomeCache.count_clients.ToString();
            lbl_sales_day.Text = "$" + HomeCache.sum_sales_day.ToString();
        }
        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
