using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.D
{
    public class Remito
    {
        public int CantBultos { get; set; }
        public DateTime Fecha { get; set; }
        public int Numero { get; set; }

        public Remito(int cantBultos, DateTime fecha, int numero)
        {
            CantBultos = cantBultos;
            Fecha = fecha;
            Numero = numero;
        }
    }
}