using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GIT_PRUEBA
{
    internal class Program
    {
        private const string MensajeNombre = "Ingresa tu nombre: ";
        private const string MensajeEdad = "Ingresa tu edad: ";

        static void Main(string[] args)
        {
            string nombre = PedirEntrada(MensajeNombre);
            int edad = PedirEdad();

            Persona persona = new Persona();
            persona.Nombre = nombre;
            persona.Edad = edad;

            string respuesta = persona.DevuelveInfo();
            Console.WriteLine(respuesta);
            Console.ReadKey();
        }

        static string PedirEntrada(string mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadLine();
        }

        static int PedirEdad()
        {
            while (true)
            {
                Console.WriteLine(MensajeEdad);
                if (int.TryParse(Console.ReadLine(), out int edad))
                {
                    return edad;
                }
                else
                {
                    Console.WriteLine("Edad no válida. Ingresa un número.");
                }
            }
        }

        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public string DevuelveInfo()
            {
                string respuesta = string.Format("Tu nombre es: {0} y tu edad es: {1} años.", Nombre, Edad);
                return respuesta;
            }
        }
    }
}
