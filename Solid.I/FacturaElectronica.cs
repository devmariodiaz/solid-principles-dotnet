using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.I
{
    public class FacturaElectronica : DocumentoContable
    {
        public int CAE { get; set; }
        public FacturaElectronica(int numero, DateTime fecha) : base(numero, fecha) { }
    }
}