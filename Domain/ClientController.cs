using Common.Cache;
using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class ClientController
    {
        ClientData clientData = new ClientData();
        ClientAccountData clientAccountData = new ClientAccountData();

        public DataTable SelectAllClients()
        {
            DataTable TableClients = new DataTable();
            TableClients = clientData.SelectAllClients();
            return TableClients;
        }
        public DataTable SearchClient(string client)
        {
            DataTable TableClients = new DataTable();
            TableClients = clientData.SearchClient(client);
            return TableClients;
        }
        public void SelectClientById(string client_id)
        {
            clientData.SelectClientById(Convert.ToInt64(client_id));
        }
        public void CreateClient(string name, string lastname, string code, string dui, string nit, string phone, string secondary_phone, string email, string address, string notes, string company_id, string dateOfBirth, string created_at)
        {
            clientData.CreateClient(name, lastname, code, dui, nit, phone, secondary_phone, email, address, notes, Convert.ToInt64(company_id), dateOfBirth, Convert.ToDateTime(created_at));
        }

        public void UpdateClient(string name, string lastname, string dui, string nit, string phone, string secondary_phone, string email, string address, string notes, string updated_at, Int64 client_id)
        {
            clientData.UpdateClient(name, lastname, dui, nit, phone, secondary_phone, email, address, notes, Convert.ToDateTime(updated_at), client_id);
        }

        public void DeleteClient(string client_id)
        {
            clientData.DeleteClient(Convert.ToInt64(client_id));
        }

        public void SelectLastCodeClient()
        {
            clientData.SelectLastCodeClient();
        }

        public DataTable GetInvoiceByClient(Int64 client_id)
        {
            DataTable TableInvoices = new DataTable();
            TableInvoices = clientAccountData.GetInvoiceByClient(client_id);
            return TableInvoices;
        }

        public void GetClientAccountById(Int64 invoice_id)
        {
            clientAccountData.GetClientAccountById(invoice_id);
        }

        public void PayInovice(string payment_method, string amount, string bank, string reference, string note, string check, string ccf, string invoice, string created_at)
        {
            clientAccountData.PayInovice(Convert.ToInt64(payment_method), Convert.ToDecimal(amount), created_at, UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd"), Convert.ToInt64(bank), reference, note, check, ccf, Convert.ToInt64(invoice));
        }

        public void CountClients()
        {
            clientData.CountClients();
        }
    }
}
