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

namespace Presentation.View.Forms.Laboratory
{
    public partial class LaboratoryCreate : Form
    {
        LaboratoryController laboratoryController = new LaboratoryController();
        public LaboratoryCreate()
        {
            InitializeComponent();
        }

        private void btn_save_laboratory_Click(object sender, EventArgs e)
        {
            if (txt_laboratory.Text == "")
            {
                lbl_error.Visible = true;
                lbl_error.Text = "No puede crear un laboratorio sin nombre.";
            }else if (txt_phone.Text == "")
            {
                lbl_error.Text = "No puede dejar el campo teléfono vacío.";
            }else if (txt_address.Text == "")
            {
                lbl_error.Text = "No puede dejar el campo dirección vacío.";
            }
            else
            {
                laboratoryController.CreateLaboratory(txt_laboratory.Text, txt_phone.Text, txt_address.Text);
                MessageBox.Show("Guardado satisfactoriamente");
                txt_laboratory.Clear();
                txt_phone.Clear();
                txt_address.Clear();
                txt_laboratory.Focus();
                lbl_error.Visible = false;
            }
        }

        private void pcb_close_laboratory_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
