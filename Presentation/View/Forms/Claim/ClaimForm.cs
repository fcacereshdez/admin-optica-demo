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
            dgv_claims.Columns[0].Visible = false;
            dgv_claims.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void btn_edit_claim_Click(object sender, EventArgs e)
        {
            try
            {
                claimController.SelectClaimById(dgv_claims.SelectedRows[0].Cells[0].Value.ToString());
                ClaimEdit claimEdit = new ClaimEdit();
                claimEdit.ShowDialog();
            }
            catch (Exception clErr)
            {
                MessageBox.Show("Ocurrió un error mientras intentabamos ejectuar esto.\n\nError: " + clErr.Message, "Reclamos");
            }
        }

        private void btn_view_claim_Click(object sender, EventArgs e)
        {
            try
            {
                claimController.SelectClaimById(dgv_claims.SelectedRows[0].Cells[0].Value.ToString());
                ClaimView claimView = new ClaimView();
                claimView.ShowDialog();
            }
            catch (Exception clErr)
            {
                MessageBox.Show("Ocurrió un error mientras intentabamos ejectuar esto.\n\nError: " + clErr.Message, "Reclamos");
            }
        }

        private void btn_delete_claim_Click(object sender, EventArgs e)
        {
            DialogResult msgDelete = MessageBox.Show("¿Desea eliminar este registro?", "Clientes", MessageBoxButtons.OKCancel);

            if (msgDelete == DialogResult.OK)
            {
                try
                {
                    claimController.DeleteClaim(dgv_claims.SelectedRows[0].Cells[0].Value.ToString());
                    SelectAllClaims();
                    MessageBox.Show("Reclamo eliminado.", "Reclamos", MessageBoxButtons.OK);
                }
                catch (Exception clErr)
                {

                    MessageBox.Show("Ocurrión un error al eliminarlo. \n\nError: " + clErr.Message, "Reclamos");
                }
            }
        }

        private void txt_search_claim_TextChanged(object sender, EventArgs e)
        {
            try
            {
              dgv_claims.DataSource = claimController.SearchClaim(txt_search_claim.Text);
            }
            catch (Exception clErr)
            {

                MessageBox.Show("Ocurrió un error mientras intentabamos ejectuar esto.\n\nError: " + clErr.Message, "Reclamos");
            }
        }
    }
}
