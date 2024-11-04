using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Interfaces.Output.Banca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Banca
{
    public class SCreditoCalendarioDet : ICreditoCalendarioDet
    {

        private readonly OCreditoCalendarioDet creditoCalendarioDet;

        public SCreditoCalendarioDet(OCreditoCalendarioDet creditoCalendarioDet)
        {
            this.creditoCalendarioDet = creditoCalendarioDet;
        }

        public int Delete(int IdCredito, int NumCuota)
        {
           return creditoCalendarioDet.Delete(IdCredito, NumCuota);
        }

        public int Insert(DtoRequestDetCreditoInsert model)
        {
            return creditoCalendarioDet.Insert(model);
        }

        public List<DtoResponseCreditoCalendarioDet> Select(int IdCredito, int NumCuota)
        {
            return creditoCalendarioDet.Select(IdCredito, NumCuota);
        }
    }
}
