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

        private void IniciarSesion()
        {
            try
            {
                string seleccionarUsuario = string.Format("SELECT * FROM tbl_login;");
                OdbcCommand comm = new OdbcCommand(seleccionarUsuario, con.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();

                while (mostrar.Read())
                {
                 
                    if ((Txt_usuario.Text == mostrar.GetString(1)) && (Txt_pass.Text == mostrar.GetString(2)))
                    {
                        //usuarioLogeado = mostrar.GetString(1);
                        //tipoUsuario = mostrar.GetString(4);
                        //MessageBox.Show("Usuario logeado");
                        //Frm_menu menu = new Frm_menu(usuarioLogeado, tipoUsuario);
                        //this.Hide();
                        //menu.Show();

                        MDIParent1 md = new MDIParent1();
                        this.Hide();
                        md.Show();
                       
                      
                        break;
                    }
                    else
                    {
                        Console.WriteLine(seleccionarUsuario);
                        Console.WriteLine("Error en el logeo");
                        Txt_usuario.Focus();
                    }
                }
            }
            catch (Exception error)
            {
                Console.Write("Error: " + error.Message);
            }
        }


        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = Txt_pass.Text;
            if (checkBox1.Checked)
            {
                Txt_pass.UseSystemPasswordChar = false;
                Txt_pass.Text = text;

            }
            else
            {
                Txt_pass.UseSystemPasswordChar = true;
                Txt_pass.Text = text;
            }
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            IniciarSesion();            
            //if (Txt_pass.Text == "jose")
            //{
            //     MDIParent1 md= new MDIParent1();
            //    this.Hide();
            //    md.Show();
            //}
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
