using Common.Cache;
using Domain;
using Presentation.View.Forms.Company;
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
    public partial class ClientCreate : Form
    {
        public ClientCreate()
        {
            InitializeComponent();
        }

        private void btn_save_client_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = true;
            if (txt_name_client.Text == "")
            {
                lbl_error.Text = "El nombre del cliente no puede estar en blanco";
                txt_name_client.Focus();
            }
            else if (txt_lastname_client.Text == "")
            {
                lbl_error.Text = "El apellido del cliente no puede estar en blanco";
                txt_lastname_client.Focus();
            }
            else if (txt_code_client.Text == "")
            {
                lbl_error.Text = "Estámos presentando un error al generar el código";
                txt_code_client.Focus();
            }
            else if (txt_dui_client.Text == "")
            {
                lbl_error.Text = "El DUI del cliente es necesario para generarlo";
                txt_dui_client.Focus();
            }
            else if (txt_phone_client.Text == "")
            {
                lbl_error.Text = "El teléfono del cliente es necesario";
                txt_phone_client.Focus();
            }
            else if (txt_address_client.Text == "")
            {
                lbl_error.Text = "La dirección es necesaria";
                txt_address_client.Focus();
            }
            else if (txt_company_client.Text == "")
            {
                lbl_error.Text = "Debes selecionar una empresa para el cliente";
                btn_search_company.Focus();
            }
            else
            {
                lbl_error.Visible = false;
                UserController userController = new UserController();
                
                userController.InsertActionsUser("Creó un cliente con código: " + txt_code_client.Text, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                MessageBox.Show("Registro creado con éxito.", "Procesado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void pcb_close_create_client_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_company_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();
            companyForm.ShowDialog();
        }
    }
}
