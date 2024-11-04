using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Request
{
    public class DtoRequestConfigProducto
    {
        public int IdConfigProductoCredito { get; set; }
        public int IdProductoCredito { get; set; }
        public int IdInteres { get; set; }
        public int IdTipoContrato { get; set; }
        public int IdTipoGarantia { get; set; }


    }
}
