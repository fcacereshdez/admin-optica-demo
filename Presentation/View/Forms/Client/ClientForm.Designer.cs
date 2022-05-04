
namespace Presentation.View.Forms.Client
{
    partial class ClientForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_search_company = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_clients = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_view_client = new System.Windows.Forms.Button();
            this.btn_export_clients = new System.Windows.Forms.Button();
            this.btn_create_client = new System.Windows.Forms.Button();
            this.btn_delete_client = new System.Windows.Forms.Button();
            this.btn_edit_client = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_search_company);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(201, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(617, 55);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // txt_search_company
            // 
            this.txt_search_company.Location = new System.Drawing.Point(71, 19);
            this.txt_search_company.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search_company.Name = "txt_search_company";
            this.txt_search_company.Size = new System.Drawing.Size(540, 25);
            this.txt_search_company.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // dgv_clients
            // 
            this.dgv_clients.AllowUserToAddRows = false;
            this.dgv_clients.AllowUserToDeleteRows = false;
            this.dgv_clients.AllowUserToOrderColumns = true;
            this.dgv_clients.AllowUserToResizeColumns = false;
            this.dgv_clients.AllowUserToResizeRows = false;
            this.dgv_clients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.dgv_clients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_clients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_clients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_clients.EnableHeadersVisualStyles = false;
            this.dgv_clients.Location = new System.Drawing.Point(201, 95);
            this.dgv_clients.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgv_clients.MultiSelect = false;
            this.dgv_clients.Name = "dgv_clients";
            this.dgv_clients.ReadOnly = true;
            this.dgv_clients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_clients.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clients.Size = new System.Drawing.Size(617, 345);
            this.dgv_clients.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_view_client);
            this.groupBox1.Controls.Add(this.btn_export_clients);
            this.groupBox1.Controls.Add(this.btn_create_client);
            this.groupBox1.Controls.Add(this.btn_delete_client);
            this.groupBox1.Controls.Add(this.btn_edit_client);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(18, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(177, 228);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // btn_view_client
            // 
            this.btn_view_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_view_client.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_view_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_client.ForeColor = System.Drawing.Color.White;
            this.btn_view_client.Image = global::Presentation.Properties.Resources.icons8_ver_24;
            this.btn_view_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_view_client.Location = new System.Drawing.Point(18, 30);
            this.btn_view_client.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_view_client.Name = "btn_view_client";
            this.btn_view_client.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.btn_view_client.Size = new System.Drawing.Size(143, 30);
            this.btn_view_client.TabIndex = 5;
            this.btn_view_client.Text = "Ver";
            this.btn_view_client.UseVisualStyleBackColor = false;
            // 
            // btn_export_clients
            // 
            this.btn_export_clients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_export_clients.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_export_clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export_clients.ForeColor = System.Drawing.Color.White;
            this.btn_export_clients.Image = global::Presentation.Properties.Resources.icons8_exportación_de_base_de_datos_24;
            this.btn_export_clients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export_clients.Location = new System.Drawing.Point(18, 182);
            this.btn_export_clients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_export_clients.Name = "btn_export_clients";
            this.btn_export_clients.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.btn_export_clients.Size = new System.Drawing.Size(143, 30);
            this.btn_export_clients.TabIndex = 4;
            this.btn_export_clients.Text = "Exportar";
            this.btn_export_clients.UseVisualStyleBackColor = false;
            // 
            // btn_create_client
            // 
            this.btn_create_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_client.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_client.ForeColor = System.Drawing.Color.White;
            this.btn_create_client.Image = global::Presentation.Properties.Resources.icons8_añadir_24;
            this.btn_create_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_create_client.Location = new System.Drawing.Point(18, 106);
            this.btn_create_client.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_create_client.Name = "btn_create_client";
            this.btn_create_client.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.btn_create_client.Size = new System.Drawing.Size(143, 30);
            this.btn_create_client.TabIndex = 1;
            this.btn_create_client.Text = "Crear";
            this.btn_create_client.UseVisualStyleBackColor = false;
            this.btn_create_client.Click += new System.EventHandler(this.btn_create_client_Click);
            // 
            // btn_delete_client
            // 
            this.btn_delete_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_delete_client.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_delete_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_client.ForeColor = System.Drawing.Color.White;
            this.btn_delete_client.Image = global::Presentation.Properties.Resources.icons8_eliminar_241;
            this.btn_delete_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete_client.Location = new System.Drawing.Point(18, 144);
            this.btn_delete_client.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete_client.Name = "btn_delete_client";
            this.btn_delete_client.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.btn_delete_client.Size = new System.Drawing.Size(143, 30);
            this.btn_delete_client.TabIndex = 2;
            this.btn_delete_client.Text = "Eliminar";
            this.btn_delete_client.UseVisualStyleBackColor = false;
            // 
            // btn_edit_client
            // 
            this.btn_edit_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_edit_client.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_edit_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_client.ForeColor = System.Drawing.Color.White;
            this.btn_edit_client.Image = global::Presentation.Properties.Resources.icons8_editar_24;
            this.btn_edit_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit_client.Location = new System.Drawing.Point(18, 68);
            this.btn_edit_client.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_edit_client.Name = "btn_edit_client";
            this.btn_edit_client.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.btn_edit_client.Size = new System.Drawing.Size(143, 30);
            this.btn_edit_client.TabIndex = 1;
            this.btn_edit_client.Text = "Editar";
            this.btn_edit_client.UseVisualStyleBackColor = false;
            this.btn_edit_client.Click += new System.EventHandler(this.btn_edit_client_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(18, 324);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox3.Size = new System.Drawing.Size(177, 116);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comunes";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Presentation.Properties.Resources.icons8_exportación_de_base_de_datos_24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(18, 65);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.button2.Size = new System.Drawing.Size(143, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reportes";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Presentation.Properties.Resources.icons8_eliminar_241;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(18, 27);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.button4.Size = new System.Drawing.Size(143, 30);
            this.button4.TabIndex = 2;
            this.button4.Text = "Abonos";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_clients);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_search_company;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_clients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_view_client;
        private System.Windows.Forms.Button btn_export_clients;
        private System.Windows.Forms.Button btn_create_client;
        private System.Windows.Forms.Button btn_delete_client;
        private System.Windows.Forms.Button btn_edit_client;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}