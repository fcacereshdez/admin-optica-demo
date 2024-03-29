﻿
namespace Presentation.View.Forms.User
{
    partial class UserCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCreate));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pcb_close_edit_user = new System.Windows.Forms.PictureBox();
            this.pcb_exit = new System.Windows.Forms.PictureBox();
            this.pcb_minus = new System.Windows.Forms.PictureBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_save_user = new System.Windows.Forms.Button();
            this.optometrist = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.consultant = new System.Windows.Forms.CheckBox();
            this.manager = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_edit_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.cb_status);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_role);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_lastname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 188);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Usuario";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(245, 142);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(226, 25);
            this.txt_email.TabIndex = 11;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(9, 142);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(230, 25);
            this.txt_phone.TabIndex = 9;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(321, 41);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(150, 25);
            this.cb_status.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Teléfono:";
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Location = new System.Drawing.Point(321, 92);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(150, 25);
            this.cb_role.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Rol:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(165, 92);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(150, 25);
            this.txt_password.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña:";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(9, 92);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(150, 25);
            this.txt_username.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario:";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(165, 41);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(150, 25);
            this.txt_lastname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(9, 41);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(150, 25);
            this.txt_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.label10);
            this.pnl_top.Controls.Add(this.pcb_close_edit_user);
            this.pnl_top.Controls.Add(this.pcb_exit);
            this.pnl_top.Controls.Add(this.pcb_minus);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(509, 29);
            this.pnl_top.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(9, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Creador de usuarios";
            // 
            // pcb_close_edit_user
            // 
            this.pcb_close_edit_user.Image = global::Presentation.Properties.Resources.close;
            this.pcb_close_edit_user.Location = new System.Drawing.Point(470, 2);
            this.pcb_close_edit_user.Name = "pcb_close_edit_user";
            this.pcb_close_edit_user.Size = new System.Drawing.Size(25, 25);
            this.pcb_close_edit_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close_edit_user.TabIndex = 4;
            this.pcb_close_edit_user.TabStop = false;
            this.pcb_close_edit_user.Click += new System.EventHandler(this.pcb_close_edit_user_Click);
            // 
            // pcb_exit
            // 
            this.pcb_exit.Image = global::Presentation.Properties.Resources.close;
            this.pcb_exit.Location = new System.Drawing.Point(1191, 5);
            this.pcb_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_exit.Name = "pcb_exit";
            this.pcb_exit.Size = new System.Drawing.Size(29, 33);
            this.pcb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_exit.TabIndex = 3;
            this.pcb_exit.TabStop = false;
            // 
            // pcb_minus
            // 
            this.pcb_minus.Image = global::Presentation.Properties.Resources.minus;
            this.pcb_minus.Location = new System.Drawing.Point(1155, 5);
            this.pcb_minus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_minus.Name = "pcb_minus";
            this.pcb_minus.Size = new System.Drawing.Size(29, 33);
            this.pcb_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_minus.TabIndex = 2;
            this.pcb_minus.TabStop = false;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_error.Location = new System.Drawing.Point(18, 292);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(10, 13);
            this.lbl_error.TabIndex = 9;
            this.lbl_error.Text = ".";
            this.lbl_error.Visible = false;
            // 
            // btn_save_user
            // 
            this.btn_save_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_save_user.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_save_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_user.ForeColor = System.Drawing.Color.White;
            this.btn_save_user.Image = global::Presentation.Properties.Resources.icons8_guardar_24;
            this.btn_save_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_user.Location = new System.Drawing.Point(370, 275);
            this.btn_save_user.Name = "btn_save_user";
            this.btn_save_user.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_save_user.Size = new System.Drawing.Size(123, 30);
            this.btn_save_user.TabIndex = 8;
            this.btn_save_user.Text = "Guardar";
            this.btn_save_user.UseVisualStyleBackColor = false;
            this.btn_save_user.Click += new System.EventHandler(this.btn_save_user_Click);
            // 
            // optometrist
            // 
            this.optometrist.AutoSize = true;
            this.optometrist.Location = new System.Drawing.Point(6, 24);
            this.optometrist.Name = "optometrist";
            this.optometrist.Size = new System.Drawing.Size(94, 21);
            this.optometrist.TabIndex = 10;
            this.optometrist.Text = "Optometra";
            this.optometrist.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.manager);
            this.groupBox2.Controls.Add(this.consultant);
            this.groupBox2.Controls.Add(this.optometrist);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 54);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos";
            // 
            // consultant
            // 
            this.consultant.AutoSize = true;
            this.consultant.Location = new System.Drawing.Point(119, 24);
            this.consultant.Name = "consultant";
            this.consultant.Size = new System.Drawing.Size(68, 21);
            this.consultant.TabIndex = 11;
            this.consultant.Text = "Asesor";
            this.consultant.UseVisualStyleBackColor = true;
            // 
            // manager
            // 
            this.manager.AutoSize = true;
            this.manager.Location = new System.Drawing.Point(197, 24);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(67, 21);
            this.manager.TabIndex = 12;
            this.manager.Text = "Gestor";
            this.manager.UseVisualStyleBackColor = true;
            // 
            // UserCreate
            // 
            this.AcceptButton = this.btn_save_user;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 314);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_save_user);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear usuario";
            this.Load += new System.EventHandler(this.UserCreate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_edit_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save_user;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txt_email;
        public System.Windows.Forms.TextBox txt_phone;
        public System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.PictureBox pcb_close_edit_user;
        private System.Windows.Forms.PictureBox pcb_exit;
        private System.Windows.Forms.PictureBox pcb_minus;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox optometrist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox manager;
        private System.Windows.Forms.CheckBox consultant;
    }
}