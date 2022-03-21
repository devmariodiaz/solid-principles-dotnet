namespace Solid.L
{
    public class Impresora
    {
        public void ImprimirRemito(Remito unRemito)
        {
            Console.WriteLine(unRemito.Descripcion());
        }

        public void ImprimirFactura(Factura unaFactura)
        {
            Console.WriteLine(unaFactura.Descripcion());
        }

        public void ImprimirNotaCredito(NotaCredito unaNotaCredito)
        {
            Console.WriteLine(unaNotaCredito.Descripcion());
        }
    }
}