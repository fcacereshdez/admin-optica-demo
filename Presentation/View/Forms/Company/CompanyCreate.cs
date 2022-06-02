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
using Common.Models;
using Domain;

namespace Presentation.View.Forms.Company
{
    public partial class CompanyCreate : Form
    {
        CompanyController companyController = new CompanyController();
        public CompanyCreate()
        {
            InitializeComponent();
            SelectLastCodeCompany();
            InsertAction("está creando una empresa.");
        }

        private void btn_save_company_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = true;
            if (txt_fullname.Text == "")
            {
                lbl_error.Text = "El nombre de la empresa no puede estar en blanco";
                txt_fullname.Focus();
            }
            else if (txt_nit.Text == "")
            {
                lbl_error.Text = "El NIT de la empresa debe ser agregado";
                txt_nit.Focus();
            }
            else if (txt_iva.Text == "")
            {
                lbl_error.Text = "El IVA de la empresa debe ser agregado";
                txt_iva.Focus();
            }
            else if (txt_address.Text == "")
            {
                lbl_error.Text = "La dirección de la empresa no puede quedar en blanco";
                txt_address.Focus();
            }
            else if (txt_phone.Text == "")
            {
                lbl_error.Text = "El teléfono de la empresa es necesario";
                txt_phone.Focus();
            }
            else if (txt_attendance_fullname.Text == "")
            {
                lbl_error.Text = "Es necesario asignar un contacto para la empresa";
                txt_attendance_fullname.Focus();
            }
            else if (txt_attendance_role.Text == "")
            {
                lbl_error.Text = "Se necesita identificar el rol del contacto en la empresa";
                txt_attendance_role.Focus();
            }
            else
            {
                lbl_error.Visible = false;
                try
                {
                    UserController userController = new UserController();
                    companyController.CreateCompany(txt_fullname.Text, txt_code.Text, txt_phone.Text, txt_secondary_phone.Text, txt_email.Text, txt_address.Text, txt_nit.Text, txt_iva.Text, txt_attendance_fullname.Text, txt_attendance_role.Text, txt_attendance_phone.Text, txt_attendance_email.Text, 
                       txt_attendance_name2.Text, txt_attendance_role2.Text, txt_attendance_phone2.Text, txt_attendance_email2.Text, 
                       txt_attendance_name3.Text, txt_attendance_role3.Text, txt_attendance_phone3.Text, txt_attendance_email3.Text, txt_comercial_name.Text, txt_legal_name.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    userController.InsertActionsUser("Creó una empresa con código: " + txt_code.Text, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    MessageBox.Show("Registro creado con éxito.", "Procesado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception iCompanies)
                {
                    MessageBox.Show("Ocurrió un error al intentar crear la empresa. \n\nError: " + iCompanies.Message, "Empresas");
                }
            }
        }

        private void SelectLastCodeCompany()
        {
            try
            {
                companyController.SelectLastCodeCompany();
                int tmp_company_code = Convert.ToInt32(Common.Models.Company.code) + 1;
                txt_code.Text = tmp_company_code.ToString();
            }
            catch (Exception GCompanies)
            {
                MessageBox.Show("Ocurrió un error al intentar generar el código de la empresa nueva. \n\nError: " + GCompanies.Message, "Empresas");
            }
        }

        private void pcb_close_create_user_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
