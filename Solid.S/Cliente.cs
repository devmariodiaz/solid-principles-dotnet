using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.S
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public Cliente(string Nombre, string Apellidos)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
        }
    }
}