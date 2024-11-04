namespace Domain.Models.Configuracion
{
    public class DescripTipoPersona
    {
        public int IdDescripTipoPersona { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public bool Estado { get; set; }

        public DescripTipoPersona() { }

        public DescripTipoPersona(int idDescripTipoPersona, string nombre, string codigo, bool estado)
        {
            IdDescripTipoPersona = idDescripTipoPersona;
            Nombre = nombre;
            Codigo = codigo;
            Estado = estado;
        }
    }
}
