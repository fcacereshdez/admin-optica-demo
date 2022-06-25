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
    public partial class ClaimEdit : Form
    {
        ClaimController claimController = new ClaimController();
        public ClaimEdit() { 
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

        private void btn_search_element_Click(object sender, EventArgs e)
        {
            ClientSelector clientSelector = new ClientSelector();
            AddOwnedForm(clientSelector);
            clientSelector.ShowDialog();
        }

        private void btn_save_claim_Click(object sender, EventArgs e)
        {
            if (txt_client_id.Text == "")
            {
                lbl_error.Text = "Debes seleccionar un cliente.";
                lbl_error.Visible = true;
            }
            else
            {
                try
                {
                    claimController.UpdateClaim(cb_type_claims.SelectedValue.ToString(), cb_motive_claims.SelectedValue.ToString(), txt_client_id.Text, txt_claim_details.Text, dtp_claim_created.Value.ToString("yyyy-MM-dd"));
                    MessageBox.Show("Reclamo actualizado con éxito.", "Reclamos");
                    Close();
                }
                catch (Exception clErr)
                {
                    MessageBox.Show("Ocurrió un error al intentar procesar esto.\n\nError: " + clErr.Message, "Reclamos");
                }
            }
        }


        private void LoadViewer()
        {
            dtp_claim_created.Value = Common.Models.Claim.claim_date;
            cb_type_claims.SelectedValue = Common.Models.Claim.claim_type_id;
            cb_motive_claims.SelectedValue = Common.Models.Claim.claim_motive_id;
            lbl_client.Text = Common.Models.Claim.client_name;
            lbl_company.Text = Common.Models.Claim.company_name;
            txt_client_id.Text = Common.Models.Claim.client_id.ToString();
            txt_claim_details.Text = Common.Models.Claim.claim_description;
        }
    }
}
