namespace Solid.L
{
    public class Impresora
    {
        public void Imprimir(DocumentoContable documento)
        {
            Console.WriteLine(documento.Imprimir());
        }
    }
}