using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.D
{
    public class NotaCredito : DocumentoContable
    {
        public NotaCredito(DateTime fecha, double importe, int numero) : base(fecha, importe, numero) 
        { 
            _sigla = "NC";
        }

        public override double Total()
        {
            return Importe * 1.21 * -1;
        }
    }
}