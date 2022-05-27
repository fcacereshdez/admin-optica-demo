using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RecipeController
    {
        RecipeData recipeData = new RecipeData();
        public DataTable SelectAllRecipes()
        {
            DataTable TableRecipes = new DataTable();
            TableRecipes = recipeData.SelectAllRecipes();
            return TableRecipes;
        }

        public DataTable SelectAllRecipesById(string client_id)
        {
            DataTable TableRecipes = new DataTable();
            TableRecipes = recipeData.SelectAllRecipesById(Convert.ToInt64(client_id));
            return TableRecipes;
        }

        public void SelectRecipeById(string recipe_id)
        {
            recipeData.SelectRecipeById(Convert.ToInt64(recipe_id));
        }

        public void CreateRecipe(
            string number_recipe, string date_recipe, string esf_od,
string esf_oi, string cil_od, string cil_oi, string eje_od, string eje_oi, string adic_od, string adic_oi,
string esf_od_recipe, string esf_oi_recipe, string cil_od_recipe, string cil_oi_recipe, string eje_od_recipe,
string eje_oi_recipe, string adic_od_recipe, string adic_oi_recipe, string altob_od_recipe, string altob_oi_recipe,
string altpu_od_recipe, string altpu_oi_recipe, string dplej_od_recipe, string dplej_oi_recipe, string dpcer_od_recipe,
string dpcer_oi_recipe, string base_od_recipe, string base_oi_recipe, string lensometry_notes,
string ring_id, string glasses_id, string comp, string sa, string aa,
string ar, string process, string quantity, string value, string hypertension, string diabetes, string cataract, string pterigion, string irritation,
string sleepiness, string burning, string headache, string itch, string tearing, string eye_movementes, string ophthalmoscopy, string eye_adnexa,
string hirsscheberg_test, string retinoscopy, string laboratory_id, string shipping_date, string admission_date, string delivery_date,
string optomestrist_id, string consultant_id,
string client_id, string age, string invoice_laboratory, string date_invoice_laboratory, string value_invoice_laboratory, string notes
            )
        {
            recipeData.CreateRecipe(
                number_recipe, Convert.ToDateTime(date_recipe), esf_od, esf_oi, cil_od, cil_oi, eje_od, eje_oi, adic_od, adic_oi,
                 esf_od_recipe,  esf_oi_recipe,  cil_od_recipe,  cil_oi_recipe,  eje_od_recipe,
 eje_oi_recipe,  adic_od_recipe,  adic_oi_recipe,  altob_od_recipe,  altob_oi_recipe,
 altpu_od_recipe,  altpu_oi_recipe,  dplej_od_recipe,  dplej_oi_recipe,  dpcer_od_recipe,
 dpcer_oi_recipe,  base_od_recipe,  base_oi_recipe,
                lensometry_notes, 
                 Convert.ToInt64(ring_id),
                  Convert.ToInt64(glasses_id), 
                  Convert.ToBoolean(comp), 
                  Convert.ToBoolean(sa), 
                  Convert.ToBoolean(aa), 
                  Convert.ToBoolean(ar), 
                  Convert.ToBoolean(process), 
                  Convert.ToInt32(quantity), 
                  value, 
                  Convert.ToBoolean(hypertension),
                  Convert.ToBoolean(diabetes),
                  Convert.ToBoolean(cataract), 
                  Convert.ToBoolean(pterigion), 
                  Convert.ToBoolean(irritation), 
                  Convert.ToBoolean(sleepiness),
                  Convert.ToBoolean(burning), 
                  Convert.ToBoolean(headache), 
                  Convert.ToBoolean(itch), 
                  Convert.ToBoolean(tearing), 
                  eye_movementes, 
                  ophthalmoscopy, 
                  eye_adnexa,
                  hirsscheberg_test, 
                  retinoscopy, 
                  Convert.ToInt64(laboratory_id), 
                  Convert.ToDateTime(shipping_date), 
                  Convert.ToDateTime(admission_date), 
                  Convert.ToDateTime(delivery_date),
                  Convert.ToInt64(optomestrist_id), 
                  Convert.ToInt64(consultant_id), 
                  Convert.ToInt64(client_id), 
                  Convert.ToInt32(age),
                  invoice_laboratory,
                  date_invoice_laboratory, 
                  value_invoice_laboratory, 
                  notes);
        }
    }
}
