using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class FacturaDeLuz : Impuesto
    {
        // Atributos
        public string CodigoPago { get; set; }

        // Constructores
        public FacturaDeLuz(double importe, string codigoPago):base(importe)
        {
            CodigoPago = codigoPago;
        }
    }
}
