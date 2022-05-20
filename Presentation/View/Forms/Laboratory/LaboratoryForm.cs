using Common.Cache;
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
            InsertAction("está en el gestor de laboratorios.");
        }

        private void SelectAllLaboratories()
        {
          dgv_laboratories.DataSource = laboratoryController.SelectAllLaboratories();
        }

        private void btn_create_user_Click(object sender, EventArgs e)
        {
            LaboratoryCreate laboratoryCreate = new LaboratoryCreate();
            laboratoryCreate.ShowDialog();
        }

        private void InsertAction(string action)
        {
            UserController userController = new UserController();
            userController.InsertActionsUser(UserCache.name + " " + UserCache.lastname + " " + action, Environment.MachineName, "127.0.0.1", UserCache.user_id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
