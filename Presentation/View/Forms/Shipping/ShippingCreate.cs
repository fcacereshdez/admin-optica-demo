using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.View.Forms.Shipping
{
    public partial class ShippingCreate : Form
    {
        public ShippingCreate()
        {
            InitializeComponent();
        }

        private void pcb_close_create_shipping_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
