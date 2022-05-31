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

namespace Presentation.View.Forms.Product
{
    public partial class CategoriesForm : Form
    {
        ProductController productController = new ProductController();
        public CategoriesForm()
        {
            InitializeComponent();
            SelectAllCategories();
        }

        private void pcb_close_categories_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectAllCategories()
        {
            dgv_categories.DataSource = productController.SelectAllCategories();
        }

        private void dgv_categories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_category_id.Text = dgv_categories.SelectedRows[0].Cells[0].Value.ToString();
            txt_category_name.Text = dgv_categories.SelectedRows[0].Cells[1].Value.ToString();
            txt_action.Text = "update";
        }

        private void btn_save_category_Click(object sender, EventArgs e)
        {
            if (txt_action.Text == "update")
            {
                productController.EditCategory(txt_category_name.Text, txt_category_id.Text);
                MessageBox.Show("Actualizado correctamente.");
                InsertAction("actualizó una categoría.");
                txt_category_name.Clear();
                txt_action.Clear();
                SelectAllCategories();
            }
            else
            {
                if (txt_category_name.Text == "")
                {
                    MessageBox.Show("No puede dejar el nombre vacío.");
                }
                else
                {
                    productController.CreateCategory(txt_category_name.Text);
                    MessageBox.Show("Guardado correctamente.");
                    InsertAction("creó una categoría.");
                    txt_category_name.Clear();
                    SelectAllCategories();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_categories.SelectedRows.Count > 0)
            {
                try
                {
                    productController.DeleteCategory(dgv_categories.SelectedRows[0].Cells[0].Value.ToString());
                    InsertAction("eliminó una categoría.");
                    SelectAllCategories();
                }
                catch (Exception errCategories)
                {
                    MessageBox.Show("Ocurrió un error al intentar realizar esto.\n\nError: " + errCategories.Message, "Categorías");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una categoría antes de continuar.");
            }
        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
