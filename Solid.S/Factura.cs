using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.S
{
    public class Factura
    {
        public int Numero { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public List<Item> Items { get; set; }

        public Factura(int Numero, Cliente Cliente)
        {
            this.Cliente = Cliente;
            this.Numero = Numero;
            this.Items = new List<Item>();
        }

        public double Total() 
        {
            double total = 0;
            foreach(var item in Items) 
            {
                total += item.SubTotal();
            }

            return total;
        }
    }
}