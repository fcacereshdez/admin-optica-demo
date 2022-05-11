using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class LaboratoryController 
    {
        LaboratoryData laboratoryData = new LaboratoryData();
        public DataTable SelectAllCompanies()
        {
            DataTable TableLaboratories = new DataTable();
            TableLaboratories = laboratoryData.SelectAllLaboratories();
            return TableLaboratories;
        }

        public void CreateLaboratory(string laboratory_name, string laboratory_phone, string laboratory_address)
        {
            laboratoryData.CreateLaboratory(laboratory_name, laboratory_phone, laboratory_address, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
