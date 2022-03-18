using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.S
{
    public class Producto
    {
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public Producto(string descripcion, double precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}