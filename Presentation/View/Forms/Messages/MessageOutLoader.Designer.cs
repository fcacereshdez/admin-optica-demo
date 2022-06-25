
namespace Presentation.View.Forms.Messages
{
    partial class MessageOutLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageOutLoader));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pcb_close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(29)))), ((int)(((byte)(26)))));
            this.pnl_top.Controls.Add(this.label2);
            this.pnl_top.Controls.Add(this.pcb_close);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(363, 35);
            this.pnl_top.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Asistente del sistema";
            // 
            // pcb_close
            // 
            this.pcb_close.Image = global::Presentation.Properties.Resources.close;
            this.pcb_close.Location = new System.Drawing.Point(958, 3);
            this.pcb_close.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pcb_close.Name = "pcb_close";
            this.pcb_close.Size = new System.Drawing.Size(29, 33);
            this.pcb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_close.TabIndex = 5;
            this.pcb_close.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Estámos preparando la información solicitada, espere...";
            // 
            // MessageOutLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(363, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageOutLoader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistente del sistema";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcb_close;
        private System.Windows.Forms.Label label1;
    }
}