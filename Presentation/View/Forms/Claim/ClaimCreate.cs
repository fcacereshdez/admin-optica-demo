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
    public partial class ClaimCreate : Form
    {
        ClaimController claimController = new ClaimController();
        public ClaimCreate()
        {
            InitializeComponent();
        }

        private void LoadTypeClaims()
        {
            cb_type_claims.DataSource = claimController.SelectAllTypeClaims();
            cb_type_claims.DisplayMember = "TIPO";
            cb_type_claims.ValueMember = "ID";
        }

        private void ClaimCreate_Load(object sender, EventArgs e)
        {
            LoadTypeClaims();
        }

        private void pcb_close_create_claim_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
