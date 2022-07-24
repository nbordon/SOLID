using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class Remito : IImprimible
    {
        // Atributos
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadBultos { get; set; }

        // Constructores
        public Remito(int numero, DateTime fecha, int cantidadBultos)
        {
            Numero = numero;
            Fecha = fecha;
            CantidadBultos = cantidadBultos;
        }

        // Métodos
        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo remito numero {Numero} del {Fecha.ToShortDateString()} con {CantidadBultos} bultos");
        }
    }
}
