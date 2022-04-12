
namespace Presentation.View.Forms
{
    partial class Login
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
            this.pnl_left = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_msg_error = new System.Windows.Forms.Label();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.pcb_exit = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.pnl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.White;
            this.pnl_left.Controls.Add(this.label1);
            this.pnl_left.Controls.Add(this.pictureBox1);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(419, 361);
            this.pnl_left.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(47, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Copyrigth 2022 © Todos los derechos reservados.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.logo_horizontal;
            this.pictureBox1.Location = new System.Drawing.Point(50, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_msg_error
            // 
            this.lbl_msg_error.AutoSize = true;
            this.lbl_msg_error.ForeColor = System.Drawing.Color.White;
            this.lbl_msg_error.Location = new System.Drawing.Point(21, 324);
            this.lbl_msg_error.Name = "lbl_msg_error";
            this.lbl_msg_error.Size = new System.Drawing.Size(265, 17);
            this.lbl_msg_error.TabIndex = 6;
            this.lbl_msg_error.Text = "* El usuario o la contraseña son incorrectos.";
            this.lbl_msg_error.Visible = false;
            // 
            // pnl_right
            // 
            this.pnl_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_right.Controls.Add(this.pcb_exit);
            this.pnl_right.Controls.Add(this.btn_login);
            this.pnl_right.Controls.Add(this.lbl_msg_error);
            this.pnl_right.Controls.Add(this.label3);
            this.pnl_right.Controls.Add(this.label2);
            this.pnl_right.Controls.Add(this.txt_password);
            this.pnl_right.Controls.Add(this.txt_user);
            this.pnl_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_right.Location = new System.Drawing.Point(419, 0);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(298, 361);
            this.pnl_right.TabIndex = 1;
            // 
            // pcb_exit
            // 
            this.pcb_exit.Image = global::Presentation.Properties.Resources.close;
            this.pcb_exit.Location = new System.Drawing.Point(270, 3);
            this.pcb_exit.Name = "pcb_exit";
            this.pcb_exit.Size = new System.Drawing.Size(25, 25);
            this.pcb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_exit.TabIndex = 7;
            this.pcb_exit.TabStop = false;
            this.pcb_exit.Click += new System.EventHandler(this.pcb_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(41, 240);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(109, 37);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Entrar";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(41, 189);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(224, 25);
            this.txt_password.TabIndex = 2;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(41, 136);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(224, 25);
            this.txt_user.TabIndex = 1;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 361);
            this.Controls.Add(this.pnl_right);
            this.Controls.Add(this.pnl_left);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auth";
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_right.ResumeLayout(false);
            this.pnl_right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_msg_error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcb_exit;
    }
}