using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public abstract class DocumentoContable
    {
        // Atributos
        public DateTime Fecha { get; set; }
        public int Numero { get; set; }
        protected string _sigla;

        // Constructores
        public DocumentoContable(int numero, DateTime fecha)
        {
            Numero = numero;
            Fecha = fecha;
        }

        // Métodos
        public string Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }

        public virtual string Descripcion()
        {
            return $"{_sigla} nro {Numero} de fecha {Fecha.ToShortDateString()}";
        }
    }
}
