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
    public partial class RecipeForm : Form
    {
        RecipeController recipeController = new RecipeController();
        public RecipeForm()
        {
            InitializeComponent();
            InsertAction("está en el gestor de recetas.");
            SelectAllRecipes();
            Dock = DockStyle.Fill;
        }

        private void btn_create_recipe_Click(object sender, EventArgs e)
        {
            RecipeCreate recipeCreate = new RecipeCreate();
            recipeCreate.FormClosed += new FormClosedEventHandler(RecipeCreate_FormClosed);
            recipeCreate.ShowDialog();
        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void SelectAllRecipes()
        {
            try
            {
                dgv_recipes.DataSource = recipeController.SelectAllRecipes();
                dgv_recipes.Columns[0].Width = 60;
                dgv_recipes.Columns[3].Width = 413;
                dgv_recipes.Columns[1].Visible = false;
                dgv_recipes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_recipes.Columns[4].Visible = false;
                dgv_recipes.Columns[5].Visible = false;
                dgv_recipes.Columns[6].Visible = false;
                dgv_recipes.Columns[7].Visible = false;
                dgv_recipes.Columns[8].Visible = false;
                dgv_recipes.Columns[9].Visible = false;
                dgv_recipes.Columns[10].Visible = false;
                dgv_recipes.Columns[11].Visible = false;
                dgv_recipes.Columns[12].Visible = false;
                dgv_recipes.Columns[13].Visible = false;
            }
            catch (Exception errRecipes)
            {
                MessageBox.Show("Ocurrió un error al intentar ejecutar esto.\n\nError: " + errRecipes.Message, "Recetas");
            }
        }

        private void btn_edit_recipe_Click(object sender, EventArgs e)
        {
           
                recipeController.SelectRecipeById(dgv_recipes.SelectedRows[0].Cells[0].Value.ToString());
                RecipeCreate recipeCreate = new RecipeCreate();
                recipeCreate.lbl_client_name.Text = Common.Models.Recipe.client_name;
                recipeCreate.lbl_company_name.Text = Common.Models.Recipe.company_name;
                recipeCreate.dtp_date.Value = Convert.ToDateTime(Common.Models.Recipe.date_recipe);
                recipeCreate.dgv_recipes.Visible = false;
                recipeCreate.txt_esf_od.Text = Common.Models.Recipe.esf_od;
                recipeCreate.txt_esf_oi.Text = Common.Models.Recipe.esf_oi;
                recipeCreate.txt_cil_od.Text = Common.Models.Recipe.cil_od;
                recipeCreate.txt_cil_oi.Text = Common.Models.Recipe.cil_oi;
                recipeCreate.txt_eje_od.Text = Common.Models.Recipe.eje_od;
                recipeCreate.txt_eje_oi.Text = Common.Models.Recipe.eje_oi;
                recipeCreate.txt_adic_od.Text = Common.Models.Recipe.adic_od;
                recipeCreate.txt_adic_oi.Text = Common.Models.Recipe.adic_oi;
                recipeCreate.txt_esf_od_recipe.Text = Common.Models.Recipe.esf_od_recipe;
                recipeCreate.txt_esf_oi_recipe.Text = Common.Models.Recipe.esf_oi_recipe;
                recipeCreate.txt_cil_od_recipe.Text = Common.Models.Recipe.cil_od_recipe;
                recipeCreate.txt_cil_oi_recipe.Text = Common.Models.Recipe.cil_oi_recipe;
                recipeCreate.txt_eje_od_recipe.Text = Common.Models.Recipe.eje_od_recipe;
                recipeCreate.txt_eje_oi_recipe.Text = Common.Models.Recipe.eje_oi_recipe;
                recipeCreate.txt_adic_od_recipe.Text = Common.Models.Recipe.adic_od_recipe;
                recipeCreate.txt_adic_oi_recipe.Text = Common.Models.Recipe.adic_oi_recipe;
                recipeCreate.txt_altob_od_recipe.Text = Common.Models.Recipe.altob_od_recipe;
                recipeCreate.txt_altob_oi_recipe.Text = Common.Models.Recipe.altob_oi_recipe;
                recipeCreate.txt_altpu_od_recipe.Text = Common.Models.Recipe.altpu_od_recipe;
                recipeCreate.txt_altpu_oi_recipe.Text = Common.Models.Recipe.altpu_oi_recipe;
                recipeCreate.txt_dplej_od_recipe.Text = Common.Models.Recipe.dplej_od_recipe;
                recipeCreate.txt_dplej_oi_recipe.Text = Common.Models.Recipe.dplej_oi_recipe;
                recipeCreate.txt_dpcer_od_recipe.Text = Common.Models.Recipe.dpcer_od_recipe;
                recipeCreate.txt_dpcer_oi_recipe.Text = Common.Models.Recipe.dpcer_oi_recipe;
                recipeCreate.txt_base_od_recipe.Text = Common.Models.Recipe.base_od_recipe;
                recipeCreate.txt_base_oi_recipe.Text = Common.Models.Recipe.base_oi_recipe;
                recipeCreate.txt_lensometry_notes.Text = Common.Models.Recipe.lensometry_notes;
                recipeCreate.txt_ring_name.Text = Common.Models.Recipe.ring;
                recipeCreate.txt_glasses_name.Text = Common.Models.Recipe.glasses;
                recipeCreate.rb_comp.Checked = Common.Models.Recipe.comp;
                recipeCreate.rb_sa.Checked = Common.Models.Recipe.sa;
                recipeCreate.rb_aa.Checked = Common.Models.Recipe.aa;
                recipeCreate.cb_ar.Checked = Common.Models.Recipe.ar;
                recipeCreate.cb_process.Checked = Common.Models.Recipe.process;
                recipeCreate.txt_quantity.Text = Common.Models.Recipe.quantity.ToString();
                recipeCreate.txt_value.Text = Common.Models.Recipe.value.ToString();
                recipeCreate.cb_hypertension.Checked = Common.Models.Recipe.hypertension;
                recipeCreate.cb_diabetes.Checked = Common.Models.Recipe.diabetes;
                recipeCreate.cb_cataract.Checked = Common.Models.Recipe.cataract;
                recipeCreate.cb_pterigion.Checked = Common.Models.Recipe.pterigion;
                recipeCreate.cb_irritation.Checked = Common.Models.Recipe.irritation;
                recipeCreate.cb_sleepiness.Checked = Common.Models.Recipe.sleepiness;
                recipeCreate.cb_burning.Checked = Common.Models.Recipe.burning;
                recipeCreate.cb_headache.Checked = Common.Models.Recipe.headache;
                recipeCreate.cb_itch.Checked = Common.Models.Recipe.itch;
                recipeCreate.cb_tearing.Checked = Common.Models.Recipe.tearing;
                recipeCreate.txt_eye_movements.Text = Common.Models.Recipe.eye_movementes;
                recipeCreate.txt_ophtalmoscopy.Text = Common.Models.Recipe.ophthalmoscopy;
                recipeCreate.txt_ocular_abnex.Text = Common.Models.Recipe.eye_adnexa;
                recipeCreate.txt_hirsscheberg_test.Text = Common.Models.Recipe.hirsscheberg_test;
                recipeCreate.txt_retinoscopy.Text = Common.Models.Recipe.retinoscopy;
                recipeCreate.txt_laboratory_name.Text = Common.Models.Recipe.laboratory;
                recipeCreate.dtp_shipping.Value = Common.Models.Recipe.shipping_date;
                recipeCreate.dtp_admission.Value = Common.Models.Recipe.admission_date;
                recipeCreate.dtp_delivery.Value = Common.Models.Recipe.delivery_date;
                recipeCreate.txt_optometryst.Text = Common.Models.Recipe.optometryst;
                recipeCreate.txt_seller.Text = Common.Models.Recipe.seller;
                recipeCreate.txt_age.Text = Common.Models.Recipe.client_age.ToString();
                recipeCreate.txt_invoice_laboratory.Text = Common.Models.Recipe.invoice_laboratory;
                recipeCreate.txt_date_laboratory.Text = Common.Models.Recipe.date_invoice_laboratory;
                recipeCreate.txt_value_invoice_laboratory.Text = Common.Models.Recipe.value_invoice_laboratory;
                recipeCreate.txt_laboratory_notes_invoice.Text = Common.Models.Recipe.notes;
                recipeCreate.btn_search_clients.Enabled = false;
                recipeCreate.btn_search_ring.Enabled = true;
                recipeCreate.btn_search_glasses.Enabled = true;
                recipeCreate.btn_search_laboratory.Enabled = true;
                recipeCreate.btn_search_optometryst.Enabled = true;
                recipeCreate.btn_seller_search.Enabled = true;
                recipeCreate.txt_method.Text = "update";
            recipeCreate.FormClosed += new FormClosedEventHandler(RecipeCreate_FormClosed);
            recipeCreate.ShowDialog();
        }

        private void btn_delete_recipe_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminación", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                UserController userController = new UserController();
                try
                {
                    recipeController.DeleteRecipe(dgv_recipes.SelectedRows[0].Cells[0].Value.ToString());
                    MessageBox.Show("Registro eliminado", "Procesado", MessageBoxButtons.OK);
                    userController.InsertActionsUser("Eliminió una receta", Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    SelectAllRecipes();
                }
                catch (Exception errRecipes)
                {
                    MessageBox.Show("Ocurrió un error al intentar ejecutar esto.\n\nError: " + errRecipes.Message, "Recetas");
                }

            }
        }

        private void txt_search_recipe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_recipes.DataSource = recipeController.SearchRecipe(txt_search_recipe.Text);
                dgv_recipes.Columns[0].Width = 60;
                dgv_recipes.Columns[3].Width = 413;
                dgv_recipes.Columns[1].Visible = false;
                dgv_recipes.Columns[4].Visible = false;
                dgv_recipes.Columns[5].Visible = false;
                dgv_recipes.Columns[6].Visible = false;
                dgv_recipes.Columns[7].Visible = false;
                dgv_recipes.Columns[8].Visible = false;
                dgv_recipes.Columns[9].Visible = false;
                dgv_recipes.Columns[10].Visible = false;
                dgv_recipes.Columns[11].Visible = false;
            }
            catch (Exception errRecipes)
            {
                MessageBox.Show("Ocurrió un error al intentar ejecutar esto.\n\nError: " + errRecipes.Message, "Recetas");
            }
        }

        private void RecipeCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelectAllRecipes();
        }

        private void btn_view_recipe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recipe.rdlc y otros componentes no son compatibles con esta versión del Framework .NET", "Recetas");
        }
    }
}
