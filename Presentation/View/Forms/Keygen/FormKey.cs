using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.View.Forms.Keygen
{
    public partial class FormKey : Form
    {
        public FormKey()
        {
            InitializeComponent();
        }

        private void pcb_close_keygen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
