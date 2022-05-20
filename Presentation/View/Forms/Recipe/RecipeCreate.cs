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

namespace Presentation.View.Forms.Recipe
{
    public partial class RecipeCreate : Form
    {
        RecipeController recipeController = new RecipeController();
        public RecipeCreate()
        {
            InitializeComponent();
            InsertAction("está creando una receta");
            
        }

        private void pcb_close_create_recipe_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void RecipeCreate_Load(object sender, EventArgs e)
        {
            
        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void btn_search_clients_Click(object sender, EventArgs e)
        {
            ClientsSelector clientsSelector = new ClientsSelector();
            AddOwnedForm(clientsSelector);
            clientsSelector.ShowDialog();
        }

        private void btn_search_ring_Click(object sender, EventArgs e)
        {
            ProductsSelector productsSelector = new ProductsSelector();
            AddOwnedForm(productsSelector);
            productsSelector.txt_search.Text = "ring";
            productsSelector.ShowDialog();
        }

        private void btn_search_glasses_Click(object sender, EventArgs e)
        {
            ProductsSelector productsSelector = new ProductsSelector();
            AddOwnedForm(productsSelector);
            productsSelector.txt_search.Text = "glasses";
            productsSelector.ShowDialog();
        }

        private void btn_search_laboratory_Click(object sender, EventArgs e)
        {
            LaboratoriesSelector laboratoriesSelector = new LaboratoriesSelector();
            AddOwnedForm(laboratoriesSelector);
            laboratoriesSelector.ShowDialog();
        }

        private void btn_search_optometryst_Click(object sender, EventArgs e)
        {
            UsersSelector usersSelector = new UsersSelector();
            AddOwnedForm(usersSelector);
            usersSelector.txt_search.Text = "optometryst";
            usersSelector.ShowDialog();
        }

        private void btn_seller_search_Click(object sender, EventArgs e)
        {
            UsersSelector usersSelector = new UsersSelector();
            AddOwnedForm(usersSelector);
            usersSelector.txt_search.Text = "seller";
            usersSelector.ShowDialog();
        }

        private void btn_save_recipe_Click(object sender, EventArgs e)
        {
            recipeController.CreateRecipe(
                txt_recipe_number.Text,
                dtp_date.Value.ToString(),
                txt_esf_od.Text,
                txt_esf_oi.Text,
                txt_cil_od.Text,
                txt_cil_oi.Text,
                txt_eje_od.Text,
                txt_eje_oi.Text,
                txt_adic_od.Text,
                txt_adic_oi.Text,
                txt_lensometry_notes.Text,
                txt_ring_id.Text,
                txt_glasses_id.Text,
                rb_comp.Checked.ToString(),
                rb_sa.Checked.ToString(),
                rb_aa.Checked.ToString(),
                cb_ar.Checked.ToString(),
                cb_process.Checked.ToString(),
                txt_quantity.Text,
                txt_value.Text,
                cb_hypertension.Checked.ToString(),
                cb_diabetes.Checked.ToString(),
                cb_cataract.Checked.ToString(),
                cb_pterigion.Checked.ToString(),
                cb_irritation.Checked.ToString(),
                cb_sleepiness.Checked.ToString(),
                cb_burning.Checked.ToString(),
                cb_headache.Checked.ToString(),
                cb_itch.Checked.ToString(),
                cb_tearing.Checked.ToString(),
                txt_eye_movements.Text,
                txt_ophtalmoscopy.Text,
                txt_ocular_abnex.Text,
                txt_hirsscheberg_test.Text,
                txt_retinoscopy.Text,
                txt_laboratory_id.Text,
                dtp_shipping.Value.ToString(),
                dtp_admission.Value.ToString(),
                dtp_delivery.Value.ToString(),
                txt_id_optometryst.Text,
                txt_seller_id.Text,
                txt_id_client.Text,
                lbl_client_age.Text,
                txt_invoice_laboratory.Text,
                txt_date_laboratory.Text,
                txt_value_invoice_laboratory.Text,
                txt_laboratory_notes_invoice.Text
                );
            MessageBox.Show("Se ha creado una receta con éxito.");
            Close();
        }

    }
}
