namespace CapaDiseño.Procesos
{
    partial class Frm_Cita
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
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.lbl_tituloFrm = new System.Windows.Forms.Label();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.Pnl_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pnl_titulo.Controls.Add(this.lbl_tituloFrm);
            this.Pnl_titulo.Controls.Add(this.btn_minimizar);
            this.Pnl_titulo.Controls.Add(this.btn_salir);
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 13);
            this.Pnl_titulo.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(1533, 59);
            this.Pnl_titulo.TabIndex = 2;
            // 
            // lbl_tituloFrm
            // 
            this.lbl_tituloFrm.AutoSize = true;
            this.lbl_tituloFrm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloFrm.Location = new System.Drawing.Point(17, 11);
            this.lbl_tituloFrm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tituloFrm.Name = "lbl_tituloFrm";
            this.lbl_tituloFrm.Size = new System.Drawing.Size(213, 28);
            this.lbl_tituloFrm.TabIndex = 3;
            this.lbl_tituloFrm.Text = "Creacion de Cita";
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Location = new System.Drawing.Point(1383, 11);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(45, 34);
            this.btn_minimizar.TabIndex = 2;
            this.btn_minimizar.Text = "mini";
            this.btn_minimizar.UseVisualStyleBackColor = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(1456, 11);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(45, 34);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            // 
            // Frm_Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 823);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Cita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Cita";
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Label lbl_tituloFrm;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_salir;
    }
}