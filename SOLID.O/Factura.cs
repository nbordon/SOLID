using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O
{
    public class Factura:DocumentoContable
    {
        // Constructores
        public Factura(int numero): base(numero)
        {

        }

        // Métodos
        public override string Descripcion()
        {
            return $"FC-{Numero}";
        }
    }
}
