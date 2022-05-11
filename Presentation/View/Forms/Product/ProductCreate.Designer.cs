
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
            this.label15 = new System.Windows.Forms.Label();
            this.pcb_close_product = new System.Windows.Forms.PictureBox();
            this.pcb_exit = new System.Windows.Forms.PictureBox();
            this.pcb_minus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
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
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.label15);
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(11, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "Crear producto";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 83;
            this.label1.Text = "Producto:";
            // 
            // txt_product
            // 
            this.txt_product.Location = new System.Drawing.Point(77, 45);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(195, 23);
            this.txt_product.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 85;
            this.label2.Text = "Marca:";
            // 
            // cb_brand
            // 
            this.cb_brand.FormattingEnabled = true;
            this.cb_brand.Location = new System.Drawing.Point(336, 45);
            this.cb_brand.Name = "cb_brand";
            this.cb_brand.Size = new System.Drawing.Size(121, 23);
            this.cb_brand.TabIndex = 86;
            // 
            // cb_model
            // 
            this.cb_model.FormattingEnabled = true;
            this.cb_model.Location = new System.Drawing.Point(77, 86);
            this.cb_model.Name = "cb_model";
            this.cb_model.Size = new System.Drawing.Size(121, 23);
            this.cb_model.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 87;
            this.label3.Text = "Modelo:";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(278, 86);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(179, 23);
            this.cb_category.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 89);
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
            this.txt_quantity.Size = new System.Drawing.Size(54, 23);
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
            this.txt_notes.Location = new System.Drawing.Point(331, 131);
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(122, 23);
            this.txt_notes.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 134);
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
            this.btn_save_product.Location = new System.Drawing.Point(318, 181);
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
            this.lbl_error.Location = new System.Drawing.Point(14, 190);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(10, 15);
            this.lbl_error.TabIndex = 98;
            this.lbl_error.Text = ".";
            this.lbl_error.Visible = false;
            // 
            // ProductCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 233);
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
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear producto";
//            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductCreate_FormClosed);
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pcb_close_product;
        private System.Windows.Forms.PictureBox pcb_exit;
        private System.Windows.Forms.PictureBox pcb_minus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_brand;
        private System.Windows.Forms.ComboBox cb_model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_save_product;
        private System.Windows.Forms.Label lbl_error;
    }
}