using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_1
{
    public class Circulo : ICalcAux
    {

        double rad = 0; //Agregar ReadLine en Main() para modificar este valor.
        double pi = 3.14;
        double res;

        public double CalcularArea()
        {
            res = rad * pi;
            return res;
        }

        public double CalcularPerimetro()
        {
            res = 2 * pi * rad;
            return res;
        }
    }
}
