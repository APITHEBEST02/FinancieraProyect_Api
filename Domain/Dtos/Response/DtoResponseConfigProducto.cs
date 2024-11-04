using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Response
{
    public class DtoResponseConfigProducto
    {
        public int IdConfigProductoCredito { get; set; }
        public int IdProductoCredito { get; set; }
        public int IdInteres { get; set; }
        public int IdTipoContrato { get; set; }
        public int IdTipoGarantia { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }
        public string InteresNombre { get; set; }
        public string TipContratoNombre { get; set; }
        public string TipGarantia { get; set; }
        public string ProductoCredito { get; set; }
    }
}
