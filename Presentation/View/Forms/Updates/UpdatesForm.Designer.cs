﻿
namespace Presentation.View.Forms.Updates
{
    partial class UpdatesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_version = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizaciones";
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(108, 9);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(10, 15);
            this.lbl_version.TabIndex = 1;
            this.lbl_version.Text = ".";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(12, 140);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(316, 31);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "Entendido";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_version
            // 
            this.txt_version.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_version.Location = new System.Drawing.Point(15, 38);
            this.txt_version.Name = "txt_version";
            this.txt_version.ReadOnly = true;
            this.txt_version.Size = new System.Drawing.Size(313, 96);
            this.txt_version.TabIndex = 4;
            this.txt_version.Text = "";
            // 
            // UpdatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 187);
            this.Controls.Add(this.txt_version);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdatesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe de Actualizaciones";
            this.Load += new System.EventHandler(this.UpdatesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.RichTextBox txt_version;
    }
}