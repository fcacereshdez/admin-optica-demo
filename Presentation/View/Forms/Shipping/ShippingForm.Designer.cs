
namespace Presentation.View.Forms.Shipping
{
    partial class ShippingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_search_vehicles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_vehicles = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_brand = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.btn_vehicle = new System.Windows.Forms.Button();
            this.btn_model = new System.Windows.Forms.Button();
            this.btn_view_invoice = new System.Windows.Forms.Button();
            this.btn_create_shippment = new System.Windows.Forms.Button();
            this.btn_delete_invoice = new System.Windows.Forms.Button();
            this.btn_edit_invoice = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicles)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txt_search_vehicles);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(208, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(617, 55);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // txt_search_vehicles
            // 
            this.txt_search_vehicles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search_vehicles.Location = new System.Drawing.Point(61, 18);
            this.txt_search_vehicles.Name = "txt_search_vehicles";
            this.txt_search_vehicles.Size = new System.Drawing.Size(550, 23);
            this.txt_search_vehicles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_view_invoice);
            this.groupBox1.Controls.Add(this.btn_create_shippment);
            this.groupBox1.Controls.Add(this.btn_delete_invoice);
            this.groupBox1.Controls.Add(this.btn_edit_invoice);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(25, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(177, 185);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // dgv_vehicles
            // 
            this.dgv_vehicles.AllowUserToAddRows = false;
            this.dgv_vehicles.AllowUserToDeleteRows = false;
            this.dgv_vehicles.AllowUserToOrderColumns = true;
            this.dgv_vehicles.AllowUserToResizeColumns = false;
            this.dgv_vehicles.AllowUserToResizeRows = false;
            this.dgv_vehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_vehicles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.dgv_vehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_vehicles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_vehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_vehicles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_vehicles.EnableHeadersVisualStyles = false;
            this.dgv_vehicles.Location = new System.Drawing.Point(208, 80);
            this.dgv_vehicles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_vehicles.MultiSelect = false;
            this.dgv_vehicles.Name = "dgv_vehicles";
            this.dgv_vehicles.ReadOnly = true;
            this.dgv_vehicles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vehicles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_vehicles.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_vehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vehicles.Size = new System.Drawing.Size(617, 413);
            this.dgv_vehicles.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_brand);
            this.groupBox2.Controls.Add(this.btn_category);
            this.groupBox2.Controls.Add(this.btn_vehicle);
            this.groupBox2.Controls.Add(this.btn_model);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(25, 264);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(177, 185);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehículos";
            // 
            // btn_brand
            // 
            this.btn_brand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_brand.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_brand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_brand.ForeColor = System.Drawing.Color.White;
            this.btn_brand.Image = global::Presentation.Properties.Resources.icons8_smart_24;
            this.btn_brand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_brand.Location = new System.Drawing.Point(17, 32);
            this.btn_brand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_brand.Name = "btn_brand";
            this.btn_brand.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.btn_brand.Size = new System.Drawing.Size(143, 30);
            this.btn_brand.TabIndex = 4;
            this.btn_brand.Text = "Marca";
            this.btn_brand.UseVisualStyleBackColor = false;
            this.btn_brand.Click += new System.EventHandler(this.btn_brand_Click);
            // 
            // btn_category
            // 
            this.btn_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_category.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category.ForeColor = System.Drawing.Color.White;
            this.btn_category.Image = global::Presentation.Properties.Resources.icons8_category_24;
            this.btn_category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_category.Location = new System.Drawing.Point(17, 105);
            this.btn_category.Name = "btn_category";
            this.btn_category.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_category.Size = new System.Drawing.Size(143, 30);
            this.btn_category.TabIndex = 1;
            this.btn_category.Text = "Categoría";
            this.btn_category.UseVisualStyleBackColor = false;
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // btn_vehicle
            // 
            this.btn_vehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_vehicle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_vehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vehicle.ForeColor = System.Drawing.Color.White;
            this.btn_vehicle.Image = global::Presentation.Properties.Resources.icons8_vehicle_24;
            this.btn_vehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_vehicle.Location = new System.Drawing.Point(17, 141);
            this.btn_vehicle.Name = "btn_vehicle";
            this.btn_vehicle.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_vehicle.Size = new System.Drawing.Size(143, 30);
            this.btn_vehicle.TabIndex = 2;
            this.btn_vehicle.Text = "Vehículo";
            this.btn_vehicle.UseVisualStyleBackColor = false;
            this.btn_vehicle.Click += new System.EventHandler(this.btn_vehicle_Click);
            // 
            // btn_model
            // 
            this.btn_model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_model.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_model.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_model.ForeColor = System.Drawing.Color.White;
            this.btn_model.Image = global::Presentation.Properties.Resources.icons8_model_24;
            this.btn_model.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_model.Location = new System.Drawing.Point(17, 69);
            this.btn_model.Name = "btn_model";
            this.btn_model.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_model.Size = new System.Drawing.Size(143, 30);
            this.btn_model.TabIndex = 1;
            this.btn_model.Text = "Modelo";
            this.btn_model.UseVisualStyleBackColor = false;
            this.btn_model.Click += new System.EventHandler(this.btn_model_Click);
            // 
            // btn_view_invoice
            // 
            this.btn_view_invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_view_invoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_view_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_invoice.ForeColor = System.Drawing.Color.White;
            this.btn_view_invoice.Image = global::Presentation.Properties.Resources.icons8_ver_24;
            this.btn_view_invoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_view_invoice.Location = new System.Drawing.Point(17, 32);
            this.btn_view_invoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_view_invoice.Name = "btn_view_invoice";
            this.btn_view_invoice.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.btn_view_invoice.Size = new System.Drawing.Size(143, 30);
            this.btn_view_invoice.TabIndex = 4;
            this.btn_view_invoice.Text = "Ver";
            this.btn_view_invoice.UseVisualStyleBackColor = false;
            // 
            // btn_create_shippment
            // 
            this.btn_create_shippment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_shippment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_shippment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_shippment.ForeColor = System.Drawing.Color.White;
            this.btn_create_shippment.Image = global::Presentation.Properties.Resources.icons8_añadir_24;
            this.btn_create_shippment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_create_shippment.Location = new System.Drawing.Point(17, 105);
            this.btn_create_shippment.Name = "btn_create_shippment";
            this.btn_create_shippment.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_create_shippment.Size = new System.Drawing.Size(143, 30);
            this.btn_create_shippment.TabIndex = 1;
            this.btn_create_shippment.Text = "Crear";
            this.btn_create_shippment.UseVisualStyleBackColor = false;
            this.btn_create_shippment.Click += new System.EventHandler(this.btn_create_shippment_Click);
            // 
            // btn_delete_invoice
            // 
            this.btn_delete_invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_delete_invoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_delete_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_invoice.ForeColor = System.Drawing.Color.White;
            this.btn_delete_invoice.Image = global::Presentation.Properties.Resources.icons8_eliminar_241;
            this.btn_delete_invoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete_invoice.Location = new System.Drawing.Point(17, 141);
            this.btn_delete_invoice.Name = "btn_delete_invoice";
            this.btn_delete_invoice.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_delete_invoice.Size = new System.Drawing.Size(143, 30);
            this.btn_delete_invoice.TabIndex = 2;
            this.btn_delete_invoice.Text = "Eliminar";
            this.btn_delete_invoice.UseVisualStyleBackColor = false;
            // 
            // btn_edit_invoice
            // 
            this.btn_edit_invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_edit_invoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_edit_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_invoice.ForeColor = System.Drawing.Color.White;
            this.btn_edit_invoice.Image = global::Presentation.Properties.Resources.icons8_editar_24;
            this.btn_edit_invoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit_invoice.Location = new System.Drawing.Point(17, 69);
            this.btn_edit_invoice.Name = "btn_edit_invoice";
            this.btn_edit_invoice.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_edit_invoice.Size = new System.Drawing.Size(143, 30);
            this.btn_edit_invoice.TabIndex = 1;
            this.btn_edit_invoice.Text = "Editar";
            this.btn_edit_invoice.UseVisualStyleBackColor = false;
            // 
            // ShippingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_vehicles);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShippingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entregas";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehicles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_search_vehicles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_view_invoice;
        private System.Windows.Forms.Button btn_create_shippment;
        private System.Windows.Forms.Button btn_delete_invoice;
        private System.Windows.Forms.Button btn_edit_invoice;
        public System.Windows.Forms.DataGridView dgv_vehicles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_brand;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Button btn_vehicle;
        private System.Windows.Forms.Button btn_model;
    }
}