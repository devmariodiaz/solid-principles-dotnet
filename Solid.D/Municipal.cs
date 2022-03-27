using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.D
{
    public class Municipal : Impuesto
    {
        public string Partida { get; set; }
        public Municipal(double importe, string partida) : base(importe)
        {
            Partida = partida;
        }
    }
}