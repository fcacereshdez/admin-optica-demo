using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CommonController
    {
        CommonData commonData = new CommonData();
        ReportsData reportData = new ReportsData();
        ClientData clientData = new ClientData();

        public DataTable SelectAllBank()
        {
            DataTable TableBanks = new DataTable();
            TableBanks = commonData.SelectAllBank();
            return TableBanks;
        }

        public DataTable SelectAllPaymentMethod()
        {
            DataTable TablePaymentMethod = new DataTable();
            TablePaymentMethod = commonData.SelectAllPaymentMethod();
            return TablePaymentMethod;
        }

        public DataTable GetSalesBook()
        {
            DataTable DataSetSalesBook = new DataTable();
            DataSetSalesBook = reportData.GetSalesBook();
            return DataSetSalesBook;
        }

        public DataTable GetAuditAllUsers()
        {
            DataTable DataSetAuditAllUsers = new DataTable();
            DataSetAuditAllUsers = reportData.GetAuditAllUsers();
            return DataSetAuditAllUsers;
        }

        public void CountClients()
        {
            clientData.CountClients();
        }

    }

}
