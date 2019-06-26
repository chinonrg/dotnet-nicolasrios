using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_5
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {

            var numeros = new List<int>();
            int num = 1;
            int sum = 0;
            int res = 0;

            while (num != 0)
            {
                Console.WriteLine("Ingrese un número: ");
                num = Convert.ToInt32(Console.ReadLine());
                numeros.Add(num);
            }
            for (int i = 0; i < numeros.Count; i++)
            {
                sum = sum + numeros[i];
            }
            res = sum / (numeros.Count - 1);
            Console.WriteLine("Usted ingresó " + (numeros.Count - 1) +
                " números. El promedio de ellos es: " + res);


        }
    }
}
