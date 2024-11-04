namespace Domain.Models.Configuracion
{
    public class EstadoCredito
    {
        public int IdEstadoCredito { get; set; }
        public string Codigo {  get; set; }  
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado {  get; set; }

        public EstadoCredito() { }

        public EstadoCredito(int idEstadoCredito, string codigo, string nombre, DateTime fechaCreacion, bool estado)
        {
            IdEstadoCredito = idEstadoCredito;
            Codigo = codigo;
            Nombre = nombre;
            FechaCreacion = fechaCreacion;
            Estado = estado;
        }
    }
}
