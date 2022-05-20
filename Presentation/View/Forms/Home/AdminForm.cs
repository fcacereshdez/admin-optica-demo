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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void LoadHome()
        {
            clientController.CountClients();
            lbl_client_count.Text = ClientCache.countClients.ToString();
        }
        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
