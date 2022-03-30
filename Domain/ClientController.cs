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

        public DataTable SelectAllClients()
        {
            DataTable TableClients = new DataTable();
            TableClients = clientData.SelectAllClients();
            return TableClients;
        }
        public void SelectClientById(string client_id)
        {
            clientData.SelectClientById(Convert.ToInt64(client_id));
        }
        public void CreateClient(string name, string lastname, string code, string dui, string nit, string phone, string secondary_phone, string email, string address, string notes, string company_id, string created_at)
        {
            clientData.CreateClient(name, lastname, code, dui, nit, phone, secondary_phone, email, address, notes, Convert.ToInt64(company_id), Convert.ToDateTime(created_at));
        }

        public void UpdateClient(string name, string lastname, string dui, string nit, string phone, string secondary_phone, string email, string address, string notes, string company_id, string updated_at, Int64 client_id)
        {
            clientData.UpdateClient(name, lastname, dui, nit, phone, secondary_phone, email, address, notes, Convert.ToInt64(company_id), Convert.ToDateTime(updated_at), client_id);
        }

        public void DeleteClient(Int64 client_id)
        {
            clientData.DeleteClient(client_id);
        }

        public void SelectLastCodeClient()
        {
            clientData.SelectLastCodeClient();
        }
    }
}
