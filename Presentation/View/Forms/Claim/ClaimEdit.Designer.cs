
namespace Presentation.View.Forms.Claim
{
    partial class ClaimEdit

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClaimEdit));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pcb_close_create_claim = new System.Windows.Forms.PictureBox();
            this.pcb_exit = new System.Windows.Forms.PictureBox();
            this.pcb_minus = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_motive_claims = new System.Windows.Forms.ComboBox();
            this.dtp_claim_created = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_type_claims = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_company = new System.Windows.Forms.Label();
            this.lbl_client = new System.Windows.Forms.Label();
            this.btn_search_element = new System.Windows.Forms.Button();
            this.txt_claim_details = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_client_id = new System.Windows.Forms.TextBox();
            this.btn_save_claim = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_create_claim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.label10);
            this.pnl_top.Controls.Add(this.pcb_close_create_claim);
            this.pnl_top.Controls.Add(this.pcb_exit);
            this.pnl_top.Controls.Add(this.pcb_minus);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(596, 29);
            this.pnl_top.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(11, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Editor de reclamos";
            // 
            // pcb_close_create_claim
            // 
            this.pcb_close_create_claim.Image = global::Presentation.Properties.Resources.close;
            this.pcb_close_create_claim.Location = new System.Drawing.Point(557, 3);
            this.pcb_close_create_claim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_close_create_claim.Name = "pcb_close_create_claim";
            this.pcb_close_create_claim.Size = new System.Drawing.Size(25, 25);
            this.pcb_close_create_claim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close_create_claim.TabIndex = 4;
            this.pcb_close_create_claim.TabStop = false;
            this.pcb_close_create_claim.Click += new System.EventHandler(this.pcb_close_create_claim_Click);
            // 
            // pcb_exit
            // 
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
            this.pcb_minus.Location = new System.Drawing.Point(1347, 7);
            this.pcb_minus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pcb_minus.Name = "pcb_minus";
            this.pcb_minus.Size = new System.Drawing.Size(34, 43);
            this.pcb_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_minus.TabIndex = 2;
            this.pcb_minus.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_motive_claims);
            this.groupBox1.Controls.Add(this.dtp_claim_created);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_type_claims);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 92);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del reclamo";
            // 
            // cb_motive_claims
            // 
            this.cb_motive_claims.FormattingEnabled = true;
            this.cb_motive_claims.Location = new System.Drawing.Point(280, 51);
            this.cb_motive_claims.Name = "cb_motive_claims";
            this.cb_motive_claims.Size = new System.Drawing.Size(276, 23);
            this.cb_motive_claims.TabIndex = 8;
            // 
            // dtp_claim_created
            // 
            this.dtp_claim_created.CustomFormat = "yyyy-MM-dd";
            this.dtp_claim_created.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_claim_created.Location = new System.Drawing.Point(9, 51);
            this.dtp_claim_created.Name = "dtp_claim_created";
            this.dtp_claim_created.Size = new System.Drawing.Size(132, 23);
            this.dtp_claim_created.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de reclamo";
            // 
            // cb_type_claims
            // 
            this.cb_type_claims.FormattingEnabled = true;
            this.cb_type_claims.Location = new System.Drawing.Point(147, 51);
            this.cb_type_claims.Name = "cb_type_claims";
            this.cb_type_claims.Size = new System.Drawing.Size(127, 23);
            this.cb_type_claims.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de reclamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Motivo de reclamo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_company);
            this.groupBox2.Controls.Add(this.lbl_client);
            this.groupBox2.Controls.Add(this.btn_search_element);
            this.groupBox2.Controls.Add(this.txt_claim_details);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 131);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del reclamo";
            // 
            // lbl_company
            // 
            this.lbl_company.AutoSize = true;
            this.lbl_company.Location = new System.Drawing.Point(6, 62);
            this.lbl_company.Name = "lbl_company";
            this.lbl_company.Size = new System.Drawing.Size(110, 15);
            this.lbl_company.TabIndex = 9;
            this.lbl_company.Text = "Empresa del Cliente";
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Location = new System.Drawing.Point(6, 36);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(109, 15);
            this.lbl_client.TabIndex = 8;
            this.lbl_client.Text = "Nombre del Cliente";
            // 
            // btn_search_element
            // 
            this.btn_search_element.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(142)))), ((int)(((byte)(4)))));
            this.btn_search_element.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(142)))), ((int)(((byte)(4)))));
            this.btn_search_element.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_element.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_element.Location = new System.Drawing.Point(9, 89);
            this.btn_search_element.Name = "btn_search_element";
            this.btn_search_element.Size = new System.Drawing.Size(164, 27);
            this.btn_search_element.TabIndex = 23;
            this.btn_search_element.Text = "Buscar cliente";
            this.btn_search_element.UseVisualStyleBackColor = false;
            this.btn_search_element.Click += new System.EventHandler(this.btn_search_element_Click);
            // 
            // txt_claim_details
            // 
            this.txt_claim_details.Location = new System.Drawing.Point(258, 33);
            this.txt_claim_details.Multiline = true;
            this.txt_claim_details.Name = "txt_claim_details";
            this.txt_claim_details.Size = new System.Drawing.Size(298, 92);
            this.txt_claim_details.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción del reclamo";
            // 
            // txt_client_id
            // 
            this.txt_client_id.Location = new System.Drawing.Point(21, 284);
            this.txt_client_id.Name = "txt_client_id";
            this.txt_client_id.Size = new System.Drawing.Size(61, 23);
            this.txt_client_id.TabIndex = 27;
            this.txt_client_id.Visible = false;
            // 
            // btn_save_claim
            // 
            this.btn_save_claim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_save_claim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_save_claim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_claim.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_claim.ForeColor = System.Drawing.Color.White;
            this.btn_save_claim.Image = global::Presentation.Properties.Resources.icons8_guardar_24;
            this.btn_save_claim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_claim.Location = new System.Drawing.Point(447, 278);
            this.btn_save_claim.Name = "btn_save_claim";
            this.btn_save_claim.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_save_claim.Size = new System.Drawing.Size(135, 30);
            this.btn_save_claim.TabIndex = 29;
            this.btn_save_claim.Text = "Guardar";
            this.btn_save_claim.UseVisualStyleBackColor = false;
            this.btn_save_claim.Click += new System.EventHandler(this.btn_save_claim_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_error.Location = new System.Drawing.Point(18, 266);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(50, 15);
            this.lbl_error.TabIndex = 9;
            this.lbl_error.Text = "lbl_error";
            this.lbl_error.Visible = false;
            // 
            // ClaimEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 324);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_save_claim);
            this.Controls.Add(this.txt_client_id);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClaimEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Reclamo";
            this.Load += new System.EventHandler(this.ClaimCreate_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_create_claim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pcb_close_create_claim;
        private System.Windows.Forms.PictureBox pcb_exit;
        private System.Windows.Forms.PictureBox pcb_minus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_type_claims;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_search_element;
        private System.Windows.Forms.Button btn_save_claim;
        private System.Windows.Forms.ComboBox cb_motive_claims;
        private System.Windows.Forms.DateTimePicker dtp_claim_created;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_claim_details;
        public System.Windows.Forms.TextBox txt_client_id;
        public System.Windows.Forms.Label lbl_company;
        public System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.Label lbl_error;
    }
}