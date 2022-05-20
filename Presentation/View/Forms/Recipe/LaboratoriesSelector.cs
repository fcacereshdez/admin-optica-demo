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
    }
}
