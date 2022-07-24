using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public class Remito
    {
        // Atributos
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadBultos { get; set; }

        // Constructores
        public Remito(int numero, DateTime fecha, int bultos)
        {
            Numero = numero;
            Fecha = fecha;
            CantidadBultos = bultos;
        }

        // Métodos
        public string Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }

        public string Descripcion()
        {
            return $"Remito nro {Numero} de fecha {Fecha.ToShortDateString()} con {CantidadBultos} bultos";
        }
    }
}
