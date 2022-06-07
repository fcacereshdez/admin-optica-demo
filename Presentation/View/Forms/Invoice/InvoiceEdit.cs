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
    public partial class InvoiceEdit : Form
    {
        CommonController commonController = new CommonController();
        InvoiceController invoiceController = new InvoiceController();
        int counter;
        decimal subtotal_product;
        decimal price_product;
        decimal subtotal;
        decimal total;
        int quantity;
        decimal discount;
        public InvoiceEdit()
        {
            InitializeComponent();
            InsertAction("está en el editor de facturas.");
            SelectAllCommonElements();
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
                if (dgv_products.Rows[counter].Cells[4] == null)
                {
                    dgv_products.Rows[counter].Cells[5].Value = 0.00;
                }
                else
                {
                    quantity = int.Parse(dgv_products.Rows[counter].Cells[3].Value.ToString());
                    price_product = decimal.Parse(dgv_products.Rows[counter].Cells[4].Value.ToString());
                    subtotal_product = quantity * price_product;
                    dgv_products.Rows[counter].Cells[5].Value = subtotal_product;
                    FormatDataGridView();
                }
            }
            foreach (DataGridViewRow row in dgv_products.Rows)
            {
                subtotal += Convert.ToDecimal(row.Cells[5].Value);
            }
            txt_sub_total.Text = "$" + Math.Round(subtotal, 2).ToString();
            txt_total.Text = "$" + Math.Round(subtotal, 2).ToString();
            total = Math.Round(subtotal, 2);
        }

        private void FormatDataGridView()
        {
           // dgv_products.Columns["cl_priceUnit_product"].DefaultCellStyle.Format = "c";
            dgv_products.Columns[5].DefaultCellStyle.Format = "c";
        }

        private void btn_save_invoice_Click(object sender, EventArgs e)
        {
            int recurrency = 0;
            if (rb_biweekly.Checked == false && rb_montly.Checked == false)
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

                    foreach (DataGridViewRow rows in dgv_products.Rows)
                    {
                        invoiceController.UpdateDetailInvoice(rows.Cells[0].Value.ToString(),
                            rows.Cells[3].Value.ToString(),
                            rows.Cells[4].Value.ToString(),
                            rows.Cells[5].Value.ToString());
                    }
                     invoiceController.UpdateInvoice(txt_first_payment.Text, dtp_invoice.Value.ToString(), txt_optometryst_id.Text,
                     recurrency.ToString(), txt_seller_id.Text, txt_manager_id.Text, cmb_payment_method.SelectedValue.ToString(), subtotal.ToString(), discount.ToString(), total.ToString(), txt_n_fee.Text, txt_fee.Text, txt_notes.Text, txt_pay_day_1.Text, txt_pay_day_2.Text, Common.Models.Invoice.id_invoice.ToString());
                    MessageBox.Show("Se ha modificado la factura con éxito");
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
            txt_total.Text = Math.Round(subtotal, 2).ToString();
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
                txt_total.Text = "$" + Math.Round(subtotal, 2).ToString();
                total = Math.Round(subtotal, 2);
            }
            else
            {
                discount = Convert.ToDecimal(txt_discount.Text);
                decimal withDiscount = subtotal * (discount / 100);
                txt_with_discount.Text = "$"+Math.Round(withDiscount, 2).ToString();
                total = subtotal - withDiscount;
                txt_total.Text = "$" + Math.Round(total, 2).ToString();
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

        private void InvoiceEdit_Load(object sender, EventArgs e)
        {
            dtp_invoice.Value = Common.Models.Invoice.date;
            lbl_client_name.Text = Common.Models.Invoice.client_name;
            cmb_payment_method.SelectedValue = Common.Models.Invoice.payment_method;
            if (Common.Models.Invoice.recurrence == 30)
            {
                rb_montly.Checked = true;
            }
            else
            {
                rb_biweekly.Checked = true;
            }
            txt_pay_day_1.Text = Common.Models.Invoice.first_pay_day;
            txt_pay_day_2.Text = Common.Models.Invoice.secondary_pay_day;
            txt_n_fee.Text = Common.Models.Invoice.n_payments.ToString();
            txt_fee.Text = Common.Models.Invoice.fee.ToString();
            txt_optometryst.Text = Common.Models.Invoice.optometrist;
            txt_seller.Text = Common.Models.Invoice.consultant;
            txt_manager.Text = Common.Models.Invoice.manager;
            txt_optometryst_id.Text = Common.Models.Invoice.optometrist_id.ToString();
            txt_seller_id.Text = Common.Models.Invoice.consultant_id.ToString();
            txt_manager_id.Text = Common.Models.Invoice.manager_id.ToString();
            txt_sub_total.Text = Common.Models.Invoice.subtotal.ToString();
            txt_total.Text = Common.Models.Invoice.total.ToString();
            txt_discount.Text = Common.Models.Invoice.discount.ToString();
            txt_notes.Text = Common.Models.Invoice.notes;

            dgv_products.Columns[0].Visible = false;
            dgv_products.Columns[2].Width = 287;

            CalculateInvoice();
        }
    }
}
