using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Response
{
    public class DtoResponseCredito
    {
        public int IdCredito { get; set; }
        public int IdProductoCredito { get; set; }
        public int IdPersona { get; set; }
        public int IdEstadoCredito { get; set; }
        public string Codigo { get; set; }
        public int PlazoCuotas { get; set; }
        public DateTime FechaInicioPago { get; set; }
        public DateTime FechaVenceCredito { get; set; }
        public decimal MontoCapital { get; set; }
        public DateTime Fecha { get; set; }
        public string ProductoCredito { get; set; }
        public string Persona { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string NumDocIdentidad { get; set; }
        public string NumContacto { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string CodigoModular { get; set; }
        public string Empleador { get; set; }
        public string EstadoCredito { get; set; }
        public string PeriocidadMensual { get; set; }
        public int NumeroPagos { get; set; }
        public bool Estado { get; set; }
        public string NroTarjeta { get; set; }
        public string MesTarjeta { get; set; }
        public string AnioTarjeta { get; set; }
        public DateTime FechaSolictud { get; set; }
        public DateTime FechaAutorizacion { get; set; }
        public DateTime FechaDesembolso { get; set; }
        public string TipoDesembolso { get; set; }
        public string CodigoPc { get; set; }
        public string NroCheque { get; set; }
    }
}
