using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public abstract class Impuesto
    {
        // Atributos
        public double Importe { get; set; }

        // Constructores
        public Impuesto(double importe)
        {
            Importe = importe;
        }
    }
}
