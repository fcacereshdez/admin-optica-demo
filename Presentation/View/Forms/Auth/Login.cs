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

namespace Presentation.View.Forms
{
    public partial class Login : Form
    {
        UserController userController = new UserController();

        public Login()
        {
            InitializeComponent();
        }

        private void InicializeInformationEdition()
        {
            lbl_version_login.Text = "Release Version - v" + Application.ProductVersion.ToString();
        }

        private void pcb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void msgError(string msg)
        {
            lbl_msg_error.Text = "* " + msg;
            lbl_msg_error.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txt_user.Clear();
            txt_password.Clear();
            lbl_msg_error.Visible = false;
            this.Show();
            txt_user.Focus();
        }

        private void LoginActionUser()
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " inició sesión", Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void UpdateLastLoginUser()
        {
            UserController userController = new UserController();
            userController.UpdateLastAccessUser(UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }


        private void Login_Load(object sender, EventArgs e)
        {
            InicializeInformationEdition();
        }

        private void btn_login_action_Click(object sender, EventArgs e)
        {
            if (txt_user.Text != "")
            {
                if (txt_password.Text != "")
                {
                    lbl_login_status.Visible = true;
                    btn_login.Visible = false;
                    lbl_msg_error.Visible = false;
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(2000);
                    try
                    {
                        var validateLogin = userController.LoginUser(txt_user.Text, txt_password.Text);
                        if (validateLogin == true)
                        {
                            LoginActionUser();
                            UpdateLastLoginUser();
                            Layout layoutMain = new Layout();
                            layoutMain.Show();
                            layoutMain.FormClosed += Logout;
                            this.Hide();
                            lbl_login_status.Visible = false;
                            btn_login.Visible = true;
                        }
                        else
                        {
                            msgError("Las credenciales son incorrectas. \n Intenta nuevamente.");
                            lbl_login_status.Visible = false;
                            btn_login.Visible = true;
                            txt_password.Clear();
                            txt_user.Focus();
                        }
                    }
                    catch (Exception errLogin)
                    {
                        MessageBox.Show("Ocurrió un error mientras intentabamos iniciar sesión.\n\nError: " + errLogin.Message, "Iniciar sesión");
                    }
                }
                else
                {
                    msgError("Debe ingresar la contraseña.");
                }
            }
            else
            {
                msgError("Debe ingresar el su usuario.");
            }
        }
    }
}
