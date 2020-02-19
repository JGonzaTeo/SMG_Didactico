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

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
           
        
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

        private void Btn_buscar1_Click_1(object sender, EventArgs e)
        {
            llenardatos();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("NUMERO DE PASAPORTE:  " + Txt_Numeropasaporte.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawString("TIPO:  " + Cmb_tipo.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 115));

            e.Graphics.DrawString("CODIGO ISO:  " + Txt_codigoiso.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 130));
            e.Graphics.DrawString("EMISOR:  " + Txt_autoridadexpo.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 145));


            e.Graphics.DrawString("CODIGO CAN:  " + Txt_codigocan.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 160));
            e.Graphics.DrawString("FECHA:  " + Dtp_emision.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 175));

            e.Graphics.DrawString("FECHA:  " + Dtp_expedicion.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 190));
            e.Graphics.DrawString("FECHA NACIMIENTO:  " + Txt_Fechanac.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 205));

            e.Graphics.DrawString("NOMBRE:  " + Txt_nombre.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 220));
            e.Graphics.DrawString("APELLIDO:  " + Txt_Apellido.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 235));

            e.Graphics.DrawString("NACIONALIDAD:  " + Txt_Nacionalidad.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 250 ));
            e.Graphics.DrawString("PAIS:  " + Txt_Paisnac.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 265));

           
            e.Graphics.DrawString("SEXO:  " + Txt_Sexo.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 295));

            
        }
    }
}
