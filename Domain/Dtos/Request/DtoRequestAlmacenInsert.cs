using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Request
{
    public class DtoRequestAlmacenInsert
    {
        public int IdSede { get; set; }
        public int IdUbigeo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
    }
}
