using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_3
{
    class Ejercicio3

    {
        static void Main(string[] args)
        {

            int num = 0;
            int res = 0;
            Console.WriteLine("Ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = num; i > 0; i--)
            {
                res += i;
            }
            Console.WriteLine("Su número es: " + res);

        }
    }
}
