using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.Cache;

namespace Presentation.View.Forms.User
{
    public partial class UsersForm : Form
    {
        UserController userController = new UserController();
        public UsersForm()
        {
            InitializeComponent();
        }
        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadAllUsers();
            LoadUsersActionUser();
        }

        private void LoadAllUsers()
        {
            dgv_users.DataSource = userController.GetAllUsers();
            dgv_users.Columns[0].Width = 25;
            dgv_users.Columns[1].Width = 108;
            dgv_users.Columns[2].Width = 108;
            dgv_users.Columns[3].Width = 110;
            dgv_users.Columns[4].Width = 95;
            dgv_users.Columns[5].Width = 128;
            //dgv_users.CurrentRow.Selected = false;
        }

        private void LoadUsersActionUser()
        {
            UserController userController = new UserController();
            userController.InsertActionsUser("Ingresó al gestor de usuarios", Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
