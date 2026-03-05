using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using tareaa.Clases;
using tareaa.Interfaz;

namespace tareaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("-----------MENU-----------");
                Console.WriteLine("1.Enviar notificación mail");
                Console.WriteLine("2.EnViar notificación sms");
                Console.WriteLine("3.Salir");
                Console.WriteLine("Selecciona la opcion: ");

                int opc= int.Parse(Console.ReadLine());

                switch (opc)
                {

                    case 1:
                        Console.Write("Ingrese la dirección de email: ");
                        string direcemail = Console.ReadLine();

                        Console.Write("Ingrese el mensaje a enviar: ");
                        string mensajeEmail = Console.ReadLine();

                        INotificable objEmN = new EmailNotificador(direcemail);
                        objEmN.EnviarMensaje(mensajeEmail);
                        objEmN.EnviarConfirmacion();

                        Console.WriteLine("Operación completada.");
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el número de teléfono: ");
                        int numerotel = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese el mensaje a enviar: ");
                        string mensajeEail = Console.ReadLine();

                        INotificable sms = new SMSNotificador();
                        sms.EnviarMensaje(mensajeEail);
                        sms.EnviarConfirmacion();

                        Console.WriteLine("Operación completada. Presione una tecla para continuar...");
                        Console.ReadKey();



                        break;
                }

            }
        }
    }
}
