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
using CapaDatos;
namespace CapaDiseño.Procesos
{
    public partial class Frm_noticias : Form
    {
        Logica log = new Logica();
        public Frm_noticias()
        {
            InitializeComponent();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textbuscador.Text);
        }

        private void Frm_noticias_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.prensalibre.com");
            textbuscador.Text = "www.prensalibre.com";
        }
    }
}
