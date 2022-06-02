using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using Common.Cache;
using Domain;
using Presentation.View.Forms; 
using Presentation.View.Forms.Company;
using Presentation.View.Forms.Client;
using Presentation.View.Forms.About;
using Presentation.View.Forms.Laboratory;
using Presentation.View.Forms.Product;
using Presentation.View.Forms.Recipe;
using Presentation.View.Forms.Home;
using Presentation.View.Forms.User;
using Presentation.View.Forms.Invoice;

// añadir ajustes en la interfaz inicial

namespace Presentation
{
    public partial class Layout : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Layout()
        {

            InitializeComponent();
           

            //this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

        }

        private void LoadSystemInfo()
        {
            lbl_name_pc.Text = Environment.MachineName;
            lbl_version_sw.Text = "v" + System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();

        }
        private void LoadUserData()
        {
            char[] cutLastname = UserCache.lastname.ToCharArray();

            lbl_name_user.Text = UserCache.name + " " + cutLastname[0] + ".";
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
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " cerró sesión", Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void pcb_close_form_Click(object sender, EventArgs e)
        {
            pnl_layout.Controls.Clear();
            pnl_layout.Controls.Add(pcb_logo);
            lbl_form_name.Text = "";
            pcb_close_form.Visible = false;
            pcb_logo.Visible = true;
        }

        private void btn_companies_Click(object sender, EventArgs e)
        {
            ShowForm(new CompanyForm());
        }

        private void btn_clients_Click(object sender, EventArgs e)
        {
            ShowForm(new ClientForm());
        }

        public void showError()
        {
            string error = "El tiempo de prueba de tu licencia ha expirado, por favor, completa el pago del servicio para continuar...";
            MessageBox.Show(error, "Licencia inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void alertCloseApp()
        {
            string error = "La aplicación se ha detenido.";
            DialogResult errorClose = MessageBox.Show(error, "Licencia inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (errorClose == DialogResult.OK)
            {
                Environment.Exit(1);
            }
            else
            {
                Environment.Exit(1);
            }
                
        }

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0x0f012, 0);
        }

        private void btn_labs_Click(object sender, EventArgs e)
        {
            ShowForm(new LaboratoryForm());
        }

        private void btn_recipes_Click(object sender, EventArgs e)
        {
            ShowForm(new RecipeForm());
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            ShowForm(new ProductForm());
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            ShowForm(new SelectorForm());
        }

        private void btn_shipping_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este servicio no ha sido habilitado", "Entregas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_about_info_Click(object sender, EventArgs e)
        {
            ShowForm(new AboutForm());
        }

        private void btn_facturation_Click(object sender, EventArgs e)
        {
            ShowForm(new InvoiceForm());
        }

        private void PolicyFunctionsForUsers(string slug_role)
        {

            if (slug_role == "superadmin" || slug_role == "admin")
            {
              //  btn_dashboard.Enabled = true;
                btn_clients.Enabled = true;
                btn_companies.Enabled = true;
                btn_labs.Enabled = true;
                btn_recipes.Enabled = true;
                btn_facturation.Enabled = true;
                btn_products.Enabled = true;
                btn_reports.Enabled = true;
                btn_shipping.Enabled = true;
                btn_users.Enabled = true;
                //btn_about_info.Enabled = true;
            }
            else if (slug_role == "seller" || slug_role == "seller-optometryst" || slug_role == "optometryst")
            {
              //  btn_dashboard.Enabled = false;
                btn_clients.Enabled = true;
                btn_companies.Enabled = true;
                btn_labs.Enabled = false;
                btn_recipes.Enabled = true;
                btn_facturation.Enabled = false;
                btn_products.Enabled = false;
                btn_reports.Enabled = false;
                btn_shipping.Enabled = false;
                btn_users.Enabled = false;
               // btn_about_info.Enabled = true;
            }
            else
            {
             //   btn_dashboard.Enabled = false;
                btn_clients.Enabled = false;
                btn_companies.Enabled = false;
                btn_labs.Enabled = false;
                btn_recipes.Enabled = false;
                btn_facturation.Enabled = false;
                btn_products.Enabled = false;
                btn_reports.Enabled = false;
                btn_shipping.Enabled = false;
                btn_users.Enabled = false;
                //btn_about_info.Enabled = true;
            }
        }

        private void btn_banks_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gestor de bancos en desarollo");
        }

        private void btn_iva_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gestor de IVA en desarollo");
        }

        private void pcb_maximize_Click(object sender, EventArgs e)
        {
             if (WindowState == FormWindowState.Maximized)
             {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Layout_Load(object sender, EventArgs e)
        {
           
            LoadSystemInfo();
            LoadUserData();
            PolicyFunctionsForUsers(UserCache.slug_role);
            pnl_menu.AutoScroll = false;
            pnl_menu.HorizontalScroll.Enabled = false;
            pnl_menu.HorizontalScroll.Visible = false;
            pnl_menu.HorizontalScroll.Maximum = 0;
            pnl_menu.AutoScroll = true;
        }

        private void txt_claims_Click(object sender, EventArgs e)
        {
            ShowForm(new ClaimForm());
        }

        private void pnl_top_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
