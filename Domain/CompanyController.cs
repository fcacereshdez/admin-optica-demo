﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Data;

namespace Domain
{
    public class CompanyController
    {
        CompanyData companyData = new CompanyData();
        ClientAccountData clientAccountData = new ClientAccountData();

        public DataTable SelectAllCompanies()
        {
            DataTable TableCompanies = new DataTable();
            TableCompanies = companyData.SelectAllCompanies();
            return TableCompanies;
        }
        public DataTable SearchCompany(string company)
        {
            DataTable TableCompanies = new DataTable();
            TableCompanies = companyData.SearchCompany(company);
            return TableCompanies;
        }
        public void SelectCompanyById(string company_id)
        {
            companyData.SelectCompanyById(Convert.ToInt64(company_id));
        }
        public void CreateCompany(string fullname, string code, string phone, string secondary_phone, string email, string address, string nit, string iva, string attendance_fullname, string attendance_role, string created_at)
        {
            companyData.CreateCompany(fullname, code, phone, secondary_phone, email, address, nit, iva, attendance_fullname, attendance_role, Convert.ToDateTime(created_at));
        }

        public void UpdateCompany(string fullname, string phone, string secondary_phone, string email, string address, string nit, string iva, string attendance_fullname, string attendance_role, string updated_at, Int64 company_id)
        {
            companyData.UpdateCompany(fullname, phone, secondary_phone, email, address, nit, iva, attendance_fullname, attendance_role, Convert.ToDateTime(updated_at), company_id);
        }

        public void DeleteCompany(Int64 company_id)
        {
            companyData.DeleteCompany(company_id);
        }

        public void SelectLastCodeCompany()
        {
            companyData.SelectLastCodeCompany();
        }

        public void GetTotalByCompany(Int64 company_id)
        {
            clientAccountData.GetTotalByCompany(company_id);
        }

        public DataTable GetClientsByCompany(Int64 company_id)
        {
            DataTable TableClients = new DataTable();
            TableClients = clientAccountData.GetClientsByCompany(company_id);
            return TableClients;
        }
    }
}
