using System;
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
using System.Diagnostics;

namespace CapaDiseño.Procesos
{
    public partial class Frm_verCitas : Form
    {
        Logica logic = new Logica();
        public Frm_verCitas()
        {
            
            InitializeComponent();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_verCitas_Load(object sender, EventArgs e)
        {
            OdbcDataReader citas = logic.consultarCita();
            string fecha;

            DateTime fechaHoy = DateTime.Now;
            fecha = fechaHoy.ToString("d");
            label2.Text = fecha;

            DateTime nuevaFecha = Convert.ToDateTime(fecha);
            nuevaFecha = nuevaFecha.AddDays(1);
            fecha = nuevaFecha.ToString("d");
            label3.Text = fecha;

            nuevaFecha = Convert.ToDateTime(fecha);
            nuevaFecha = nuevaFecha.AddDays(1);
            fecha = nuevaFecha.ToString("d");
            label4.Text = fecha;

            nuevaFecha = Convert.ToDateTime(fecha);
            nuevaFecha = nuevaFecha.AddDays(1);
            fecha = nuevaFecha.ToString("d");
            label5.Text = fecha;

            nuevaFecha = Convert.ToDateTime(fecha);
            nuevaFecha = nuevaFecha.AddDays(1);
            fecha = nuevaFecha.ToString("d");
            label6.Text = fecha;

            nuevaFecha = Convert.ToDateTime(fecha);
            nuevaFecha = nuevaFecha.AddDays(1);
            fecha = nuevaFecha.ToString("d");
            label7.Text = fecha;

            nuevaFecha = Convert.ToDateTime(fecha);
            nuevaFecha = nuevaFecha.AddDays(1);
            fecha = nuevaFecha.ToString("d");
            label8.Text = fecha;

            nuevaFecha = Convert.ToDateTime(fecha);
            nuevaFecha = nuevaFecha.AddDays(1);
            fecha = nuevaFecha.ToString("d");
            label15.Text = fecha;

            nuevaFecha = Convert.ToDateTime(fecha);
            nuevaFecha = nuevaFecha.AddDays(1);
            fecha = nuevaFecha.ToString("d");
            label14.Text = fecha;

            nuevaFecha = Convert.ToDateTime(fecha);
            nuevaFecha = nuevaFecha.AddDays(1);
            fecha = nuevaFecha.ToString("d");
            label13.Text = fecha;

            nuevaFecha = Convert.ToDateTime(fecha);
            nuevaFecha = nuevaFecha.AddDays(1);
            fecha = nuevaFecha.ToString("d");
            label12.Text = fecha;

            nuevaFecha = Convert.ToDateTime(fecha);
            nuevaFecha = nuevaFecha.AddDays(1);
            fecha = nuevaFecha.ToString("d");
            label11.Text = fecha;

            nuevaFecha = Convert.ToDateTime(fecha);
            nuevaFecha = nuevaFecha.AddDays(1);
            fecha = nuevaFecha.ToString("d");
            label10.Text = fecha;

            nuevaFecha = Convert.ToDateTime(fecha);
            nuevaFecha = nuevaFecha.AddDays(1);
            fecha = nuevaFecha.ToString("d");
            label9.Text = fecha;

            string[] valores = new string[20];
            int count = 0;
            while (citas.Read())
            {
                valores[count] = citas.GetString(0);
                count++;
            }
            for (int i = 0; i < 20; i++)
            {
                if (string.IsNullOrEmpty(valores[i]))
                    valores[i] = "0";
            }
            //Primera semana
            label22.Text = valores[0];
            label21.Text = valores[1];
            label20.Text = valores[2];
            label19.Text = valores[3];
            label18.Text = valores[4];
            label17.Text = valores[5];
            label16.Text = valores[6];

            //Segunda semana
            label29.Text = valores[7];
            label28.Text = valores[8];
            label27.Text = valores[9];
            label26.Text = valores[10];
            label25.Text = valores[11];
            label24.Text = valores[12];
            label23.Text = valores[13];
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
