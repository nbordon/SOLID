using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public class NotaDeDebito : DocumentoContable
    {
        // Constructores
        public NotaDeDebito(int numero, DateTime fecha) : base(numero, fecha)
        {
            _sigla = "ND";
        }
    }
}
