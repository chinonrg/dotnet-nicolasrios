using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public class Materia
    {
        public int MateriaID { get; set; }
        public String name { get; set; }
        public int year { get; set; }
        public int cuatri { get; set; }

        public Materia(int MateriaID, string name, int year, int cuatri)
        {
            this.MateriaID = MateriaID;
            this.name = name;
            this.year = year;
            this.cuatri = cuatri;
        }

        public override string ToString()
        {
   
            return string.Format("ID:{0} | Nombre:{1} | Año:{2} | Cuatrimestre:{3}", MateriaID, name, year, cuatri);
        }


    }
}
