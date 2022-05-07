using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.View.Reports
{
    public partial class ViewerForm : Form
    {
        public ViewerForm()
        {
            InitializeComponent();
        }

        private void ViewerForm_Load(object sender, EventArgs e)
        {

            this.rv_viewer.RefreshReport();
        }

        private void pcb_close_edit_company_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
