
namespace Presentation.View.Forms.Reports
{
    partial class SalesByCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesByOptometristParams));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pcb_close_create_report = new System.Windows.Forms.PictureBox();
            this.pcb_close = new System.Windows.Forms.PictureBox();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_generate_report = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_by_date = new System.Windows.Forms.RadioButton();
            this.rb_all = new System.Windows.Forms.RadioButton();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_create_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.pnl_top.Size = new System.Drawing.Size(363, 35);
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
            this.pcb_close_create_report.Location = new System.Drawing.Point(326, 6);
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
            // dtp_from
            // 
            this.dtp_from.CustomFormat = "yyyy-MM-dd";
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_from.Location = new System.Drawing.Point(62, 27);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(117, 23);
            this.dtp_from.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Hasta:";
            // 
            // dtp_to
            // 
            this.dtp_to.CustomFormat = "yyyy-MM-dd";
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_to.Location = new System.Drawing.Point(62, 56);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(117, 23);
            this.dtp_to.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_to);
            this.groupBox1.Controls.Add(this.dtp_from);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(166, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 98);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // btn_generate_report
            // 
            this.btn_generate_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(142)))), ((int)(((byte)(4)))));
            this.btn_generate_report.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(142)))), ((int)(((byte)(4)))));
            this.btn_generate_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generate_report.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate_report.Location = new System.Drawing.Point(185, 146);
            this.btn_generate_report.Name = "btn_generate_report";
            this.btn_generate_report.Size = new System.Drawing.Size(166, 27);
            this.btn_generate_report.TabIndex = 48;
            this.btn_generate_report.Text = "Generar informe";
            this.btn_generate_report.UseVisualStyleBackColor = false;
            this.btn_generate_report.Click += new System.EventHandler(this.btn_generate_report_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_by_date);
            this.groupBox2.Controls.Add(this.rb_all);
            this.groupBox2.Location = new System.Drawing.Point(12, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 98);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de informe";
            // 
            // rb_by_date
            // 
            this.rb_by_date.AutoSize = true;
            this.rb_by_date.Location = new System.Drawing.Point(6, 60);
            this.rb_by_date.Name = "rb_by_date";
            this.rb_by_date.Size = new System.Drawing.Size(80, 19);
            this.rb_by_date.TabIndex = 1;
            this.rb_by_date.TabStop = true;
            this.rb_by_date.Text = "Por fechas";
            this.rb_by_date.UseVisualStyleBackColor = true;
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.Location = new System.Drawing.Point(6, 31);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(52, 19);
            this.rb_all.TabIndex = 0;
            this.rb_all.TabStop = true;
            this.rb_all.Text = "Todo";
            this.rb_all.UseVisualStyleBackColor = true;
            // 
            // SalesByOptometristParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 185);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_generate_report);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesByOptometristParams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas por Optómetra";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_create_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcb_close_create_report;
        private System.Windows.Forms.PictureBox pcb_close;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_generate_report;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_by_date;
        private System.Windows.Forms.RadioButton rb_all;
    }
}