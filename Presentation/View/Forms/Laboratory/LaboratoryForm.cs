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

namespace Presentation.View.Forms.Laboratory
{
    public partial class LaboratoryForm : Form
    {
        LaboratoryController laboratoryController = new LaboratoryController();
        public LaboratoryForm()
        {
            InitializeComponent();
            SelectAllLaboratories();
        }

        private void SelectAllLaboratories()
        {
          dgv_laboratories.DataSource = laboratoryController.SelectAllCompanies();
        }

        private void btn_create_user_Click(object sender, EventArgs e)
        {
            LaboratoryCreate laboratoryCreate = new LaboratoryCreate();
            laboratoryCreate.ShowDialog();
        }
    }
}
