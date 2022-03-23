using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.I
{
    public abstract class DocumentoContable
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        
        public DocumentoContable(int numero, DateTime fecha)
        {
            Numero = numero;
            Fecha = fecha;
        }
    }
}