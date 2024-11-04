using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Banca
{
    public class CreditoCalendarioDet
    {
        public int IdCreditoCalendarioDet {  get; set; }
        public int IdPersona {  get; set; }
        public int IdCredito {  get; set; }
        public DateTime FechaPago { get; set; }
        public decimal MontoPagado { get; set; }
        public int NumCuota { get; set; }
        public bool Estado {  get; set; }

        public CreditoCalendarioDet(int idCreditoCalendarioDet, int idPersona, int idCredito, DateTime fechaPago, decimal montoPagado, int numCuota, bool estado)
        {
            IdCreditoCalendarioDet = idCreditoCalendarioDet;
            IdPersona = idPersona;
            IdCredito = idCredito;
            FechaPago = fechaPago;
            MontoPagado = montoPagado;
            NumCuota = numCuota;
            Estado = estado;
        }

        public CreditoCalendarioDet()
        {
        }
    }
}
