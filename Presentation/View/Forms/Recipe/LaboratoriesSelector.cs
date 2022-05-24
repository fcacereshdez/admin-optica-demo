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

namespace Presentation.View.Forms.Recipe
{
    public partial class LaboratoriesSelector : Form
    {
        LaboratoryController laboratoryController = new LaboratoryController();
        public LaboratoriesSelector()
        {
            InitializeComponent();
            LoadData();
            
        }

        private void LoadData()
        {
            dgv_laboratories.DataSource = laboratoryController.SelectAllLaboratories();
        }

        private void dgv_laboratories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RecipeCreate recipeCreate = ((RecipeCreate)(Owner));
            recipeCreate.txt_laboratory_name.Text = dgv_laboratories.SelectedRows[0].Cells[1].Value.ToString();
            recipeCreate.txt_laboratory_id.Text = dgv_laboratories.SelectedRows[0].Cells[0].Value.ToString();
            Close();
        }

        private void pcb_close_create_client_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_search_laboratories_TextChanged(object sender, EventArgs e)
        {
            dgv_laboratories.DataSource = laboratoryController.SearchLaboratory(txt_search_laboratories.Text);
            dgv_laboratories.Columns[0].Width = 25;
            dgv_laboratories.Columns[1].Width = 170;
        }
    }
}
