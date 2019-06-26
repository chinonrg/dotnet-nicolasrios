using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_1
{
    class Program
    {

        public static void Main(String[] args)
        {
            int op;
            Console.WriteLine("// CALCULO DE FIGURAS GEOMETRICAS //");
            Console.WriteLine("");
            Console.WriteLine("Ingrese un numero para crear:");
            Console.WriteLine("________________________________");
            Console.WriteLine("1. Circulo");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Cuadrado");
            Console.WriteLine("________________________________");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:Console.WriteLine(); Console.WriteLine("Usted ha seleccionado Circulo"); Console.WriteLine("");
                    double b, h;
                    Console.WriteLine("Ingrese base: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese altura: ");
                    h = Convert.ToDouble(Console.ReadLine());

                    break;
            }
        }
    }
}
