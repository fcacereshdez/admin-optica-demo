
namespace Presentation.View.Reports
{
    partial class ViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewerForm));
            this.rv_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pcb_close_edit_company = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_edit_company)).BeginInit();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // rv_viewer
            // 
            this.rv_viewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rv_viewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rv_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_viewer.DocumentMapCollapsed = true;
            this.rv_viewer.Location = new System.Drawing.Point(0, 31);
            this.rv_viewer.Name = "rv_viewer";
            this.rv_viewer.ServerReport.BearerToken = null;
            this.rv_viewer.Size = new System.Drawing.Size(864, 425);
            this.rv_viewer.TabIndex = 25;
            // 
            // pcb_close_edit_company
            // 
            this.pcb_close_edit_company.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcb_close_edit_company.Image = global::Presentation.Properties.Resources.close;
            this.pcb_close_edit_company.Location = new System.Drawing.Point(836, 2);
            this.pcb_close_edit_company.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_close_edit_company.Name = "pcb_close_edit_company";
            this.pcb_close_edit_company.Size = new System.Drawing.Size(25, 25);
            this.pcb_close_edit_company.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close_edit_company.TabIndex = 4;
            this.pcb_close_edit_company.TabStop = false;
            this.pcb_close_edit_company.Click += new System.EventHandler(this.pcb_close_edit_company_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Visor de reportes";
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.label10);
            this.pnl_top.Controls.Add(this.pcb_close_edit_company);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(864, 31);
            this.pnl_top.TabIndex = 24;
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 456);
            this.Controls.Add(this.rv_viewer);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor de informes";
            this.Load += new System.EventHandler(this.ViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close_edit_company)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Microsoft.Reporting.WinForms.ReportViewer rv_viewer;
        private System.Windows.Forms.PictureBox pcb_close_edit_company;
        private System.Windows.Forms.Panel pnl_top;
        public System.Windows.Forms.Label label10;
    }
}