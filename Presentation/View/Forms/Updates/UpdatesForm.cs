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

namespace Presentation.View.Forms.Updates
{
    public partial class UpdatesForm : Form
    {
        public UpdatesForm()
        {
            InitializeComponent();
        }

        private void UpdatesForm_Load(object sender, EventArgs e)
        {
            lbl_version.Text = Common.Models.Update.version;
            txt_version.Text = Common.Models.Update.description;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            UpdateController updateController = new UpdateController();
            try
            {
                updateController.CloseUpdate();
                Close();
            }
            catch (Exception upErr)
            {
                MessageBox.Show("Ocurrió un error al intentar ejecutar esto. \n\nError: " + upErr.Message, "Actualizaciones");
            }
        }

    }
}
