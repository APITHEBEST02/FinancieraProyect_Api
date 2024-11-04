using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Request
{
    public class DtoRequestDetCreditoInsert
    {
        public int IdCredito { get; set; }
        public decimal MontoPagado { get; set; }
        public int NumCuota { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
