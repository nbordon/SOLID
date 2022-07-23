using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente("Diego", "Lopez");
            
            Factura f = new Factura(12346, c);

            Item i1 = new Item(new Producto("Arroz", 10), 5);
            Item i2 = new Item(new Producto("Queso", 90), 1);
            Item i3 = new Item(new Producto("Gaseosa", 70), 2);

            f.Items.Add(i1);
            f.Items.Add(i2);
            f.Items.Add(i3);

            Console.WriteLine(f.Total());

            Console.ReadKey();

        }
    }
}
