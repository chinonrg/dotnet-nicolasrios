using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_1
{
    public class Triangulo : ICalcAux
    {
        double b = 0; //Agregar ReadLine en Main() para modificar este valor
        double h = 0; //Agregar ReadLine en Main() para modificar este valor
        double res;

        public double CalcularArea()
        {
            res = (b * h) / 2;
            return res;
        }

        public double CalcularPerimetro()
        {
            //Suponiendo que siempre es equilatero...
            res = b * 3;
            return res;
        }
    }
}
