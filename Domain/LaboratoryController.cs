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
        public DataTable SelectAllLaboratories()
        {
            DataTable TableLaboratories = new DataTable();
            TableLaboratories = laboratoryData.SelectAllLaboratories();
            return TableLaboratories;
        }

        public void CreateLaboratory(string laboratory_name, string laboratory_phone, string laboratory_address)
        {
            laboratoryData.CreateLaboratory(laboratory_name, laboratory_phone, laboratory_address, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        public DataTable SearchLaboratory(string laboratory)
        {
            DataTable TableLaboratories = new DataTable();
            TableLaboratories = laboratoryData.SearchLaboratory(laboratory);
            return TableLaboratories;
        }
        
        public void SelectLaboratoryById(string laboratory_id)
        {
            laboratoryData.SelectLaboratoryById(Convert.ToInt64(laboratory_id));
        }
        public void UpdateLaboratory(string name, string phone, string address, string laboratory_id)
        {
            laboratoryData.UpdateLaboratory(name, phone, address, Convert.ToInt64(laboratory_id));
        }
        public void DeleteLaboratory(string laboratory_id)
        {
            laboratoryData.DeleteLaboratory(Convert.ToInt64(laboratory_id));
        }
    }
}
