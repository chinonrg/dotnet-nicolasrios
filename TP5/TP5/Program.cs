using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Materia[] materias = {
            new Materia(1,"Plataformas de Desarrollo", 2019, 1),
            new Materia(2,"Bases de Datos 3",2019, 1),
            new Materia(3,"Aplicaciones Móviles",2019, 1),
            new Materia(4, "Análisis y Metodología de Sistemas", 2019, 2),
            new Materia(5,"Redes y Comunicaciones",2019,2) };
            Print(materias, "Array Original");

            Nota[] notas = {
            new Nota(1, "TP", DateTime.Now, 7, 1),
            new Nota(2, "TP", DateTime.Now, 9, 2),
            new Nota(3, "TP", DateTime.Now, 8, 3),
            new Nota(4, "TP", DateTime.Now, 2, 4),
            new Nota(5, "TP", DateTime.Now, 3, 5),
            new Nota(6, "Parcial", DateTime.Now, 5, 1),
            new Nota(7, "Parcial", DateTime.Now, 7, 2),
            new Nota(8, "Parcial", DateTime.Now, 4, 3),
            new Nota(9, "Parcial", DateTime.Now, 10, 4),
            new Nota(10, "Parcial", DateTime.Now, 1, 5) };
            Print(notas, "Array Original");

            var primercuatri = from e in materias
                               where e.cuatri == 1
                               select e;
            Print(primercuatri, "Materias correspondientes al primer cuatrimestre");

            var ordenalfabetico = from e in materias
                                  orderby e.name
                                  select e;
            Print(ordenalfabetico, "Materias en orden alfabetico");

            var notasTP = from e in notas
                          where e.tipo == "TP"
                          select e;
            Print(notasTP, "Notas de TP");
            
            // Se me complico con el método de extension :(

            Console.ReadKey();
        }
        //Método para imprimir con formato...
        public static void Print<T>(IEnumerable<T> results, string title)
        {
            Console.WriteLine("{0}:", title);
            foreach (T element in results)
            Console.WriteLine(element);
            Console.WriteLine();
        }
    }
}
