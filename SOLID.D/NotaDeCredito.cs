using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class NotaDeCredito : DocumentoContable
    {
        // Constructores
        public NotaDeCredito(DateTime fecha, double importe, int numero) : base(fecha, importe, numero)
        {
            _sigla = "NC";
        }


        // Métodos
        public override double Total()
        {
            return Importe * 1.21 * -1; // EJEMPLO
        }
        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo nota de credito {Numero} del {Fecha.ToShortDateString()} por un importe de ${Total()}");
        }
    }
}
