
namespace Presentation.View.Forms.Reports
{
    partial class GetAllTransactionsByClientParams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetAllTransactionsByClientParams));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pcb_close_create_report = new System.Windows.Forms.PictureBox();
            this.pcb_close = new System.Windows.Forms.PictureBox();
            this.btn_generate_report = new System.Windows.Forms.Button();
            this.dgv_clients = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_search_client = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_create_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.label2);
            this.pnl_top.Controls.Add(this.pcb_close_create_report);
            this.pnl_top.Controls.Add(this.pcb_close);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(459, 35);
            this.pnl_top.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Configurar parámetros del informe";
            // 
            // pcb_close_create_report
            // 
            this.pcb_close_create_report.Image = global::Presentation.Properties.Resources.close;
            this.pcb_close_create_report.Location = new System.Drawing.Point(422, 6);
            this.pcb_close_create_report.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_close_create_report.Name = "pcb_close_create_report";
            this.pcb_close_create_report.Size = new System.Drawing.Size(25, 25);
            this.pcb_close_create_report.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close_create_report.TabIndex = 15;
            this.pcb_close_create_report.TabStop = false;
            this.pcb_close_create_report.Click += new System.EventHandler(this.pcb_close_create_report_Click);
            // 
            // pcb_close
            // 
            this.pcb_close.Image = global::Presentation.Properties.Resources.close;
            this.pcb_close.Location = new System.Drawing.Point(958, 3);
            this.pcb_close.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pcb_close.Name = "pcb_close";
            this.pcb_close.Size = new System.Drawing.Size(29, 33);
            this.pcb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close.TabIndex = 5;
            this.pcb_close.TabStop = false;
            // 
            // btn_generate_report
            // 
            this.btn_generate_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(142)))), ((int)(((byte)(4)))));
            this.btn_generate_report.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(142)))), ((int)(((byte)(4)))));
            this.btn_generate_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generate_report.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate_report.Location = new System.Drawing.Point(281, 291);
            this.btn_generate_report.Name = "btn_generate_report";
            this.btn_generate_report.Size = new System.Drawing.Size(166, 27);
            this.btn_generate_report.TabIndex = 48;
            this.btn_generate_report.Text = "Generar informe";
            this.btn_generate_report.UseVisualStyleBackColor = false;
            this.btn_generate_report.Click += new System.EventHandler(this.btn_generate_report_Click);
            // 
            // dgv_clients
            // 
            this.dgv_clients.AllowUserToAddRows = false;
            this.dgv_clients.AllowUserToDeleteRows = false;
            this.dgv_clients.AllowUserToOrderColumns = true;
            this.dgv_clients.AllowUserToResizeColumns = false;
            this.dgv_clients.AllowUserToResizeRows = false;
            this.dgv_clients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_clients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.dgv_clients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_clients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_clients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_clients.EnableHeadersVisualStyles = false;
            this.dgv_clients.Location = new System.Drawing.Point(15, 113);
            this.dgv_clients.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgv_clients.MultiSelect = false;
            this.dgv_clients.Name = "dgv_clients";
            this.dgv_clients.ReadOnly = true;
            this.dgv_clients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_clients.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clients.Size = new System.Drawing.Size(432, 169);
            this.dgv_clients.TabIndex = 49;
//            this.dgv_clients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clients_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_search_client);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(432, 55);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            // 
            // txt_search_client
            // 
            this.txt_search_client.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search_client.Location = new System.Drawing.Point(71, 19);
            this.txt_search_client.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search_client.Name = "txt_search_client";
            this.txt_search_client.Size = new System.Drawing.Size(355, 23);
            this.txt_search_client.TabIndex = 1;
            this.txt_search_client.TextChanged += new System.EventHandler(this.txt_search_client_TextChanged);
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
            // GetAllTransactionsByClientParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 329);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_clients);
            this.Controls.Add(this.btn_generate_report);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GetAllTransactionsByClientParams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas por Optómetra";
            this.Load += new System.EventHandler(this.GetAllTransactionsByClientParams_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_create_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcb_close_create_report;
        private System.Windows.Forms.PictureBox pcb_close;
        private System.Windows.Forms.Button btn_generate_report;
        public System.Windows.Forms.DataGridView dgv_clients;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_search_client;
        private System.Windows.Forms.Label label1;
    }
}