using Common.Cache;
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
            InsertAction("creó un laboratorio.");
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
                if (txt_id_laboratory.Text == "")
                {
                    try
                    {
                        laboratoryController.CreateLaboratory(txt_laboratory.Text, txt_phone.Text, txt_address.Text);
                        MessageBox.Show("Guardado satisfactoriamente");
                        txt_laboratory.Clear();
                        txt_phone.Clear();
                        txt_address.Clear();
                        txt_laboratory.Focus();
                        lbl_error.Visible = false;
                    }
                    catch (Exception CLaboratory)
                    {
                        MessageBox.Show("No pudimos crear el laboratorio debido a un error. \n\nError: " + CLaboratory.Message, "Laboratorios");
                    }
                }
                else
                {
                    try
                    {
                        laboratoryController.UpdateLaboratory(txt_laboratory.Text, txt_phone.Text, txt_address.Text, txt_id_laboratory.Text);
                        MessageBox.Show("Actualizado satisfactoriamente");
                        txt_laboratory.Clear();
                        txt_phone.Clear();
                        txt_address.Clear();
                        txt_laboratory.Clear();
                        txt_id_laboratory.Clear();
                        lbl_form.Text = "Crear laboratorio";
                        btn_save_laboratory.Text = "Guardar";
                        lbl_error.Visible = false;
                    }
                    catch (Exception CLaboratory)
                    {
                        MessageBox.Show("No pudimos actualizar el laboratorio debido a un error. \n\nError: " + CLaboratory.Message, "Laboratorios");
                    }
                }
            }
        }

        private void pcb_close_laboratory_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void LaboratoryCreate_Load(object sender, EventArgs e)
        {

        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_laboratory_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
