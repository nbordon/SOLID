using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();

            Factura fc = new Factura(DateTime.Now, 55.98, 11524);
            NotaDeCredito nc = new NotaDeCredito(DateTime.Now, 29.40, 95824);
            FacturaDeLuz fl = new FacturaDeLuz(150.53, "5548752");
            Municipal mu = new Municipal(124.63, "A2321");
            ReciboDeSueldo rs = new ReciboDeSueldo(15000, 458447525);
            Remito rto = new Remito(45874, DateTime.Now, 28);

            impresora.Imprimir(fc);
            impresora.Imprimir(nc);
            impresora.Imprimir(fl);
            impresora.Imprimir(mu);
            impresora.Imprimir(rs);
            impresora.Imprimir(rto);

            Console.ReadKey();
        }
    }
}
