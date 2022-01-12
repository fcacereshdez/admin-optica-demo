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

namespace Presentation.View.Forms.User
{
    public partial class UserEdit : Form
    {
        public UserEdit()
        {
            InitializeComponent();
        }

        private void pcb_close_edit_user_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_edit_user_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            userController.UpdateUser(txt_name.Text, txt_lastname.Text, txt_username.Text, txt_password.Text, txt_email.Text, txt_phone.Text, cb_role.SelectedValue.ToString(), cb_status.SelectedValue.ToString(), Users.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            userController.InsertActionsUser("Modificó un usuario con idetificado como: " + txt_username.Text, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            MessageBox.Show("Registro actualizado", "Procesado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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

        private void GetSelectedValues()
        {
            cb_role.SelectedValue = Users.role;
            cb_status.SelectedValue = Users.status;
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            LoadRolesAndStatus();
            GetSelectedValues();
        }
    }
}
