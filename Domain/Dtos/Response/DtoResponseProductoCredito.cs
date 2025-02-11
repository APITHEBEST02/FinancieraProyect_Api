using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Response
{
    public class DtoResponseProductoCredito
    {
        public int IdProductoCredito { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string FechaCreacion { get; set; }
        public bool Estado { get; set; }
    }
}
