using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S
{
    public class Cliente
    {
        // Atributos
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        // Constructores
        public Cliente(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
