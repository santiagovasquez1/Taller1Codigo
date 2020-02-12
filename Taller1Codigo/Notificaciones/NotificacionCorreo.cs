using System;
using System.Net.Mail;

namespace Taller1Codigo.Cuentas
{
    public class NotificacionCorreo : INotificacion
    {
        public string DirCorreo { get; set; }

        public NotificacionCorreo(string dirCorreo)
        {
            DirCorreo = dirCorreo;
        }

        public void enviar(string mensaje)
        {
            /*

            Ejemplo de como podria ser el comportamiento del metodo enviar
            dentro de la clase notificacion correo
            */
            
            string formato = $"Enviando a {DirCorreo} : ";

            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(DirCorreo);
            mailMessage.Subject = "Prueba enviar correo";
            mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;

            mailMessage.Body = formato;
            mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            mailMessage.IsBodyHtml = true;
            mailMessage.From = new MailAddress("santivasquez1@gmail.com");

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("betomm@gmail.com", "*****");
            client.Port = 587;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";

            try
            {
                client.Send(mailMessage);
            }
            catch (System.Exception )
            {

                Console.WriteLine("No se envio el correo");
            }

            Console.WriteLine(formato + mensaje);
        }
    }
}