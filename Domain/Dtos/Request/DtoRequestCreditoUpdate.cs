using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Request
{
    public class DtoRequestCreditoUpdate
    {
        public int IdCredito { get; set; }
        public int IdProductoCredito { get; set; }
        public int IdPersona { get; set; }
        public int inIdInteres { get; set; }
        public int inIdTipoContrato { get; set; }
        public int inIdTipoGarantia { get; set; }
        public int IdEstadoCredito { get; set; }
        public string Codigo { get; set; }
        public int PlazoCuotas { get; set; }
        public DateTime FechaInicioPago { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public decimal MontoCapital { get; set; }
        public string NroCheque { get; set; }
    }
}
