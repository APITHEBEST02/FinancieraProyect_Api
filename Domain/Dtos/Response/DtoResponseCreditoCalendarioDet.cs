using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Response
{
    public class DtoResponseCreditoCalendarioDet
    {
        public int IdCreditoCalendarioDet {  get; set; }
        public int IdPersona { get; set; }
        public int IdCredito { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal MontoPagado { get; set; }
        public int NumCuota { get; set; }
        public bool Estado { get; set; }
    }
}
