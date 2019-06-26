using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2EJ2
{
    interface IMotor
    {
        string Cilindrada { get; set; }

        void Iniciar();
        void Frenar();

    }
}
