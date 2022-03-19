// See https://aka.ms/new-console-template for more information

using Solid.O;

DocumentoContable factura = new DocumentoContable(TipoDocumentoContableEnum.Factura, 123457890);
Console.WriteLine(factura.Descripcion());
