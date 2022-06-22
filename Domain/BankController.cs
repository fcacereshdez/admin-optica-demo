using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public  class BankController
    {
        BankData bankData = new BankData();

        public DataTable SelectAllBanks()
        {
            DataTable TableBanks = new DataTable();
            TableBanks = bankData.SelectAllBanks();
            return TableBanks;
        }
        public DataTable SearchBank(string bank)
        {
            DataTable TableBanks = new DataTable();
            TableBanks = bankData.SearchBank(bank);
            return TableBanks;
        }
        public void SelectBankById(string bank_id)
        {
            bankData.SelectBankById(Convert.ToInt64(bank_id));
        }
        public void CreateBank(string bank_name, string last_check, string number_account, string balance)
        {
            bankData.InsertBank(bank_name, Convert.ToInt32(last_check), number_account, Convert.ToDecimal(balance));
        }

        public void UpdateBank(string bank_name, string last_check, string number_account, string balance)
        {
            bankData.UpdateBank(bank_name, Convert.ToInt32(last_check), number_account, Convert.ToDecimal(balance), Common.Models.Bank.bank_id);
        }

        public void DeleteBankt(string bank_id)
        {
            bankData.DeleteBank(Convert.ToInt64(bank_id));
        }
    }
}
