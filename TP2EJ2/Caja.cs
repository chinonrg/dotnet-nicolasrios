using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2EJ2
{
    class Caja : ICaja
    {
        public List<string> TipoCambios = new List<string>()
        {
            "manual",
            "automático"
        };

        public int CantidadCambios { get; set ; }

    }
}
