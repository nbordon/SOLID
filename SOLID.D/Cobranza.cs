using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class Cobranza : IImprimible
    {
        // Atributos
        public double Importe { get; set; }
        public int Numero { get; set; }

        // Constructores
        public Cobranza(double importe, int numero)
        {
            Importe = importe;
            Numero = numero;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo cobranza número {Numero} con un importe de ${Importe}");
        }
    }
}
