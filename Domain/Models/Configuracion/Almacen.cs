namespace Domain.Models.Configuracion
{
    public class Almacen
    {
        public int IdAlmacen { get; set; }
        public int IdSede { get; set; }
        public int IdUbigeo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public Almacen(int idAlmacen, int idSede, int idUbigeo, string codigo, string nombre, bool estado)
        {
            IdAlmacen = idAlmacen;
            IdSede = idSede;
            IdUbigeo = idUbigeo;
            Codigo = codigo;
            Nombre = nombre;
            Estado = estado;
        }

        public Almacen()
        {
        }
    }
}
