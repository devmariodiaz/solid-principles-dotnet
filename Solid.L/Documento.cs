namespace Solid.L
{
    public class Documento
    {
        protected string _sigla;
        public DateTime Fecha { get; set; }        
        public int Numero { get; set; }
        public Documento(int numero, DateTime fecha)
        {
            Numero = numero;
            Fecha = fecha;
        }

        public string Imprimir() 
        {
            return $"Imprimiendo {Descripcion()}";
        }

        public virtual string Descripcion()
        {
            return $"{_sigla} nro {Numero} de fecha {Fecha.ToShortDateString()}";
        }
    }
}