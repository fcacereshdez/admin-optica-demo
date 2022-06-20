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
        public DataTable GetAccountStatusAllClients()
        {
            DataTable DataSetAccountStatus = new DataTable();
            DataSetAccountStatus = reportData.GetAccountStatusAllClients();
            return DataSetAccountStatus;
        }
        public DataTable GetAuditAllUsers()
        {
            DataTable DataSetAuditAllUsers = new DataTable();
            DataSetAuditAllUsers = reportData.GetAuditAllUsers();
            return DataSetAuditAllUsers;
        }

        public DataTable SelectAllSalesByOptometrist(string from, string to)
        {
            DataTable DataSetSalesOptometrist = new DataTable();
            DataSetSalesOptometrist = reportData.SelectSalesByOptometrist(from, to);
            return DataSetSalesOptometrist;
        }
        public DataTable SelectAllSalesByOptometristAll()
        {
            DataTable DataSetSalesOptometrist = new DataTable();
            DataSetSalesOptometrist = reportData.SelectSalesByOptometristAll();
            return DataSetSalesOptometrist;
        }
        public DataTable SelectAllSalesByConsultant(string from, string to)
        {
            DataTable DataSetSalesConsultant = new DataTable();
            DataSetSalesConsultant = reportData.SelectSalesByConsultant(from, to);
            return DataSetSalesConsultant;
        }
        public DataTable SelectAllSalesByConsultantAll()
        {
            DataTable DataSetSalesConsultant = new DataTable();
            DataSetSalesConsultant = reportData.SelectSalesByConsultantAll();
            return DataSetSalesConsultant;
        }
        public DataTable SelectAllSalesByManager(string from, string to)
        {
            DataTable DataSetSalesManager = new DataTable();
            DataSetSalesManager = reportData.SelectSalesByManager(from, to);
            return DataSetSalesManager;
        }

        public DataTable SelectAllSalesByManagerAll()
        {
            DataTable DataSetSalesManager = new DataTable();
            DataSetSalesManager = reportData.SelectSalesByManagerAll();
            return DataSetSalesManager;
        }

        public void CountClients()
        {
            clientData.CountClients();
        }

    }

}
