using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.View.Forms.Shipping
{
    public partial class ShippingForm : Form
    {
        public ShippingForm()
        {
            InitializeComponent();
        }

        private void btn_brand_Click(object sender, EventArgs e)
        {
            BrandsForm brandsForm = new BrandsForm();
            brandsForm.ShowDialog();
        }

        private void btn_model_Click(object sender, EventArgs e)
        {
            ModelsForm modelsForm = new ModelsForm();
            modelsForm.ShowDialog();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.ShowDialog();
        }

        private void btn_vehicle_Click(object sender, EventArgs e)
        {
            CarriersForm carriersForm = new CarriersForm();
            carriersForm.ShowDialog();
        }

        private void btn_create_shippment_Click(object sender, EventArgs e)
        {
            ShippingCreate shippingCreate = new ShippingCreate();
            shippingCreate.ShowDialog();
        }
    }
}
