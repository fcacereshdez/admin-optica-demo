
namespace Presentation.View.Forms.Claim
{
    partial class ClaimCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClaimCreate));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pcb_close_create_claim = new System.Windows.Forms.PictureBox();
            this.pcb_exit = new System.Windows.Forms.PictureBox();
            this.pcb_minus = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_product = new System.Windows.Forms.RadioButton();
            this.rb_recipe = new System.Windows.Forms.RadioButton();
            this.rb_client = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_type_claims = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_search_element = new System.Windows.Forms.Button();
            this.txt_element = new System.Windows.Forms.TextBox();
            this.btn_save_claim = new System.Windows.Forms.Button();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_create_claim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.label10);
            this.pnl_top.Controls.Add(this.pcb_close_create_claim);
            this.pnl_top.Controls.Add(this.pcb_exit);
            this.pnl_top.Controls.Add(this.pcb_minus);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(596, 29);
            this.pnl_top.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(11, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Creador de reclamos";
            // 
            // pcb_close_create_claim
            // 
            this.pcb_close_create_claim.Image = global::Presentation.Properties.Resources.close;
            this.pcb_close_create_claim.Location = new System.Drawing.Point(557, 3);
            this.pcb_close_create_claim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_close_create_claim.Name = "pcb_close_create_claim";
            this.pcb_close_create_claim.Size = new System.Drawing.Size(25, 25);
            this.pcb_close_create_claim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close_create_claim.TabIndex = 4;
            this.pcb_close_create_claim.TabStop = false;
            this.pcb_close_create_claim.Click += new System.EventHandler(this.pcb_close_create_claim_Click);
            // 
            // pcb_exit
            // 
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
            this.pcb_minus.Location = new System.Drawing.Point(1347, 7);
            this.pcb_minus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pcb_minus.Name = "pcb_minus";
            this.pcb_minus.Size = new System.Drawing.Size(34, 43);
            this.pcb_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_minus.TabIndex = 2;
            this.pcb_minus.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_product);
            this.groupBox1.Controls.Add(this.rb_recipe);
            this.groupBox1.Controls.Add(this.rb_client);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_type_claims);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 92);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del reclamo";
            // 
            // rb_product
            // 
            this.rb_product.AutoSize = true;
            this.rb_product.Location = new System.Drawing.Point(482, 51);
            this.rb_product.Name = "rb_product";
            this.rb_product.Size = new System.Drawing.Size(74, 19);
            this.rb_product.TabIndex = 5;
            this.rb_product.TabStop = true;
            this.rb_product.Text = "Producto";
            this.rb_product.UseVisualStyleBackColor = true;
            // 
            // rb_recipe
            // 
            this.rb_recipe.AutoSize = true;
            this.rb_recipe.Location = new System.Drawing.Point(416, 51);
            this.rb_recipe.Name = "rb_recipe";
            this.rb_recipe.Size = new System.Drawing.Size(60, 19);
            this.rb_recipe.TabIndex = 4;
            this.rb_recipe.TabStop = true;
            this.rb_recipe.Text = "Receta";
            this.rb_recipe.UseVisualStyleBackColor = true;
            // 
            // rb_client
            // 
            this.rb_client.AutoSize = true;
            this.rb_client.Location = new System.Drawing.Point(349, 51);
            this.rb_client.Name = "rb_client";
            this.rb_client.Size = new System.Drawing.Size(61, 19);
            this.rb_client.TabIndex = 3;
            this.rb_client.TabStop = true;
            this.rb_client.Text = "Cliente";
            this.rb_client.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Motivo de reclamo";
            // 
            // cb_type_claims
            // 
            this.cb_type_claims.FormattingEnabled = true;
            this.cb_type_claims.Location = new System.Drawing.Point(9, 50);
            this.cb_type_claims.Name = "cb_type_claims";
            this.cb_type_claims.Size = new System.Drawing.Size(322, 23);
            this.cb_type_claims.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de reclamo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 131);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del reclamo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(555, 73);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción del reclamo";
            // 
            // btn_search_element
            // 
            this.btn_search_element.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(142)))), ((int)(((byte)(4)))));
            this.btn_search_element.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(142)))), ((int)(((byte)(4)))));
            this.btn_search_element.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_element.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_element.Location = new System.Drawing.Point(12, 281);
            this.btn_search_element.Name = "btn_search_element";
            this.btn_search_element.Size = new System.Drawing.Size(65, 27);
            this.btn_search_element.TabIndex = 23;
            this.btn_search_element.Text = "Buscar";
            this.btn_search_element.UseVisualStyleBackColor = false;
            // 
            // txt_element
            // 
            this.txt_element.Location = new System.Drawing.Point(83, 285);
            this.txt_element.Name = "txt_element";
            this.txt_element.Size = new System.Drawing.Size(61, 23);
            this.txt_element.TabIndex = 27;
            this.txt_element.Visible = false;
            // 
            // btn_save_claim
            // 
            this.btn_save_claim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_save_claim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_save_claim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_claim.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_claim.ForeColor = System.Drawing.Color.White;
            this.btn_save_claim.Image = global::Presentation.Properties.Resources.icons8_guardar_24;
            this.btn_save_claim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_claim.Location = new System.Drawing.Point(447, 278);
            this.btn_save_claim.Name = "btn_save_claim";
            this.btn_save_claim.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_save_claim.Size = new System.Drawing.Size(135, 30);
            this.btn_save_claim.TabIndex = 29;
            this.btn_save_claim.Text = "Guardar";
            this.btn_save_claim.UseVisualStyleBackColor = false;
            // 
            // ClaimCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 324);
            this.Controls.Add(this.btn_save_claim);
            this.Controls.Add(this.txt_element);
            this.Controls.Add(this.btn_search_element);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClaimCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Reclamo";
            this.Load += new System.EventHandler(this.ClaimCreate_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_create_claim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pcb_close_create_claim;
        private System.Windows.Forms.PictureBox pcb_exit;
        private System.Windows.Forms.PictureBox pcb_minus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_product;
        private System.Windows.Forms.RadioButton rb_recipe;
        private System.Windows.Forms.RadioButton rb_client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_type_claims;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_search_element;
        private System.Windows.Forms.TextBox txt_element;
        private System.Windows.Forms.Button btn_save_claim;
        private System.Windows.Forms.TextBox textBox1;
    }
}