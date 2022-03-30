using Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.View.Forms.Company
{
    public partial class CompanyView : Form
    {
        public CompanyView()
        {
            InitializeComponent();
            LoadViewData();
        }
        private void LoadViewData()
        {
            txt_fullname.Text = Common.Models.Company.full_name;
            txt_code.Text = Common.Models.Company.code;
            txt_nit.Text = Common.Models.Company.nit;
            txt_iva.Text = Common.Models.Company.iva;
            txt_address.Text = Common.Models.Company.address;
            txt_phone.Text = Common.Models.Company.phone;
            txt_secondary_phone.Text = Common.Models.Company.secondary_phone;
            txt_email.Text = Common.Models.Company.email;
            txt_attendance_fullname.Text = Common.Models.Company.attendance_fullname;
            txt_attendance_role.Text = Common.Models.Company.attendance_role;
        }

        private void btn_edit_company_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            CompanyEdit companyEdit = new CompanyEdit();
            companyEdit.ShowDialog();
        }
    }
}
