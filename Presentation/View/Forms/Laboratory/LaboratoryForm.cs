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
    public partial class LaboratoryForm : Form
    {
        LaboratoryController laboratoryController = new LaboratoryController();
        public LaboratoryForm()
        {
            InitializeComponent();
            SelectAllLaboratories();
            InsertAction("está en el gestor de laboratorios.");
        }

        private void SelectAllLaboratories()
        {
          dgv_laboratories.DataSource = laboratoryController.SelectAllLaboratories();
            dgv_laboratories.Columns[0].Width = 30;
            dgv_laboratories.Columns[1].Width = 325;
            dgv_laboratories.Columns[2].Width = 63;
        }

        private void btn_create_user_Click(object sender, EventArgs e)
        {
            LaboratoryCreate laboratoryCreate = new LaboratoryCreate();
            laboratoryCreate.ShowDialog();
        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void btn_edit_laboratory_Click(object sender, EventArgs e)
        {
            try
            {
                laboratoryController.SelectLaboratoryById(dgv_laboratories.SelectedRows[0].Cells[0].Value.ToString());
                LaboratoryCreate laboratoryCreate = new LaboratoryCreate();
                laboratoryCreate.txt_laboratory.Text = Common.Models.Laboratory.laboratory_name;
                laboratoryCreate.txt_phone.Text = Common.Models.Laboratory.laboratory_phone;
                laboratoryCreate.txt_address.Text = Common.Models.Laboratory.laboratory_address;
                laboratoryCreate.txt_id_laboratory.Text = Common.Models.Laboratory.laboratory_id.ToString();
                laboratoryCreate.lbl_form.Text = "Editar laboratorio";
                laboratoryCreate.btn_save_laboratory.Text = "Actualizar";
                laboratoryCreate.ShowDialog();
            }
            catch (Exception ELaboratory)
            {
                MessageBox.Show("No pudimos cargar el labortario para su edición.\n\nError: " + ELaboratory.Message, "Laboratorios");
            }
        }

        private void btn_laboratory_delete_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Está seguro de eliminar este registro?", "Laboratorios", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                UserController userController = new UserController();
                try
                {
                    laboratoryController.DeleteLaboratory(dgv_laboratories.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("Registro eliminado", "Laboratorios", MessageBoxButtons.OK);
                    userController.InsertActionsUser("Eliminió un laboratorio", Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    SelectAllLaboratories();
                }
                catch (Exception errLaboratories)
                {
                    MessageBox.Show("Ocurrió un error al intentar ejecutar esto.\n\nError: " + errLaboratories.Message, "Laboratorios");
                }

            }
        }
    }
}
