
namespace Presentation.View.Forms.Payment
{
    partial class PayFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayFee));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pcb_close_payment = new System.Windows.Forms.PictureBox();
            this.pcb_exit = new System.Windows.Forms.PictureBox();
            this.pcb_minus = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_client_name = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_date_invoice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_invoice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_company_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_acumulated = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_invoice_payment = new System.Windows.Forms.Label();
            this.lbl_fee = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_invoice_id = new System.Windows.Forms.TextBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_ccf = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_check = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_pay_note = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_ref_bank = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_bank = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_method_payment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_last_date = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtp_payment = new System.Windows.Forms.DateTimePicker();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.label10);
            this.pnl_top.Controls.Add(this.pcb_close_payment);
            this.pnl_top.Controls.Add(this.pcb_exit);
            this.pnl_top.Controls.Add(this.pcb_minus);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(520, 29);
            this.pnl_top.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(11, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Abono a cuenta";
            // 
            // pcb_close_payment
            // 
            this.pcb_close_payment.Image = global::Presentation.Properties.Resources.close;
            this.pcb_close_payment.Location = new System.Drawing.Point(480, 2);
            this.pcb_close_payment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_close_payment.Name = "pcb_close_payment";
            this.pcb_close_payment.Size = new System.Drawing.Size(25, 25);
            this.pcb_close_payment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close_payment.TabIndex = 4;
            this.pcb_close_payment.TabStop = false;
            this.pcb_close_payment.Click += new System.EventHandler(this.pcb_close_payment_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cliente: ";
            // 
            // lbl_client_name
            // 
            this.lbl_client_name.AutoSize = true;
            this.lbl_client_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_client_name.Location = new System.Drawing.Point(217, 30);
            this.lbl_client_name.Name = "lbl_client_name";
            this.lbl_client_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_client_name.Size = new System.Drawing.Size(120, 17);
            this.lbl_client_name.TabIndex = 26;
            this.lbl_client_name.Text = "Nombre del cliente";
            this.lbl_client_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_date_invoice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_invoice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_company_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_client_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 142);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales";
            // 
            // lbl_date_invoice
            // 
            this.lbl_date_invoice.AutoSize = true;
            this.lbl_date_invoice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_invoice.Location = new System.Drawing.Point(233, 108);
            this.lbl_date_invoice.Name = "lbl_date_invoice";
            this.lbl_date_invoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_date_invoice.Size = new System.Drawing.Size(74, 17);
            this.lbl_date_invoice.TabIndex = 32;
            this.lbl_date_invoice.Text = "12/25/2022";
            this.lbl_date_invoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Fecha de emisión: ";
            // 
            // lbl_invoice
            // 
            this.lbl_invoice.AutoSize = true;
            this.lbl_invoice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoice.Location = new System.Drawing.Point(252, 82);
            this.lbl_invoice.Name = "lbl_invoice";
            this.lbl_invoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_invoice.Size = new System.Drawing.Size(36, 17);
            this.lbl_invoice.TabIndex = 30;
            this.lbl_invoice.Text = "0000";
            this.lbl_invoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Factura: ";
            // 
            // lbl_company_name
            // 
            this.lbl_company_name.AutoSize = true;
            this.lbl_company_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_company_name.Location = new System.Drawing.Point(204, 56);
            this.lbl_company_name.Name = "lbl_company_name";
            this.lbl_company_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_company_name.Size = new System.Drawing.Size(145, 17);
            this.lbl_company_name.TabIndex = 28;
            this.lbl_company_name.Text = "Nombre de la empresa";
            this.lbl_company_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Empresa: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_last_date);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lbl_acumulated);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbl_balance);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lbl_invoice_payment);
            this.groupBox2.Controls.Add(this.lbl_fee);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 168);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles de la cuenta";
            // 
            // lbl_acumulated
            // 
            this.lbl_acumulated.AutoSize = true;
            this.lbl_acumulated.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acumulated.Location = new System.Drawing.Point(151, 83);
            this.lbl_acumulated.Name = "lbl_acumulated";
            this.lbl_acumulated.Size = new System.Drawing.Size(36, 17);
            this.lbl_acumulated.TabIndex = 39;
            this.lbl_acumulated.Text = "0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Acumulado:";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.Location = new System.Drawing.Point(151, 59);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(36, 17);
            this.lbl_balance.TabIndex = 37;
            this.lbl_balance.Text = "0000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 17);
            this.label15.TabIndex = 36;
            this.label15.Text = "Saldo: ";
            // 
            // lbl_invoice_payment
            // 
            this.lbl_invoice_payment.AutoSize = true;
            this.lbl_invoice_payment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoice_payment.Location = new System.Drawing.Point(151, 107);
            this.lbl_invoice_payment.Name = "lbl_invoice_payment";
            this.lbl_invoice_payment.Size = new System.Drawing.Size(36, 17);
            this.lbl_invoice_payment.TabIndex = 35;
            this.lbl_invoice_payment.Text = "0000";
            // 
            // lbl_fee
            // 
            this.lbl_fee.AutoSize = true;
            this.lbl_fee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fee.Location = new System.Drawing.Point(151, 32);
            this.lbl_fee.Name = "lbl_fee";
            this.lbl_fee.Size = new System.Drawing.Size(36, 17);
            this.lbl_fee.TabIndex = 33;
            this.lbl_fee.Text = "0000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Total facturado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Couta: ";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(92, 26);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(117, 23);
            this.txt_amount.TabIndex = 34;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(10, 29);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 17);
            this.label21.TabIndex = 33;
            this.label21.Text = "Monto: ";
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_pay.FlatAppearance.BorderSize = 0;
            this.btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.ForeColor = System.Drawing.Color.White;
            this.btn_pay.Location = new System.Drawing.Point(264, 460);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(255, 46);
            this.btn_pay.TabIndex = 39;
            this.btn_pay.Text = "Abonar";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.LightGray;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(0, 460);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(265, 46);
            this.btn_cancel.TabIndex = 40;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_invoice_id
            // 
            this.txt_invoice_id.Location = new System.Drawing.Point(200, 429);
            this.txt_invoice_id.Name = "txt_invoice_id";
            this.txt_invoice_id.Size = new System.Drawing.Size(86, 25);
            this.txt_invoice_id.TabIndex = 35;
            this.txt_invoice_id.Visible = false;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_error.Location = new System.Drawing.Point(14, 432);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_error.Size = new System.Drawing.Size(57, 17);
            this.lbl_error.TabIndex = 33;
            this.lbl_error.Text = "lbl_error";
            this.lbl_error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtp_payment);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txt_ccf);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txt_check);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txt_pay_note);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txt_ref_bank);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cmb_bank);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cmb_method_payment);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(294, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 272);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Información del abono";
            // 
            // txt_ccf
            // 
            this.txt_ccf.Location = new System.Drawing.Point(90, 228);
            this.txt_ccf.Name = "txt_ccf";
            this.txt_ccf.Size = new System.Drawing.Size(117, 25);
            this.txt_ccf.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 45;
            this.label14.Text = "N° CCF:";
            // 
            // txt_check
            // 
            this.txt_check.Location = new System.Drawing.Point(90, 197);
            this.txt_check.Name = "txt_check";
            this.txt_check.Size = new System.Drawing.Size(117, 25);
            this.txt_check.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 17);
            this.label13.TabIndex = 43;
            this.label13.Text = "N° Cheque:";
            // 
            // txt_pay_note
            // 
            this.txt_pay_note.Location = new System.Drawing.Point(110, 166);
            this.txt_pay_note.Name = "txt_pay_note";
            this.txt_pay_note.Size = new System.Drawing.Size(97, 25);
            this.txt_pay_note.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "Nota de abono:";
            // 
            // txt_ref_bank
            // 
            this.txt_ref_bank.Location = new System.Drawing.Point(90, 135);
            this.txt_ref_bank.Name = "txt_ref_bank";
            this.txt_ref_bank.Size = new System.Drawing.Size(117, 25);
            this.txt_ref_bank.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Referencia:";
            // 
            // cmb_bank
            // 
            this.cmb_bank.FormattingEnabled = true;
            this.cmb_bank.Location = new System.Drawing.Point(78, 99);
            this.cmb_bank.Name = "cmb_bank";
            this.cmb_bank.Size = new System.Drawing.Size(127, 25);
            this.cmb_bank.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Banco: ";
            // 
            // cmb_method_payment
            // 
            this.cmb_method_payment.FormattingEnabled = true;
            this.cmb_method_payment.Location = new System.Drawing.Point(78, 62);
            this.cmb_method_payment.Name = "cmb_method_payment";
            this.cmb_method_payment.Size = new System.Drawing.Size(127, 25);
            this.cmb_method_payment.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Método: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_amount);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 67);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Abono";
            // 
            // lbl_last_date
            // 
            this.lbl_last_date.AutoSize = true;
            this.lbl_last_date.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_last_date.Location = new System.Drawing.Point(164, 133);
            this.lbl_last_date.Name = "lbl_last_date";
            this.lbl_last_date.Size = new System.Drawing.Size(36, 17);
            this.lbl_last_date.TabIndex = 41;
            this.lbl_last_date.Text = "0000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 17);
            this.label17.TabIndex = 40;
            this.label17.Text = "Última fecha de pago:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 17);
            this.label16.TabIndex = 47;
            this.label16.Text = "Fecha: ";
            // 
            // dtp_payment
            // 
            this.dtp_payment.CustomFormat = "yyyy-MM-dd";
            this.dtp_payment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_payment.Location = new System.Drawing.Point(78, 32);
            this.dtp_payment.Name = "dtp_payment";
            this.dtp_payment.Size = new System.Drawing.Size(127, 25);
            this.dtp_payment.TabIndex = 48;
            // 
            // PayFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 507);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txt_invoice_id);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PayFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abonar a cuenta";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pcb_close_payment;
        private System.Windows.Forms.PictureBox pcb_exit;
        private System.Windows.Forms.PictureBox pcb_minus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Label lbl_client_name;
        public System.Windows.Forms.Label lbl_date_invoice;
        public System.Windows.Forms.Label lbl_invoice;
        public System.Windows.Forms.Label lbl_company_name;
        public System.Windows.Forms.Label lbl_balance;
        public System.Windows.Forms.Label lbl_invoice_payment;
        public System.Windows.Forms.Label lbl_fee;
        public System.Windows.Forms.Label lbl_error;
        public System.Windows.Forms.TextBox txt_invoice_id;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_ref_bank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_bank;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_method_payment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ccf;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_check;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_pay_note;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label lbl_acumulated;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_last_date;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtp_payment;
        private System.Windows.Forms.Label label16;
    }
}