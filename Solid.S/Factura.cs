using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.S
{
    public class Factura
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public List<Item> Items { get; set; }

        public Factura(string Nombre, string Apellidos, int Numero)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Numero = Numero;
            this.Items = new List<Item>();
        }

        public double Total() 
        {
            double total = 0;
            foreach(var item in Items) 
            {
                total += item.Cantidad * item.Producto.Precio;
            }

            return total;
        }
    }
}