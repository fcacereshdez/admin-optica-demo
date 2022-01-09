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

namespace Presentation.View.Forms.User
{
    public partial class UserCreate : Form
    {
        public UserCreate()
        {
            InitializeComponent();
        }

        private void UserCreate_Load(object sender, EventArgs e)
        {
            LoadRolesAndStatus();
        }

        private void LoadRolesAndStatus()
        {
            UserController userController = new UserController();
            cb_role.DataSource = userController.SelectAllRoles();
            cb_status.DataSource = userController.SelectAllstatus();
            cb_role.DisplayMember = "role";
            cb_role.ValueMember = "role_id";
            cb_status.DisplayMember = "user_status";
            cb_status.ValueMember = "user_status_id";
        }

        private void btn_save_user_Click(object sender, EventArgs e)
        {
           if(txt_name.Text == "")
            {
                lbl_error.Visible = true;
                lbl_error.Text = "El nombre no puede estar vacío";
            }
            if (txt_lastname.Text == "")
            {
                lbl_error.Text = "El apellido no puede estar vacío";
            }
            if (txt_username.Text == "")
            {
                lbl_error.Text = "El usuario no puede estar vacío";
            }
            if (txt_password.Text == "")
            {
                lbl_error.Text = "La contraseña no puede estar vacía";
            }
            lbl_error.Visible = false;
            UserController userController = new UserController();
            userController.CreateUser(txt_name.Text, txt_lastname.Text, txt_username.Text, txt_password.Text, txt_email.Text, txt_phone.Text, cb_role.SelectedValue.ToString(), cb_status.SelectedValue.ToString(), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            this.Close();
        }

        private void pcb_close_edit_user_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
