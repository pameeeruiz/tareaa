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
        /// <summary>
        /// Gutierrez Ruiz Evelyn Pamela
        /// se creo una clase smsnotificador que implementa la interfaz INotificable para enviar notificaciones por SMS. La clase tiene una propiedad numero para almacenar el número de teléfono del destinatario, y los métodos enviarmensaje y enviarconfirmacion para enviar mensajes y confirmaciones
        /// </summary>

        public int NumeroTelefono { get; set; }

        public SMSNotificador(int numeroTelefono)
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
