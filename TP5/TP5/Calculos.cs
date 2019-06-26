using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public static class Calculos
    {

        public static double Promedio(int [] valor)
        {
            double valores = 0;
            for(int i =0; i<=valor.Length; i++)
            {
                valores += valor[i];
            }
            valores = (valores / valor.Length);
            return valores;
        }

    }
}
