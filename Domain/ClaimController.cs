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
        public DataTable SearchClaim(string client)
        {
            DataTable TableClaims = new DataTable();
            TableClaims = claimData.SearchClaims(client);
            return TableClaims;
        }
        public DataTable SelectAllTypeClaims()
        {
            DataTable TableTypeClaims = new DataTable();
            TableTypeClaims = claimData.SelectAllTypeClaims();
            return TableTypeClaims;
        }
        public DataTable SelectAllMotiveClaims()
        {
            DataTable TableMotiveClaims = new DataTable();
            TableMotiveClaims = claimData.SelectAllMotiveClaims();
            return TableMotiveClaims;
        }


        public void InsertClaim(string claim_type, string claim_motive, string client_id, string claim_details, string claim_date)
        {
            claimData.InsertClaim(Convert.ToInt64(claim_type), Convert.ToInt64(claim_motive), Convert.ToInt64(client_id), claim_details, Convert.ToDateTime(claim_date));
        }

        public void SelectClaimById(string claim_id)
        {
            claimData.SelectClaimById(Convert.ToInt64(claim_id));
        }

        public void UpdateClaim(string claim_type, string claim_motive, string client_id, string claim_details, string claim_date)
        {
            claimData.UpdateClaim(Convert.ToInt64(claim_type), Convert.ToInt64(claim_motive), Convert.ToInt64(client_id), claim_details, Convert.ToDateTime(claim_date));
        }

        public void DeleteClaim(string claim_id)
        {
            claimData.DeleteClaim(Convert.ToInt64(claim_id));
        }
    }
}
