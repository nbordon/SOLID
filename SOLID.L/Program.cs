using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();

            Remito rto = new Remito(4598, DateTime.Now, 10);
            Factura fc = new Factura(4458, DateTime.Now);
            NotaDeCredito nc = new NotaDeCredito(7984, DateTime.Now);

            impresora.ImprimirRemito(rto);
            impresora.ImprimirFactura(fc);
            impresora.ImprimirNotaDeCredito(nc);

            Console.ReadKey();
        }
    }
}
