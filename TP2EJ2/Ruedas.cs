using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2EJ2
{
    class Ruedas : IRuedas
    {
        public double Diametro { get; set; }

        public void Frenar()
        {
            Console.WriteLine("Las ruedas han frenado");
        }

        public void Iniciar()
        {
            Console.WriteLine("Las ruedas han inicidado");
        }
    }
}
