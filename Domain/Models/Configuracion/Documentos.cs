namespace Domain.Models.Configuracion
{
    public class Documentos
    {
        public int IdDocumento { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Serie { get; set; }
        public int Numero { get; set; }
        public bool Estado { get; set; }

        public Documentos() { }

        public Documentos(int idDocumento, string codigo, string descripcion, string serie, int numero, bool estado)
        {
            IdDocumento = idDocumento;
            Codigo = codigo;
            Descripcion = descripcion;
            Serie = serie;
            Numero = numero;
            Estado = estado;
        }
    }
}
