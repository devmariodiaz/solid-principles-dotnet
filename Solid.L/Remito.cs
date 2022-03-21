namespace Solid.L
{
    public class Remito : Documento
    {
        public int CantBultos { get; set; }
        
        
        public Remito(int numero, DateTime fecha, int bultos) : base (numero, fecha)
        {
            CantBultos = bultos;
        }

        public override string Descripcion()
        {
            return $"Remito nro {Numero} de fecha {Fecha.ToShortDateString()} con {CantBultos}";
        }
    }
}