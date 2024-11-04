using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Response
{
    public class DtoResponseCalendario
    {
        public int IdCredito { get; set; }
        public int Cuota { get; set; }
        public int MontoPagado { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set;}
        public DateTime FechaPagada { get; set; }
        public decimal Capital { get; set; }
        public decimal CostoRiesgo { get; set; }
        public decimal GastosAdm { get; set; }
        public string Mora { get; set; }
        public decimal TEM { get; set; }
        public decimal Total { get; set; }
    }
}
