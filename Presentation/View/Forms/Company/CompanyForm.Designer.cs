﻿
namespace Presentation.View.Forms.Company
{
    partial class CompanyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_companies = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_search_company = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_company_report = new System.Windows.Forms.Button();
            this.btn_view_company = new System.Windows.Forms.Button();
            this.btn_export_companies = new System.Windows.Forms.Button();
            this.btn_create_company = new System.Windows.Forms.Button();
            this.btn_delete_company = new System.Windows.Forms.Button();
            this.btn_edit_company = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_companies)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_view_company);
            this.groupBox1.Controls.Add(this.btn_export_companies);
            this.groupBox1.Controls.Add(this.btn_create_company);
            this.groupBox1.Controls.Add(this.btn_delete_company);
            this.groupBox1.Controls.Add(this.btn_edit_company);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(18, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(177, 221);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comunes";
            // 
            // dgv_companies
            // 
            this.dgv_companies.AllowUserToAddRows = false;
            this.dgv_companies.AllowUserToDeleteRows = false;
            this.dgv_companies.AllowUserToOrderColumns = true;
            this.dgv_companies.AllowUserToResizeColumns = false;
            this.dgv_companies.AllowUserToResizeRows = false;
            this.dgv_companies.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.dgv_companies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_companies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_companies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_companies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_companies.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_companies.EnableHeadersVisualStyles = false;
            this.dgv_companies.Location = new System.Drawing.Point(201, 95);
            this.dgv_companies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_companies.MultiSelect = false;
            this.dgv_companies.Name = "dgv_companies";
            this.dgv_companies.ReadOnly = true;
            this.dgv_companies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_companies.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_companies.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_companies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_companies.Size = new System.Drawing.Size(617, 345);
            this.dgv_companies.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_search_company);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(201, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 55);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // txt_search_company
            // 
            this.txt_search_company.Location = new System.Drawing.Point(61, 18);
            this.txt_search_company.Name = "txt_search_company";
            this.txt_search_company.Size = new System.Drawing.Size(550, 25);
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btn_company_report);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(18, 361);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox3.Size = new System.Drawing.Size(177, 79);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comunes";
            // 
            // btn_company_report
            // 
            this.btn_company_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_company_report.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_company_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_company_report.ForeColor = System.Drawing.Color.White;
            this.btn_company_report.Image = global::Presentation.Properties.Resources.icons8_script_de_informes_de_gráficos_241;
            this.btn_company_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_company_report.Location = new System.Drawing.Point(18, 27);
            this.btn_company_report.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_company_report.Name = "btn_company_report";
            this.btn_company_report.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.btn_company_report.Size = new System.Drawing.Size(143, 30);
            this.btn_company_report.TabIndex = 4;
            this.btn_company_report.Text = "Informe";
            this.btn_company_report.UseVisualStyleBackColor = false;
            this.btn_company_report.Click += new System.EventHandler(this.btn_company_report_Click);
            // 
            // btn_view_company
            // 
            this.btn_view_company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_view_company.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_view_company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_company.ForeColor = System.Drawing.Color.White;
            this.btn_view_company.Image = global::Presentation.Properties.Resources.icons8_ver_24;
            this.btn_view_company.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_view_company.Location = new System.Drawing.Point(18, 30);
            this.btn_view_company.Name = "btn_view_company";
            this.btn_view_company.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_view_company.Size = new System.Drawing.Size(143, 30);
            this.btn_view_company.TabIndex = 5;
            this.btn_view_company.Text = "Ver";
            this.btn_view_company.UseVisualStyleBackColor = false;
            this.btn_view_company.Click += new System.EventHandler(this.btn_view_company_Click);
            // 
            // btn_export_companies
            // 
            this.btn_export_companies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_export_companies.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_export_companies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export_companies.ForeColor = System.Drawing.Color.White;
            this.btn_export_companies.Image = global::Presentation.Properties.Resources.icons8_exportación_de_base_de_datos_24;
            this.btn_export_companies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export_companies.Location = new System.Drawing.Point(18, 176);
            this.btn_export_companies.Name = "btn_export_companies";
            this.btn_export_companies.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_export_companies.Size = new System.Drawing.Size(143, 30);
            this.btn_export_companies.TabIndex = 4;
            this.btn_export_companies.Text = "Exportar";
            this.btn_export_companies.UseVisualStyleBackColor = false;
            // 
            // btn_create_company
            // 
            this.btn_create_company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_company.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_company.ForeColor = System.Drawing.Color.White;
            this.btn_create_company.Image = global::Presentation.Properties.Resources.icons8_añadir_24;
            this.btn_create_company.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_create_company.Location = new System.Drawing.Point(18, 104);
            this.btn_create_company.Name = "btn_create_company";
            this.btn_create_company.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_create_company.Size = new System.Drawing.Size(143, 30);
            this.btn_create_company.TabIndex = 1;
            this.btn_create_company.Text = "Crear";
            this.btn_create_company.UseVisualStyleBackColor = false;
            this.btn_create_company.Click += new System.EventHandler(this.btn_create_company_Click);
            // 
            // btn_delete_company
            // 
            this.btn_delete_company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_delete_company.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_delete_company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_company.ForeColor = System.Drawing.Color.White;
            this.btn_delete_company.Image = global::Presentation.Properties.Resources.icons8_eliminar_241;
            this.btn_delete_company.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete_company.Location = new System.Drawing.Point(18, 140);
            this.btn_delete_company.Name = "btn_delete_company";
            this.btn_delete_company.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_delete_company.Size = new System.Drawing.Size(143, 30);
            this.btn_delete_company.TabIndex = 2;
            this.btn_delete_company.Text = "Eliminar";
            this.btn_delete_company.UseVisualStyleBackColor = false;
            this.btn_delete_company.Click += new System.EventHandler(this.btn_delete_company_Click);
            // 
            // btn_edit_company
            // 
            this.btn_edit_company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_edit_company.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_edit_company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_company.ForeColor = System.Drawing.Color.White;
            this.btn_edit_company.Image = global::Presentation.Properties.Resources.icons8_editar_24;
            this.btn_edit_company.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit_company.Location = new System.Drawing.Point(18, 68);
            this.btn_edit_company.Name = "btn_edit_company";
            this.btn_edit_company.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_edit_company.Size = new System.Drawing.Size(143, 30);
            this.btn_edit_company.TabIndex = 1;
            this.btn_edit_company.Text = "Editar";
            this.btn_edit_company.UseVisualStyleBackColor = false;
            this.btn_edit_company.Click += new System.EventHandler(this.btn_edit_company_Click);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_companies);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Empresas";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_companies)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_export_companies;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_create_company;
        private System.Windows.Forms.Button btn_delete_company;
        private System.Windows.Forms.Button btn_edit_company;
        public System.Windows.Forms.DataGridView dgv_companies;
        private System.Windows.Forms.Button btn_view_company;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_search_company;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_company_report;
    }
}