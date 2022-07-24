using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public class Remito : Documento
    {
        // Atributos
        public int CantidadBultos { get; set; }

        // Constructores
        public Remito(int numero, DateTime fecha, int bultos) : base(numero, fecha)
        {
            CantidadBultos = bultos;
        }

        // Métodos
        public override string Descripcion()
        {
            return $"Remito nro {Numero} de fecha {Fecha.ToShortDateString()} con {CantidadBultos}";
        }
    }
}
