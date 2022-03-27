using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.D
{
    public class FacturaLuz : Impuesto
    {
        public string CodigoPago { get; set; }
        public FacturaLuz(double importe, string codigoPago) : base(importe)
        {
            CodigoPago = codigoPago;
        }
    }
}