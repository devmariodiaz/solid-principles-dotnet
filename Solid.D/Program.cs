// See https://aka.ms/new-console-template for more information

using Solid.D;

Impresora impresora = new Impresora();

Factura factura = new Factura(DateTime.Now, 123456, 394);
NotaCredito notaCredito = new NotaCredito(DateTime.Now, 9874, 3879);
Remito remito = new Remito(576363, DateTime.Now, 7);
FacturaLuz facturaLuz = new FacturaLuz(479687, "964873526");
Municipal municipal = new Municipal(3424, "68476376");

impresora.Imprimir(factura);
impresora.Imprimir(notaCredito);
impresora.Imprimir(remito);
impresora.Imprimir(facturaLuz);
impresora.Imprimir(municipal);