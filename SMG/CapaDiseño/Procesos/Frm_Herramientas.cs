using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseño.Procesos
{
    public partial class Frm_Herramientas : Form
    {
        public Frm_Herramientas()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool ventanaCalendario = false;
        Frm_verCitas citas = new Frm_verCitas();
        private void button1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_verCitas);
            if (ventanaCalendario == false || frmC == null)
            {
                if (frmC == null)
                {
                    citas = new Frm_verCitas();
                }

                citas.Show();
                Application.DoEvents();
                ventanaCalendario = true;
            }
            else
            {
                citas.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
}
