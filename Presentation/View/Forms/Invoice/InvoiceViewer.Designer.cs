
namespace Presentation.View.Forms.Invoice
{
    partial class InvoiceViewer
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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pcb_close_invoice_client = new System.Windows.Forms.PictureBox();
            this.pcb_exit = new System.Windows.Forms.PictureBox();
            this.pcb_minus = new System.Windows.Forms.PictureBox();
            this.dgv_invoices_client = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_get_invoice = new System.Windows.Forms.Button();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_invoice_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoices_client)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.label10);
            this.pnl_top.Controls.Add(this.pcb_close_invoice_client);
            this.pnl_top.Controls.Add(this.pcb_exit);
            this.pnl_top.Controls.Add(this.pcb_minus);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(398, 29);
            this.pnl_top.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(11, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Facturas por cliente";
            // 
            // pcb_close_invoice_client
            // 
            this.pcb_close_invoice_client.Image = global::Presentation.Properties.Resources.close;
            this.pcb_close_invoice_client.Location = new System.Drawing.Point(370, 2);
            this.pcb_close_invoice_client.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_close_invoice_client.Name = "pcb_close_invoice_client";
            this.pcb_close_invoice_client.Size = new System.Drawing.Size(25, 25);
            this.pcb_close_invoice_client.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close_invoice_client.TabIndex = 4;
            this.pcb_close_invoice_client.TabStop = false;
            this.pcb_close_invoice_client.Click += new System.EventHandler(this.pcb_close_invoice_client_Click);
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
            // dgv_invoices_client
            // 
            this.dgv_invoices_client.AllowUserToAddRows = false;
            this.dgv_invoices_client.AllowUserToDeleteRows = false;
            this.dgv_invoices_client.AllowUserToOrderColumns = true;
            this.dgv_invoices_client.AllowUserToResizeColumns = false;
            this.dgv_invoices_client.AllowUserToResizeRows = false;
            this.dgv_invoices_client.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.dgv_invoices_client.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_invoices_client.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_invoices_client.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_invoices_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_invoices_client.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_invoices_client.EnableHeadersVisualStyles = false;
            this.dgv_invoices_client.Location = new System.Drawing.Point(12, 39);
            this.dgv_invoices_client.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgv_invoices_client.MultiSelect = false;
            this.dgv_invoices_client.Name = "dgv_invoices_client";
            this.dgv_invoices_client.ReadOnly = true;
            this.dgv_invoices_client.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_invoices_client.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_invoices_client.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_invoices_client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_invoices_client.Size = new System.Drawing.Size(374, 185);
            this.dgv_invoices_client.TabIndex = 26;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.LightGray;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(0, 233);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(197, 46);
            this.btn_cancel.TabIndex = 42;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_get_invoice
            // 
            this.btn_get_invoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_get_invoice.FlatAppearance.BorderSize = 0;
            this.btn_get_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get_invoice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get_invoice.ForeColor = System.Drawing.Color.White;
            this.btn_get_invoice.Location = new System.Drawing.Point(195, 233);
            this.btn_get_invoice.Name = "btn_get_invoice";
            this.btn_get_invoice.Size = new System.Drawing.Size(203, 46);
            this.btn_get_invoice.TabIndex = 41;
            this.btn_get_invoice.Text = "Abonar";
            this.btn_get_invoice.UseVisualStyleBackColor = false;
            this.btn_get_invoice.Click += new System.EventHandler(this.btn_get_invoice_Click);
            // 
            // InvoiceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 279);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_get_invoice);
            this.Controls.Add(this.dgv_invoices_client);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoiceViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceView";
            this.Load += new System.EventHandler(this.InvoiceViewer_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_invoice_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoices_client)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pcb_close_invoice_client;
        private System.Windows.Forms.PictureBox pcb_exit;
        private System.Windows.Forms.PictureBox pcb_minus;
        public System.Windows.Forms.DataGridView dgv_invoices_client;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_get_invoice;
    }
}