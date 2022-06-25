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

namespace Presentation.View.Forms.Shipping
{
    public partial class CarriersForm : Form
    {
        ShippmentController shippmentController = new ShippmentController();
        public CarriersForm()
        {
            InitializeComponent();
        }

        private void pcb_close_brands_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void LoadDataForCarriers()
        {
            cb_brands.DataSource = shippmentController.SelectAllBrands();
            cb_brands.DisplayMember = "MARCA";
            cb_brands.ValueMember = "ID";

            cb_models.DataSource = shippmentController.SelectAllModels();
            cb_models.DisplayMember = "MODELO";
            cb_models.ValueMember = "ID";

            cb_categories.DataSource = shippmentController.SelectAllCategories();
            cb_categories.DisplayMember = "CATEGORIA";
            cb_categories.ValueMember = "ID";

            dgv_carriers.DataSource = shippmentController.SelectAllCarriers();
            dgv_carriers.Columns[4].Visible = false;
            dgv_carriers.Columns[5].Visible = false;
            dgv_carriers.Columns[6].Visible = false;
            dgv_carriers.Columns[7].Visible = false;
        }

        private void CarriersForm_Load(object sender, EventArgs e)
        {
            InsertAction("está registrando un repartidor");
            LoadDataForCarriers();
        }

        private void btn_save_carrier_Click(object sender, EventArgs e)
        {
            if (txt_action.Text == "update")
            {
                try
                {
                    shippmentController.UpdatedCarrier(cb_brands.SelectedValue.ToString(), cb_models.SelectedValue.ToString(), cb_categories.SelectedValue.ToString(), txt_identification.Text, txt_carrier_fullname.Text, txt_carrier_id.Text);
                    MessageBox.Show("Conductor/a actualizado con éxito.", "Entregas");
                    txt_action.Clear();
                    Close();
                }
                catch (Exception crErr)
                {
                    MessageBox.Show("Ocurrió un error al intentar realizar esto.\n\nError: " + crErr.Message, "Entregas");
                }
            }
            else if(txt_action.Text == "")
            {
                try
                {
                    shippmentController.CreateCarrier(cb_brands.SelectedValue.ToString(), cb_models.SelectedValue.ToString(), cb_categories.SelectedValue.ToString(), txt_identification.Text, txt_carrier_fullname.Text);
                    MessageBox.Show("Conductor/a registrado con éxito.", "Entregas");
                    Close();
                }
                catch (Exception crErr)
                {
                    MessageBox.Show("Ocurrió un error al intentar realizar esto.\n\nError: " + crErr.Message, "Entregas");
                }
            }
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult msgDelete = MessageBox.Show("¿Desea eliminar este registro?", "Entregas", MessageBoxButtons.OKCancel);

            if (msgDelete == DialogResult.OK)
            {
                try
                {
                    shippmentController.DeleteCarrier(dgv_carriers.SelectedRows[0].Cells[0].Value.ToString());
                    LoadDataForCarriers();
                    MessageBox.Show("Conductor/a eliminado.", "Entregas", MessageBoxButtons.OK);
                }
                catch (Exception dClients)
                {

                    MessageBox.Show("Ocurrión un error al eliminarlo. \n\nError: " + dClients.Message, "Entregas");
                }
            }
        }

        private void dgv_carriers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_carrier_id.Text = dgv_carriers.SelectedRows[0].Cells[8].Value.ToString();
            cb_brands.SelectedValue = dgv_carriers.SelectedRows[0].Cells[4].Value.ToString();
            cb_models.SelectedValue = dgv_carriers.SelectedRows[0].Cells[5].Value.ToString();
            cb_categories.SelectedValue = dgv_carriers.SelectedRows[0].Cells[6].Value.ToString();
            txt_identification.Text = dgv_carriers.SelectedRows[0].Cells[7].Value.ToString();
            txt_carrier_fullname.Text = dgv_carriers.SelectedRows[0].Cells[3].Value.ToString();
            txt_action.Text = "update";
        }
    }
}
