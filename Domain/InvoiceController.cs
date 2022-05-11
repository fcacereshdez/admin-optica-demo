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
    }
}
