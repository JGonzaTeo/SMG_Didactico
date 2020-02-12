﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using System.Data.Odbc;

namespace CapaDiseño.Procesos
{
    public partial class Frm_verificacionHijosPrimerP : Form
    {
        Logica logic = new Logica();
        public Frm_verificacionHijosPrimerP()
        {
            InitializeComponent();
        }

        void verificarDatos()
        {
            if (txt_CUI.Text == lbl_CUI.Text && txt_nombre.Text == lbl_nombre.Text && txt_apellidos.Text == lbl_apellidos.Text && txt_nacionalidad.Text == lbl_nacionalidad.Text && txt_sexo.Text == lbl_sexo.Text && txt_fecha.Text == lbl_fechaN.Text && txt_pais.Text == lbl_paisN.Text)
            {
                MessageBox.Show("Datos verificados.");
                txt_CUI.Enabled = false;
                txt_nombre.Enabled = false;
                txt_apellidos.Enabled = false;
                txt_nacionalidad.Enabled = false;
                txt_sexo.Enabled = false;
                txt_fecha.Enabled = false;
                txt_pais.Enabled = false;

                txt_banco.Enabled = true;
                btn_banco.Enabled = true;

                btn_buscar.Enabled = false;
                return;
            }
            else
            {
                MessageBox.Show("Los datos no son correctos, compruebelos.");
                return;
            }
        }
        private void Lbl_tituloFrm_Click(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            string campo = txt_CUI.Text;
            if (string.IsNullOrEmpty(txt_CUI.Text) || string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_apellidos.Text) || string.IsNullOrEmpty(txt_nacionalidad.Text) || string.IsNullOrEmpty(txt_sexo.Text) || string.IsNullOrEmpty(txt_fecha.Text) || string.IsNullOrEmpty(txt_pais.Text))
            {
                MessageBox.Show("Debe completar la informacion.");
                return;
            }
            else
            {
                OdbcDataReader mostrarResultado = logic.verificacionCUI(txt_CUI.Text);
                lbl_CUI.Text = mostrarResultado.GetString(0);
                lbl_nombre.Text = mostrarResultado.GetString(1);
                lbl_apellidos.Text = mostrarResultado.GetString(2);
                lbl_nacionalidad.Text = mostrarResultado.GetString(3);
                lbl_sexo.Text = mostrarResultado.GetString(4);
                lbl_fechaN.Text = mostrarResultado.GetString(5);
                lbl_paisN.Text = mostrarResultado.GetString(6);
                verificarDatos();
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_banco_Click(object sender, EventArgs e)
        {
            OdbcDataReader mostrarResultado = logic.verificacionBanco(txt_banco.Text);
            string banco = mostrarResultado.GetString(0);
            if (txt_banco.Text == banco)
            {
                if (mostrarResultado.GetString(1) == "1")
                {
                    label14.BackColor = Color.Green;
                    label14.Text = "OK";

                    txt_banco.Enabled = false;

                    btn_banco.Enabled = false;

                    btn_guardar.Enabled = true;
                }
                else
                {
                    label14.BackColor = Color.Red;
                    label14.Text = "NO VALIDO";
                }
            }
            else
            {
                MessageBox.Show("Codigo no encontrado.");
            }
        }
    }
}
