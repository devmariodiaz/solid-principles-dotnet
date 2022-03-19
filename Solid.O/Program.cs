// See https://aka.ms/new-console-template for more information

using Solid.O;

Factura factura = new Factura(15454);
Console.WriteLine(factura.Descripcion());

NotaDebito notaDebito = new NotaDebito(1564154);
Console.WriteLine(notaDebito.Descripcion());

NotaCredito notaCredito = new NotaCredito(567809);
Console.WriteLine(notaCredito.Descripcion());