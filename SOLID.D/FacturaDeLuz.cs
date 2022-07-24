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

        // Métodos
        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo factura de luz con código de pago {CodigoPago} por un importe de ${Importe}");
        }
    }
}
