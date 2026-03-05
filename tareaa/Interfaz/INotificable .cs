using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaa.Interfaz
{
    /// <summary>
    /// Gutierrez Ruiz Evelyn Pamela
    /// se creo una interfaz INotificable que define los métodos para enviar mensajes y confirmaciones, y luego se implementa esta interfaz en las clases emailnotificador y smsnotificador para enviar notificaciones por email y sms
    /// </summary>
    internal interface INotificable
    {
       void EnviarMensaje(string mensaje);

        void EnviarConfirmacion();




    }
}
