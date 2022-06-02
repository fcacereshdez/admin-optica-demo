using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class InvoiceController
    {
        InvoiceData invoiceData = new InvoiceData();
        public DataTable SelectAllInvoices()
        {
            DataTable TableInvoices = new DataTable();
            TableInvoices = invoiceData.SelectAllInvoices();
            return TableInvoices;
        }

        public void InsertInvoice(string firstpayment, string date, string number, string optometryst_id, string recurrency, string seller_id, string manager_id, string recipe_id, string payment_method, string subtotal, string discount, string total, string nfee, string fee, string notes, string fday, string sday)
        {
            invoiceData.InsertInvoice(Convert.ToDecimal(firstpayment), Convert.ToDateTime(date), Convert.ToInt32(number), Convert.ToInt64(optometryst_id),
                Convert.ToInt32(recurrency), Convert.ToInt64(seller_id), Convert.ToInt64(manager_id), Convert.ToInt64(recipe_id), Convert.ToInt64(payment_method),
                Convert.ToDecimal(subtotal), Convert.ToDecimal(discount), Convert.ToDecimal(total), Convert.ToInt32(nfee), Convert.ToDecimal(fee), notes, fday, sday);
        }

        public void InsertDetailInvoice(string product_id, string quantity, string value, string total)
        {
            invoiceData.InsertDetailInvoice(Convert.ToInt64(product_id), Convert.ToInt32(quantity), Convert.ToDecimal(value), Convert.ToDecimal(total));
        }

        public void DeleteInvoice(string invoice_id)
        {
            invoiceData.DeleteInvoice(Convert.ToInt64(invoice_id));
        }
    }
}
