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
                            Recipe.eje_od = reader.GetString(9);
                            Recipe.adic_oi = reader.GetString(10);
                            Recipe.esf_od_recipe = reader.GetString(11);
                            Recipe.esf_oi_recipe = reader.GetString(12);
                            Recipe.cil_od_recipe = reader.GetString(13);
                            Recipe.cil_oi_recipe = reader.GetString(14);
                            Recipe.eje_od_recipe = reader.GetString(15);
                            Recipe.eje_oi_recipe = reader.GetString(16);
                            Recipe.adic_od_recipe = reader.GetString(17);
                            Recipe.adic_oi_recipe = reader.GetString(18);
                            Recipe.altob_od_recipe = reader.GetString(19);
                            Recipe.altob_oi_recipe = reader.GetString(20);
                            Recipe.altpu_od_recipe = reader.GetString(21);
                            Recipe.altpu_oi_recipe = reader.GetString(22);
                            Recipe.dplej_od_recipe = reader.GetString(23);
                            Recipe.dplej_oi_recipe = reader.GetString(24);
                            Recipe.dpcer_od_recipe = reader.GetString(25);
                            Recipe.dpcer_oi_recipe = reader.GetString(26);
                            Recipe.base_od_recipe = reader.GetString(27);
                            Recipe.base_oi_recipe = reader.GetString(28);
                            Recipe.lensometry_notes = reader.GetString(29);
                            Recipe.ring_id = reader.GetInt64(30);
                            Recipe.glasses_id = reader.GetInt64(31);
                            Recipe.comp = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(32).ToString()));
                            Recipe.sa = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(33).ToString()));
                            Recipe.aa = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(34).ToString()));
                            Recipe.ar = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(35).ToString()));
                            Recipe.process = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(36).ToString()));
                            Recipe.quantity = reader.GetInt32(37);
                            Recipe.value = reader.GetString(38);
                            Recipe.hypertension = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(39).ToString()));
                            Recipe.diabetes = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(40).ToString()));
                            Recipe.cataract = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(41).ToString()));
                            Recipe.pterigion = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(42).ToString()));
                            Recipe.irritation = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(43).ToString()));
                            Recipe.sleepiness = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(44).ToString()));
                            Recipe.burning = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(45).ToString()));
                            Recipe.headache = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(46).ToString()));
                            Recipe.itch = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(47).ToString()));
                            Recipe.tearing = Convert.ToBoolean(Convert.ToInt32(reader.GetValue(48).ToString()));
                            Recipe.eye_movementes = reader.GetString(49);
                            Recipe.ophthalmoscopy = reader.GetString(50);
                            Recipe.eye_adnexa = reader.GetString(51);
                            Recipe.hirsscheberg_test = reader.GetString(52);
                            Recipe.retinoscopy = reader.GetString(53);
                            Recipe.laboratory_id = reader.GetInt64(54);
                            Recipe.shipping_date = reader.GetDateTime(55);
                            Recipe.admission_date = reader.GetDateTime(56);
                            Recipe.delivery_date = reader.GetDateTime(57);
                            Recipe.optomestrist_id = reader.GetInt64(58);
                            Recipe.consultant_id = reader.GetInt64(59);
                            Recipe.client_id = reader.GetInt64(60);
                            Recipe.client_age = reader.GetInt32(61);
                            Recipe.invoice_laboratory = reader.GetString(62);
                            Recipe.date_invoice_laboratory = reader.GetString(63);
                            Recipe.value_invoice_laboratory = reader.GetString(64);
                            Recipe.notes = reader.GetString(65);
                            Recipe.client_name = reader.GetString(66);
                            Recipe.client_lastname = reader.GetString(67);
                            Recipe.company_name = reader.GetString(68);
                            Recipe.ring = reader.GetString(69);
                            Recipe.glasses = reader.GetString(70);
                            Recipe.laboratory = reader.GetString(71);
                            Recipe.optometryst = reader.GetString(72);
                            Recipe.seller = reader.GetString(73);
                        }
                    }
                }
            }
        }

        public void CreateRecipe(
string number_recipe, DateTime date_recipe, string esf_od,
string esf_oi, string cil_od, string cil_oi, string eje_od, string eje_oi, string adic_od, string adic_oi,
string esf_od_recipe, string esf_oi_recipe, string cil_od_recipe, string cil_oi_recipe, string eje_od_recipe,
string eje_oi_recipe, string adic_od_recipe, string adic_oi_recipe, string altob_od_recipe, string altob_oi_recipe,
string altpu_od_recipe, string altpu_oi_recipe, string dplej_od_recipe, string dplej_oi_recipe, string dpcer_od_recipe,
string dpcer_oi_recipe, string base_od_recipe, string base_oi_recipe,
string lensometry_notes,
Int64 ring_id, Int64 glasses_id, bool comp, bool sa, bool aa,
bool ar, bool process, int quantity, string value, bool hypertension, bool diabetes, bool cataract, bool pterigion, bool irritation,
bool sleepiness, bool burning, bool headache, bool itch, bool tearing, string eye_movementes, string ophthalmoscopy, string eye_adnexa,
string hirsscheberg_test, string retinoscopy, Int64 laboratory_id, DateTime shipping_date, DateTime admission_date, DateTime delivery_date,
Int64 optomestrist_id, Int64 consultant_id,
Int64 client_id, Int32 age, string invoice_laboratory, string date_invoice_laboratory, string value_invoice_laboratory, string notes

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
                    cmd.Parameters.AddWithValue("@esf_od_recipe", esf_od_recipe);
                    cmd.Parameters.AddWithValue("@esf_oi_recipe", esf_oi_recipe);
                    cmd.Parameters.AddWithValue("@cil_od_recipe", cil_od_recipe);
                    cmd.Parameters.AddWithValue("@cil_oi_recipe", cil_oi_recipe);
                    cmd.Parameters.AddWithValue("@eje_od_recipe", eje_od_recipe);
                    cmd.Parameters.AddWithValue("@eje_oi_recipe", eje_oi_recipe);
                    cmd.Parameters.AddWithValue("@adic_od_recipe", adic_od_recipe);
                    cmd.Parameters.AddWithValue("@adic_oi_recipe", adic_oi_recipe);
                    cmd.Parameters.AddWithValue("@altob_od_recipe", altob_od_recipe);
                    cmd.Parameters.AddWithValue("@altob_oi_recipe", altob_oi_recipe);
                    cmd.Parameters.AddWithValue("@altpu_od_recipe", altpu_od_recipe);
                    cmd.Parameters.AddWithValue("@altpu_oi_recipe", altpu_oi_recipe);
                    cmd.Parameters.AddWithValue("@dplej_od_recipe", dplej_od_recipe);
                    cmd.Parameters.AddWithValue("@dplej_oi_recipe", dplej_oi_recipe);
                    cmd.Parameters.AddWithValue("@dpcer_od_recipe", dpcer_od_recipe);
                    cmd.Parameters.AddWithValue("@dpcer_oi_recipe", dpcer_oi_recipe);
                    cmd.Parameters.AddWithValue("@base_od_recipe", base_od_recipe);
                    cmd.Parameters.AddWithValue("@base_oi_recipe", base_oi_recipe);
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

        public void UpdateRecipe(DateTime date_recipe, string esf_od,
string esf_oi, string cil_od, string cil_oi, string eje_od, string eje_oi, string adic_od, string adic_oi,
string esf_od_recipe, string esf_oi_recipe, string cil_od_recipe, string cil_oi_recipe, string eje_od_recipe,
string eje_oi_recipe, string adic_od_recipe, string adic_oi_recipe, string altob_od_recipe, string altob_oi_recipe,
string altpu_od_recipe, string altpu_oi_recipe, string dplej_od_recipe, string dplej_oi_recipe, string dpcer_od_recipe,
string dpcer_oi_recipe, string base_od_recipe, string base_oi_recipe,
string lensometry_notes,
bool comp, bool sa, bool aa,
bool ar, bool process, int quantity, string value, bool hypertension, bool diabetes, bool cataract, bool pterigion, bool irritation,
bool sleepiness, bool burning, bool headache, bool itch, bool tearing, string eye_movementes, string ophthalmoscopy, string eye_adnexa,
string hirsscheberg_test, string retinoscopy, DateTime shipping_date, DateTime admission_date, DateTime delivery_date,
Int32 age, string invoice_laboratory, string date_invoice_laboratory, string value_invoice_laboratory, string notes, Int64 ring, Int64 glasses

            )
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UpdateRecipe";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@date_recipe", date_recipe);
                    cmd.Parameters.AddWithValue("@esf_od", esf_od);
                    cmd.Parameters.AddWithValue("@esf_oi", esf_oi);
                    cmd.Parameters.AddWithValue("@cil_od", cil_od);
                    cmd.Parameters.AddWithValue("@cil_oi", cil_oi);
                    cmd.Parameters.AddWithValue("@eje_od", eje_od);
                    cmd.Parameters.AddWithValue("@eje_oi", eje_oi);
                    cmd.Parameters.AddWithValue("@adic_od", adic_od);
                    cmd.Parameters.AddWithValue("@adic_oi", adic_oi);
                    cmd.Parameters.AddWithValue("@esf_od_recipe", esf_od_recipe);
                    cmd.Parameters.AddWithValue("@esf_oi_recipe", esf_oi_recipe);
                    cmd.Parameters.AddWithValue("@cil_od_recipe", cil_od_recipe);
                    cmd.Parameters.AddWithValue("@cil_oi_recipe", cil_oi_recipe);
                    cmd.Parameters.AddWithValue("@eje_od_recipe", eje_od_recipe);
                    cmd.Parameters.AddWithValue("@eje_oi_recipe", eje_oi_recipe);
                    cmd.Parameters.AddWithValue("@adic_od_recipe", adic_od_recipe);
                    cmd.Parameters.AddWithValue("@adic_oi_recipe", adic_oi_recipe);
                    cmd.Parameters.AddWithValue("@altob_od_recipe", altob_od_recipe);
                    cmd.Parameters.AddWithValue("@altob_oi_recipe", altob_oi_recipe);
                    cmd.Parameters.AddWithValue("@altpu_od_recipe", altpu_od_recipe);
                    cmd.Parameters.AddWithValue("@altpu_oi_recipe", altpu_oi_recipe);
                    cmd.Parameters.AddWithValue("@dplej_od_recipe", dplej_od_recipe);
                    cmd.Parameters.AddWithValue("@dplej_oi_recipe", dplej_oi_recipe);
                    cmd.Parameters.AddWithValue("@dpcer_od_recipe", dpcer_od_recipe);
                    cmd.Parameters.AddWithValue("@dpcer_oi_recipe", dpcer_oi_recipe);
                    cmd.Parameters.AddWithValue("@base_od_recipe", base_od_recipe);
                    cmd.Parameters.AddWithValue("@base_oi_recipe", base_oi_recipe);
                    cmd.Parameters.AddWithValue("@lensometry_notes", lensometry_notes);
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
                    cmd.Parameters.AddWithValue("@shipping_date", shipping_date);
                    cmd.Parameters.AddWithValue("@admission_date", admission_date);
                    cmd.Parameters.AddWithValue("@delivery_date", delivery_date);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@invoice_laboratory", invoice_laboratory);
                    cmd.Parameters.AddWithValue("@date_invoice_laboratory", date_invoice_laboratory);
                    cmd.Parameters.AddWithValue("@value_invoice_laboratory", value_invoice_laboratory);
                    cmd.Parameters.AddWithValue("@notes", notes);
                    cmd.Parameters.AddWithValue("@ring", ring);
                    cmd.Parameters.AddWithValue("@glasses", glasses);
                    cmd.Parameters.AddWithValue("@recipe_id", Recipe.recipe_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void DeleteRecipe(Int64 recipe_id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DeleteRecipe";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@recipe_id", recipe_id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public DataTable SearchRecipe(string client)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SearchRecipe";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@client", client);
                    SqlDataReader ReaderRecipes = cmd.ExecuteReader();
                    DataTable TableRecipes = new DataTable();
                    TableRecipes.Load(ReaderRecipes);
                    conn.Close();
                    return TableRecipes;
                }
            }
        }
    }
}
