using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tareaa.Interfaz;

namespace tareaa.Clases
{
    /// <summary>
    /// Gutierrez Ruiz Evelyn Pamela
    /// se creo una clase emailnotificador que implementa la interfaz INotificable para enviar notificaciones por email. La clase tiene una propiedad email para almacenar la dirección de correo electrónico del destinatario, y los métodos enviarmensaje y enviarconfirmacion para enviar mensajes y confirmaciones
    /// </summary>
    public class EmailNotificador: INotificable
    {
        public string DireccionEmail { get; set; }

       public EmailNotificador(string direccionEmail) 
        {
            this.DireccionEmail = direccionEmail;
        }

        public void EnviarConfirmacion()
        {
            Console.WriteLine($"[EMAIL] Confirmación: enviada a {DireccionEmail}");
        }
        public void EnviarMensaje(string mensaje)
        {
            
            Console.WriteLine($"[EMAIL] Para: {DireccionEmail} - Mensaje: {mensaje} ");

        }
       


    }
}
