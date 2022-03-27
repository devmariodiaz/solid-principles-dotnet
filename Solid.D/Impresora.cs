using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid.D
{
    public class Impresora
    {
        public void Imprimir(Factura factura) {
            Console.WriteLine($"Imprimiendo Factura {factura.Numero} del {factura.Fecha} por un importe de {factura.Importe}");
        }

        public void Imprimir(NotaCredito notaCredito) {
            Console.WriteLine($"Imprimiendo Nota Credito {notaCredito.Numero} del {notaCredito.Fecha} por un importe de {notaCredito.Importe}");   
        }

        public void Imprimir(FacturaLuz facturaLuz) {
            Console.WriteLine($"Imprimiendo Factura de luz con código de pago {facturaLuz.CodigoPago} por un importe de {facturaLuz.Importe}");
        }

        public void Imprimir(Municipal municipal) {
            Console.WriteLine($"Imprimiendo Impuesto Municipal de Partida{municipal.Partida} por un importe de {municipal.Importe}");
        }

        public void Imprimir(Remito remito) {
            Console.WriteLine($"Imprimiendo Remito Número {remito.Numero} del {remito.Fecha} con un total de  {remito.CantBultos} bultos");
        }
    }
}