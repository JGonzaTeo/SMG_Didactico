using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseño.Mantenimientos
{
    public partial class internacinalesnoti7 : Form
    {
        public internacinalesnoti7()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void internacinalesnoti7_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://news.google.com/?hl=es-419&gl=US&ceid=US:es-419");
            textbuscador.Text = "https://news.google.com/?hl=es-419&gl=US&ceid=US:es-419";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textbuscador.Text);
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
