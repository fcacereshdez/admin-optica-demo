
namespace Presentation.View.Forms.Product
{
    partial class ProductForm
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
            this.txt_search_company = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_brands = new System.Windows.Forms.Button();
            this.btn_create_product = new System.Windows.Forms.Button();
            this.btn_user_delete = new System.Windows.Forms.Button();
            this.btn_types = new System.Windows.Forms.Button();
            this.btn_categories = new System.Windows.Forms.Button();
            this.btn_edit_user = new System.Windows.Forms.Button();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_resume_companies = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_search_company);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(229, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(596, 55);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // txt_search_company
            // 
            this.txt_search_company.Location = new System.Drawing.Point(61, 18);
            this.txt_search_company.Name = "txt_search_company";
            this.txt_search_company.Size = new System.Drawing.Size(550, 23);
            this.txt_search_company.TabIndex = 1;
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
            this.groupBox1.Controls.Add(this.btn_brands);
            this.groupBox1.Controls.Add(this.btn_create_product);
            this.groupBox1.Controls.Add(this.btn_user_delete);
            this.groupBox1.Controls.Add(this.btn_types);
            this.groupBox1.Controls.Add(this.btn_categories);
            this.groupBox1.Controls.Add(this.btn_edit_user);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(25, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(198, 256);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btn_brands
            // 
            this.btn_brands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_brands.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_brands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_brands.ForeColor = System.Drawing.Color.White;
            this.btn_brands.Image = global::Presentation.Properties.Resources.icons8_marca_24;
            this.btn_brands.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_brands.Location = new System.Drawing.Point(15, 205);
            this.btn_brands.Name = "btn_brands";
            this.btn_brands.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_brands.Size = new System.Drawing.Size(177, 30);
            this.btn_brands.TabIndex = 3;
            this.btn_brands.Text = "Marcas";
            this.btn_brands.UseVisualStyleBackColor = false;
            this.btn_brands.Click += new System.EventHandler(this.btn_brands_Click);
            // 
            // btn_create_product
            // 
            this.btn_create_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_product.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_product.ForeColor = System.Drawing.Color.White;
            this.btn_create_product.Image = global::Presentation.Properties.Resources.icons8_añadir_24;
            this.btn_create_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_create_product.Location = new System.Drawing.Point(15, 61);
            this.btn_create_product.Name = "btn_create_product";
            this.btn_create_product.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_create_product.Size = new System.Drawing.Size(177, 30);
            this.btn_create_product.TabIndex = 1;
            this.btn_create_product.Text = "Crear";
            this.btn_create_product.UseVisualStyleBackColor = false;
            this.btn_create_product.Click += new System.EventHandler(this.btn_create_product_Click);
            // 
            // btn_user_delete
            // 
            this.btn_user_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_user_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_user_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_delete.ForeColor = System.Drawing.Color.White;
            this.btn_user_delete.Image = global::Presentation.Properties.Resources.icons8_eliminar_241;
            this.btn_user_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user_delete.Location = new System.Drawing.Point(15, 97);
            this.btn_user_delete.Name = "btn_user_delete";
            this.btn_user_delete.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_user_delete.Size = new System.Drawing.Size(177, 30);
            this.btn_user_delete.TabIndex = 2;
            this.btn_user_delete.Text = "Eliminar";
            this.btn_user_delete.UseVisualStyleBackColor = false;
            // 
            // btn_types
            // 
            this.btn_types.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_types.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_types.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_types.ForeColor = System.Drawing.Color.White;
            this.btn_types.Image = global::Presentation.Properties.Resources.icons8_basculas_en_3d_24;
            this.btn_types.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_types.Location = new System.Drawing.Point(15, 169);
            this.btn_types.Name = "btn_types";
            this.btn_types.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_types.Size = new System.Drawing.Size(177, 30);
            this.btn_types.TabIndex = 4;
            this.btn_types.Text = "Modelos";
            this.btn_types.UseVisualStyleBackColor = false;
            this.btn_types.Click += new System.EventHandler(this.btn_types_Click);
            // 
            // btn_categories
            // 
            this.btn_categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_categories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_categories.ForeColor = System.Drawing.Color.White;
            this.btn_categories.Image = global::Presentation.Properties.Resources.icons8_categories_25;
            this.btn_categories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categories.Location = new System.Drawing.Point(15, 133);
            this.btn_categories.Name = "btn_categories";
            this.btn_categories.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_categories.Size = new System.Drawing.Size(177, 30);
            this.btn_categories.TabIndex = 1;
            this.btn_categories.Text = "Categorías";
            this.btn_categories.UseVisualStyleBackColor = false;
            this.btn_categories.Click += new System.EventHandler(this.btn_categories_Click);
            // 
            // btn_edit_user
            // 
            this.btn_edit_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_edit_user.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_edit_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_user.ForeColor = System.Drawing.Color.White;
            this.btn_edit_user.Image = global::Presentation.Properties.Resources.icons8_editar_24;
            this.btn_edit_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit_user.Location = new System.Drawing.Point(15, 25);
            this.btn_edit_user.Name = "btn_edit_user";
            this.btn_edit_user.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_edit_user.Size = new System.Drawing.Size(177, 30);
            this.btn_edit_user.TabIndex = 1;
            this.btn_edit_user.Text = "Editar";
            this.btn_edit_user.UseVisualStyleBackColor = false;
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            this.dgv_products.AllowUserToOrderColumns = true;
            this.dgv_products.AllowUserToResizeColumns = false;
            this.dgv_products.AllowUserToResizeRows = false;
            this.dgv_products.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.dgv_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_products.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_products.EnableHeadersVisualStyles = false;
            this.dgv_products.Location = new System.Drawing.Point(229, 86);
            this.dgv_products.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_products.MultiSelect = false;
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.ReadOnly = true;
            this.dgv_products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_products.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_products.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_products.Size = new System.Drawing.Size(596, 413);
            this.dgv_products.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_resume_companies);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(25, 341);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(198, 77);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comunes";
            // 
            // btn_resume_companies
            // 
            this.btn_resume_companies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_resume_companies.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_resume_companies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resume_companies.ForeColor = System.Drawing.Color.White;
            this.btn_resume_companies.Image = global::Presentation.Properties.Resources.icons8_script_de_informes_de_gráficos_241;
            this.btn_resume_companies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_resume_companies.Location = new System.Drawing.Point(15, 34);
            this.btn_resume_companies.Name = "btn_resume_companies";
            this.btn_resume_companies.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_resume_companies.Size = new System.Drawing.Size(177, 30);
            this.btn_resume_companies.TabIndex = 6;
            this.btn_resume_companies.Text = "Informe";
            this.btn_resume_companies.UseVisualStyleBackColor = false;
            this.btn_resume_companies.Click += new System.EventHandler(this.btn_report_products_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_products);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventario";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_search_company;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_brands;
        private System.Windows.Forms.Button btn_types;
        private System.Windows.Forms.Button btn_categories;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_create_product;
        private System.Windows.Forms.Button btn_user_delete;
        private System.Windows.Forms.Button btn_edit_user;
        public System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btn_resume_companies;
    }
}