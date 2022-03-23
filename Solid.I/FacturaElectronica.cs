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

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo la factura {Numero} del dia {Fecha.ToShortDateString()}");
        }

        public override void EnviarPorEmail()
        {
            Console.WriteLine($"Enviando por Email la factura electrónica {Numero} del dia {Fecha.ToShortDateString()}");
        }
    }
}