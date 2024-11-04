namespace Domain.Models.Configuracion
{
    public class ConfigProducto
    {
        public int IdConfigProductoCredito { get; set; }
        public int IdProductoCredito { get; set; }
        public int IdInteres { get; set; }
        public int IdTipoContrato { get; set; }
        public int IdTipoGarantia { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }

        public ConfigProducto() { }

        public ConfigProducto(int idConfigProductoCredito, int idProductoCredito, int idInteres, int idTipoContrato, int idTipoGarantia, DateTime fecha, bool estado)
        {
            IdConfigProductoCredito = idConfigProductoCredito;
            IdProductoCredito = idProductoCredito;
            IdInteres = idInteres;
            IdTipoContrato = idTipoContrato;
            IdTipoGarantia = idTipoGarantia;
            Fecha = fecha;
            Estado = estado;
        }
    }
}
