
namespace Presentation.View.Forms.Bank
{
    partial class BankForm
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
            this.txt_search_bank = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_banks = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_view_view = new System.Windows.Forms.Button();
            this.btn_create_bank = new System.Windows.Forms.Button();
            this.btn_delete_bank = new System.Windows.Forms.Button();
            this.btn_edit_bank = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_banks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_search_bank);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(198, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(637, 55);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // txt_search_bank
            // 
            this.txt_search_bank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search_bank.Location = new System.Drawing.Point(71, 19);
            this.txt_search_bank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search_bank.Name = "txt_search_bank";
            this.txt_search_bank.Size = new System.Drawing.Size(560, 23);
            this.txt_search_bank.TabIndex = 1;
            this.txt_search_bank.TextChanged += new System.EventHandler(this.txt_search_bank_TextChanged);
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
            // dgv_banks
            // 
            this.dgv_banks.AllowUserToAddRows = false;
            this.dgv_banks.AllowUserToDeleteRows = false;
            this.dgv_banks.AllowUserToOrderColumns = true;
            this.dgv_banks.AllowUserToResizeColumns = false;
            this.dgv_banks.AllowUserToResizeRows = false;
            this.dgv_banks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_banks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.dgv_banks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_banks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_banks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_banks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_banks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_banks.EnableHeadersVisualStyles = false;
            this.dgv_banks.Location = new System.Drawing.Point(198, 85);
            this.dgv_banks.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgv_banks.MultiSelect = false;
            this.dgv_banks.Name = "dgv_banks";
            this.dgv_banks.ReadOnly = true;
            this.dgv_banks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_banks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_banks.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_banks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_banks.Size = new System.Drawing.Size(637, 442);
            this.dgv_banks.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_view_view);
            this.groupBox1.Controls.Add(this.btn_create_bank);
            this.groupBox1.Controls.Add(this.btn_delete_bank);
            this.groupBox1.Controls.Add(this.btn_edit_bank);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(15, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(177, 189);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // btn_view_view
            // 
            this.btn_view_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_view_view.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_view_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_view.ForeColor = System.Drawing.Color.White;
            this.btn_view_view.Image = global::Presentation.Properties.Resources.icons8_ver_24;
            this.btn_view_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_view_view.Location = new System.Drawing.Point(18, 27);
            this.btn_view_view.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_view_view.Name = "btn_view_view";
            this.btn_view_view.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.btn_view_view.Size = new System.Drawing.Size(143, 30);
            this.btn_view_view.TabIndex = 3;
            this.btn_view_view.Text = "Ver";
            this.btn_view_view.UseVisualStyleBackColor = false;
            this.btn_view_view.Click += new System.EventHandler(this.btn_view_view_Click);
            // 
            // btn_create_bank
            // 
            this.btn_create_bank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_bank.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_bank.ForeColor = System.Drawing.Color.White;
            this.btn_create_bank.Image = global::Presentation.Properties.Resources.icons8_añadir_24;
            this.btn_create_bank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_create_bank.Location = new System.Drawing.Point(18, 103);
            this.btn_create_bank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_create_bank.Name = "btn_create_bank";
            this.btn_create_bank.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.btn_create_bank.Size = new System.Drawing.Size(143, 30);
            this.btn_create_bank.TabIndex = 1;
            this.btn_create_bank.Text = "Crear";
            this.btn_create_bank.UseVisualStyleBackColor = false;
            this.btn_create_bank.Click += new System.EventHandler(this.btn_create_bank_Click);
            // 
            // btn_delete_bank
            // 
            this.btn_delete_bank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_delete_bank.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_delete_bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_bank.ForeColor = System.Drawing.Color.White;
            this.btn_delete_bank.Image = global::Presentation.Properties.Resources.icons8_eliminar_241;
            this.btn_delete_bank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete_bank.Location = new System.Drawing.Point(18, 141);
            this.btn_delete_bank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete_bank.Name = "btn_delete_bank";
            this.btn_delete_bank.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.btn_delete_bank.Size = new System.Drawing.Size(143, 30);
            this.btn_delete_bank.TabIndex = 2;
            this.btn_delete_bank.Text = "Eliminar";
            this.btn_delete_bank.UseVisualStyleBackColor = false;
            this.btn_delete_bank.Click += new System.EventHandler(this.btn_delete_bank_Click);
            // 
            // btn_edit_bank
            // 
            this.btn_edit_bank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_edit_bank.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_edit_bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_bank.ForeColor = System.Drawing.Color.White;
            this.btn_edit_bank.Image = global::Presentation.Properties.Resources.icons8_editar_24;
            this.btn_edit_bank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit_bank.Location = new System.Drawing.Point(18, 65);
            this.btn_edit_bank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_edit_bank.Name = "btn_edit_bank";
            this.btn_edit_bank.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.btn_edit_bank.Size = new System.Drawing.Size(143, 30);
            this.btn_edit_bank.TabIndex = 1;
            this.btn_edit_bank.Text = "Editar";
            this.btn_edit_bank.UseVisualStyleBackColor = false;
            this.btn_edit_bank.Click += new System.EventHandler(this.btn_edit_bank_Click);
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_banks);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BankForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bancos";
            this.Load += new System.EventHandler(this.BankForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_banks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_search_bank;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_banks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_view_view;
        private System.Windows.Forms.Button btn_create_bank;
        private System.Windows.Forms.Button btn_delete_bank;
        private System.Windows.Forms.Button btn_edit_bank;
    }
}