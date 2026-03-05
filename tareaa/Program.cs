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
        /// <summary>
        /// Gutierrez Ruiz Evelyn Pamela
        /// se creo un programa que permite enviar notificaciones por email o sms utilizando una interfaz INotificable.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            string opc;
            do
            {
                Console.WriteLine("-----------MENU-----------");
                Console.WriteLine("1.Enviar notificación mail");
                Console.WriteLine("2.EnViar notificación sms");
                Console.WriteLine("3.Salir");
                Console.WriteLine("Selecciona la opcion: ");
                 opc = Console.ReadLine();

                switch (opc)
                {

                    case "1":
                        Console.Write("Ingrese la dirección de email: ");
                        string direcemail = Console.ReadLine();

                        Console.Write("Ingrese el mensaje a enviar: ");
                        string mensajeEmail = Console.ReadLine();

                        INotificable objEmN = new EmailNotificador(direcemail);
                        objEmN.EnviarMensaje(mensajeEmail);
                        objEmN.EnviarConfirmacion();

                        Console.WriteLine("Operación completada.");
                        break;

                    case "2":
                        try
                        {
                            Console.WriteLine("Ingrese el número de teléfono: ");
                            int numerotel = int.Parse(Console.ReadLine());

                            Console.Write("Ingrese el mensaje a enviar: ");
                            string mensajeEail = Console.ReadLine();

                            INotificable sms = new SMSNotificador(numerotel);
                            sms.EnviarMensaje(mensajeEail);
                            sms.EnviarConfirmacion();

                            Console.WriteLine("Operación completada. ");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                         
                        }
                        

                        break;

                    case "3":
                        Console.WriteLine("Gracias por usar el sistema. ");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;

                }

            } while (opc != "3");
        }
    }
}
