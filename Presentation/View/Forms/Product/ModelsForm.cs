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

namespace Presentation.View.Forms.Product
{
    public partial class ModelsForm : Form
    {
        ProductController productController = new ProductController();
        public ModelsForm()
        {
            InitializeComponent();
            SelectAllModels();
        }

        private void pcb_close_models_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectAllModels()
        {
            dgv_models.DataSource = productController.SelectAllModels();
        }

        private void btn_save_model_Click(object sender, EventArgs e)
        {
            if (txt_action.Text == "update")
            {
                productController.EditModel(txt_model_name.Text, txt_model_id.Text);
                MessageBox.Show("Actualizado correctamente.");
                txt_model_name.Clear();
                txt_action.Clear();
                SelectAllModels();
            }
            else
            {
                if (txt_model_name.Text == "")
                {
                    MessageBox.Show("No puede dejar el nombre vacío.");
                }
                else
                {
                    productController.CreateModel(txt_model_name.Text);
                    MessageBox.Show("Guardado correctamente.");
                    txt_model_name.Clear();
                    SelectAllModels();
                }
            }
        }

        private void dgv_models_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_model_id.Text = dgv_models.SelectedRows[0].Cells[0].Value.ToString();
            txt_model_name.Text = dgv_models.SelectedRows[0].Cells[1].Value.ToString();
            txt_action.Text = "update";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_models.SelectedRows.Count > 0)
            {
                productController.DeleteBrand(dgv_models.SelectedRows[0].Cells[0].Value.ToString());
                SelectAllModels();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una marca antes de continuar.");
            }
        }
    }
}
