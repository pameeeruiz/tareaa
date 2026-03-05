using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tareaa.Interfaz;

namespace tareaa.Clases
{
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
