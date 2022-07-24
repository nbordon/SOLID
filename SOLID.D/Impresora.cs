using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class Impresora
    {
        // Métodos
        public void Imprimir(Factura factura)
        {
            Console.WriteLine($"Imprimiendo factura {factura.Numero} del {factura.fecha.ToShortDateString()} por un importe de ${factura.Total()}");
        }

        public void Imprimir(NotaDeCredito notaDeCredito)
        {
            Console.WriteLine($"Imprimiendo nota de credito {notaDeCredito.Numero} del {notaDeCredito.fecha.ToShortDateString()} por un importe de ${notaDeCredito.Total()}");
        }

        public void Imprimir(FacturaDeLuz facturaDeLuz)
        {
            Console.WriteLine($"Imprimiendo factura de luz con código de pago {facturaDeLuz.CodigoPago} por un importe de ${facturaDeLuz.Importe}");
        }

        public void Imprimir(Municipal municipal)
        {
            Console.WriteLine($"Imprimiendo impuesto municipal de partida {municipal.Partida} por un importe de ${municipal.Importe}");
        }

        public void Imprimir(ReciboDeSueldo reciboDeSueldo)
        {
            Console.WriteLine($"Imprimiendo recibo de sueldo del legajo {reciboDeSueldo.Legajo} por un total de ${reciboDeSueldo.Total}");
        }

        public void Imprimir(Remito remito)
        {
            Console.WriteLine($"Imprimiendo remito numero {remito.Numero} del {remito.Fecha.ToShortDateString()} con {remito.CantidadBultos} bultos");
        }
    }
}
