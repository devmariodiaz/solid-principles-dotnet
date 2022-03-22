// See https://aka.ms/new-console-template for more information
using Solid.L;
DocumentoContable factura = new Factura(15890, DateTime.Now);
DocumentoContable notaCredito = new NotaCredito(90885, DateTime.Now);
DocumentoContable notaDebito = new NotaDebito(67840, DateTime.Now);

Impresora impresora = new Impresora();

impresora.Imprimir(factura);
impresora.Imprimir(notaCredito);
impresora.Imprimir(notaDebito);
