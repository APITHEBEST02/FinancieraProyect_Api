using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Request
{
    public class DtoRequestAlmacenUpdate
    {
        public int IdAlmacen { get; set; }
        public int IdSede { get; set; }
        public int IdUbigeo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
    }
}
