using Common.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class RecipeData : DBConnection
    {
        public DataTable SelectAllRecipes()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllRecipes";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader ReaderRecipes = cmd.ExecuteReader();
                    DataTable TableRecipes = new DataTable();
                    TableRecipes.Load(ReaderRecipes);
                    conn.Close();
                    return TableRecipes;
                }
            }
        }

        public DataTable SelectAllRecipesById(Int64 client_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectAllRecipesById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@client_id", client_id);
                    SqlDataReader ReaderRecipes = cmd.ExecuteReader();
                    DataTable TableRecipes = new DataTable();
                    TableRecipes.Load(ReaderRecipes);
                    conn.Close();
                    return TableRecipes;
                }
            }
        }

        public void SelectRecipeById(Int64 recipe_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SelectRecipeById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@recipe_id", recipe_id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Recipe.recipe_id = reader.GetInt64(0);
                            Recipe.number_recipe = reader.GetString(1);
                            Recipe.date_recipe = reader.GetDateTime(2);
                            Recipe.esf_od = reader.GetString(3);
                            Recipe.esf_oi = reader.GetString(4);
                            Recipe.cil_od = reader.GetString(5);
                            Recipe.cil_oi = reader.GetString(6);
                            Recipe.eje_od = reader.GetString(7);
                            Recipe.eje_oi = reader.GetString(8);
                            Recipe.adic_od = reader.GetString(9);
                            Recipe.adic_oi = reader.GetString(10);
                            Recipe.lensometry_notes = reader.GetString(11);
                            Recipe.ring_id = reader.GetInt64(12);
                            Recipe.glasses_id = reader.GetInt64(13);
                            Recipe.comp = Convert.ToBoolean(14);
                            /*Recipe.sa = reader.GetBoolean(15);
                            Recipe.aa = reader.GetBoolean(16);
                            Recipe.ar = reader.GetBoolean(17);
                            Recipe.process = reader.GetBoolean(18); */
                            Recipe.quantity = reader.GetInt32(19);
                            Recipe.value = reader.GetString(20);
                            /* Recipe.hypertension = reader.GetBoolean(21);
                            Recipe.diabetes = reader.GetBoolean(22);
                            Recipe.cataract = reader.GetBoolean(23);
                            Recipe.pterigion = reader.GetBoolean(24);
                            Recipe.irritation = reader.GetBoolean(25);
                            Recipe.sleepiness = reader.GetBoolean(26);
                            Recipe.burning = reader.GetBoolean(27);
                            Recipe.headache = reader.GetBoolean(28);
                            Recipe.itch = reader.GetBoolean(29);
                            Recipe.tearing = reader.GetBoolean(30);
                             */
                            Recipe.eye_movementes = reader.GetString(31);
                            Recipe.ophthalmoscopy = reader.GetString(33);
                            Recipe.eye_adnexa = reader.GetString(33);
                            Recipe.hirsscheberg_test = reader.GetString(34);
                            Recipe.retinoscopy = reader.GetString(35);
                            Recipe.laboratory_id = reader.GetInt64(36);
                            Recipe.shipping_date = reader.GetDateTime(37);
                            Recipe.admission_date = reader.GetDateTime(38);
                            Recipe.delivery_date = reader.GetDateTime(39);
                            Recipe.optomestrist_id = reader.GetInt64(40);
                            Recipe.consultant_id = reader.GetInt64(41);
                            Recipe.client_id = reader.GetInt64(42);
                            Recipe.client_age = reader.GetInt32(43);
                            Recipe.invoice_laboratory = reader.GetString(44);
                            Recipe.date_invoice_laboratory = reader.GetString(45);
                            Recipe.value_invoice_laboratory = reader.GetString(46);
                            Recipe.notes = reader.GetString(47);
                            Recipe.client_name = reader.GetString(48);
                            Recipe.client_lastname = reader.GetString(49);
                            Recipe.company_name = reader.GetString(50);
                            Recipe.ring = reader.GetString(51);
                            Recipe.glasses = reader.GetString(52);
                            Recipe.laboratory = reader.GetString(53);
                            Recipe.optometryst = reader.GetString(54);
                            Recipe.seller = reader.GetString(55);
                        }
                    }
                }
            }
        }

        public void CreateRecipe(
string number_recipe, DateTime date_recipe, string esf_od,
string esf_oi, string cil_od, string cil_oi, string eje_od, string eje_oi, string adic_od, string adic_oi, string lensometry_notes, 
Int64 ring_id, Int64 glasses_id, bool comp, bool sa, bool aa,
bool ar, bool process, int quantity, string value, bool hypertension, bool diabetes, bool cataract, bool pterigion, bool irritation,
bool sleepiness, bool burning, bool headache, bool itch, bool tearing, string eye_movementes, string ophthalmoscopy, string eye_adnexa,
string hirsscheberg_test, string retinoscopy, Int64 laboratory_id, DateTime shipping_date, DateTime admission_date, DateTime delivery_date,
Int64 optomestrist_id, Int64 consultant_id,
Int64 client_id, Int32 age, string invoice_laboratory , string date_invoice_laboratory, string value_invoice_laboratory, string notes

            )
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "InsertRecipe";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@number_recipe", number_recipe);
                    cmd.Parameters.AddWithValue("@date_recupe", date_recipe);
                    cmd.Parameters.AddWithValue("@esf_od", esf_od);
                    cmd.Parameters.AddWithValue("@esf_oi", esf_oi);
                    cmd.Parameters.AddWithValue("@cil_od", cil_od);
                    cmd.Parameters.AddWithValue("@cil_oi", cil_oi);
                    cmd.Parameters.AddWithValue("@eje_od", eje_od);
                    cmd.Parameters.AddWithValue("@eje_oi", eje_oi);
                    cmd.Parameters.AddWithValue("@adic_od", adic_od);
                    cmd.Parameters.AddWithValue("@adic_oi", adic_oi);
                    cmd.Parameters.AddWithValue("@lensometry_notes", lensometry_notes);
                    cmd.Parameters.AddWithValue("@ring_id", ring_id);
                    cmd.Parameters.AddWithValue("@glasses_id", glasses_id);
                    cmd.Parameters.AddWithValue("@comp", comp);
                    cmd.Parameters.AddWithValue("@sa", sa);
                    cmd.Parameters.AddWithValue("@aa", aa);
                    cmd.Parameters.AddWithValue("@ar", ar);
                    cmd.Parameters.AddWithValue("@process", process);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.Parameters.AddWithValue("@hypertension", hypertension);
                    cmd.Parameters.AddWithValue("@diabetes", diabetes);
                    cmd.Parameters.AddWithValue("@cataract", cataract);
                    cmd.Parameters.AddWithValue("@pterigion", pterigion);
                    cmd.Parameters.AddWithValue("@irritation", irritation);
                    cmd.Parameters.AddWithValue("@sleepiness", sleepiness);
                    cmd.Parameters.AddWithValue("@burning", burning);
                    cmd.Parameters.AddWithValue("@headache", headache);
                    cmd.Parameters.AddWithValue("@itch", itch);
                    cmd.Parameters.AddWithValue("@tearing", tearing);
                    cmd.Parameters.AddWithValue("@eye_movementes", eye_movementes);
                    cmd.Parameters.AddWithValue("@ophthalmoscopy", ophthalmoscopy);
                    cmd.Parameters.AddWithValue("@eye_adnexa", eye_adnexa);
                    cmd.Parameters.AddWithValue("@hirsscheberg_test", hirsscheberg_test);
                    cmd.Parameters.AddWithValue("@retinoscopy", retinoscopy);
                    cmd.Parameters.AddWithValue("@laboratory_id", laboratory_id);
                    cmd.Parameters.AddWithValue("@shipping_date", shipping_date);
                    cmd.Parameters.AddWithValue("@admission_date", admission_date);
                    cmd.Parameters.AddWithValue("@delivery_date", delivery_date);
                    cmd.Parameters.AddWithValue("@optomestrist_id", optomestrist_id);
                    cmd.Parameters.AddWithValue("@consultant_id", consultant_id);
                    cmd.Parameters.AddWithValue("@client_id", client_id);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@invoice_laboratory", invoice_laboratory);
                    cmd.Parameters.AddWithValue("@date_invoice_laboratory", date_invoice_laboratory);
                    cmd.Parameters.AddWithValue("@value_invoice_laboratory", value_invoice_laboratory);
                    cmd.Parameters.AddWithValue("@notes", notes);
                    cmd.ExecuteNonQuery();
                    conn.Close();
 
                }
            }
        }
    }
}
