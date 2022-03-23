namespace Solid.L
{
    public class Remito : DocumentoContable
    {
        public int CantBultos { get; set; }
        
        
        public Remito(int numero, DateTime fecha, int bultos) : base (numero, fecha)
        {
            CantBultos = bultos;
        }
    }
}