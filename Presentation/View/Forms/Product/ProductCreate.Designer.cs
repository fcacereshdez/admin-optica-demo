
namespace Presentation.View.Forms.Product
{
    partial class ProductCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCreate));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_action = new System.Windows.Forms.Label();
            this.pcb_close_product = new System.Windows.Forms.PictureBox();
            this.pcb_exit = new System.Windows.Forms.PictureBox();
            this.pcb_minus = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_brand = new System.Windows.Forms.ComboBox();
            this.cb_model = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_save_product = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.txt_price_cost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_price_sale = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_code_product = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_method = new System.Windows.Forms.TextBox();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.lbl_action);
            this.pnl_top.Controls.Add(this.pcb_close_product);
            this.pnl_top.Controls.Add(this.pcb_exit);
            this.pnl_top.Controls.Add(this.pcb_minus);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(468, 29);
            this.pnl_top.TabIndex = 82;
            // 
            // lbl_action
            // 
            this.lbl_action.AutoSize = true;
            this.lbl_action.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_action.ForeColor = System.Drawing.Color.White;
            this.lbl_action.Location = new System.Drawing.Point(11, 4);
            this.lbl_action.Name = "lbl_action";
            this.lbl_action.Size = new System.Drawing.Size(100, 17);
            this.lbl_action.TabIndex = 6;
            this.lbl_action.Text = "Crear producto";
            // 
            // pcb_close_product
            // 
            this.pcb_close_product.Image = global::Presentation.Properties.Resources.close;
            this.pcb_close_product.Location = new System.Drawing.Point(428, 2);
            this.pcb_close_product.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_close_product.Name = "pcb_close_product";
            this.pcb_close_product.Size = new System.Drawing.Size(25, 25);
            this.pcb_close_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close_product.TabIndex = 4;
            this.pcb_close_product.TabStop = false;
            this.pcb_close_product.Click += new System.EventHandler(this.pcb_close_product_Click);
            // 
            // pcb_exit
            // 
            this.pcb_exit.Image = global::Presentation.Properties.Resources.close;
            this.pcb_exit.Location = new System.Drawing.Point(1389, 7);
            this.pcb_exit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pcb_exit.Name = "pcb_exit";
            this.pcb_exit.Size = new System.Drawing.Size(34, 43);
            this.pcb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_exit.TabIndex = 3;
            this.pcb_exit.TabStop = false;
            // 
            // pcb_minus
            // 
            this.pcb_minus.Image = global::Presentation.Properties.Resources.minus;
            this.pcb_minus.Location = new System.Drawing.Point(1347, 7);
            this.pcb_minus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pcb_minus.Name = "pcb_minus";
            this.pcb_minus.Size = new System.Drawing.Size(34, 43);
            this.pcb_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_minus.TabIndex = 2;
            this.pcb_minus.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 85;
            this.label2.Text = "Marca:";
            // 
            // cb_brand
            // 
            this.cb_brand.FormattingEnabled = true;
            this.cb_brand.Location = new System.Drawing.Point(75, 46);
            this.cb_brand.Name = "cb_brand";
            this.cb_brand.Size = new System.Drawing.Size(147, 23);
            this.cb_brand.TabIndex = 86;
            // 
            // cb_model
            // 
            this.cb_model.FormattingEnabled = true;
            this.cb_model.Location = new System.Drawing.Point(301, 46);
            this.cb_model.Name = "cb_model";
            this.cb_model.Size = new System.Drawing.Size(152, 23);
            this.cb_model.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 87;
            this.label3.Text = "Modelo:";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(75, 86);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(147, 23);
            this.cb_category.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 89;
            this.label4.Text = "Categoría:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 91;
            this.label5.Text = "Cantidad:";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(77, 128);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(67, 23);
            this.txt_quantity.TabIndex = 92;
            // 
            // txt_color
            // 
            this.txt_color.Location = new System.Drawing.Point(194, 128);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(78, 23);
            this.txt_color.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 93;
            this.label6.Text = "Color:";
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(72, 186);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(381, 46);
            this.txt_notes.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 95;
            this.label7.Text = "Notas:";
            // 
            // btn_save_product
            // 
            this.btn_save_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_save_product.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_save_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_product.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_product.ForeColor = System.Drawing.Color.White;
            this.btn_save_product.Image = global::Presentation.Properties.Resources.icons8_guardar_24;
            this.btn_save_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_product.Location = new System.Drawing.Point(318, 238);
            this.btn_save_product.Name = "btn_save_product";
            this.btn_save_product.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_save_product.Size = new System.Drawing.Size(135, 30);
            this.btn_save_product.TabIndex = 97;
            this.btn_save_product.Text = "Guardar";
            this.btn_save_product.UseVisualStyleBackColor = false;
            this.btn_save_product.Click += new System.EventHandler(this.btn_save_product_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(12, 253);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(10, 15);
            this.lbl_error.TabIndex = 98;
            this.lbl_error.Text = ".";
            this.lbl_error.Visible = false;
            // 
            // txt_price_cost
            // 
            this.txt_price_cost.Location = new System.Drawing.Point(376, 128);
            this.txt_price_cost.Name = "txt_price_cost";
            this.txt_price_cost.Size = new System.Drawing.Size(80, 23);
            this.txt_price_cost.TabIndex = 100;
            this.txt_price_cost.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 99;
            this.label8.Text = "Precio de costo:";
            // 
            // txt_price_sale
            // 
            this.txt_price_sale.Location = new System.Drawing.Point(376, 157);
            this.txt_price_sale.Name = "txt_price_sale";
            this.txt_price_sale.Size = new System.Drawing.Size(80, 23);
            this.txt_price_sale.TabIndex = 102;
            this.txt_price_sale.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 101;
            this.label9.Text = "Precio de venta:";
            // 
            // txt_code_product
            // 
            this.txt_code_product.Location = new System.Drawing.Point(301, 89);
            this.txt_code_product.Name = "txt_code_product";
            this.txt_code_product.Size = new System.Drawing.Size(152, 23);
            this.txt_code_product.TabIndex = 104;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 103;
            this.label10.Text = "Código:";
            // 
            // txt_method
            // 
            this.txt_method.Location = new System.Drawing.Point(245, 238);
            this.txt_method.Name = "txt_method";
            this.txt_method.Size = new System.Drawing.Size(67, 23);
            this.txt_method.TabIndex = 105;
            this.txt_method.Visible = false;
            // 
            // ProductCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 279);
            this.Controls.Add(this.txt_method);
            this.Controls.Add(this.txt_code_product);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_price_sale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_price_cost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_save_product);
            this.Controls.Add(this.txt_notes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_model);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_brand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear producto";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.PictureBox pcb_close_product;
        private System.Windows.Forms.PictureBox pcb_exit;
        private System.Windows.Forms.PictureBox pcb_minus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cb_brand;
        public System.Windows.Forms.ComboBox cb_model;
        public System.Windows.Forms.ComboBox cb_category;
        public System.Windows.Forms.TextBox txt_quantity;
        public System.Windows.Forms.TextBox txt_color;
        public System.Windows.Forms.TextBox txt_notes;
        public System.Windows.Forms.TextBox txt_price_cost;
        public System.Windows.Forms.TextBox txt_price_sale;
        public System.Windows.Forms.TextBox txt_code_product;
        public System.Windows.Forms.Label lbl_action;
        public System.Windows.Forms.Button btn_save_product;
        public System.Windows.Forms.TextBox txt_method;
    }
}