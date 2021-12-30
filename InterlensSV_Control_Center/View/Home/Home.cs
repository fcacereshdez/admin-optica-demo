using InterlensSV_Control_Center.Models;
using InterlensSV_Control_Center.View.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterlensSV_Control_Center
{
    public partial class LayoutHome : Form
    {
        public LayoutHome()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            tm_time_system.Enabled = true;
            //lbl_hello_user.Text = "Hi";
        }

        private void pcb_close_home_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tm_time_system_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbl_date.Text = DateTime.Now.ToLongDateString();
            
        }
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard Dashboard = new Dashboard();
            pnl_viewer.Controls.Add(Dashboard);
        }
    }
}
