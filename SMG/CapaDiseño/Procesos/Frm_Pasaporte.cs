using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaDiseño.Procesos
{
    public partial class Frm_Pasaporte : Form
    {

        Conexion con = new Conexion();
        public Frm_Pasaporte()
        {

            
            InitializeComponent();
            Txt_CUI.Visible = false;
            label2.Visible = false;
            btn_buscar1.Visible = false;
            Txt_QR.Visible = false;
            label3.Visible = false;
            btn_buscar2.Visible = false;

        }

        public void llenardatos()
        {
            try
            {
                string seleccionarUsuario = string.Format("SELECT * FROM tbl_ciudadanos_mayores WHERE CUI="+Txt_CUI.Text+";");
                OdbcCommand comm = new OdbcCommand(seleccionarUsuario, con.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();

                while (mostrar.Read())
                {
                    Txt_nombre.Text = mostrar.GetString(1);
                    Txt_Apellido.Text = mostrar.GetString(2);
                    Txt_Nacionalidad.Text = mostrar.GetString(3);
                    Txt_Paisnac.Text = mostrar.GetString(4);
                    Txt_Sexo.Text = mostrar.GetString(5);
                    Txt_Fechanac.Text = mostrar.GetString(6);                  
                }
            }
            catch (Exception error)
            {
                Console.Write("Error: " + error.Message);
            }
        }

        public void tipoderecepcion()
        {
            if (Cmb1.SelectedIndex == 0)
            {
                Txt_CUI.Visible = true;
                label2.Visible = true;
                btn_buscar1.Visible = true;
                Txt_QR.Visible = false;
                label3.Visible = false;
                btn_buscar2.Visible = false;
            }
            if (Cmb1.SelectedIndex == 1)
            {
                Txt_QR.Visible = true;
                label3.Visible = true;
                btn_buscar2.Visible = true;
                Txt_CUI.Visible = false;
                label2.Visible = false;
                btn_buscar1.Visible = false;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //tipoderecepcion();
            MessageBox.Show("sus datos estan siendo procesado para impresion");
        
        }

        private void Cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoderecepcion();
        }

        private void Btn_buscar1_Click(object sender, EventArgs e)
        {
            llenardatos();
        }

        private void Btn_buscar2_Click(object sender, EventArgs e)
        {
            llenardatos();
        }
    }
}
