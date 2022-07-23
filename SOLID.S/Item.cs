using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S
{
    public class Item
    {
        // Atributos
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        // Constructores
        public Item(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        // Métodos
        public double Subtotal()
        {
            return Cantidad * Producto.Precio;
        }

    }
}
