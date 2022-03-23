namespace Solid.I
{
    public class Factura : DocumentoContable
    {
        public int CAI { get; set; }
        public Factura(int numero, DateTime fecha) : base(numero, fecha)
        {
        }
    }
}