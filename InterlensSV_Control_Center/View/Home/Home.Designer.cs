
namespace InterlensSV_Control_Center
{
    partial class LayoutHome
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
            this.pnl_top_home = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.pcb_close_home = new System.Windows.Forms.PictureBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_hello_user = new System.Windows.Forms.Label();
            this.pcb_logo_home = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_name_view = new System.Windows.Forms.Panel();
            this.tm_time_system = new System.Windows.Forms.Timer(this.components);
            this.pnl_viewer = new System.Windows.Forms.Panel();
            this.pnl_top_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_home)).BeginInit();
            this.pnl_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo_home)).BeginInit();
            this.pnl_name_view.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top_home
            // 
            this.pnl_top_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(25)))));
            this.pnl_top_home.Controls.Add(this.lbl_date);
            this.pnl_top_home.Controls.Add(this.pcb_close_home);
            this.pnl_top_home.Controls.Add(this.lbl_time);
            this.pnl_top_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top_home.Location = new System.Drawing.Point(207, 0);
            this.pnl_top_home.Name = "pnl_top_home";
            this.pnl_top_home.Size = new System.Drawing.Size(775, 33);
            this.pnl_top_home.TabIndex = 0;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(7, 9);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(152, 17);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "dia, 00 del mes de 0000";
            // 
            // pcb_close_home
            // 
            this.pcb_close_home.Image = global::InterlensSV_Control_Center.Properties.Resources.close;
            this.pcb_close_home.Location = new System.Drawing.Point(741, 4);
            this.pcb_close_home.Name = "pcb_close_home";
            this.pcb_close_home.Size = new System.Drawing.Size(31, 26);
            this.pcb_close_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close_home.TabIndex = 3;
            this.pcb_close_home.TabStop = false;
            this.pcb_close_home.Click += new System.EventHandler(this.pcb_close_home_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(348, 9);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(72, 17);
            this.lbl_time.TabIndex = 2;
            this.lbl_time.Text = "00:00:00 tt";
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.White;
            this.pnl_menu.Controls.Add(this.button8);
            this.pnl_menu.Controls.Add(this.button7);
            this.pnl_menu.Controls.Add(this.button6);
            this.pnl_menu.Controls.Add(this.button5);
            this.pnl_menu.Controls.Add(this.button4);
            this.pnl_menu.Controls.Add(this.button3);
            this.pnl_menu.Controls.Add(this.button2);
            this.pnl_menu.Controls.Add(this.btn_dashboard);
            this.pnl_menu.Controls.Add(this.panel1);
            this.pnl_menu.Controls.Add(this.pcb_logo_home);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(207, 566);
            this.pnl_menu.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(3, 472);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(198, 47);
            this.button8.TabIndex = 22;
            this.button8.Text = "Otro";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(6, 419);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(198, 47);
            this.button7.TabIndex = 21;
            this.button7.Text = "Otro";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(6, 366);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(198, 47);
            this.button6.TabIndex = 20;
            this.button6.Text = "Otro";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(6, 313);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 47);
            this.button5.TabIndex = 19;
            this.button5.Text = "Otro";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(6, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 47);
            this.button4.TabIndex = 18;
            this.button4.Text = "Ventas";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(6, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 47);
            this.button3.TabIndex = 17;
            this.button3.Text = "Inventario";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 47);
            this.button2.TabIndex = 16;
            this.button2.Text = "Clientes";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btn_dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Location = new System.Drawing.Point(3, 101);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(198, 47);
            this.btn_dashboard.TabIndex = 15;
            this.btn_dashboard.Text = "Inicio";
            this.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbl_hello_user);
            this.panel1.Location = new System.Drawing.Point(3, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 56);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterlensSV_Control_Center.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(59, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Rol de Usuario";
            // 
            // lbl_hello_user
            // 
            this.lbl_hello_user.AutoSize = true;
            this.lbl_hello_user.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hello_user.ForeColor = System.Drawing.Color.Black;
            this.lbl_hello_user.Location = new System.Drawing.Point(59, 9);
            this.lbl_hello_user.Name = "lbl_hello_user";
            this.lbl_hello_user.Size = new System.Drawing.Size(92, 17);
            this.lbl_hello_user.TabIndex = 11;
            this.lbl_hello_user.Text = "Hola, Usuario";
            // 
            // pcb_logo_home
            // 
            this.pcb_logo_home.BackColor = System.Drawing.Color.White;
            this.pcb_logo_home.Image = global::InterlensSV_Control_Center.Properties.Resources.logo_horizontal;
            this.pcb_logo_home.Location = new System.Drawing.Point(0, 0);
            this.pcb_logo_home.Name = "pcb_logo_home";
            this.pcb_logo_home.Size = new System.Drawing.Size(207, 33);
            this.pcb_logo_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_logo_home.TabIndex = 2;
            this.pcb_logo_home.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicio";
            // 
            // pnl_name_view
            // 
            this.pnl_name_view.BackColor = System.Drawing.Color.White;
            this.pnl_name_view.Controls.Add(this.label1);
            this.pnl_name_view.Location = new System.Drawing.Point(207, 33);
            this.pnl_name_view.Name = "pnl_name_view";
            this.pnl_name_view.Size = new System.Drawing.Size(775, 31);
            this.pnl_name_view.TabIndex = 4;
            // 
            // tm_time_system
            // 
            this.tm_time_system.Tick += new System.EventHandler(this.tm_time_system_Tick);
            // 
            // pnl_viewer
            // 
            this.pnl_viewer.BackColor = System.Drawing.Color.White;
            this.pnl_viewer.Location = new System.Drawing.Point(210, 65);
            this.pnl_viewer.Name = "pnl_viewer";
            this.pnl_viewer.Size = new System.Drawing.Size(772, 501);
            this.pnl_viewer.TabIndex = 5;
            // 
            // LayoutHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 566);
            this.Controls.Add(this.pnl_viewer);
            this.Controls.Add(this.pnl_name_view);
            this.Controls.Add(this.pnl_top_home);
            this.Controls.Add(this.pnl_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LayoutHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnl_top_home.ResumeLayout(false);
            this.pnl_top_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_home)).EndInit();
            this.pnl_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo_home)).EndInit();
            this.pnl_name_view.ResumeLayout(false);
            this.pnl_name_view.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top_home;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.PictureBox pcb_logo_home;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_name_view;
        private System.Windows.Forms.PictureBox pcb_close_home;
        private System.Windows.Forms.Timer tm_time_system;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_hello_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnl_viewer;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_dashboard;
    }
}

