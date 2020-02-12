using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaLogica;
using System.Data.Odbc;

namespace CapaDiseño
{
    public partial class Frm_verificacionPrimerP : Form
    {
        Logica logic = new Logica();
        public Frm_verificacionPrimerP()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            OdbcDataReader mostrarResultado = logic.ConsultaLogicaRenap(txt_CUI.Text);
            /*
            label2.Text = mostrarResultado.GetString(0);
            label3.Text = mostrarResultado.GetString(1);
            label4.Text = mostrarResultado.GetString(2);
            label5.Text = mostrarResultado.GetString(3);
            label6.Text = mostrarResultado.GetString(4);
            label7.Text = mostrarResultado.GetString(5);
            label8.Text = mostrarResultado.GetString(6);
            */
        }
    }
}
