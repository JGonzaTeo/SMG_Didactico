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
    public partial class Frm_Pasaporte : Form
    {
        public Frm_Pasaporte()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
