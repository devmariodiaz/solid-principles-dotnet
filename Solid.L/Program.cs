// See https://aka.ms/new-console-template for more information
using Solid.L;

Remito remito = new Remito(1234567, DateTime.Now, 796857);
Factura factura = new Factura(15890, DateTime.Now);
NotaCredito notaCredito = new NotaCredito(90885, DateTime.Now);

Impresora impresora = new Impresora();

impresora.ImprimirRemito(remito);
impresora.ImprimirFactura(factura);
impresora.ImprimirNotaCredito(notaCredito);
