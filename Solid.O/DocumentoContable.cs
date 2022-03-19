using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.O
{
    public abstract class DocumentoContable
    {
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }

        public DocumentoContable(int numero)
        {
            Numero = numero;
        }

        public  abstract string Descripcion();
    }
}