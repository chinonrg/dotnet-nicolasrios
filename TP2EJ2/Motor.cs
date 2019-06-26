using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2EJ2
{
    class Motor : IMotor
    {
        public string Cilindrada { get; set; }

        public void Frenar()
        {
            Console.WriteLine("El motor se ha frenado");
        }

        public void Iniciar()
        {
            Console.WriteLine("El motor se ha iniciado");
        }
    }
}
