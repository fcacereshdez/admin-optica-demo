
namespace Presentation
{
    partial class Layout
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcb_logout = new System.Windows.Forms.PictureBox();
            this.lbl_role_name = new System.Windows.Forms.Label();
            this.lbl_name_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_labs = new System.Windows.Forms.Button();
            this.btn_clients = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pcb_exit = new System.Windows.Forms.PictureBox();
            this.pcb_minus = new System.Windows.Forms.PictureBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.lbl_version_sw = new System.Windows.Forms.Label();
            this.lbl_name_pc = new System.Windows.Forms.Label();
            this.pnl_layout = new System.Windows.Forms.Panel();
            this.pcb_logo = new System.Windows.Forms.PictureBox();
            this.pnl_name_view = new System.Windows.Forms.Panel();
            this.lbl_form_name = new System.Windows.Forms.Label();
            this.tmr_layout = new System.Windows.Forms.Timer(this.components);
            this.pcb_close_form = new System.Windows.Forms.PictureBox();
            this.pnl_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).BeginInit();
            this.pnl_bottom.SuspendLayout();
            this.pnl_layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).BeginInit();
            this.pnl_name_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_form)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_menu.Controls.Add(this.panel1);
            this.pnl_menu.Controls.Add(this.btn_user);
            this.pnl_menu.Controls.Add(this.btn_labs);
            this.pnl_menu.Controls.Add(this.btn_clients);
            this.pnl_menu.Controls.Add(this.btn_dashboard);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 32);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(205, 480);
            this.pnl_menu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pcb_logout);
            this.panel1.Controls.Add(this.lbl_role_name);
            this.panel1.Controls.Add(this.lbl_name_user);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 60);
            this.panel1.TabIndex = 4;
            // 
            // pcb_logout
            // 
            this.pcb_logout.Image = global::Presentation.Properties.Resources.power_off;
            this.pcb_logout.Location = new System.Drawing.Point(174, 20);
            this.pcb_logout.Name = "pcb_logout";
            this.pcb_logout.Size = new System.Drawing.Size(20, 20);
            this.pcb_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_logout.TabIndex = 3;
            this.pcb_logout.TabStop = false;
            this.pcb_logout.Click += new System.EventHandler(this.pcb_logout_Click);
            // 
            // lbl_role_name
            // 
            this.lbl_role_name.AutoSize = true;
            this.lbl_role_name.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role_name.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_role_name.Location = new System.Drawing.Point(55, 31);
            this.lbl_role_name.Name = "lbl_role_name";
            this.lbl_role_name.Size = new System.Drawing.Size(30, 13);
            this.lbl_role_name.TabIndex = 2;
            this.lbl_role_name.Text = "Role";
            // 
            // lbl_name_user
            // 
            this.lbl_name_user.AutoSize = true;
            this.lbl_name_user.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_user.Location = new System.Drawing.Point(55, 14);
            this.lbl_name_user.Name = "lbl_name_user";
            this.lbl_name_user.Size = new System.Drawing.Size(71, 17);
            this.lbl_name_user.TabIndex = 1;
            this.lbl_name_user.Text = "Full Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_user
            // 
            this.btn_user.FlatAppearance.BorderSize = 0;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Image = global::Presentation.Properties.Resources.customer1;
            this.btn_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user.Location = new System.Drawing.Point(2, 218);
            this.btn_user.Name = "btn_user";
            this.btn_user.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.btn_user.Size = new System.Drawing.Size(200, 41);
            this.btn_user.TabIndex = 3;
            this.btn_user.Text = "Usuarios";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_labs
            // 
            this.btn_labs.FlatAppearance.BorderSize = 0;
            this.btn_labs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_labs.Image = global::Presentation.Properties.Resources.puzzle;
            this.btn_labs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_labs.Location = new System.Drawing.Point(2, 171);
            this.btn_labs.Name = "btn_labs";
            this.btn_labs.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.btn_labs.Size = new System.Drawing.Size(200, 41);
            this.btn_labs.TabIndex = 2;
            this.btn_labs.Text = "Laboratorios";
            this.btn_labs.UseVisualStyleBackColor = true;
            // 
            // btn_clients
            // 
            this.btn_clients.FlatAppearance.BorderSize = 0;
            this.btn_clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clients.Image = global::Presentation.Properties.Resources.costumer;
            this.btn_clients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clients.Location = new System.Drawing.Point(2, 124);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.btn_clients.Size = new System.Drawing.Size(200, 41);
            this.btn_clients.TabIndex = 1;
            this.btn_clients.Text = "Clientes";
            this.btn_clients.UseVisualStyleBackColor = true;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Image = global::Presentation.Properties.Resources.dashboard;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(3, 77);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.btn_dashboard.Size = new System.Drawing.Size(200, 41);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "Inicio";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.pcb_exit);
            this.pnl_top.Controls.Add(this.pcb_minus);
            this.pnl_top.Controls.Add(this.lbl_time);
            this.pnl_top.Controls.Add(this.lbl_date);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1049, 32);
            this.pnl_top.TabIndex = 1;
            // 
            // pcb_exit
            // 
            this.pcb_exit.Image = global::Presentation.Properties.Resources.close;
            this.pcb_exit.Location = new System.Drawing.Point(1021, 4);
            this.pcb_exit.Name = "pcb_exit";
            this.pcb_exit.Size = new System.Drawing.Size(25, 25);
            this.pcb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_exit.TabIndex = 3;
            this.pcb_exit.TabStop = false;
            this.pcb_exit.Click += new System.EventHandler(this.pcb_exit_Click);
            // 
            // pcb_minus
            // 
            this.pcb_minus.Image = global::Presentation.Properties.Resources.minus;
            this.pcb_minus.Location = new System.Drawing.Point(990, 4);
            this.pcb_minus.Name = "pcb_minus";
            this.pcb_minus.Size = new System.Drawing.Size(25, 25);
            this.pcb_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_minus.TabIndex = 2;
            this.pcb_minus.TabStop = false;
            this.pcb_minus.Click += new System.EventHandler(this.pcb_minus_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(525, 9);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(68, 15);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "00:00:00 tt";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(3, 9);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(109, 15);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "00 de ---- de 0000";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(142)))), ((int)(((byte)(4)))));
            this.pnl_bottom.Controls.Add(this.lbl_version_sw);
            this.pnl_bottom.Controls.Add(this.lbl_name_pc);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 512);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(1049, 25);
            this.pnl_bottom.TabIndex = 2;
            // 
            // lbl_version_sw
            // 
            this.lbl_version_sw.AutoSize = true;
            this.lbl_version_sw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_version_sw.ForeColor = System.Drawing.Color.Black;
            this.lbl_version_sw.Location = new System.Drawing.Point(998, 5);
            this.lbl_version_sw.Name = "lbl_version_sw";
            this.lbl_version_sw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_version_sw.Size = new System.Drawing.Size(51, 15);
            this.lbl_version_sw.TabIndex = 3;
            this.lbl_version_sw.Text = "v0.0.0.0";
            this.lbl_version_sw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_name_pc
            // 
            this.lbl_name_pc.AutoSize = true;
            this.lbl_name_pc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_pc.ForeColor = System.Drawing.Color.Black;
            this.lbl_name_pc.Location = new System.Drawing.Point(5, 5);
            this.lbl_name_pc.Name = "lbl_name_pc";
            this.lbl_name_pc.Size = new System.Drawing.Size(99, 15);
            this.lbl_name_pc.TabIndex = 2;
            this.lbl_name_pc.Text = "DESKTOP_NAME";
            this.lbl_name_pc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_layout
            // 
            this.pnl_layout.BackColor = System.Drawing.Color.White;
            this.pnl_layout.Controls.Add(this.pcb_logo);
            this.pnl_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_layout.Location = new System.Drawing.Point(205, 32);
            this.pnl_layout.Name = "pnl_layout";
            this.pnl_layout.Size = new System.Drawing.Size(844, 480);
            this.pnl_layout.TabIndex = 3;
            // 
            // pcb_logo
            // 
            this.pcb_logo.Image = global::Presentation.Properties.Resources.logo_horizontal;
            this.pcb_logo.Location = new System.Drawing.Point(143, 208);
            this.pcb_logo.Name = "pcb_logo";
            this.pcb_logo.Size = new System.Drawing.Size(569, 60);
            this.pcb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_logo.TabIndex = 0;
            this.pcb_logo.TabStop = false;
            // 
            // pnl_name_view
            // 
            this.pnl_name_view.BackColor = System.Drawing.Color.White;
            this.pnl_name_view.Controls.Add(this.pcb_close_form);
            this.pnl_name_view.Controls.Add(this.lbl_form_name);
            this.pnl_name_view.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_name_view.Location = new System.Drawing.Point(205, 32);
            this.pnl_name_view.Name = "pnl_name_view";
            this.pnl_name_view.Size = new System.Drawing.Size(844, 26);
            this.pnl_name_view.TabIndex = 4;
            // 
            // lbl_form_name
            // 
            this.lbl_form_name.AutoSize = true;
            this.lbl_form_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form_name.Location = new System.Drawing.Point(5, 5);
            this.lbl_form_name.Name = "lbl_form_name";
            this.lbl_form_name.Size = new System.Drawing.Size(0, 15);
            this.lbl_form_name.TabIndex = 0;
            // 
            // tmr_layout
            // 
            this.tmr_layout.Enabled = true;
            this.tmr_layout.Tick += new System.EventHandler(this.tmr_layout_Tick);
            // 
            // pcb_close_form
            // 
            this.pcb_close_form.Image = global::Presentation.Properties.Resources.close_eyes;
            this.pcb_close_form.Location = new System.Drawing.Point(821, 3);
            this.pcb_close_form.Name = "pcb_close_form";
            this.pcb_close_form.Size = new System.Drawing.Size(20, 20);
            this.pcb_close_form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close_form.TabIndex = 1;
            this.pcb_close_form.TabStop = false;
            this.pcb_close_form.Visible = false;
            this.pcb_close_form.Click += new System.EventHandler(this.pcb_close_form_Click);
            // 
            // Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 537);
            this.Controls.Add(this.pnl_name_view);
            this.Controls.Add(this.pnl_layout);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Layout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.pnl_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).EndInit();
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_bottom.PerformLayout();
            this.pnl_layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).EndInit();
            this.pnl_name_view.ResumeLayout(false);
            this.pnl_name_view.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_form)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Panel pnl_layout;
        private System.Windows.Forms.Panel pnl_name_view;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_name_pc;
        private System.Windows.Forms.PictureBox pcb_exit;
        private System.Windows.Forms.PictureBox pcb_minus;
        private System.Windows.Forms.Timer tmr_layout;
        private System.Windows.Forms.Label lbl_form_name;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_labs;
        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcb_logout;
        private System.Windows.Forms.Label lbl_role_name;
        private System.Windows.Forms.Label lbl_name_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcb_logo;
        private System.Windows.Forms.Label lbl_version_sw;
        private System.Windows.Forms.PictureBox pcb_close_form;
    }
}

