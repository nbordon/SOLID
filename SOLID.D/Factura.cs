using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class Factura : DocumentoContable
    {
        // Constructores
        public Factura(DateTime fecha, double importe, int numero) : base(fecha, importe, numero)
        {
            _sigla = "FC";
        }


        // Métodos
        public override double Total()
        {
            return Importe * 1.21; // EJEMPLO
        }
        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo factura {Numero} del {Fecha.ToShortDateString()} por un importe de ${Total()}");
        }
    }
}
