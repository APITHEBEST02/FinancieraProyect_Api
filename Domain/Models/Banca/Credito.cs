using Domain.Models.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Banca
{
    public class Credito
    {
       public int IdCredito { get; set; }
       public int IdProductoCredito { get; set; }
       public int IdPersona {  get; set; }
       public int IdEstadoCredito { get; set; }
       public string Codigo {  get; set; }
       public int PlazoCuotas { get; set; }
       public DateTime FechaInicioPago { get; set; }
       public decimal MontoCapital {  get; set; }
       public DateTime Fecha {  get; set; }
       public bool Estado { get; set; }
       public string NroCheque { get; set; }

        public Credito(int idCredito, int idProductoCredito, int idPersona, int idEstadoCredito, string codigo, int plazoCuotas, DateTime fechaInicioPago, decimal montoCapital, DateTime fecha, bool estado, string nroCheque)
        {
            IdCredito = idCredito;
            IdProductoCredito = idProductoCredito;
            IdPersona = idPersona;
            IdEstadoCredito = idEstadoCredito;
            Codigo = codigo;
            PlazoCuotas = plazoCuotas;
            FechaInicioPago = fechaInicioPago;
            MontoCapital = montoCapital;
            Fecha = fecha;
            Estado = estado;
            NroCheque = nroCheque;
        }

        public Credito()
        {
        }
    }
}
