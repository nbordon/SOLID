using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
    public abstract class Documento
    {
        // Atributos
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }

        // Constructores
        public Documento(int numero, DateTime fecha)
        {
            Numero = numero;
            Fecha = fecha;
        }

        // Métodos
        public abstract void Imprimir();
        public abstract void EnviarPorEmail();
    }
}
