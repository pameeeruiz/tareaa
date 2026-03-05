using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tareaa.Interfaz;

namespace tareaa.Clases
{
    public class SMSNotificador: INotificable
    {

        public string NumeroTelefono { get; set; }

        public SMSNotificador(string numeroTelefono)
        {
            this.NumeroTelefono = numeroTelefono;
        }
        public void EnviarConfirmacion()
        {
            Console.WriteLine($"[SMS] Confirmación enviada a {NumeroTelefono}");
        }
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine($" [SMS] Para: {NumeroTelefono} - Mensaje: {mensaje}");
        }
    }
}
