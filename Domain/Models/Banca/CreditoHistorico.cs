using Domain.Models.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Banca
{
    public class CreditoHistorico
    {
        public int IdCredito { get; set; }
        public int IdProductoCredito { get; set; }
        public int IdPersona { get; set; }
        public int IdUsuario { get; set; }
        public int IdUsuarioAutoriza { get; set; }
        public int IdInteres { get; set; }
        public int IdTipoContrato { get; set; }
        public int IdTipoGarantia { get; set; }
        public int IdEstadoCredito { get; set; }
        public string Codigo { get; set; }
        public int PlazoCuotas { get; set; }
        public DateTime FechaInicioPago { get; set; }
        public decimal MontoCapital { get; set; }
        public string DescripcionModificacion { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }
        public string NroCheque { get; set; }
        public string Accion { get; set; }
        public DateTime FechaAccion { get; set; }

    }
}
