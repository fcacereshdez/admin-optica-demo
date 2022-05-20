using Common.Cache;
using Common.Models;
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

namespace Presentation.View.Forms.Company
{
    public partial class CompanyEdit : Form
    {
        public CompanyEdit()
        {
            InitializeComponent();
            LoadEditorData();
            InsertAction("está editando una empresa con código " + Common.Models.Company.code);
        }

        private void pcb_close_edit_company_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadEditorData()
        {
            txt_fullname.Text = Common.Models.Company.full_name;
            txt_nit.Text = Common.Models.Company.nit;
            txt_iva.Text = Common.Models.Company.iva;
            txt_address.Text = Common.Models.Company.address;
            txt_phone.Text = Common.Models.Company.phone;
            txt_secondary_phone.Text = Common.Models.Company.secondary_phone;
            txt_email.Text = Common.Models.Company.email;
            txt_attendance_fullname.Text = Common.Models.Company.attendance_fullname;
            txt_attendance_role.Text = Common.Models.Company.attendance_role;
        }

        private void btn_edit_company_Click(object sender, EventArgs e)
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
                UserController userController = new UserController();
                CompanyController companyController = new CompanyController();
                companyController.UpdateCompany(txt_fullname.Text, txt_phone.Text, txt_secondary_phone.Text, txt_email.Text, txt_address.Text, txt_nit.Text, txt_iva.Text, txt_attendance_fullname.Text, txt_attendance_role.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Common.Models.Company.company_id);
                userController.InsertActionsUser("Actualizó una empresa con código: " + Common.Models.Company.code, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                MessageBox.Show("Registro actualizado con éxito.", "Procesado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
