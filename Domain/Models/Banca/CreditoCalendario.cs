using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Banca
{
    public class CreditoCalendario
    {
       

        public int IdCreditoCalendario {  get; set; }
        public int IdCredito {  get; set; }
        public int IdConcepto { get; set; }
        public int Cuota {  get; set; }
        public decimal Monto { get; set; }
        public decimal MontoPagado { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaPagado { get; set; }
        public bool Estado { get; set; }

        public CreditoCalendario()
        {
        }

        public CreditoCalendario(int idCreditoCalendario, int idCredito, int idConcepto, int cuota, decimal monto, decimal montoPagado, DateTime fecha, DateTime fechaPagado, bool estado)
        {
            IdCreditoCalendario = idCreditoCalendario;
            IdCredito = idCredito;
            IdConcepto = idConcepto;
            Cuota = cuota;
            Monto = monto;
            MontoPagado = montoPagado;
            Fecha = fecha;
            FechaPagado = fechaPagado;
            Estado = estado;
        }
    }
}
