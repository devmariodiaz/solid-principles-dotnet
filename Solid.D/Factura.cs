using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.D
{
    public class Factura : DocumentoContable
    {
        public Factura(DateTime fecha, double importe, int numero) : base(fecha, importe, numero) 
        { 
            _sigla = "FC";
        }

        public override double Total()
        {
            return Importe * 1.21;
        }
    }
}