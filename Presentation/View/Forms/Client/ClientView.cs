﻿using Common.Cache;
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

namespace Presentation.View.Forms.Client
{
    public partial class ClientView : Form
    {
        public ClientView()
        {
            InitializeComponent();
        }

        ClientController clientController = new ClientController();

        private void pcb_close_create_client_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_client_Click(object sender, EventArgs e)
        {
           
        }

        private void UserUpdated()
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " revisando a un cliente.", Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
