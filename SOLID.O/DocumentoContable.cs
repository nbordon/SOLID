using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O
{
    public abstract class DocumentoContable
    {
        // Atributos
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }

        // Constructores
        public DocumentoContable(int numero)
        {
            Numero = numero;
        }

        // Métodos
        public abstract string Descripcion();
    }
}
