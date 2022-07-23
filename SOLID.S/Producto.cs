using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S
{
    public class Producto
    {
        // Atributos
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        // Constructores
        public Producto(string descripcion, double precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}
