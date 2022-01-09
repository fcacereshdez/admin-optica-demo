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


        private void btn_edit_user_Click(object sender, EventArgs e)
        {
            if (dgv_users.SelectedCells.Count > 0)
            {
                SelectUserById(Convert.ToInt64(dgv_users.SelectedRows[0].Cells[0].Value));
            }
            else
            {
                MessageBox.Show("Sin selección", "Debes seleccionar una fila para editar");
            }
        }

        private void SelectUserById(Int64 user_id)
        {
            UserController userController = new UserController();
            userController.SelectUserById(user_id);
            UserEdit userEdit = new UserEdit();
            userEdit.txt_name.Text = UserEditor.name;
            userEdit.txt_lastname.Text = UserEditor.lastname;
            userEdit.txt_username.Text = UserEditor.username;
            userEdit.txt_phone.Text = UserEditor.phone;
            userEdit.txt_email.Text = UserEditor.email;
            userEdit.FormClosed += new System.Windows.Forms.FormClosedEventHandler(UserEdit_FormClosed);
            userEdit.ShowDialog();
        }

        private void btn_create_user_Click(object sender, EventArgs e)
        {
            UserCreate userCreate = new UserCreate();
            userCreate.FormClosed += new System.Windows.Forms.FormClosedEventHandler(UserCreate_FormClosed);
            userCreate.ShowDialog();
        }


        private void btn_user_delete_Click(object sender, EventArgs e)
        {
            bool msg = MsgBoxUsers("Eliminación", "¿Está seguro de eliminar este registro?", MessageBoxButtons.YesNo);
            if (msg == true)
            {
                UserController userController = new UserController();
                userController.DeleteUser(Convert.ToInt64(dgv_users.SelectedRows[0].Cells[0].Value));
                LoadAllUsers();
            }
            MsgBoxUsers("Procesado", "Registro eliminado.", MessageBoxButtons.OK);
        }

        private void UserEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadAllUsers();
            MsgBoxUsers("Procesado", "Registro actualizado.", MessageBoxButtons.OK);
        }

        private void UserCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadAllUsers();
            MsgBoxUsers("Procesado", "Registro creado.", MessageBoxButtons.OK);
        }

        private bool MsgBoxUsers(string title, string msg, MessageBoxButtons buttons)
        {
            DialogResult dialogResult = MessageBox.Show(msg, title, buttons);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
