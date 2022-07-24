using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public class Impresora
    {
        // Métodos
        public void ImprimirRemito(Remito remito)
        {
            Console.WriteLine(remito.Imprimir());
        }

        public void ImprimirFactura(Factura factura)
        {
            Console.WriteLine(factura.Imprimir());
        }

        public void ImprimirNotaDeCredito(NotaDeCredito notaDeCredito)
        {
            Console.WriteLine(notaDeCredito.Imprimir());
        }
    }
}
