
namespace Presentation.View.Forms.Laboratory
{
    partial class LaboratoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_search_company = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_create_user = new System.Windows.Forms.Button();
            this.btn_laboratory_delete = new System.Windows.Forms.Button();
            this.btn_edit_laboratory = new System.Windows.Forms.Button();
            this.dgv_laboratories = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_laboratories)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txt_search_company);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(201, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(617, 55);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // txt_search_company
            // 
            this.txt_search_company.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox1.Controls.Add(this.btn_create_user);
            this.groupBox1.Controls.Add(this.btn_laboratory_delete);
            this.groupBox1.Controls.Add(this.btn_edit_laboratory);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(18, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(177, 141);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // btn_create_user
            // 
            this.btn_create_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_user.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_user.ForeColor = System.Drawing.Color.White;
            this.btn_create_user.Image = global::Presentation.Properties.Resources.icons8_añadir_24;
            this.btn_create_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_create_user.Location = new System.Drawing.Point(18, 68);
            this.btn_create_user.Name = "btn_create_user";
            this.btn_create_user.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_create_user.Size = new System.Drawing.Size(143, 30);
            this.btn_create_user.TabIndex = 1;
            this.btn_create_user.Text = "Crear";
            this.btn_create_user.UseVisualStyleBackColor = false;
            this.btn_create_user.Click += new System.EventHandler(this.btn_create_user_Click);
            // 
            // btn_laboratory_delete
            // 
            this.btn_laboratory_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_laboratory_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_laboratory_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_laboratory_delete.ForeColor = System.Drawing.Color.White;
            this.btn_laboratory_delete.Image = global::Presentation.Properties.Resources.icons8_eliminar_241;
            this.btn_laboratory_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_laboratory_delete.Location = new System.Drawing.Point(18, 104);
            this.btn_laboratory_delete.Name = "btn_laboratory_delete";
            this.btn_laboratory_delete.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_laboratory_delete.Size = new System.Drawing.Size(143, 30);
            this.btn_laboratory_delete.TabIndex = 2;
            this.btn_laboratory_delete.Text = "Eliminar";
            this.btn_laboratory_delete.UseVisualStyleBackColor = false;
            this.btn_laboratory_delete.Click += new System.EventHandler(this.btn_laboratory_delete_Click);
            // 
            // btn_edit_laboratory
            // 
            this.btn_edit_laboratory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_edit_laboratory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_edit_laboratory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_laboratory.ForeColor = System.Drawing.Color.White;
            this.btn_edit_laboratory.Image = global::Presentation.Properties.Resources.icons8_editar_24;
            this.btn_edit_laboratory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit_laboratory.Location = new System.Drawing.Point(18, 30);
            this.btn_edit_laboratory.Name = "btn_edit_laboratory";
            this.btn_edit_laboratory.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_edit_laboratory.Size = new System.Drawing.Size(143, 30);
            this.btn_edit_laboratory.TabIndex = 1;
            this.btn_edit_laboratory.Text = "Editar";
            this.btn_edit_laboratory.UseVisualStyleBackColor = false;
            this.btn_edit_laboratory.Click += new System.EventHandler(this.btn_edit_laboratory_Click);
            // 
            // dgv_laboratories
            // 
            this.dgv_laboratories.AllowUserToAddRows = false;
            this.dgv_laboratories.AllowUserToDeleteRows = false;
            this.dgv_laboratories.AllowUserToOrderColumns = true;
            this.dgv_laboratories.AllowUserToResizeColumns = false;
            this.dgv_laboratories.AllowUserToResizeRows = false;
            this.dgv_laboratories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_laboratories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.dgv_laboratories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_laboratories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_laboratories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgv_laboratories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_laboratories.DefaultCellStyle = dataGridViewCellStyle34;
            this.dgv_laboratories.EnableHeadersVisualStyles = false;
            this.dgv_laboratories.Location = new System.Drawing.Point(201, 95);
            this.dgv_laboratories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_laboratories.MultiSelect = false;
            this.dgv_laboratories.Name = "dgv_laboratories";
            this.dgv_laboratories.ReadOnly = true;
            this.dgv_laboratories.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_laboratories.RowHeadersDefaultCellStyle = dataGridViewCellStyle35;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_laboratories.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dgv_laboratories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_laboratories.Size = new System.Drawing.Size(617, 417);
            this.dgv_laboratories.TabIndex = 14;
            // 
            // LaboratoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 510);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_laboratories);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LaboratoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Laboratorios";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_laboratories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_search_company;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_create_user;
        private System.Windows.Forms.Button btn_laboratory_delete;
        private System.Windows.Forms.Button btn_edit_laboratory;
        public System.Windows.Forms.DataGridView dgv_laboratories;
    }
}