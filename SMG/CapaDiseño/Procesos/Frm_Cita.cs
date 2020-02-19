using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace CapaDiseño.Procesos
{

    public partial class Frm_Cita : Form
    {
        Logica logic = new Logica();
        public Frm_Cita()
        {
            InitializeComponent();
        }


        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            int contCitas = 0;


            try
            {
                OdbcDataReader cita = logic.consultaCitas(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                contCitas = Convert.ToInt32(cita.ToString());
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            if (contCitas <= 25)
            {

                try
                {
                    OdbcDataReader cita = logic.insertarTicket(txt_CUI_c.Text, 1, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    MessageBox.Show("Datos registrados.");

                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }

                QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
                QrCode qrCode = new QrCode();
                qrEncoder.TryEncode(txt_CUI_c.Text, out qrCode);

                GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

                MemoryStream ms = new MemoryStream();

                renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
                var imageTemporal = new Bitmap(ms);
                var imagen = new Bitmap(imageTemporal, new Size(new Point(200, 200)));
                pnl_Resultado.BackgroundImage = imagen;

                // Guardar en el disco duro la imagen (Carpeta del proyecto)
                imagen.Save(txt_CUI_c.Text + ".png", ImageFormat.Png);
            }
            else
            {
                MessageBox.Show("Cantidad de citas superada, debe escoger otro dia");
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Debe escoger una fecha valida");
            }
            else
            {
                btn_buscar.Enabled = true;
            }

        }

        private void Frm_Cita_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            txt_CUI_c.Enabled = false;
            txt_nombre_c.Enabled = false;
            txt_apellidos_c.Enabled = false;
            btn_buscar.Enabled = false;
        }

        private void enviarCorreo()
        {
            try
            {
                string fecha = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                string filename = @"../Debug/" + txt_CUI_c.Text + ".png";
                Attachment data = new Attachment(filename, MediaTypeNames.Application.Octet);

                SmtpClient client = new SmtpClient();
                client.Port = 587;
                // utilizamos el servidor SMTP de gmail
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                // nos autenticamos con nuestra cuenta de gmail
                client.Credentials = new NetworkCredential("smgproyecto@gmail.com", "buenasnoches");

                MailMessage mail = new MailMessage("smgproyecto@gmail.com", txt_correo.Text, "CITA DE PASAPORTE", "Buen dia, se le envia el correo para confirmar la cita" +
                    "realizada que sera " + fecha + ", ademas se le adjunta el codigo QR que debera traer el dia de su cita. Favor no contestar este mensaje");
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                mail.Attachments.Add(data);
                client.Send(mail);
                MessageBox.Show("Correo enviado con exito");
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No se pudo enviar el correo");
            }
        }

        private void Btn_enviar_Click(object sender, EventArgs e)
        {
            enviarCorreo();


        }
    }
}
