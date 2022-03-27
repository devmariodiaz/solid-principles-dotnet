using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.D
{
    public  abstract class Impuesto
    {
        public double Importe { get; set; }
        public Impuesto(double importe)
        {
            Importe = importe;
        }
    }
}