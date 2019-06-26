using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto();

            Ruedas r1 = new Ruedas();

            Ruedas r2 = new Ruedas();

            Ruedas r3 = new Ruedas();

            Ruedas r4 = new Ruedas();

            a1.Ruedas = new List<Ruedas>()
            {
              r1,
              r2,
              r3,
              r4
            };
           
        }
    }
}
