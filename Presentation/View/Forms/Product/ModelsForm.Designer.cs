
namespace Presentation.View.Forms.Product
{
    partial class ModelsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelsForm));
            this.dgv_models = new System.Windows.Forms.DataGridView();
            this.btn_save_model = new System.Windows.Forms.Button();
            this.txt_model_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.pcb_close_models = new System.Windows.Forms.PictureBox();
            this.pcb_exit = new System.Windows.Forms.PictureBox();
            this.pcb_minus = new System.Windows.Forms.PictureBox();
            this.txt_action = new System.Windows.Forms.TextBox();
            this.txt_model_id = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_models)).BeginInit();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_models)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_models
            // 
            this.dgv_models.AllowUserToAddRows = false;
            this.dgv_models.AllowUserToDeleteRows = false;
            this.dgv_models.AllowUserToOrderColumns = true;
            this.dgv_models.AllowUserToResizeColumns = false;
            this.dgv_models.AllowUserToResizeRows = false;
            this.dgv_models.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.dgv_models.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_models.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_models.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_models.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_models.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_models.EnableHeadersVisualStyles = false;
            this.dgv_models.Location = new System.Drawing.Point(326, 46);
            this.dgv_models.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_models.MultiSelect = false;
            this.dgv_models.Name = "dgv_models";
            this.dgv_models.ReadOnly = true;
            this.dgv_models.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_models.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_models.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_models.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_models.Size = new System.Drawing.Size(349, 141);
            this.dgv_models.TabIndex = 90;
            this.dgv_models.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_models_CellDoubleClick);
            // 
            // btn_save_model
            // 
            this.btn_save_model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_save_model.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_save_model.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_model.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_model.ForeColor = System.Drawing.Color.White;
            this.btn_save_model.Image = global::Presentation.Properties.Resources.icons8_guardar_24;
            this.btn_save_model.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_model.Location = new System.Drawing.Point(158, 104);
            this.btn_save_model.Name = "btn_save_model";
            this.btn_save_model.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_save_model.Size = new System.Drawing.Size(135, 30);
            this.btn_save_model.TabIndex = 89;
            this.btn_save_model.Text = "Guardar";
            this.btn_save_model.UseVisualStyleBackColor = false;
            this.btn_save_model.Click += new System.EventHandler(this.btn_save_model_Click);
            // 
            // txt_model_name
            // 
            this.txt_model_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_model_name.Location = new System.Drawing.Point(73, 74);
            this.txt_model_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_model_name.Name = "txt_model_name";
            this.txt_model_name.Size = new System.Drawing.Size(220, 23);
            this.txt_model_name.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 87;
            this.label3.Text = "Modelo:";
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.label15);
            this.pnl_top.Controls.Add(this.pcb_close_models);
            this.pnl_top.Controls.Add(this.pcb_exit);
            this.pnl_top.Controls.Add(this.pcb_minus);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(687, 29);
            this.pnl_top.TabIndex = 86;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(11, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "Modelos";
            // 
            // pcb_close_models
            // 
            this.pcb_close_models.Image = global::Presentation.Properties.Resources.close;
            this.pcb_close_models.Location = new System.Drawing.Point(659, 4);
            this.pcb_close_models.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_close_models.Name = "pcb_close_models";
            this.pcb_close_models.Size = new System.Drawing.Size(25, 25);
            this.pcb_close_models.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close_models.TabIndex = 4;
            this.pcb_close_models.TabStop = false;
            this.pcb_close_models.Click += new System.EventHandler(this.pcb_close_models_Click);
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
            // txt_action
            // 
            this.txt_action.Location = new System.Drawing.Point(185, 167);
            this.txt_action.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_action.Name = "txt_action";
            this.txt_action.Size = new System.Drawing.Size(86, 20);
            this.txt_action.TabIndex = 92;
            this.txt_action.Visible = false;
            // 
            // txt_model_id
            // 
            this.txt_model_id.Location = new System.Drawing.Point(277, 167);
            this.txt_model_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_model_id.Name = "txt_model_id";
            this.txt_model_id.Size = new System.Drawing.Size(43, 20);
            this.txt_model_id.TabIndex = 91;
            this.txt_model_id.Visible = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = global::Presentation.Properties.Resources.icons8_eliminar_24;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(540, 194);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_delete.Size = new System.Drawing.Size(135, 30);
            this.btn_delete.TabIndex = 93;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // ModelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 236);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_action);
            this.Controls.Add(this.txt_model_id);
            this.Controls.Add(this.dgv_models);
            this.Controls.Add(this.btn_save_model);
            this.Controls.Add(this.txt_model_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModelsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_models)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_models)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_minus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_models;
        private System.Windows.Forms.Button btn_save_model;
        public System.Windows.Forms.TextBox txt_model_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pcb_close_models;
        private System.Windows.Forms.PictureBox pcb_exit;
        private System.Windows.Forms.PictureBox pcb_minus;
        public System.Windows.Forms.TextBox txt_action;
        public System.Windows.Forms.TextBox txt_model_id;
        private System.Windows.Forms.Button btn_delete;
    }
}