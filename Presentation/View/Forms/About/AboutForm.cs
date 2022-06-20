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

namespace Presentation.View.Forms.About
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            LoadAction();
            Dock = DockStyle.Fill;
        }

        private void LoadAction()
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " revisó la información del sistema", Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

        }

    }
}
