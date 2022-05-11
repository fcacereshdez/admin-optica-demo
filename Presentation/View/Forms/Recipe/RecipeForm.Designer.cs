
namespace Presentation.View.Forms.Recipe
{
    partial class RecipeForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_search_company = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_recipes = new System.Windows.Forms.DataGridView();
            this.btn_report_recipe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_create_recipe = new System.Windows.Forms.Button();
            this.btn_delete_recipe = new System.Windows.Forms.Button();
            this.btn_edit_recipe = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recipes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_report_recipe);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(25, 222);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(177, 105);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comunes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_search_company);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(208, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(617, 55);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // txt_search_company
            // 
            this.txt_search_company.Location = new System.Drawing.Point(61, 18);
            this.txt_search_company.Name = "txt_search_company";
            this.txt_search_company.Size = new System.Drawing.Size(550, 25);
            this.txt_search_company.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_create_recipe);
            this.groupBox1.Controls.Add(this.btn_delete_recipe);
            this.groupBox1.Controls.Add(this.btn_edit_recipe);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(25, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(177, 143);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // dgv_recipes
            // 
            this.dgv_recipes.AllowUserToAddRows = false;
            this.dgv_recipes.AllowUserToDeleteRows = false;
            this.dgv_recipes.AllowUserToOrderColumns = true;
            this.dgv_recipes.AllowUserToResizeColumns = false;
            this.dgv_recipes.AllowUserToResizeRows = false;
            this.dgv_recipes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.dgv_recipes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_recipes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_recipes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_recipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_recipes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_recipes.EnableHeadersVisualStyles = false;
            this.dgv_recipes.Location = new System.Drawing.Point(208, 80);
            this.dgv_recipes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_recipes.MultiSelect = false;
            this.dgv_recipes.Name = "dgv_recipes";
            this.dgv_recipes.ReadOnly = true;
            this.dgv_recipes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_recipes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_recipes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_recipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_recipes.Size = new System.Drawing.Size(617, 413);
            this.dgv_recipes.TabIndex = 14;
            // 
            // btn_report_recipe
            // 
            this.btn_report_recipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_report_recipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_report_recipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report_recipe.ForeColor = System.Drawing.Color.White;
            this.btn_report_recipe.Image = global::Presentation.Properties.Resources.icons8_asignación_entregado_24__1_;
            this.btn_report_recipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report_recipe.Location = new System.Drawing.Point(15, 61);
            this.btn_report_recipe.Name = "btn_report_recipe";
            this.btn_report_recipe.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_report_recipe.Size = new System.Drawing.Size(143, 30);
            this.btn_report_recipe.TabIndex = 6;
            this.btn_report_recipe.Text = "Exportar";
            this.btn_report_recipe.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Presentation.Properties.Resources.icons8_asignación_entregado_24__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 25);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.button1.Size = new System.Drawing.Size(143, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_create_recipe
            // 
            this.btn_create_recipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_recipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_recipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_recipe.ForeColor = System.Drawing.Color.White;
            this.btn_create_recipe.Image = global::Presentation.Properties.Resources.icons8_añadir_24;
            this.btn_create_recipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_create_recipe.Location = new System.Drawing.Point(15, 61);
            this.btn_create_recipe.Name = "btn_create_recipe";
            this.btn_create_recipe.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_create_recipe.Size = new System.Drawing.Size(143, 30);
            this.btn_create_recipe.TabIndex = 1;
            this.btn_create_recipe.Text = "Crear";
            this.btn_create_recipe.UseVisualStyleBackColor = false;
            this.btn_create_recipe.Click += new System.EventHandler(this.btn_create_recipe_Click);
            // 
            // btn_delete_recipe
            // 
            this.btn_delete_recipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_delete_recipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_delete_recipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_recipe.ForeColor = System.Drawing.Color.White;
            this.btn_delete_recipe.Image = global::Presentation.Properties.Resources.icons8_eliminar_241;
            this.btn_delete_recipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete_recipe.Location = new System.Drawing.Point(15, 97);
            this.btn_delete_recipe.Name = "btn_delete_recipe";
            this.btn_delete_recipe.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_delete_recipe.Size = new System.Drawing.Size(143, 30);
            this.btn_delete_recipe.TabIndex = 2;
            this.btn_delete_recipe.Text = "Eliminar";
            this.btn_delete_recipe.UseVisualStyleBackColor = false;
            // 
            // btn_edit_recipe
            // 
            this.btn_edit_recipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_edit_recipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_edit_recipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_recipe.ForeColor = System.Drawing.Color.White;
            this.btn_edit_recipe.Image = global::Presentation.Properties.Resources.icons8_editar_24;
            this.btn_edit_recipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit_recipe.Location = new System.Drawing.Point(15, 25);
            this.btn_edit_recipe.Name = "btn_edit_recipe";
            this.btn_edit_recipe.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btn_edit_recipe.Size = new System.Drawing.Size(143, 30);
            this.btn_edit_recipe.TabIndex = 1;
            this.btn_edit_recipe.Text = "Editar";
            this.btn_edit_recipe.UseVisualStyleBackColor = false;
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_recipes);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RecipeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recetas";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recipes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_report_recipe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_search_company;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_create_recipe;
        private System.Windows.Forms.Button btn_delete_recipe;
        private System.Windows.Forms.Button btn_edit_recipe;
        public System.Windows.Forms.DataGridView dgv_recipes;
    }
}