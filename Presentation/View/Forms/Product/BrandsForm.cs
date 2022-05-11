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
    public partial class BrandsForm : Form
    {
        ProductController productController = new ProductController();
        public BrandsForm()
        {
            InitializeComponent();
            SelectAllBrands();
        }

        private void pcb_close_brands_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectAllBrands()
        {
            dgv_brands.DataSource = productController.SelectAllBrands();
        }

        private void btn_save_brand_Click(object sender, EventArgs e)
        {
            if (txt_action.Text == "update")
            {
                productController.EditBrand(txt_brand_name.Text, txt_brand_id.Text);
                MessageBox.Show("Actualizado con éxito.");
                txt_brand_name.Clear();
                txt_action.Clear();
                SelectAllBrands();
            }
            else
            {
                if (txt_brand_name.Text == "")
                {
                    MessageBox.Show("No puede dejar el nombre vacío.");
                }
                else
                {
                    productController.CreateBrand(txt_brand_name.Text);
                    MessageBox.Show("Guardado con éxito.");
                    txt_brand_name.Clear();
                    SelectAllBrands();
                }
            }
        }

        private void dgv_brands_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_brand_id.Text = dgv_brands.SelectedRows[0].Cells[0].Value.ToString();
            txt_brand_name.Text = dgv_brands.SelectedRows[0].Cells[1].Value.ToString();
            txt_action.Text = "update";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_brands.SelectedRows.Count > 0)
            {
                productController.DeleteBrand(dgv_brands.SelectedRows[0].Cells[0].Value.ToString());
                SelectAllBrands();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una marca antes de continuar.");
            }
        }
    }
}
