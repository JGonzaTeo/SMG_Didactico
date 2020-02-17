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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cita));
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.lbl_tituloFrm = new System.Windows.Forms.Label();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.Pnl_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pnl_titulo.Controls.Add(this.btn_Ayuda);
            this.Pnl_titulo.Controls.Add(this.button1);
            this.Pnl_titulo.Controls.Add(this.btn_eliminar);
            this.Pnl_titulo.Controls.Add(this.lbl_tituloFrm);
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 13);
            this.Pnl_titulo.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(1533, 59);
            this.Pnl_titulo.TabIndex = 2;
            // 
            // lbl_tituloFrm
            // 
            this.lbl_tituloFrm.AutoSize = true;
            this.lbl_tituloFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloFrm.Location = new System.Drawing.Point(17, 11);
            this.lbl_tituloFrm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tituloFrm.Name = "lbl_tituloFrm";
            this.lbl_tituloFrm.Size = new System.Drawing.Size(208, 29);
            this.lbl_tituloFrm.TabIndex = 3;
            this.lbl_tituloFrm.Text = "Creacion de Cita";
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(1391, 11);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.btn_Ayuda.TabIndex = 9;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1335, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 38);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(1449, 11);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(44, 38);
            this.btn_eliminar.TabIndex = 7;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
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
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_eliminar;
    }
}