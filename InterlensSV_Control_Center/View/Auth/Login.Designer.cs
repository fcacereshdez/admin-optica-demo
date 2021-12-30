
namespace InterlensSV_Control_Center.View.Auth
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_login_text = new System.Windows.Forms.Label();
            this.lbl_name_business = new System.Windows.Forms.Label();
            this.lbl_info_business = new System.Windows.Forms.Label();
            this.lbl_copyrigth = new System.Windows.Forms.Label();
            this.pcb_logo_business = new System.Windows.Forms.PictureBox();
            this.pcb_close = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo_business)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.pcb_close);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.lbl_login_text);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(358, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 384);
            this.panel1.TabIndex = 0;
            // 
            // txt_user
            // 
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(42, 167);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(191, 29);
            this.txt_user.TabIndex = 9;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.btn_login.Location = new System.Drawing.Point(42, 249);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(85, 33);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Entrar";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(42, 202);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(191, 29);
            this.txt_password.TabIndex = 7;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // lbl_login_text
            // 
            this.lbl_login_text.AutoSize = true;
            this.lbl_login_text.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_text.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_text.ForeColor = System.Drawing.Color.White;
            this.lbl_login_text.Location = new System.Drawing.Point(37, 127);
            this.lbl_login_text.Name = "lbl_login_text";
            this.lbl_login_text.Size = new System.Drawing.Size(127, 25);
            this.lbl_login_text.TabIndex = 5;
            this.lbl_login_text.Text = "Iniciar sesión";
            // 
            // lbl_name_business
            // 
            this.lbl_name_business.AutoSize = true;
            this.lbl_name_business.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_business.ForeColor = System.Drawing.Color.Black;
            this.lbl_name_business.Location = new System.Drawing.Point(49, 157);
            this.lbl_name_business.Name = "lbl_name_business";
            this.lbl_name_business.Size = new System.Drawing.Size(99, 30);
            this.lbl_name_business.TabIndex = 2;
            this.lbl_name_business.Text = "Interlens";
            // 
            // lbl_info_business
            // 
            this.lbl_info_business.AutoSize = true;
            this.lbl_info_business.BackColor = System.Drawing.Color.White;
            this.lbl_info_business.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_business.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(128)))), ((int)(((byte)(131)))));
            this.lbl_info_business.Location = new System.Drawing.Point(51, 187);
            this.lbl_info_business.Name = "lbl_info_business";
            this.lbl_info_business.Size = new System.Drawing.Size(254, 85);
            this.lbl_info_business.TabIndex = 3;
            this.lbl_info_business.Text = "Somos una óptica empresarial,\r\ncomprometida con la salud visual de los\r\nsalvadore" +
    "ños, brindandoles un servicio\r\nexclusivo y de calidad, buscando día a día\r\nla ex" +
    "celencia para nuestros clientes.";
            // 
            // lbl_copyrigth
            // 
            this.lbl_copyrigth.AutoSize = true;
            this.lbl_copyrigth.BackColor = System.Drawing.Color.White;
            this.lbl_copyrigth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_copyrigth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(128)))), ((int)(((byte)(131)))));
            this.lbl_copyrigth.Location = new System.Drawing.Point(51, 358);
            this.lbl_copyrigth.Name = "lbl_copyrigth";
            this.lbl_copyrigth.Size = new System.Drawing.Size(243, 17);
            this.lbl_copyrigth.TabIndex = 4;
            this.lbl_copyrigth.Text = "© Todos los derechos reservados, 2021";
            // 
            // pcb_logo_business
            // 
            this.pcb_logo_business.Image = global::InterlensSV_Control_Center.Properties.Resources.logo_horizontal;
            this.pcb_logo_business.Location = new System.Drawing.Point(51, 45);
            this.pcb_logo_business.Name = "pcb_logo_business";
            this.pcb_logo_business.Size = new System.Drawing.Size(252, 75);
            this.pcb_logo_business.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_logo_business.TabIndex = 1;
            this.pcb_logo_business.TabStop = false;
            // 
            // pcb_close
            // 
            this.pcb_close.Image = global::InterlensSV_Control_Center.Properties.Resources.close;
            this.pcb_close.Location = new System.Drawing.Point(222, 12);
            this.pcb_close.Name = "pcb_close";
            this.pcb_close.Size = new System.Drawing.Size(33, 33);
            this.pcb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close.TabIndex = 10;
            this.pcb_close.TabStop = false;
            this.pcb_close.Click += new System.EventHandler(this.pcb_close_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 384);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_copyrigth);
            this.Controls.Add(this.lbl_info_business);
            this.Controls.Add(this.lbl_name_business);
            this.Controls.Add(this.pcb_logo_business);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo_business)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcb_logo_business;
        private System.Windows.Forms.Label lbl_name_business;
        private System.Windows.Forms.Label lbl_info_business;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_login_text;
        private System.Windows.Forms.Label lbl_copyrigth;
        private System.Windows.Forms.PictureBox pcb_close;
    }
}