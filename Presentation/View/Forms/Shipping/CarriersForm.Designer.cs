
namespace Presentation.View.Forms.Shipping
{
    partial class CarriersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarriersForm));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.pcb_close_brands = new System.Windows.Forms.PictureBox();
            this.pcb_exit = new System.Windows.Forms.PictureBox();
            this.pcb_minus = new System.Windows.Forms.PictureBox();
            this.txt_carrier_fullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save_carrier = new System.Windows.Forms.Button();
            this.dgv_carriers = new System.Windows.Forms.DataGridView();
            this.txt_carrier_id = new System.Windows.Forms.TextBox();
            this.txt_action = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cb_brands = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_models = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_categories = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_identification = new System.Windows.Forms.TextBox();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_brands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carriers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.label15);
            this.pnl_top.Controls.Add(this.pcb_close_brands);
            this.pnl_top.Controls.Add(this.pcb_exit);
            this.pnl_top.Controls.Add(this.pcb_minus);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(694, 29);
            this.pnl_top.TabIndex = 81;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(11, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "Vehículos";
            // 
            // pcb_close_brands
            // 
            this.pcb_close_brands.Image = global::Presentation.Properties.Resources.close;
            this.pcb_close_brands.Location = new System.Drawing.Point(657, 4);
            this.pcb_close_brands.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_close_brands.Name = "pcb_close_brands";
            this.pcb_close_brands.Size = new System.Drawing.Size(25, 25);
            this.pcb_close_brands.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close_brands.TabIndex = 4;
            this.pcb_close_brands.TabStop = false;
            this.pcb_close_brands.Click += new System.EventHandler(this.pcb_close_brands_Click);
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
            // txt_carrier_fullname
            // 
            this.txt_carrier_fullname.Location = new System.Drawing.Point(17, 156);
            this.txt_carrier_fullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_carrier_fullname.Name = "txt_carrier_fullname";
            this.txt_carrier_fullname.Size = new System.Drawing.Size(276, 23);
            this.txt_carrier_fullname.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 82;
            this.label3.Text = "Nombre del conductor:";
            // 
            // btn_save_carrier
            // 
            this.btn_save_carrier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_save_carrier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_save_carrier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_carrier.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_carrier.ForeColor = System.Drawing.Color.White;
            this.btn_save_carrier.Image = global::Presentation.Properties.Resources.icons8_guardar_24;
            this.btn_save_carrier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_carrier.Location = new System.Drawing.Point(158, 196);
            this.btn_save_carrier.Name = "btn_save_carrier";
            this.btn_save_carrier.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_save_carrier.Size = new System.Drawing.Size(135, 30);
            this.btn_save_carrier.TabIndex = 84;
            this.btn_save_carrier.Text = "Guardar";
            this.btn_save_carrier.UseVisualStyleBackColor = false;
            this.btn_save_carrier.Click += new System.EventHandler(this.btn_save_carrier_Click);
            // 
            // dgv_carriers
            // 
            this.dgv_carriers.AllowUserToAddRows = false;
            this.dgv_carriers.AllowUserToDeleteRows = false;
            this.dgv_carriers.AllowUserToOrderColumns = true;
            this.dgv_carriers.AllowUserToResizeColumns = false;
            this.dgv_carriers.AllowUserToResizeRows = false;
            this.dgv_carriers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.dgv_carriers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_carriers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_carriers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_carriers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_carriers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_carriers.EnableHeadersVisualStyles = false;
            this.dgv_carriers.Location = new System.Drawing.Point(326, 38);
            this.dgv_carriers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_carriers.MultiSelect = false;
            this.dgv_carriers.Name = "dgv_carriers";
            this.dgv_carriers.ReadOnly = true;
            this.dgv_carriers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_carriers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_carriers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_carriers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_carriers.Size = new System.Drawing.Size(356, 141);
            this.dgv_carriers.TabIndex = 85;
            this.dgv_carriers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_carriers_CellDoubleClick);
            // 
            // txt_carrier_id
            // 
            this.txt_carrier_id.Location = new System.Drawing.Point(639, 223);
            this.txt_carrier_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_carrier_id.Name = "txt_carrier_id";
            this.txt_carrier_id.Size = new System.Drawing.Size(43, 23);
            this.txt_carrier_id.TabIndex = 86;
            this.txt_carrier_id.Visible = false;
            // 
            // txt_action
            // 
            this.txt_action.Location = new System.Drawing.Point(547, 223);
            this.txt_action.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_action.Name = "txt_action";
            this.txt_action.Size = new System.Drawing.Size(86, 23);
            this.txt_action.TabIndex = 87;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = global::Presentation.Properties.Resources.icons8_eliminar_24;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(547, 186);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_delete.Size = new System.Drawing.Size(135, 30);
            this.btn_delete.TabIndex = 88;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cb_brands
            // 
            this.cb_brands.FormattingEnabled = true;
            this.cb_brands.Location = new System.Drawing.Point(17, 62);
            this.cb_brands.Name = "cb_brands";
            this.cb_brands.Size = new System.Drawing.Size(135, 23);
            this.cb_brands.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 90;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 92;
            this.label2.Text = "Modelo:";
            // 
            // cb_models
            // 
            this.cb_models.FormattingEnabled = true;
            this.cb_models.Location = new System.Drawing.Point(158, 62);
            this.cb_models.Name = "cb_models";
            this.cb_models.Size = new System.Drawing.Size(135, 23);
            this.cb_models.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 94;
            this.label4.Text = "Tipo:";
            // 
            // cb_categories
            // 
            this.cb_categories.FormattingEnabled = true;
            this.cb_categories.Location = new System.Drawing.Point(17, 106);
            this.cb_categories.Name = "cb_categories";
            this.cb_categories.Size = new System.Drawing.Size(135, 23);
            this.cb_categories.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 95;
            this.label5.Text = "Placa:";
            // 
            // txt_identification
            // 
            this.txt_identification.Location = new System.Drawing.Point(158, 106);
            this.txt_identification.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_identification.Name = "txt_identification";
            this.txt_identification.Size = new System.Drawing.Size(135, 23);
            this.txt_identification.TabIndex = 96;
            // 
            // CarriersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 251);
            this.Controls.Add(this.txt_identification);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_categories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_models);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_brands);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_action);
            this.Controls.Add(this.txt_carrier_id);
            this.Controls.Add(this.dgv_carriers);
            this.Controls.Add(this.btn_save_carrier);
            this.Controls.Add(this.txt_carrier_fullname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarriersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.CarriersForm_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_brands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carriers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pcb_close_brands;
        private System.Windows.Forms.PictureBox pcb_exit;
        private System.Windows.Forms.PictureBox pcb_minus;
        public System.Windows.Forms.TextBox txt_carrier_fullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save_carrier;
        public System.Windows.Forms.DataGridView dgv_carriers;
        public System.Windows.Forms.TextBox txt_carrier_id;
        public System.Windows.Forms.TextBox txt_action;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cb_brands;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_models;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_categories;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_identification;
    }
}