using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ClaimController
    {
        ClaimData claimData = new ClaimData();
        public DataTable SelectAllClaims()
        {
            DataTable TableClaims = new DataTable();
            TableClaims = claimData.SelectAllClaims();
            return TableClaims;
        }
        public DataTable SelectAllTypeClaims()
        {
            DataTable TableTypeClaims = new DataTable();
            TableTypeClaims = claimData.SelectAllTypeClaims();
            return TableTypeClaims;
        }
    }
}
