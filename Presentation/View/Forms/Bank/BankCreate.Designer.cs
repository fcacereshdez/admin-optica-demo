
namespace Presentation.View.Forms.Bank
{
    partial class BankCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankCreate));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bank_name = new System.Windows.Forms.TextBox();
            this.txt_bank_account = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_last_check = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save_bank = new System.Windows.Forms.Button();
            this.pcb_close_create_bank = new System.Windows.Forms.PictureBox();
            this.pcb_exit = new System.Windows.Forms.PictureBox();
            this.pcb_minus = new System.Windows.Forms.PictureBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_create_bank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.label10);
            this.pnl_top.Controls.Add(this.pcb_close_create_bank);
            this.pnl_top.Controls.Add(this.pcb_exit);
            this.pnl_top.Controls.Add(this.pcb_minus);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(395, 29);
            this.pnl_top.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(11, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Creador de bancos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre de la entidad:";
            // 
            // txt_bank_name
            // 
            this.txt_bank_name.Location = new System.Drawing.Point(14, 65);
            this.txt_bank_name.Name = "txt_bank_name";
            this.txt_bank_name.Size = new System.Drawing.Size(178, 23);
            this.txt_bank_name.TabIndex = 26;
            // 
            // txt_bank_account
            // 
            this.txt_bank_account.Location = new System.Drawing.Point(205, 65);
            this.txt_bank_account.Name = "txt_bank_account";
            this.txt_bank_account.Size = new System.Drawing.Size(178, 23);
            this.txt_bank_account.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Número de cuenta:";
            // 
            // txt_last_check
            // 
            this.txt_last_check.Location = new System.Drawing.Point(15, 115);
            this.txt_last_check.Name = "txt_last_check";
            this.txt_last_check.Size = new System.Drawing.Size(178, 23);
            this.txt_last_check.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Último cheque generado:";
            // 
            // txt_balance
            // 
            this.txt_balance.Location = new System.Drawing.Point(205, 115);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(178, 23);
            this.txt_balance.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Saldo actual";
            // 
            // btn_save_bank
            // 
            this.btn_save_bank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_save_bank.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_save_bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_bank.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_bank.ForeColor = System.Drawing.Color.White;
            this.btn_save_bank.Image = global::Presentation.Properties.Resources.icons8_guardar_24;
            this.btn_save_bank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_bank.Location = new System.Drawing.Point(248, 166);
            this.btn_save_bank.Name = "btn_save_bank";
            this.btn_save_bank.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_save_bank.Size = new System.Drawing.Size(135, 30);
            this.btn_save_bank.TabIndex = 33;
            this.btn_save_bank.Text = "Guardar";
            this.btn_save_bank.UseVisualStyleBackColor = false;
            this.btn_save_bank.Click += new System.EventHandler(this.btn_save_bank_Click);
            // 
            // pcb_close_create_bank
            // 
            this.pcb_close_create_bank.Image = global::Presentation.Properties.Resources.close;
            this.pcb_close_create_bank.Location = new System.Drawing.Point(362, 2);
            this.pcb_close_create_bank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_close_create_bank.Name = "pcb_close_create_bank";
            this.pcb_close_create_bank.Size = new System.Drawing.Size(25, 25);
            this.pcb_close_create_bank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close_create_bank.TabIndex = 4;
            this.pcb_close_create_bank.TabStop = false;
            this.pcb_close_create_bank.Click += new System.EventHandler(this.pcb_close_create_bank_Click);
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
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.BackColor = System.Drawing.Color.White;
            this.lbl_error.ForeColor = System.Drawing.Color.Brown;
            this.lbl_error.Location = new System.Drawing.Point(16, 182);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(10, 15);
            this.lbl_error.TabIndex = 34;
            this.lbl_error.Text = ".";
            // 
            // BankCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 210);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_save_bank);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_last_check);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_bank_account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_bank_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BankCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear banco";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_create_bank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pcb_close_create_bank;
        private System.Windows.Forms.PictureBox pcb_exit;
        private System.Windows.Forms.PictureBox pcb_minus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bank_name;
        private System.Windows.Forms.TextBox txt_bank_account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_last_check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save_bank;
        private System.Windows.Forms.Label lbl_error;
    }
}