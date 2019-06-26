using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_1
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {

            String nombre, apellido;
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Nombre Completo: " + nombre + " " + apellido);
            Console.ReadKey();

        }
    }
}
