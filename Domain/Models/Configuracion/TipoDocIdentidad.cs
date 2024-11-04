using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Models.Configuracion
{
    public class TipoDocIdentidad
    {
   

        public int IdTipoDocIdentidad { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public TipoDocIdentidad(int idTipoDocIdentidad, string codigo, string nombre, string descripcion, bool estado)
        {
            IdTipoDocIdentidad = idTipoDocIdentidad;
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = estado;
        }

        public TipoDocIdentidad()
        {
        }

    }
}
