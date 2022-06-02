using Domain;
using Presentation.View.Forms.Claim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.View.Forms.Client
{
    public partial class ClaimForm : Form
    {
        ClaimController claimController = new ClaimController();
        public ClaimForm()
        {
            InitializeComponent();
        }

        private void SelectAllClaims()
        {
            dgv_claims.DataSource = claimController.SelectAllClaims();
        }

        private void ClaimForm_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            SelectAllClaims();
        }

        private void btn_create_claim_Click(object sender, EventArgs e)
        {
            ClaimCreate claimCreate = new ClaimCreate();
            claimCreate.ShowDialog();
        }
    }
}
