using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Response
{
    public class DtoResponseAlmacen
    {
        public int IdAlmacen { get; set; }
        public int IdSede { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public string RazonSocial { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
    }
}
