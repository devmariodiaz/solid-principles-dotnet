namespace Solid.I
{
    public class Factura : DocumentoContable
    {
        public int CAI { get; set; }
        public Factura(int numero, DateTime fecha) : base(numero, fecha)
        {
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo la factura {Numero} del dia {Fecha.ToShortDateString()}");
        }

        public override void EnviarPorEmail()
        {
            // Operacion invalida para factura
        }
    }
}