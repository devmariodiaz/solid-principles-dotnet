// See https://aka.ms/new-console-template for more information
using Solid.I;

Factura factura = new(574463, DateTime.Now);
factura.CAI = "90789685";

FacturaElectronica facturaElectronica = new(573348, DateTime.Now);
facturaElectronica.CAE = "8757479";

facturaElectronica.Imprimir();
facturaElectronica.EnviarPorEmail();

factura.Imprimir();
factura.EnviarPorEmail(); // No se puede enviar por email
