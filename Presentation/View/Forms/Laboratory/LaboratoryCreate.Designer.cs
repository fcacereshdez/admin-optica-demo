
namespace Presentation.View.Forms.Laboratory
{
    partial class LaboratoryCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaboratoryCreate));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.pcb_close_laboratory = new System.Windows.Forms.PictureBox();
            this.pcb_exit = new System.Windows.Forms.PictureBox();
            this.pcb_minus = new System.Windows.Forms.PictureBox();
            this.txt_laboratory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.btn_save_laboratory = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_laboratory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.label15);
            this.pnl_top.Controls.Add(this.pcb_close_laboratory);
            this.pnl_top.Controls.Add(this.pcb_exit);
            this.pnl_top.Controls.Add(this.pcb_minus);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(526, 29);
            this.pnl_top.TabIndex = 83;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(11, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "Crear laboratorio";
            // 
            // pcb_close_laboratory
            // 
            this.pcb_close_laboratory.Image = global::Presentation.Properties.Resources.close;
            this.pcb_close_laboratory.Location = new System.Drawing.Point(497, 2);
            this.pcb_close_laboratory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_close_laboratory.Name = "pcb_close_laboratory";
            this.pcb_close_laboratory.Size = new System.Drawing.Size(25, 25);
            this.pcb_close_laboratory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close_laboratory.TabIndex = 4;
            this.pcb_close_laboratory.TabStop = false;
            this.pcb_close_laboratory.Click += new System.EventHandler(this.pcb_close_laboratory_Click);
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
            // txt_laboratory
            // 
            this.txt_laboratory.Location = new System.Drawing.Point(90, 48);
            this.txt_laboratory.Name = "txt_laboratory";
            this.txt_laboratory.Size = new System.Drawing.Size(235, 23);
            this.txt_laboratory.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 85;
            this.label1.Text = "Laboratorio:";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(393, 48);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(129, 23);
            this.txt_phone.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 87;
            this.label2.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 89;
            this.label3.Text = "Dirección:";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(90, 86);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(432, 23);
            this.txt_address.TabIndex = 90;
            // 
            // btn_save_laboratory
            // 
            this.btn_save_laboratory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_save_laboratory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_save_laboratory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_laboratory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_laboratory.ForeColor = System.Drawing.Color.White;
            this.btn_save_laboratory.Image = global::Presentation.Properties.Resources.icons8_guardar_24;
            this.btn_save_laboratory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_laboratory.Location = new System.Drawing.Point(387, 115);
            this.btn_save_laboratory.Name = "btn_save_laboratory";
            this.btn_save_laboratory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_save_laboratory.Size = new System.Drawing.Size(135, 30);
            this.btn_save_laboratory.TabIndex = 98;
            this.btn_save_laboratory.Text = "Guardar";
            this.btn_save_laboratory.UseVisualStyleBackColor = false;
            this.btn_save_laboratory.Click += new System.EventHandler(this.btn_save_laboratory_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(13, 130);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(10, 15);
            this.lbl_error.TabIndex = 99;
            this.lbl_error.Text = ".";
            // 
            // LaboratoryCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 156);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_save_laboratory);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_laboratory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LaboratoryCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear laboratorio";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_laboratory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pcb_close_laboratory;
        private System.Windows.Forms.PictureBox pcb_exit;
        private System.Windows.Forms.PictureBox pcb_minus;
        private System.Windows.Forms.TextBox txt_laboratory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Button btn_save_laboratory;
        private System.Windows.Forms.Label lbl_error;
    }
}