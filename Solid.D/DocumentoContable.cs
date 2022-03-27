using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.D
{
    public abstract class DocumentoContable
    {
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }
        public string _sigla { get; set; }

        public DocumentoContable(DateTime fecha, double importe, int numero)
        {
            Fecha = fecha;
            Importe = importe;
            Numero = numero;
        }

        public abstract double Total();
    }
}