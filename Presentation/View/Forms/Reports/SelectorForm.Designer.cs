
namespace Presentation.View.Forms
{
    partial class SelectorForms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_book_sales = new System.Windows.Forms.Button();
            this.btn_invoice_pending = new System.Windows.Forms.Button();
            this.btn_invoice_by_companies = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_book_sales);
            this.groupBox1.Controls.Add(this.btn_invoice_pending);
            this.groupBox1.Controls.Add(this.btn_invoice_by_companies);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 136);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // btn_book_sales
            // 
            this.btn_book_sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_book_sales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_book_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_book_sales.ForeColor = System.Drawing.Color.White;
            this.btn_book_sales.Image = global::Presentation.Properties.Resources.icons8_libro_24;
            this.btn_book_sales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_book_sales.Location = new System.Drawing.Point(6, 24);
            this.btn_book_sales.Name = "btn_book_sales";
            this.btn_book_sales.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_book_sales.Size = new System.Drawing.Size(237, 30);
            this.btn_book_sales.TabIndex = 29;
            this.btn_book_sales.Text = "Libro de Ventas";
            this.btn_book_sales.UseVisualStyleBackColor = false;
            this.btn_book_sales.Click += new System.EventHandler(this.btn_book_sales_Click);
            // 
            // btn_invoice_pending
            // 
            this.btn_invoice_pending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_invoice_pending.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_invoice_pending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_invoice_pending.ForeColor = System.Drawing.Color.White;
            this.btn_invoice_pending.Image = global::Presentation.Properties.Resources.icons8_factura_24;
            this.btn_invoice_pending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_invoice_pending.Location = new System.Drawing.Point(6, 60);
            this.btn_invoice_pending.Name = "btn_invoice_pending";
            this.btn_invoice_pending.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_invoice_pending.Size = new System.Drawing.Size(237, 30);
            this.btn_invoice_pending.TabIndex = 31;
            this.btn_invoice_pending.Text = "Pendientes";
            this.btn_invoice_pending.UseVisualStyleBackColor = false;
            // 
            // btn_invoice_by_companies
            // 
            this.btn_invoice_by_companies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_invoice_by_companies.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_invoice_by_companies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_invoice_by_companies.ForeColor = System.Drawing.Color.White;
            this.btn_invoice_by_companies.Image = global::Presentation.Properties.Resources.icons8_cliente_de_empresa_24;
            this.btn_invoice_by_companies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_invoice_by_companies.Location = new System.Drawing.Point(6, 96);
            this.btn_invoice_by_companies.Name = "btn_invoice_by_companies";
            this.btn_invoice_by_companies.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_invoice_by_companies.Size = new System.Drawing.Size(237, 30);
            this.btn_invoice_by_companies.TabIndex = 30;
            this.btn_invoice_by_companies.Text = "Pendientes por Empresa";
            this.btn_invoice_by_companies.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(310, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 136);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "No disponible";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(566, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 136);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "No disponible";
            // 
            // SelectorForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectorForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_invoice_pending;
        private System.Windows.Forms.Button btn_invoice_by_companies;
        private System.Windows.Forms.Button btn_book_sales;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}