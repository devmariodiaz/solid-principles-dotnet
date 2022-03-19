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

        public DocumentoContable(TipoDocumentoContableEnum tipo, int numero)
        {
            Tipo = tipo;
            Numero = numero;
        }

        public string Descripcion(){
            switch(Tipo)
            {
                case TipoDocumentoContableEnum.Factura:
                    return $"FC-{Numero}";

                case TipoDocumentoContableEnum.NotaCredito:
                    return $"NC-{Numero}";

                case TipoDocumentoContableEnum.NotaDebito:
                    return $"ND-{Numero}";

                default:
                    return "N/D";
            }
        }
    }
}