using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_2
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {

                        String nombre, edad;
            int num;
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad:");
            edad = Console.ReadLine();

            num = Convert.ToInt32(edad);
            if(num < 18)
            {
                Console.WriteLine("Usted Tiene " + num + "años. Usted es menor de edad.");
            }
            else
            {
                Console.WriteLine("Usted tiene " + num + "años. Usted es mayor de edad.");
            }
            Console.ReadKey();

        }
    }
}
