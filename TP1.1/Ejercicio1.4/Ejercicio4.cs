using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_4
{
    class Ejercicio4

    {
        static void Main(string[] args)
        {

            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int a = Math.Max(num1, num2);
            int b = Math.Min(num1, num2);

            int res;

            do
            {
                res = b;
                b = a % b;
                a = res;
            } while (b != 0);

        }
    }
}
