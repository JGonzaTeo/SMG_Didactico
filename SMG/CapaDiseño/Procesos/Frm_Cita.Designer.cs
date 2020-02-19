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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_apellidosS = new System.Windows.Forms.Label();
            this.txt_apellidos_c = new System.Windows.Forms.TextBox();
            this.lbl_nombreS = new System.Windows.Forms.Label();
            this.txt_nombre_c = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cuiS = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_CUI_c = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_Resultado = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.Pnl_titulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
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
            this.btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbl_apellidosS);
            this.panel1.Controls.Add(this.txt_apellidos_c);
            this.panel1.Controls.Add(this.lbl_nombreS);
            this.panel1.Controls.Add(this.txt_nombre_c);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_cuiS);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.txt_CUI_c);
            this.panel1.Location = new System.Drawing.Point(22, 97);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1479, 273);
            this.panel1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(984, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 22);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(713, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fecha de Cita";
            // 
            // lbl_apellidosS
            // 
            this.lbl_apellidosS.AutoSize = true;
            this.lbl_apellidosS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidosS.Location = new System.Drawing.Point(44, 139);
            this.lbl_apellidosS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_apellidosS.Name = "lbl_apellidosS";
            this.lbl_apellidosS.Size = new System.Drawing.Size(180, 21);
            this.lbl_apellidosS.TabIndex = 16;
            this.lbl_apellidosS.Text = "Apellidos solicitante:";
            // 
            // txt_apellidos_c
            // 
            this.txt_apellidos_c.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidos_c.Location = new System.Drawing.Point(315, 133);
            this.txt_apellidos_c.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellidos_c.Name = "txt_apellidos_c";
            this.txt_apellidos_c.Size = new System.Drawing.Size(313, 27);
            this.txt_apellidos_c.TabIndex = 17;
            // 
            // lbl_nombreS
            // 
            this.lbl_nombreS.AutoSize = true;
            this.lbl_nombreS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreS.Location = new System.Drawing.Point(713, 76);
            this.lbl_nombreS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombreS.Name = "lbl_nombreS";
            this.lbl_nombreS.Size = new System.Drawing.Size(179, 21);
            this.lbl_nombreS.TabIndex = 14;
            this.lbl_nombreS.Text = "Nombres solicitante:";
            // 
            // txt_nombre_c
            // 
            this.txt_nombre_c.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_c.Location = new System.Drawing.Point(984, 69);
            this.txt_nombre_c.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_c.Name = "txt_nombre_c";
            this.txt_nombre_c.Size = new System.Drawing.Size(313, 27);
            this.txt_nombre_c.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Datos entregados";
            // 
            // lbl_cuiS
            // 
            this.lbl_cuiS.AutoSize = true;
            this.lbl_cuiS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuiS.Location = new System.Drawing.Point(45, 74);
            this.lbl_cuiS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cuiS.Name = "lbl_cuiS";
            this.lbl_cuiS.Size = new System.Drawing.Size(136, 21);
            this.lbl_cuiS.TabIndex = 2;
            this.lbl_cuiS.Text = "CUI solicitante:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(393, 203);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(581, 28);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Aceptar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // txt_CUI_c
            // 
            this.txt_CUI_c.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CUI_c.Location = new System.Drawing.Point(316, 70);
            this.txt_CUI_c.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CUI_c.Name = "txt_CUI_c";
            this.txt_CUI_c.Size = new System.Drawing.Size(313, 27);
            this.txt_CUI_c.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_correo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pnl_Resultado);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_enviar);
            this.panel2.Location = new System.Drawing.Point(22, 412);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1479, 418);
            this.panel2.TabIndex = 29;
            // 
            // pnl_Resultado
            // 
            this.pnl_Resultado.Location = new System.Drawing.Point(570, 48);
            this.pnl_Resultado.Name = "pnl_Resultado";
            this.pnl_Resultado.Size = new System.Drawing.Size(259, 275);
            this.pnl_Resultado.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(631, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Codigo QR";
            // 
            // btn_enviar
            // 
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_enviar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Location = new System.Drawing.Point(393, 369);
            this.btn_enviar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(581, 28);
            this.btn_enviar.TabIndex = 1;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.Btn_enviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 340);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Correo Solicitante";
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(570, 337);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(313, 27);
            this.txt_correo.TabIndex = 28;
            // 
            // Frm_Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 843);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Cita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Cita";
            this.Load += new System.EventHandler(this.Frm_Cita_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Label lbl_tituloFrm;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_apellidosS;
        private System.Windows.Forms.Label lbl_nombreS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cuiS;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_Resultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_enviar;
        public System.Windows.Forms.TextBox txt_apellidos_c;
        public System.Windows.Forms.TextBox txt_nombre_c;
        public System.Windows.Forms.TextBox txt_CUI_c;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label1;
    }
}