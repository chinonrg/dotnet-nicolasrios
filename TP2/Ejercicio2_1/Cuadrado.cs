using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_1
{
    public class Cuadrado : ICalcAux
    {
        double l = 0; //Agregar ReadLine en Main() para modificar este valor.
        double res;
        public double CalcularArea()
        {
            res = l * l;
            return res;

        }

        public double CalcularPerimetro()
        {
            res = l * 4;
            return res;
        }
    }
}
W