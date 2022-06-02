
namespace Presentation.View.Forms.Client
{
    partial class ClaimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClaimForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_search_client = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_claims = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_create_claim = new System.Windows.Forms.Button();
            this.btn_delete_claim = new System.Windows.Forms.Button();
            this.btn_edit_claim = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_claims)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_search_client);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(198, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(637, 55);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // txt_search_client
            // 
            this.txt_search_client.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search_client.Location = new System.Drawing.Point(71, 19);
            this.txt_search_client.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search_client.Name = "txt_search_client";
            this.txt_search_client.Size = new System.Drawing.Size(560, 23);
            this.txt_search_client.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // dgv_claims
            // 
            this.dgv_claims.AllowUserToAddRows = false;
            this.dgv_claims.AllowUserToDeleteRows = false;
            this.dgv_claims.AllowUserToOrderColumns = true;
            this.dgv_claims.AllowUserToResizeColumns = false;
            this.dgv_claims.AllowUserToResizeRows = false;
            this.dgv_claims.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_claims.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.dgv_claims.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_claims.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(171)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_claims.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_claims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_claims.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_claims.EnableHeadersVisualStyles = false;
            this.dgv_claims.Location = new System.Drawing.Point(198, 85);
            this.dgv_claims.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgv_claims.MultiSelect = false;
            this.dgv_claims.Name = "dgv_claims";
            this.dgv_claims.ReadOnly = true;
            this.dgv_claims.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_claims.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_claims.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_claims.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_claims.Size = new System.Drawing.Size(637, 442);
            this.dgv_claims.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_create_claim);
            this.groupBox1.Controls.Add(this.btn_delete_claim);
            this.groupBox1.Controls.Add(this.btn_edit_claim);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(15, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(177, 152);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funciones";
            // 
            // btn_create_claim
            // 
            this.btn_create_claim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_claim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_create_claim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_claim.ForeColor = System.Drawing.Color.White;
            this.btn_create_claim.Image = global::Presentation.Properties.Resources.icons8_añadir_24;
            this.btn_create_claim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_create_claim.Location = new System.Drawing.Point(18, 65);
            this.btn_create_claim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_create_claim.Name = "btn_create_claim";
            this.btn_create_claim.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.btn_create_claim.Size = new System.Drawing.Size(143, 30);
            this.btn_create_claim.TabIndex = 1;
            this.btn_create_claim.Text = "Crear";
            this.btn_create_claim.UseVisualStyleBackColor = false;
            this.btn_create_claim.Click += new System.EventHandler(this.btn_create_claim_Click);
            // 
            // btn_delete_claim
            // 
            this.btn_delete_claim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_delete_claim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_delete_claim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_claim.ForeColor = System.Drawing.Color.White;
            this.btn_delete_claim.Image = global::Presentation.Properties.Resources.icons8_eliminar_241;
            this.btn_delete_claim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete_claim.Location = new System.Drawing.Point(18, 103);
            this.btn_delete_claim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete_claim.Name = "btn_delete_claim";
            this.btn_delete_claim.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.btn_delete_claim.Size = new System.Drawing.Size(143, 30);
            this.btn_delete_claim.TabIndex = 2;
            this.btn_delete_claim.Text = "Eliminar";
            this.btn_delete_claim.UseVisualStyleBackColor = false;
            // 
            // btn_edit_claim
            // 
            this.btn_edit_claim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_edit_claim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(56)))), ((int)(((byte)(45)))));
            this.btn_edit_claim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_claim.ForeColor = System.Drawing.Color.White;
            this.btn_edit_claim.Image = global::Presentation.Properties.Resources.icons8_editar_24;
            this.btn_edit_claim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit_claim.Location = new System.Drawing.Point(18, 27);
            this.btn_edit_claim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_edit_claim.Name = "btn_edit_claim";
            this.btn_edit_claim.Padding = new System.Windows.Forms.Padding(17, 0, 6, 0);
            this.btn_edit_claim.Size = new System.Drawing.Size(143, 30);
            this.btn_edit_claim.TabIndex = 1;
            this.btn_edit_claim.Text = "Editar";
            this.btn_edit_claim.UseVisualStyleBackColor = false;
            // 
            // ClaimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_claims);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClaimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reclamos";
            this.Load += new System.EventHandler(this.ClaimForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_claims)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_search_client;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_claims;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_create_claim;
        private System.Windows.Forms.Button btn_delete_claim;
        private System.Windows.Forms.Button btn_edit_claim;
    }
}