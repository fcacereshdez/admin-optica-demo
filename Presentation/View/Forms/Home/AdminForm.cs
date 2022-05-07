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

namespace Presentation.View.Forms.Home
{
    public partial class AdminForm : Form
    {
        CommonController commonController = new CommonController();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void pcb_close_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void LoadHome()
        {
            lbl_client_count.Text = ClientCache.countClients.ToString();
        }
    }
}
