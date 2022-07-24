using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class ReciboDeSueldo : IImprimible
    {
        // Atributos
        public int Legajo { get; set; }
        public double Total { get; set; }

        // Constructores
        public ReciboDeSueldo(double total, int legajo)
        {
            Legajo = legajo;
            Total = total;
        }

        // Métodos
        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo recibo de sueldo del legajo {Legajo} por un total de ${Total}");
        }
    }
}
