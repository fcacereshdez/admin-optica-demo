﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Presentation.View.Forms.Home;
using Presentation.View.Forms.User;
using Common.Cache;
using System.Net;

namespace Presentation
{
    public partial class Layout : Form
    {
        public Layout()
        {
            InitializeComponent();
            LoadSystemInfo();
            LoadUserData();
        }

        private void LoadSystemInfo()
        {
            lbl_name_pc.Text = Environment.MachineName;
            lbl_version_sw.Text = "v" + System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
        }
        private void LoadUserData()
        {
            lbl_name_user.Text = UserCache.name + " " + UserCache.lastname;
            lbl_role_name.Text = UserCache.role;
        }

        private void tmr_layout_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void pcb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcb_minus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            ShowForm(new UsersForm());
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            ShowForm(new AdminForm());
        }

        private void ShowForm(Form viewForm)
        {
            UpdateViewerForm();
            viewForm.TopLevel = false;
            viewForm.AutoScroll = true;
            pnl_layout.Controls.Add(viewForm);
            lbl_form_name.Text = viewForm.Text;
            viewForm.Show();
            pcb_close_form.Visible = true;
        }

        private void UpdateViewerForm()
        {
            if (pnl_layout.Controls.Count > 0)
            {
                pnl_layout.Controls.Clear();
            }
        }

        private void pcb_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            LogoutUsersActionUser();
        }

        private void LogoutUsersActionUser()
        {
            UserController userController = new UserController();
            userController.InsertActionsUser("Cerró sesión", Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void pcb_close_form_Click(object sender, EventArgs e)
        {
            pnl_layout.Controls.Clear();
            pnl_layout.Controls.Add(pcb_logo);
            lbl_form_name.Text = "";
            pcb_close_form.Visible = false;
            pcb_logo.Visible = true;
        }
    }
}