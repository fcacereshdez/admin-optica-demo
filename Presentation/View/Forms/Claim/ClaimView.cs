using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.View.Forms.Claim
{
    public partial class ClaimView : Form
    {
        ClaimController claimController = new ClaimController();
        public ClaimView()
        {
            InitializeComponent();
        }

        private void LoadDataForClaims()
        {
            cb_type_claims.DataSource = claimController.SelectAllTypeClaims();
            cb_type_claims.DisplayMember = "TIPO";
            cb_type_claims.ValueMember = "ID";

            cb_motive_claims.DataSource = claimController.SelectAllMotiveClaims();
            cb_motive_claims.DisplayMember = "claim_motive";
            cb_motive_claims.ValueMember = "claim_motive_id";
        }

        private void ClaimCreate_Load(object sender, EventArgs e)
        {
            LoadDataForClaims();
            LoadViewer();
        }

        private void pcb_close_create_claim_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadViewer()
        {
            dtp_claim_created.Value = Common.Models.Claim.claim_date;
            cb_type_claims.SelectedValue = Common.Models.Claim.claim_type_id;
            cb_motive_claims.SelectedValue = Common.Models.Claim.claim_motive_id;
            lbl_client.Text = Common.Models.Claim.client_name;
            lbl_company.Text = Common.Models.Claim.company_name;
            txt_client_id.Text = Common.Models.Claim.client_id.ToString();
            txt_details.Text = Common.Models.Claim.claim_description;
        }
    }
}
