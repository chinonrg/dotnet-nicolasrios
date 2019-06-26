using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public class Nota
    {
        public int NotaID { get; set; }
        public String tipo { get; set; }
        public DateTime fecha { get; set; }
        public int valor { get; set; }
        public int MateriaID { get; set; }

        public Nota(int NotaID, string tipo, DateTime fecha, int valor, int MateriaID)
        {
            this.NotaID = NotaID;
            this.tipo = tipo;
            this.fecha = fecha;
            this.valor = valor;
            this.MateriaID = MateriaID;
        }

        public override string ToString()
        {
            return string.Format("ID: {0}, Tipo: {1}, Fecha: {2:d} Valor: {3} MateriaID:{4}", NotaID, tipo, fecha, valor, MateriaID);
        }
    }
}
