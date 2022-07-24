using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
    public class FacturaElectronica : Documento
    {
        // Atributos
        public string CAE { get; set; }

        // Constructores
        public FacturaElectronica(int numero, DateTime fecha) : base(numero, fecha) { }

        // Métodos
        public override void EnviarPorEmail()
        {
            Console.WriteLine($"Enviando por mail la factura electrónica {Numero} del día {Fecha.ToShortDateString()} con CAE {CAE}");
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo la factura electrónica {Numero} del día {Fecha.ToShortDateString()} con CAE {CAE}");
        }
    }
}
