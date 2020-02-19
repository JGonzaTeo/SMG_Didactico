using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using System.Data.Odbc;

namespace CapaDiseño
{
    public partial class Frm_Login : Form
    {


        //variables utilizadas para validar usuario
        string contrasenaDesencriptada = " ";
        int idUsuario = 0;
        string nombreUsuario = " ";
        int estadoLogeado = 0;
        int tipoPerfil = 0;
        string actualizarCampo = " ";
        bool datosIncorrectos = false;
        public Frm_Login()
        {
            this.Location = new Point(0, 0); //sobra si tienes la posición en el diseño
            this.Size = new Size(this.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
            InitializeComponent();
            this.TransparencyKey = Color.Crimson;
            this.BackColor = Color.Crimson;
        }
        Conexion con = new Conexion();
        public static string MD5(string word)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(word));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();


        }
        private void IniciarSesion()
        {

            contrasenaDesencriptada = Txt_Pass.Text;
            string cadenaEncriptada2 = MD5(contrasenaDesencriptada);

            try
            {
                string seleccionarUsuario = string.Format("SELECT * FROM tbl_login;");
                OdbcCommand comm = new OdbcCommand(seleccionarUsuario, con.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();

                while (mostrar.Read())
                {

                    if ((Txt_Usuario.Text == mostrar.GetString(1)) && (cadenaEncriptada2 == mostrar.GetString(2)))
                    {


                        MDIParent1 md = new MDIParent1();
                        this.Hide();
                        md.Show();


                        break;
                    }
                    else
                    {
                        Console.WriteLine(seleccionarUsuario);
                        Console.WriteLine("Error en el logeo");
                        Txt_Usuario.Focus();
                    }
                }
            }
            catch (Exception error)
            {
                Console.Write("Error: " + error.Message);
            }
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = Txt_Pass.Text;
            if (checkBox1.Checked)
            {
                Txt_Pass.UseSystemPasswordChar = false;
                Txt_Pass.Text = text;

            }
            else
            {
                Txt_Pass.UseSystemPasswordChar = true;
                Txt_Pass.Text = text;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
    }

