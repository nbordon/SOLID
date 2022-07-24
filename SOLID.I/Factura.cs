using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
    public class Factura : Documento
    {
        // Atributos
        public string CAI { get; set; }

        // Constructores
        public Factura(int numero, DateTime fecha) : base(numero, fecha) { }

        // Métodos
        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo la factura {Numero} del día {Fecha.ToShortDateString()} con CAI {CAI}");
        }

    }
}
