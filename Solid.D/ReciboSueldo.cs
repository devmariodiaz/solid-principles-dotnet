using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.D
{
    public class ReciboSueldo
    {
        public int Legado { get; set; }
        public int Total { get; set; }
        public ReciboSueldo(int legado, int total)
        {
            Legado = legado;
            Total = total;
        }
    }
}