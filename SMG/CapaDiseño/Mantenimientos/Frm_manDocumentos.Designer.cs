﻿namespace CapaDiseño.Mantenimientos
{
    partial class Frm_manDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_manDocumentos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Ayuda);
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 45);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Noticias";
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(1103, 3);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.btn_Ayuda.TabIndex = 3;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1056, 3);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 2;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(1153, 3);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(44, 38);
            this.btn_eliminar.TabIndex = 1;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Frm_manDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_manDocumentos";
            this.Text = "Frm_manDocumentos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_eliminar;
    }
}