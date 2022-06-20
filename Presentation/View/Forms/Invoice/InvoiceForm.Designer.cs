
namespace Presentation.View.Forms.Invoice
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_search_invoice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_print_invoice = new System.Windows.Forms.Button();
            this.btn_view_invoice = new System.Windows.Forms.Button();
            this.btn_create_invoice = new System.Windows.Forms.Button();
            this.btn_delete_invoice = new System.Windows.Forms.Button();
            this.btn_edit_invoice = new System.Windows.Forms.Button();
            this.dgv_invoices = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoices)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txt_search_invoice);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(208, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(617, 55);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // txt_search_invoice
            // 
            this.txt_search_invoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search_invoice.Location = new System.Drawing.Point(61, 18);
            this.txt_search_invoice.Name = "txt_search_invoice";
            this.txt_search_invoice.Size = new System.Drawing.Size(550, 23);
            this.txt_search_invoice.TabIndex = 1;
            this.txt_search_invoice.TextChanged += new System.EventHandler(this.txt_search_company_TextChanged);
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
            this.groupBox1.Controls.Add(this.btn_print_invoice);
            this.groupBox1.Controls.Add(this.btn_view_invoice);
            this.groupBox1.Controls.Add(this.btn_create_invoice);
            this.groupBox1.Controls.Add(this.btn_delete_invoice);
            this.groupBox1.Controls.Add(this.btn_edit_invoice);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(25, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(177, 223);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // btn_print_invoice
            // 
            this.btn_print_invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_print_invoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_print_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print_invoice.ForeColor = System.Drawing.Color.White;
            this.btn_print_invoice.Image = global::Presentation.Properties.Resources.icons8_print_24__1_;
            this.btn_print_invoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print_invoice.Location = new System.Drawing.Point(17, 178);
            this.btn_print_invoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_print_invoice.Name = "btn_print_invoice";
            this.btn_print_invoice.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.btn_print_invoice.Size = new System.Drawing.Size(143, 30);
            this.btn_print_invoice.TabIndex = 5;
            this.btn_print_invoice.Text = "Imprimir";
            this.btn_print_invoice.UseVisualStyleBackColor = false;
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
            this.btn_view_invoice.Click += new System.EventHandler(this.btn_view_invoice_Click);
            // 
            // btn_create_invoice
            // 
            this.btn_create_invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_invoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_invoice.ForeColor = System.Drawing.Color.White;
            this.btn_create_invoice.Image = global::Presentation.Properties.Resources.icons8_añadir_24;
            this.btn_create_invoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_create_invoice.Location = new System.Drawing.Point(17, 105);
            this.btn_create_invoice.Name = "btn_create_invoice";
            this.btn_create_invoice.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_create_invoice.Size = new System.Drawing.Size(143, 30);
            this.btn_create_invoice.TabIndex = 1;
            this.btn_create_invoice.Text = "Crear";
            this.btn_create_invoice.UseVisualStyleBackColor = false;
            this.btn_create_invoice.Click += new System.EventHandler(this.btn_create_invoice_Click);
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
            this.btn_delete_invoice.Click += new System.EventHandler(this.btn_delete_invoice_Click);
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
            this.btn_edit_invoice.Click += new System.EventHandler(this.btn_edit_invoice_Click);
            // 
            // dgv_invoices
            // 
            this.dgv_invoices.AllowUserToAddRows = false;
            this.dgv_invoices.AllowUserToDeleteRows = false;
            this.dgv_invoices.AllowUserToOrderColumns = true;
            this.dgv_invoices.AllowUserToResizeColumns = false;
            this.dgv_invoices.AllowUserToResizeRows = false;
            this.dgv_invoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_invoices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.dgv_invoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_invoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_invoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_invoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_invoices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_invoices.EnableHeadersVisualStyles = false;
            this.dgv_invoices.Location = new System.Drawing.Point(208, 80);
            this.dgv_invoices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_invoices.MultiSelect = false;
            this.dgv_invoices.Name = "dgv_invoices";
            this.dgv_invoices.ReadOnly = true;
            this.dgv_invoices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_invoices.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_invoices.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_invoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_invoices.Size = new System.Drawing.Size(617, 413);
            this.dgv_invoices.TabIndex = 14;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 510);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_invoices);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facturas";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_search_invoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_create_invoice;
        private System.Windows.Forms.Button btn_delete_invoice;
        private System.Windows.Forms.Button btn_edit_invoice;
        public System.Windows.Forms.DataGridView dgv_invoices;
        private System.Windows.Forms.Button btn_view_invoice;
        private System.Windows.Forms.Button btn_print_invoice;
    }
}