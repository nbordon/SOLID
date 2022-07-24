using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura factura = new Factura(4585, DateTime.Now);
            factura.CAI = "55892";

            FacturaElectronica facturaElectronica = new FacturaElectronica(2312,DateTime.Now);
            facturaElectronica.CAE = "55874";

            facturaElectronica.Imprimir();
            facturaElectronica.EnviarPorEmail();
            factura.Imprimir();
            factura.EnviarPorEmail(); // no se puede enviar por email

            Console.ReadKey();
        }
    }
}
