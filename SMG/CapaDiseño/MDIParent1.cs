using CapaDiseño.Procesos;
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

namespace CapaDiseño
{
   
    public partial class MDIParent1 : Form
    {
        Logica logic = new Logica();

        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

      

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void LocalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_noticias childForm = new Frm_noticias();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
            
           // Frm_noticias noti = new Frm_noticias();
            //noti.Show();

        }

        private void ToolStripLabel3_Click(object sender, EventArgs e)
        {
            string tabla = "tbl_ticket";
            logic.TestTabla(tabla);  
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            //string tabla = "tbl_wsrenap";
           // string tablaok= logic.TestTabla(tabla);
           // MessageBox.Show(tablaok);
        }

        

        private void verificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        bool ventanaValidacion = false;
        Frm_verificacionPrimerP capacitacion = new Frm_verificacionPrimerP();
        private void AdultosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_verificacionPrimerP);
            if (ventanaValidacion == false || frmC == null)
            {
                if (frmC == null)
                {
                    capacitacion = new Frm_verificacionPrimerP();
                }

                capacitacion.MdiParent = this;
                capacitacion.Show();
                Application.DoEvents();
                ventanaValidacion = true;
            }
            else
            {
                capacitacion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaValidacionH = false;
        Frm_verificacionHijosPrimerP capacitacionH = new Frm_verificacionHijosPrimerP();
        private void MenoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_verificacionPrimerP);
            if (ventanaValidacionH == false || frmC == null)
            {
                if (frmC == null)
                {
                    capacitacionH = new Frm_verificacionHijosPrimerP();
                }

                capacitacionH.MdiParent = this;
                capacitacionH.Show();
                Application.DoEvents();
                ventanaValidacionH = true;
            }
            else
            {
                capacitacionH.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaValidacionHerramientas = false;
        Frm_Herramientas herramientas = new Frm_Herramientas();
        private void toolsMenu_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Herramientas);
            if (ventanaValidacionHerramientas == false || frmC == null)
            {
                if (frmC == null)
                {
                    herramientas = new Frm_Herramientas();
                }

                herramientas.MdiParent = this;
                herramientas.Show();
                Application.DoEvents();
                ventanaValidacionHerramientas = true;
            }
            else
            {
                herramientas.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
    }

