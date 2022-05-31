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

namespace Presentation.View.Forms.Client
{
    public partial class ClientEdit : Form
    {
        public ClientEdit()
        {
            InitializeComponent();
        }

        ClientController clientController = new ClientController();

        private void pcb_close_create_client_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_client_Click(object sender, EventArgs e)
        {
            try
            {
                clientController.UpdateClient(txt_name_client.Text, txt_lastname_client.Text, txt_dui_client.Text, txt_nit_client.Text, txt_phone_client.Text, txt_secondary_phone_client.Text, txt_email_client.Text, txt_address_client.Text, txt_notes_client.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Convert.ToInt64(txt_id_client.Text));
                MessageBox.Show("Registro actualizado", "Procesado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserUpdated();
            }
            catch (Exception EClients)
            {
                MessageBox.Show("Ocurrió un error al intentar editar el cliente seleccionado. \n\nError: " + EClients.Message, "Clientes");
            }
        }

        private void UserUpdated()
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " actualizó a un cliente.", Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
