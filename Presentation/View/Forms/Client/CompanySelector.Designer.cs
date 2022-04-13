
namespace Presentation.View.Forms.Client
{
    partial class CompanySelector
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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pcb_close = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_search_company = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_companies_child = new System.Windows.Forms.DataGridView();
            this.pcb_close_create_client = new System.Windows.Forms.PictureBox();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_companies_child)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_create_client)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.pcb_close_create_client);
            this.pnl_top.Controls.Add(this.pcb_close);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(647, 35);
            this.pnl_top.TabIndex = 12;
            this.pnl_top.Visible = false;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_search_company);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 55);
            this.groupBox2.TabIndex = 14;
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
            // dgv_companies_child
            // 
            this.dgv_companies_child.AllowUserToAddRows = false;
            this.dgv_companies_child.AllowUserToDeleteRows = false;
            this.dgv_companies_child.AllowUserToOrderColumns = true;
            this.dgv_companies_child.AllowUserToResizeColumns = false;
            this.dgv_companies_child.AllowUserToResizeRows = false;
            this.dgv_companies_child.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.dgv_companies_child.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_companies_child.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_companies_child.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_companies_child.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_companies_child.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_companies_child.EnableHeadersVisualStyles = false;
            this.dgv_companies_child.Location = new System.Drawing.Point(12, 104);
            this.dgv_companies_child.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_companies_child.MultiSelect = false;
            this.dgv_companies_child.Name = "dgv_companies_child";
            this.dgv_companies_child.ReadOnly = true;
            this.dgv_companies_child.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_companies_child.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_companies_child.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_companies_child.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_companies_child.Size = new System.Drawing.Size(617, 345);
            this.dgv_companies_child.TabIndex = 13;
            this.dgv_companies_child.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_companies_CellDoubleClick);
            // 
            // pcb_close_create_client
            // 
            this.pcb_close_create_client.Image = global::Presentation.Properties.Resources.close;
            this.pcb_close_create_client.Location = new System.Drawing.Point(619, 6);
            this.pcb_close_create_client.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_close_create_client.Name = "pcb_close_create_client";
            this.pcb_close_create_client.Size = new System.Drawing.Size(25, 25);
            this.pcb_close_create_client.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close_create_client.TabIndex = 15;
            this.pcb_close_create_client.TabStop = false;
            this.pcb_close_create_client.Click += new System.EventHandler(this.pcb_close_create_client_Click);
            // 
            // CompanySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_companies_child);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CompanySelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanySelector";
            this.pnl_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_companies_child)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_create_client)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.PictureBox pcb_close;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_search_company;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_companies_child;
        private System.Windows.Forms.PictureBox pcb_close_create_client;
    }
}