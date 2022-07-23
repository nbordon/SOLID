using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentoContable unaFactura = new Factura(12340);
            Console.WriteLine(unaFactura.Descripcion());

            DocumentoContable unaNotaDeCredito = new NotaDeCredito(11854);
            Console.WriteLine(unaNotaDeCredito.Descripcion());

            Console.ReadKey();
        }
    }
}
