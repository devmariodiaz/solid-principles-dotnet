using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.O
{
    public class DocumentoContable
    {
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }
        public TipoDocumentoContableEnum Tipo { get; set; }
    }
}