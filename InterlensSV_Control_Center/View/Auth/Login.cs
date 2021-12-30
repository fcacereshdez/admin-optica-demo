using InterlensSV_Control_Center.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterlensSV_Control_Center.View.Auth
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LayoutHome Layout = new LayoutHome();
            this.Hide();
            Layout.Show();
        }

        private void pcb_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
