using Common.Cache;
using Domain;
using Presentation.View.Forms.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.View.Forms.Invoice
{
    public partial class InvoiceCreate : Form
    {
        CommonController commonController = new CommonController();
        InvoiceController invoiceController = new InvoiceController();
        int counter;
        decimal subtotal_product;
        decimal price_product;
        decimal subtotal, subtotal_secondary;
        decimal total, total_final;
        int quantity;
        decimal discount, discount_secondary;
        public InvoiceCreate()
        {
            InitializeComponent();
            InsertAction("está en el creador de facturas.");
            SelectAllCommonElements();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pcb_close_create_invoice_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_search_client_Click(object sender, EventArgs e)
        {
            RecipeSelector recipeSelector = new RecipeSelector();
            AddOwnedForm(recipeSelector);
            recipeSelector.ShowDialog();
        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void SelectAllCommonElements()
        {
            txt_discount.Text = "0";
            cmb_payment_method.DataSource = commonController.SelectAllPaymentMethod();
            cmb_payment_method.DisplayMember = "payment_method";
            cmb_payment_method.ValueMember = "payment_method_id";
        }

        private void btn_search_optometryst_Click(object sender, EventArgs e)
        {
            UserSelector userSelector = new UserSelector();
            AddOwnedForm(userSelector);
            userSelector.txt_search.Text = "optometryst";
            userSelector.ShowDialog();
        }

        private void btn_search_seller_Click(object sender, EventArgs e)
        {
            UserSelector userSelector = new UserSelector();
            AddOwnedForm(userSelector);
            userSelector.txt_search.Text = "seller";
            userSelector.ShowDialog();
        }

        private void btn_search_gestor_Click(object sender, EventArgs e)
        {
            UserSelector userSelector = new UserSelector();
            AddOwnedForm(userSelector);
            userSelector.txt_search.Text = "manager";
            userSelector.ShowDialog();
        }



        public void CalculateInvoice()
        {
            subtotal = 0;
            for (counter = 0; counter < dgv_products.Rows.Count; counter++)
            {
                if (dgv_products.Rows[counter].Cells["cl_priceUnit_product"] == null)
                {
                    dgv_products.Rows[counter].Cells["cl_subtotal_product"].Value = 0.00;
                }
                else
                {
                    quantity = int.Parse(dgv_products.Rows[counter].Cells["cl_cant_product"].Value.ToString());
                    price_product = decimal.Parse(dgv_products.Rows[counter].Cells["cl_priceUnit_product"].Value.ToString());
                    subtotal_product = quantity * price_product;
                    dgv_products.Rows[counter].Cells["cl_subtotal_product"].Value = subtotal_product;
                    FormatDataGridView();
                }
            }
            foreach (DataGridViewRow row in dgv_products.Rows)
            {
                subtotal += Convert.ToDecimal(row.Cells["cl_subtotal_product"].Value);
            }
            txt_sub_total.Text = "$" + Math.Round(subtotal, 2).ToString();
            txt_total2.Text = "$" + Math.Round(subtotal, 2).ToString();
            total = Math.Round(subtotal, 2);
        }

        private void FormatDataGridView()
        {
           // dgv_products.Columns["cl_priceUnit_product"].DefaultCellStyle.Format = "c";
            dgv_products.Columns["cl_subtotal_product"].DefaultCellStyle.Format = "c";
        }

        private void btn_save_invoice_Click(object sender, EventArgs e)
        {
            int recurrency = 0;
            if (txt_recipe_id.Text == "")
            {
                lbl_error.Text = "Debe seleccionar una receta.";
            }else if (rb_biweekly.Checked == false && rb_montly.Checked == false)
            {
                lbl_error.Text = "Debe elegir una recurrencia de pago";
            }/* else if (txt_postpone.Text == "")
            {
                lbl_error.Text = "Debe indicar a los cuantos días debemos aplazarlo.";
            } */
            else if (txt_n_fee.Text == "")
            {
                lbl_error.Text = "Debe indicar el número de coutas a generar.";
            }else if (txt_fee.Text == "")
            {
                lbl_error.Text = "Debe indicar el valor de la couta a asignar.";
            }else if (txt_optometryst_id.Text == "")
            {
                lbl_error.Text = "Debe seleccionar el optometrista asignado.";
            }else if(txt_seller_id.Text == "")
            {
                lbl_error.Text = "Debe seleccionar el gestor asignado.";
            }else if(txt_manager_id.Text == "")
            {
                lbl_error.Text = "Debe seleccionar el asesor asignado.";
            }else if(dgv_products.Rows.Count == 0)
            {
                MessageBox.Show("Ocurrió un error mientras revisabamos los productos a gestionar, verificar si la receta contiene Aro y Lentes seleccionardos previamente.");
            }
            else
            {
                if (rb_biweekly.Checked == true)
                {
                    recurrency = 15;
                }
                else if (rb_montly.Checked == true)
                {
                    recurrency = 30;
                }
                try
                 {

                invoiceController.InsertInvoice(txt_first_payment.Text, dtp_invoice.Value.ToString(), "1", txt_optometryst_id.Text,
                   recurrency.ToString(), txt_seller_id.Text, txt_manager_id.Text, txt_recipe_id.Text, cmb_payment_method.SelectedValue.ToString(), subtotal.ToString(), discount.ToString(), total_final.ToString(),  txt_n_fee.Text, txt_fee.Text, txt_notes.Text, txt_pay_day_1.Text, txt_pay_day_2.Text, subtotal_secondary.ToString(), discount_secondary.ToString());

                foreach (DataGridViewRow rows in dgv_products.Rows)
                    {
                        invoiceController.InsertDetailInvoice(rows.Cells["cl_id_product"].Value.ToString(),
                            rows.Cells["cl_cant_product"].Value.ToString(),
                            rows.Cells["cl_priceUnit_product"].Value.ToString(),
                            rows.Cells["cl_subtotal_product"].Value.ToString());
                    }
                   
                    MessageBox.Show("Se ha generado la factura con éxito");
                    Close();
                }
               catch (Exception errInvoice)
               {

                    MessageBox.Show("Ocurrió un error al intentar guardar la factura.\n\nError: " +errInvoice.Message, "Facturas");
                }
            }
        }

        private void txt_sub_total_TextChanged(object sender, EventArgs e)
        {
            txt_total2.Text = Math.Round(subtotal, 2).ToString();
        }

        private void dgv_products_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateInvoice();
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text == "")
            {
                txt_with_discount.Text = "$0.00";
                txt_total2.Text =  Math.Round(subtotal, 2).ToString();
                txt_total.Text =  Math.Round(subtotal, 2).ToString();
                total = Math.Round(subtotal, 2);
            }
            else
            {
                discount = Convert.ToDecimal(txt_discount.Text);
                decimal withDiscount = subtotal * (discount / 100);
                txt_with_discount.Text = "$"+Math.Round(withDiscount, 2).ToString();
                total = subtotal - withDiscount;
                txt_total2.Text = Math.Round(total, 2).ToString();
                txt_total.Text =  Math.Round(total, 2).ToString();
            }
        }

        private void btn_add_element_Click(object sender, EventArgs e)
        {
            ProductsSelector productsSelector = new ProductsSelector();
            AddOwnedForm(productsSelector);
            productsSelector.ShowDialog();
        }

        private void btn_remove_element_Click(object sender, EventArgs e)
        {
            if (dgv_products.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una fila previamente.");
            }
            else
            {
                dgv_products.Rows.Remove(dgv_products.CurrentRow);
                CalculateInvoice();
            }
        }

        private void txt_discount_secondary_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount_secondary.Text == "")
            {
                txt_discount_secondary.Text = "0.00";
                total_final = Math.Round(subtotal - subtotal_secondary, 2);
                txt_total.Text = "$" + Math.Round(total_final, 2).ToString();
            }
            else
            {
                subtotal_secondary = Convert.ToDecimal(txt_total2.Text);
                discount_secondary = Convert.ToDecimal(txt_discount_secondary.Text);
                decimal withDiscountSecondary = total * (discount_secondary / 100);
                txt_with_discount_secondary.Text = "$" + Math.Round(withDiscountSecondary, 2).ToString();
                total_final = subtotal_secondary - withDiscountSecondary;
                txt_total.Text = "$" + Math.Round(total_final, 2).ToString();
            }
        }

    }
}
