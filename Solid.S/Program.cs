// See https://aka.ms/new-console-template for more information

using Solid.S;

Cliente client = new Cliente("Mario", "Diaz");
Factura factura = new Factura(123456789, client);

Item item1 = new(new Producto("Maiz", 100), 10);
Item item2 = new(new Producto("Frijol", 25), 6);
Item item3 = new(new Producto("Arroz", 36), 9);

factura.Items.Add(item1);
factura.Items.Add(item2);
factura.Items.Add(item3);

Console.WriteLine($"Total = {factura.Total()}");
