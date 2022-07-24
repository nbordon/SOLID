using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class ReciboDeSueldo
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
    }
}
