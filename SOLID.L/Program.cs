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
            DocumentoContable fc = new Factura(4458, DateTime.Now);
            DocumentoContable nc = new NotaDeCredito(7984, DateTime.Now);
            DocumentoContable nd = new NotaDeDebito(56985, DateTime.Now);

            impresora.ImprimirRemito(rto);
            impresora.Imprimir(fc);
            impresora.Imprimir(nc);
            impresora.Imprimir(nd);

            Console.ReadKey();
        }
    }
}
